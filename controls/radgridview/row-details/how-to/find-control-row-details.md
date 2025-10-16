---
title: Find a control in RowDetailsTemplate
page_title: Find a control in RowDetailsTemplate
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to find a control which is placed in the DataTemplate of the RowDetailsTemplate.
slug: gridview-find-control-row-details
tags: find,a,control,in,rowdetailstemplate
published: True
position: 0
---

# Find a control in RowDetailsTemplate

This article demonstrates how to find a control which is placed in the DataTemplate of the __RowDetailsTemplate__. 

Let assume that you have a control (RadComboBox) in the RowDetailsTemplate which you need to set some properties at __runtime__:



```XAML
	<telerik:RadGridView.RowDetailsTemplate>
	    <DataTemplate>
	        <StackPanel>
	            <telerik:RadComboBox Name="rcbCountries" />
	            <!-- some other controls here -->
	        </StackPanel>
	    </DataTemplate>
	</telerik:RadGridView.RowDetailsTemplate>
```

The best way to do this is to subscribe to the [LoadingRowDetails]({%slug radgridview-row-details-programming%}) event and find the control there:



```XAML
	<telerik:RadGridView Name="gridView" 
	ItemsSource="{Binding Source={StaticResource itemsList}}"
	LoadingRowDetails="gridView_LoadingRowDetails"
	RowDetailsVisibilityMode="VisibleWhenSelected">
```

In the [LoadingRowDetails]({%slug radgridview-row-details-programming%}) event handler use the [FindName](http://msdn.microsoft.com/en-us/library/system.windows.frameworkelement.findname.aspx) method of the __e.DetailsElement__:



```C#
	private void gridView_LoadingRowDetails(object sender, GridViewRowDetailsEventArgs e)
	{
	    RadComboBox countries = e.DetailsElement.FindName("rcbCountries") as RadComboBox;
	    countries.ItemsSource = GetCountries();
	}
```
```VB.NET
	Private Sub gridView_LoadingRowDetails(sender As Object, e As GridViewRowDetailsEventArgs)
	    Dim countries As RadComboBox = TryCast(e.DetailsElement.FindName("rcbCountries"), RadComboBox)
	    countries.ItemsSource = GetCountries()
	End Sub
```

## See Also

 * [RowDetails - Overview]({%slug radgridview-row-details-overview%})
