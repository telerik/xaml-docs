#region radpivotgrid-features-datetimegroup_1
DateTimeGroupDescription dateTimeGroupDescription1 = new DateTimeGroupDescription();
dateTimeGroupDescription1.PropertyName = "Date";
dateTimeGroupDescription1.Step = DateTimeStep.Quarter;
DateTimeGroupDescription dateTimeGroupDescription2 = new DateTimeGroupDescription();
dateTimeGroupDescription2.PropertyName = "Date";
dateTimeGroupDescription2.Step = DateTimeStep.Month;
Telerik.Pivot.Core.PropertyGroupDescription propertyGroupDescription = new Telerik.Pivot.Core.PropertyGroupDescription();
propertyGroupDescription.PropertyName = "Date";

var dataProvider = new LocalDataSourceProvider();
dataProvider.RowGroupDescriptions.Add(dateTimeGroupDescription1);
dataProvider.RowGroupDescriptions.Add(dateTimeGroupDescription2);
dataProvider.RowGroupDescriptions.Add(propertyGroupDescription);
#endregion

#region radpivotgrid-features-datetimegroup_2
var dataProvider = new LocalDataSourceProvider();
dataProvider.ItemsSource = new Source();
var descriptionProvider = new LocalDataSourceFieldDescriptionsProvider();
descriptionProvider.AddingContainerNode += LocalDataSourceFieldDescriptionsProvider_ContainerNodeAdded;
dataProvider.FieldDescriptionsProvider = descriptionProvider;
#endregion

#region radpivotgrid-features-datetimegroup_3
void LocalDataSourceFieldDescriptionsProvider_ContainerNodeAdded(object sender, ContainerNodeEventArgs e)
{
    //Use the name of the DateTime property, in our case it is Date
    if (e.ContainerNode.Name == "Date")
    {
        foreach (var containerNode in e.ContainerNode.Children)
        {
            FieldInfoNode fin = containerNode as FieldInfoNode;
            if (containerNode.Name == "Date.Hour")
            {
                //Show Hour from the DateTime tree
                (fin.FieldInfo as PropertyFieldInfo).AutoGenerateField = true;
            }
        }
    }
}
#endregion

#region radpivotgrid-features-datetimegroup_4
void LocalDataSourceFieldDescriptionsProvider_ContainerNodeAdded(object sender, ContainerNodeEventArgs e)
{
    //Use the name of the DateTime property, in our case it is Date
    if (e.ContainerNode.Name == "Date")
    {
        foreach (var containerNode in e.ContainerNode.Children)
        {
            FieldInfoNode fin = containerNode as FieldInfoNode;
            if (containerNode.Name == "Date.Year")
            {
                //Remove Year from the DateTime tree
                (fin.FieldInfo as PropertyFieldInfo).AutoGenerateField = false;
            }
        }
    }
}
#endregion

#region radpivotgrid-features-datetimegroup_5
void LocalDataSourceFieldDescriptionsProvider_ContainerNodeAdded(object sender, ContainerNodeEventArgs e)
{
    //Use the name of the DateTime property, in our case it is Date
    if (e.ContainerNode.Name == "Date")
    {
        e.Cancel = true;
    }
}
#endregion

#region radpivotgrid-features-datetimegroup_6
void LocalDataSourceFieldDescriptionsProvider_ContainerNodeAdded(object sender, ContainerNodeEventArgs e)
{
    //Use the name of the DateTime property, in our case it is Date
    if (e.ContainerNode.Name == "Date")
    {
        //Find the children Date.Month and show it.
        FieldInfoNode fin = e.ContainerNode.Children.First<ContainerNode>(cn => cn.Name == "Date.Month") as FieldInfoNode;
        e.ContainerNode = fin;
    }
}
#endregion