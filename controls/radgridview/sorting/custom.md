---
title: Custom Sorting
page_title: Custom Sorting
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn more about the different ways to enable custom sorting.
slug: gridview-sorting-custom
tags: custom,sorting
published: True
position: 2
---

# Custom Sorting

Although __RadGridView__ provides a fully functional sorting mechanism, it can sometimes be slow or ineffective, compared to other sorting mechanisms (database server, LINQ extension methods, manually working with the __SortDescriptors__ collection etc.). To benefit from them you have to bypass the existing sorting functionality of __RadGridView__.

>You can set the __SortMemberPath__ property of the column to specify the name of the property the data in the column will be sorted by.

Some other ways to customize the sort are listed below:

* [Custom Sorting with IComparable ](#custom-sorting-with-icomparable)
* [Custom Sorting with Generic SortDescriptor](#custom-sorting-with-generic-sortdescriptor)
* [Custom Sorting handling Sorting Event](#custom-sorting-handling-sorting-event)
* [Sort Group by Aggregate](#sort-group-by-aggregate)
* [Sort Group by Different Property](#sort-group-by-different-property) 
        
## Custom Sorting with IComparable 

In order to be able to sort the items in a way you define, the bound business object could implement __IComparable__ interface. Thus you will tell RadGridView how to sort the items. Since it respects this interface, it will sort the items depending on the logic you implement.
        
You can check some sample code on our {% if site.site_name == 'Silverlight' %}[Custom Sorting with IComparable demo.](https://demos.telerik.com/silverlight/#GridView/IComparable){% endif %}{% if site.site_name == 'WPF' %}[Custom Sorting with IComparable demo.](https://demos.telerik.com/wpf){% endif %}

It demonstrates using the [IComparable](http://msdn.microsoft.com/en-us/library/system.icomparable.aspx) interface to sort items.

>tip You can also find the [Sorting Strings as Numbers]({%slug gridview-sort-strings%}) topic.

## Custom Sorting with Generic SortDescriptor

You can also change the sorting algorithm through applying a [Generic Sort Descriptor]({%slug gridview-sorting-generic-descriptor%}).
       
## Custom Sorting handling Sorting Event

To do so you can use the __Sorting__ event. As a start you need to attach an event handler to it:
       
#### __C#__

```C#
	this.radGridView.Sorting += this.radGridView_Sorting;
```

#### __VB.NET__

```VB.NET
	  
	AddHandler Me.radGridView.Sorting, AddressOf Me.radGridView_Sorting
```

>When performing a custom sorting, you need to set the __IsCustomSortingEnabled__ property of the column to True. This is required in order to preserve the sorting direction of the column when another data operation (such as sorting, filtering or grouping) is performed.

Take a look at the __GridViewSortingEventArgs__ argument of the event handler. There are a few properties that require your attention:
        
* __DataControl__ - this one holds the instance of __RadGridView__ owning the column that was clicked and is going to be sorted.
            
* __Cancel__ - this boolean property defines whether the internal handling of the sorting event should be canceled. The default value is __False__, which means that the event will be handled internally by __RadGridView__ and the built-in sorting functionality will be executed. If you set it to __True__ the event won't be handled by __RadGridView__ and the built-in sorting functionality will be bypassed.

* __OldSortingState__ - defines the current sorting state of the column being sorted.

* __NewSortingState__ - defines the new sorting state of the column and controls the sorting indicator of the column's header. Even if you don't want the built-in sorting functionality to be executed you have to properly set this property, otherwise the visual state of the sort indicator won't match the sort state of the data.

* __Column__ - the gridview column which is being sorted.

For the example you have to sort the __ItemsSource of RadGridView__ on __Sorting__ event handler using LINQ extension methods. For that purpose be sure that you are using __System.Linq__ namespace.

The first thing to do is to get the value of __RadGridView.ItemsSource__ and assure that it is not null. In the __Sorting__ event handler you can add the following lines of code:

#### __C#__

```C#
	private void radGridView_Sorting(object sender, GridViewSortingEventArgs e)
	{
	    //Gets the value of the ItemsSource property as IEnumerable.
	    IEnumerable<Employee> employees = e.DataControl.ItemsSource as IEnumerable<Employee>;
	    //Checks if the value of the collection is null.
	    if (employees == null)
	    {
	        e.Cancel = true;
	        return;
	    }
	}
```

#### __VB.NET__

```VB.NET
	Private Sub radGridView_Sorting(ByVal sender As Object, ByVal e As GridViewSortingEventArgs)
	    'Gets the value of the ItemsSource property as IEnumerable.
	    Dim employees As IEnumerable(Of Employee) = TryCast(e.DataControl.ItemsSource, IEnumerable(Of Employee))
	
	    'Checks if the value of the collection is null.
	    If employees Is Nothing Then
	        e.Cancel = True
	        Exit Sub
	    End If
	End Sub
```

Next you have to check the value of the current sorting direction. To do that use __OldSortingState__ property of __GridViewSortingEventArgs__, adding the following lines of code to the sorting event handler:
        
#### __C#__

```C#
	//If the sorting state is none, sort the items ascending.
	if (e.OldSortingState == SortingState.None)
	{
	    e.NewSortingState = SortingState.Ascending;
	}
	//If the sorting state is ascending, sort the items descending.
	else if (e.OldSortingState == SortingState.Ascending)
	{
	    e.NewSortingState = SortingState.Descending;
	}
	//If the sorting state is descending, apply default sorting to the items.
	else
	{
	    e.NewSortingState = SortingState.None;
	}
```

#### __VB.NET__

```VB.NET
	'If the sorting state is none, sort the items ascending.
	If e.OldSortingState = SortingState.None Then
	    e.NewSortingState = SortingState.Ascending
	    'If the sorting state is ascending, sort the items descending.
	ElseIf e.OldSortingState = SortingState.Ascending Then
	    e.NewSortingState = SortingState.Descending
	    'If the sorting state is descending, apply default sorting to the items.
	Else
	    e.NewSortingState = SortingState.None
	End If
```

You can see that after determining the sorting state, __NewSortingState__ property is set to match the new sorting state.

To sort the employees collection use __OrderBy__ and __OrderByDescending__ extension methods provided by __System.Linq__ namespace. The extension methods work with lambda expressions.
        
#### __C#__

```C#
	//Via the SortPropertyName value get 
	//the value of the property to sort your data by.
	employees = employees.OrderBy(employee => employee.GetType()
	                                                  .GetProperty((e.Column as GridViewDataColumn).GetDataMemberName())
	                                                  .GetValue(employee, null));
```

#### __VB.NET__

```VB.NET
	'Via the SortPropertyName value get 
	'the value of the property to sort your data by.
	employees = employees.OrderBy(Function(employee) employee.GetType().GetProperty((TryCast(e.Column, GridViewDataColumn)).GetDataMemberName()).GetValue(employee, Nothing))
	' #endregion
	
	'#region gridview-sorting-custom_9
	e.DataControl.ItemsSource = employees.ToList()
	e.Cancel = True
```

Do the same with __OrderByDescending__ extension method. In the end, set __RadGridView.ItemsSource__ to the sorted employees collection and set the __Cancel__ property of the __RadGridViewEventArgs__ to __True__ , so the built-in sorting functionality would be bypassed.

#### __C#__

```C#
	e.DataControl.ItemsSource = employees.ToList();
	e.Cancel = true;
```

#### __VB.NET__

```VB.NET
	e.DataControl.ItemsSource = employees.ToList()
	e.Cancel = True
```

Here is the final code that should represent __Sorting__ event handler.

#### __C#__

```C#
	private void CustomSortingGrid_Sorting(object sender, GridViewSortingEventArgs e)
	{
	    //Gets the value of the ItemsSource property as IEnumerable.
	    IEnumerable<Employee> employees = e.DataControl.ItemsSource as IEnumerable<Employee>;
	    //Checks if the value of the collection is null.
	    if (employees == null)
	    {
	        e.Cancel = true;
	        return;
	    }
	    //If the sorting state is none, sort the items ascending.
	    if (e.OldSortingState == SortingState.None)
	    {
	        e.NewSortingState = SortingState.Ascending;
	        employees = employees.OrderBy(employee => employee.GetType()
	                                                          .GetProperty((e.Column as GridViewDataColumn).GetDataMemberName())
	                                                          .GetValue(employee, null));
	    }
	    //If the sorting state is ascending, sort the items descending.
	    else if (e.OldSortingState == SortingState.Ascending)
	    {
	        e.NewSortingState = SortingState.Descending;
	        employees = employees.OrderByDescending(employee => employee.GetType()
	                                                           .GetProperty((e.Column as GridViewDataColumn).GetDataMemberName())
	                                                           .GetValue(employee, null));
	    }
	    //If the sorting state is descending, apply default sorting to the items.
	    else
	    {
	        e.NewSortingState = SortingState.None;
	        employees = employees.OrderBy(employee => employee.EmployeeID);
	    }
	    //Set the sorted collection as source of the RadGridView
	    e.DataControl.ItemsSource = employees.ToList();
	    e.Cancel = true;
	}
```

#### __VB.NET__

```VB.NET
	Private Sub CustomSortingGrid_Sorting(ByVal sender As Object, ByVal e As GridViewSortingEventArgs)
	    'Gets the value of the ItemsSource property as IEnumerable.
	    Dim employees As IEnumerable(Of Employee) = TryCast(e.DataControl.ItemsSource, IEnumerable(Of Employee))
	
	    'Checks if the value of the collection is null.
	    If employees Is Nothing Then
	        e.Cancel = True
	        Exit Sub
	    End If
	
	    'If the sorting state is none, sort the items ascending.
	    If e.OldSortingState = SortingState.None Then
	        e.NewSortingState = SortingState.Ascending
	        employees = employees.OrderBy(Function(employee) employee.[GetType]().GetProperty(TryCast(e.Column, GridViewDataColumn).GetDataMemberName()).GetValue(employee, Nothing))
	        'If the sorting state is ascending, sort the items descending.
	    ElseIf e.OldSortingState = SortingState.Ascending Then
	        e.NewSortingState = SortingState.Descending
	        employees = employees.OrderByDescending(Function(employee) employee.[GetType]().GetProperty(TryCast(e.Column, GridViewDataColumn).GetDataMemberName()).GetValue(employee, Nothing))
	    Else
	        'If the sorting state is descending, apply default sorting to the items.
	        e.NewSortingState = SortingState.None
	        employees = employees.OrderBy(Function(employee) employee.EmployeeID)
	    End If
	
	    'Set the sorted collection as source of the RadGridView
	    e.DataControl.ItemsSource = employees.ToList()
	    e.Cancel = True
	End Sub
```

The same technique is not only usable with LINQ extension methods and RadGridView.ItemsSource__. You can implement whatever logic you like for getting data and sorting it. This is just a simple example that clarifies the logic around the implementation of the custom sorting and not the sorting functionality itself. 

Another example for custom sorting is the multi-column sorting, which is described in the [Multi-column Sorting]({%slug gridview-multiple-column-sorting%}) topic.

## Sort Group by Aggregate

You can download a __runnable project__ on how to sort a group by defined aggregate functions from our online SDK repository: [SortGroupByAggregate](https://github.com/telerik/xaml-sdk/tree/master/GridView/SortGroupByAggregate).

## Sort Group by Different Property

You can download a __runnable project__ on how to sort a group by a different property from our online SDK repository: [SortGroupByDifferentProperty](https://github.com/telerik/xaml-sdk/tree/master/GridView/SortGroupByDifferentProperty).

You can also find [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. 

## See Also
 
 * [Sorting Strings as Numbers]({%slug gridview-sort-strings%})

 * [Basic Sorting]({%slug gridview-sorting-basics%})

 * [Programmatic Sorting]({%slug gridview-sorting-programmatic%})

 * [Multiple-column Sorting]({%slug gridview-multiple-column-sorting%})
 
