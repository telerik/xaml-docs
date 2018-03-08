---
title: Cosmos DB
page_title: Cosmos DB
description: Integration between Cosmos DB and RadGridView
slug: cloud-integration-cosmosdb
tags: cloud,integration,radgridview,cosmosdb
published: True
position: 1
---

# Integration between Cosmos DB and RadGridView

**Azure Cosmos DB** is a globally distributed, multi-model database service which enables you to develop document, key-value, wide-column, and graph databases by using popular APIs and programming models. This article will show you how to integrate the RadGridView control to work with your remote database.

>important For the purposes of this article, we will assume that you've already set up the **FamilyDB** database and **FamilyCollection** collection from the [SQL API Getting Started Tutorial](https://docs.microsoft.com/en-us/azure/cosmos-db/sql-api-get-started).

## Query the Data

Let us first define the RadGridView instance that we will be using.

#### __[XAML] Example 1: Adding RadGridView in XAML__

{{region cloud-integration-cosmosdb-0}}
    <telerik:RadGridView x:Name="grid" 
                            ItemsSource="{Binding Families}"
                            IsBusy="{Binding IsBusy}"
                            AutoGenerateColumns="False"
                            RowDetailsTemplate="{StaticResource ParentGridTemplate}"
                            NewRowPosition="Bottom">
        <telerik:EventToCommandBehavior.EventBindings>
            <telerik:EventBinding EventName="AddingNewDataItem" Command="{Binding AddNewItemCommand}" PassEventArgsToCommand="True" />
            <telerik:EventBinding EventName="RowEditEnded" Command="{Binding EditItemCommand}" PassEventArgsToCommand="True" />
            <telerik:EventBinding EventName="Deleted" Command="{Binding DeleteItemCommand}" PassEventArgsToCommand="True" />
        </telerik:EventToCommandBehavior.EventBindings>
        <telerik:RadGridView.Columns>
            <telerik:GridViewToggleRowDetailsColumn />
            <telerik:GridViewDataColumn DataMemberBinding="{Binding LastName}" />
            <telerik:GridViewCheckBoxColumn DataMemberBinding="{Binding IsRegistered}" />
            <telerik:GridViewDataColumn Header="State" DataMemberBinding="{Binding Address.State}" />
            <telerik:GridViewDataColumn Header="County" DataMemberBinding="{Binding Address.County}" />
            <telerik:GridViewDataColumn Header="City" DataMemberBinding="{Binding Address.City}" />
        </telerik:RadGridView.Columns>
    </telerik:RadGridView>
{{endregion}}

We will also want to display the parents for each family by specifying the RowDetailsTemplate from **Example 2**.

#### __[XAML] Example 2: The RowDetailsTemplate__

{{region cloud-integration-cosmosdb-1}}
    <Grid.Resources>
        <DataTemplate x:Key="ParentGridTemplate">
            <telerik:RadGridView AutoGenerateColumns="False"
                        ItemsSource="{Binding Children}">
                <telerik:RadGridView.Columns>
                    <telerik:GridViewDataColumn DataMemberBinding="{Binding FirstName}" />
                    <telerik:GridViewDataColumn DataMemberBinding="{Binding FamilyName}" />
                    <telerik:GridViewDataColumn DataMemberBinding="{Binding Gender}" />
                    <telerik:GridViewDataColumn DataMemberBinding="{Binding Grade}" />
                </telerik:RadGridView.Columns>
            </telerik:RadGridView>
        </DataTemplate>
    </Grid.Resources>
{{endregion}}

And here is the definition of the underlying viewmodel.

#### __[XAML] Example 3: The MainWindowViewModel Class__

