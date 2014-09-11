#region radpivotgrid-events-overview_1
private void OnPrepareDescriptionForField(object sender, Telerik.Pivot.Core.PrepareDescriptionForFieldEventArgs e)
{
	// Get the current DoubleGroupDescription description.
	var doubleGroupDescription = e.Description as DoubleGroupDescription;

	if (e.DescriptionType == Telerik.Pivot.Core.DataProviderDescriptionType.Group && doubleGroupDescription != null)
	{
		// Replace it with PropertyGroupDescription.
		e.Description = new Telerik.Pivot.Core.PropertyGroupDescription() { PropertyName = doubleGroupDescription.PropertyName };
	}
}
#endregion

#region radpivotgrid-events-overview_2
private void OnDataProviderStatusChanged(object sender, DataProviderStatusChangedEventArgs e)
{
    if (e.NewStatus == DataProviderStatus.Ready)
    {
        Dispatcher.BeginInvoke(new Action(() => 
		{
			// Execute custom logic here.
		}));
    }
}
#endregion

#region radpivotgrid-events-overview_3
private void OnGetDescriptionsDataAsyncCompleted(object sender, GetDescriptionsDataCompletedEventArgs e)
{
	var rootItem = e.DescriptionsData.RootFieldInfo;
	var allContainers = rootItem.Children.ToList();
	rootItem.Children.Clear();

	var firstFolder = new ContainerNode("First Folder", ContainerNodeRole.Folder);
	var secondFolder = new ContainerNode("Second Folder", ContainerNodeRole.Folder);

	foreach (var item in allContainers)
	{
		if (item.Name == "Product" || item.Name == "Quantity")
		{
			firstFolder.Children.Add(item);
		}
		else if (item.Name == "Net" || item.Name == "Promotion")
		{
			secondFolder.Children.Add(item);
		}
		else
		{
			rootItem.Children.Add(item);
		}
	}

	rootItem.Children.Add(firstFolder);
	rootItem.Children.Add(secondFolder);       
}
#endregion

