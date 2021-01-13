---
title: Filtering
page_title: Filtering
description: The article describes the filtering feature of RadCardView.
slug: radcardview-features-filtering
tags: filtering,cardview
published: True
position: 2
---

# Filtering

RadCardView supports filtering via the UI or in code, in case you are using ICollectionView as the ItemsSource.

The control internally works with a [QueryableCollectionView]({%slug consuming-data-queryablecollectionview%}) instance. When the ItemsSource is set, and if different type than QueryableCollectionView is used, then the original collection is wrapped in a QueryableCollectionView instance. This way filtering is supported even if you use a more basic IEnumerable implementation, like `List<T>` or `ObservableCollection<T>`.
 
## Filtering in the UI

The data items can be filtered using the [filtering control]({%slug radcardview-visual-structure%}) which opens when a data field descriptor's filters button is pressed.

#### Figure 1: RadCardView filtering control
![](images/radcardview-features-filtering-0.png)

To disable user filtering, set the __IsFilteringAllowed__ property to __False__.

#### __[XAML] Example 1: Setting the IsFilteringAllowed property__
{{region radcardview-features-filtering-0}}
	<telerik:RadCardView IsFilteringAllowed="False" />
{{endregion}}

## Programmatic Filtering

The following example shows how to setup RadCardView, populate it a [QueryableCollectionView]({%slug consuming-data-queryablecollectionview%}) and add GroupDescriptors in code.

#### __[C#] Example 2: Defining the model__
{{region radcardview-features-filtering-1}}
	public class CardInfo
    {
        public string Header { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Category { get; set; }
    }
	
	public class MainViewModel
    {
        public ObservableCollection<CardInfo> Items { get; private set; }
        public QueryableCollectionView CollectionView { get; private set; }

        public MainViewModel()
        {
            int counter = 0;
            Items = new ObservableCollection<CardInfo>();
            for (int g = 0; g < 3; g++)
            {
                for (int i = 0; i < 6; i++)
                {
                    Items.Add(new CardInfo()
                    {
                        Header = "Card " + counter,
                        Name = "Name " + counter,
                        Number = counter,
                        Category = "Category " + g
                    });
                    counter++;
                }
            }

            CollectionView = new QueryableCollectionView(Items);
            CollectionView.GroupDescriptors.Add(new GroupDescriptor() { Member = "Category" });
        }
    }
{{endregion}} 

>tip Read the [QueryableCollectionView]({%slug consuming-data-queryablecollectionview%}#filtering) to see how to use the GroupDescriptors collection of the QueryableCollectionView.

#### __[XAML] Example 3: Setting the DataContext__
{{region radcardview-features-filtering-2}}
	public MainWindow()
	{
		InitializeComponent();
		this.DataContext = new MainViewModel();
	}
{{endregion}}

#### __[XAML] Example 4: Setting up the view__
{{region radcardview-features-filtering-3}}
	<telerik:RadCardView ItemsSource="{Binding CollectionView}" CardHeaderBinding="{Binding Header}" />
{{endregion}}

The filtering operations invoke several events that can be used to customize the filtering. Read more in the [Events]({%slug radcardview-events%}#filtering) article.

## See Also