{{region cloud-integration-cosmosdb-2}}
    public class MainWindowViewModel : ViewModelBase
    {
        private DocumentClient client;
        private bool isBusy;
        private QueryableCollectionView families;
        private const string EndpointUrl = "https://your.endpoint.url.azure.com:port/";
        private const string PrimaryKey = "yOurPrimaryKey==";
        private const string DatabaseName = "FamilyDB";
        private const string CollectionName = "FamilyCollection";

        public ICommand AddNewItemCommand { get; set; }
        public ICommand EditItemCommand { get; set; }
        public ICommand DeleteItemCommand { get; set; }

        public MainWindowViewModel()
        {
            this.client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);
            this.AddNewItemCommand = new DelegateCommand(OnAddNewItemCommandExecuted);
            this.EditItemCommand = new DelegateCommand(OnEditItemCommandExecuted);
            this.DeleteItemCommand = new DelegateCommand(OnDeleteItemCommandExecuted);
        }

        public QueryableCollectionView Families
        {
            get
            {
                return families;
            }
            private set
            {
                families = value;
                this.OnPropertyChanged("Families");
            }
        }

        public bool IsBusy
        {
            get { return isBusy; }
            private set
            {
                isBusy = value;
                this.OnPropertyChanged("IsBusy");
            }
        }

        public async Task GetFamilies()
        {
            var familyQuery = this.client.CreateDocumentQuery<Family>(UriFactory.CreateDocumentCollectionUri(DatabaseName, CollectionName), new FeedOptions { MaxItemCount = -1 });

            this.IsBusy = true;
            var items = await QueryAsync(familyQuery);
            this.Families = new QueryableCollectionView(items);
            this.IsBusy = false;
        }

        private static async Task<IEnumerable<T>> QueryAsync<T>(IQueryable<T> query)
        {
            var docQuery = query.AsDocumentQuery();
            var batches = new List<IEnumerable<T>>();

            do
            {
                var batch = await docQuery.ExecuteNextAsync<T>();

                batches.Add(batch);
            }
            while (docQuery.HasMoreResults);

            var docs = batches.SelectMany(b => b);

            return docs;
        }

        // ...
    }
{{endregion}}

We start off by creating a new DocumentClient and passing in the endpoint URL and primary key to it. Then, we generate the query by calling the client's **CreateDocumentQuery** method and passing the database and collection names to the **CreateDocumentCollectionUri** factory method.

This will be enough to query the data from your Cosmos DB, but let us now enable the create, update and delete operations.

## Create New Entries

Here's the code required to create a new instance of the Family class when the user clicks the "Add new item..." button or the Insert key.

#### __[XAML] Example 4: Handle the AddingNewDataItem Event__

{{region cloud-integration-cosmosdb-3}}
    private void OnAddNewItemCommandExecuted(object obj)
    {
        var args = obj as GridViewAddingNewEventArgs;
        var family = new Family();
        family.Id = Guid.NewGuid().ToString();
        args.NewObject = family;
    }
{{endregion}}

Note that we're creating a new GUID for our new Family object. Now, we need to actually send this data to our database by utilizing the **CreateDocumentAsync** method. Here's the logic which is executed when the **RowEditEnded** event, bound to the **EditItemCommand**, is raised.

#### __[XAML] Example 5: Handle the RowEditEnded Event__

{{region cloud-integration-cosmosdb-4}}
    private async void OnEditItemCommandExecuted(object obj)
    {
        var args = obj as GridViewRowEditEndedEventArgs;
        if (args.EditAction == GridViewEditAction.Commit)
        {
            if (args.EditOperationType == GridViewEditOperationType.Insert)
            {
                var item = args.EditedItem as Family;
                await client.CreateDocumentAsync(UriFactory.CreateDocumentCollectionUri(DatabaseName, CollectionName), item);
            }
            // ...
        }
    }
{{endregion}}

## Edit an Entry

To handle the process of updating an already existing database document, we will need to once more handle the **RowEditEnded** event, but this time we will check if the current **EditOperationType** has a value of **GridViewEditOperationType.Edit**.

#### __[XAML] Example 6: Handle the RowEditEnded Event__

{{region cloud-integration-cosmosdb-5}}
    if (args.EditAction == GridViewEditAction.Commit)
    {
        // ...
        else if (args.EditOperationType == GridViewEditOperationType.Edit)
        {
            var item = args.EditedItem as Family;
            dynamic doc = client.CreateDocumentQuery<Document>(UriFactory.CreateDocumentCollectionUri(DatabaseName, CollectionName)).Where(d => d.Id == item.Id).AsEnumerable().FirstOrDefault();
            await client.ReplaceDocumentAsync(doc.SelfLink, item);
        }
    }
{{endregion}}

## Delete an Entry

Lastly, we will handle the process of deleting entries when the user presses the **Delete** key. Here is the command which is invoked when the **Deleted** event is raised.

#### __[XAML] Example 7: Handle the Deleted Event__

{{region cloud-integration-cosmosdb-6}}
    private async void OnDeleteItemCommandExecuted(object obj)
    {
        var args = obj as GridViewDeletedEventArgs;
        var items = args.Items;
        foreach (Family item in items)
        {
            dynamic doc = client.CreateDocumentQuery<Document>(UriFactory.CreateDocumentCollectionUri(DatabaseName, CollectionName)).Where(d => d.Id == item.Id).AsEnumerable().FirstOrDefault();
            await client.DeleteDocumentAsync(doc.SelfLink);
        }
    }
{{endregion}}

As you can see, once more we get the document corresponding to the deleted item's **Id** using the **CreateDocumentQuery** method and then call the **DeleteDocumentAsync** method of the **DocumentClient** by passing the document's **self-link**.

## See Also