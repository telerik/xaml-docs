---
title: Display All Distinct Values
page_title: Display All Distinct Values
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to display all distinct values.
slug: gridview-filtering-howto-display-all-distinct-values
tags: display,all,distinct,values
published: True
position: 3
---

# Display All Distinct Values

By default, the distinct values that a column shows will be limited to the first 1000 distinct values that are visible in this column. If other columns have an active filter that hides some of the data rows then these rows will not be considered when extracting the distinct values. You can control this behavior by attaching to the __DistinctValuesLoading__ event of __RadGridView__ and assigning a value to the __ItemsSource__ property of the event arguments. This event will be fired each time the popup filtering control is about to be displayed. This event should be used solely for controlling the number of distinct values that the user will see. You can’t replace the original distinct values with values from another .NET Type since this would break the data engine. The distinct values that you assign to the ItemsSource property of the event arguments should always be of the same type as the data displayed in the column. 
If possible, you should always use __RadGridView’s__ public method GetDistinctValues which has two overloads. Using the first overload you can tell __RadGridView__ to provide all distinct values for a certain column by ignoring the currently active filters of other columns(__Example 1__). This is achieved by specifying false for the filter argument of the method. For example, if we have countries and players and we have filtered by CountryX, when we request all distinct players, if 'filter' is true we will get players from CountryX only. If 'filter' is false we will get all distinct players.
		

__Example 1:__ The __GetDistinctValues(GridViewColumn, Boolean)__ method returns the first 1000 distinct values for the given column.The Boolean('filter') parameter specifies whether distinct values should be filtered according to other columns' active filters.
		
#### __C#__
```C#
	private void OnRadGridViewDistinctValuesLoading(object sender, Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs e)
	{
	    e.ItemsSource = ((Telerik.Windows.Controls.RadGridView)sender).GetDistinctValues(e.Column, false);
	}
```


#### __VB.NET__
```VB.NET
	Private Sub OnRadGridViewDistinctValuesLoading(sender As System.Object, e As Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs)
	    e.ItemsSource = DirectCast(sender, Telerik.Windows.Controls.RadGridView).GetDistinctValues(e.Column, False)
	End Sub
```

To control the maximum amount of distinct values displayed by the column you can use the second overload of the __GetDistinctValues__ method which has one additional argument of type nullable integer called __maximumValueCount__. The value you provide will be used to limit the amount of distinct values returned(__Example 2__). If you supply a null value you will get absolutely all distinct values. Have in mind that displaying absolutely all distinct values may lead to performance issues.
		

__Example 2:__ The __GetDistinctValues(GridViewColumn, Boolean, Nullable(Int32))__ method will force the column to display only the first 15 visible distinct values.The maximum amount of distinct values to return. If you specify null for the __Nullable(Int32)__ parameter, then all distinct values will be returned.
		
#### __C#__
```C#
	private void OnRadGridViewDistinctValuesLoading2(object sender, Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs e)
	{
	    e.ItemsSource = ((Telerik.Windows.Controls.RadGridView)sender).GetDistinctValues(e.Column, true, 15);
	}
```

#### __VB.NET__

```VB.NET
	Private Sub OnRadGridViewDistinctValuesLoading2(sender As System.Object, e As Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs)
	    e.ItemsSource = DirectCast(sender, Telerik.Windows.Controls.RadGridView).GetDistinctValues(e.Column, True, 15)
	End Sub
```

The column instance provided by the event arguments can help make adjustments for specific columns only.

## Display Case Insensitive Distinct Values

By default, the distinct values are case sensitive. In order to populate them case insensitive and then filter on them, you can implement the following additional code(__Example 3__): 		  
        

__Example 3:__ Displaying case insensitive distinct values.
		
#### __C#__
```C#
	private void OnRadGridViewFiltered(object sender, Telerik.Windows.Controls.GridView.GridViewFilteredEventArgs e)
	{
	    foreach (var item in e.ColumnFilterDescriptor.DistinctFilter.FilterDescriptors)
	    {
	        item.IsCaseSensitive = false;
	    }
	}
	
	private void OnRadGridViewDistinctValuesLoading3(object sender, Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs e)
	{
	    e.ItemsSource = ((Telerik.Windows.Controls.RadGridView)sender).GetDistinctValues(e.Column, false).OfType<string>().Select(x => x.ToLower()).Distinct();
	}
```

#### __VB.NET__
```VB.NET
	Private Sub OnRadGridViewFiltered(sender As Object, e As Telerik.Windows.Controls.GridView.GridViewFilteredEventArgs)
	    For Each item In e.ColumnFilterDescriptor.DistinctFilter.FilterDescriptors
	        item.IsCaseSensitive = False
	    Next
	End Sub
	
	Private Sub OnRadGridViewDistinctValuesLoading3(sender As Object, e As Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs)
	    e.ItemsSource = DirectCast(sender, Telerik.Windows.Controls.RadGridView).GetDistinctValues(e.Column, False).OfType(Of String)().[Select](Function(x) x.ToLower()).Distinct()
	End Sub
```
