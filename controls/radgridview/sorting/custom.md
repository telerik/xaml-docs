---
title: Custom Sorting
page_title: Custom Sorting
description: Custom Sorting
slug: gridview-sorting-custom
tags: custom,sorting
published: True
position: 2
---

# Custom Sorting

Although __RadGridView__ provides a fully functional sorting mechanism, it can sometimes be slow or ineffective, compared to other sorting mechanisms (database server, LINQ extension methods, manually working with the __SortDescriptors__ collection etc.). To benefit from them you have to bypass the existing sorting functionality of __RadGridView__.

>You can set the __SortMemberPath__ property of the column to specify the name of the property the data in the column will be sorted by.
        
## Custom Sorting with IComparable 

In order to be able to sort the items in a way you define, the bound business object could implement __IComparable__ interface. Thus you will tell RadGridView how to sort the items. Since it respects this interface, it will sort the items depending on the logic you implement.
        
You can check some sample code on our {% if site.site_name == 'WPF' %}[Custom Sorting with IComparable demo.](http://demos.telerik.com/silverlight/#GridView/IComparable){% endif %}{% if site.site_name == 'Silverlight' %}[Custom Sorting with IComparable demo.](http://demos.telerik.com/wpf){% endif %}

It demonstrates using the [IComparable](http://msdn.microsoft.com/en-us/library/system.icomparable.aspx) interface to sort items.

## Custom Sorting with Generic SortDescriptor

You can also change the sorting algorithm through applying a [Generic Sort Descriptor]({%slug gridview-sorting-generic-descriptor%}).
       
## Custom Sorting handling Sorting Event

To do so you can use the __Sorting__ event. As a start you need to attach an event handler to it:
       
#### __C#__

{{region gridview-sorting-custom_0}}

	public CustomSorting()
	{
	    InitializeComponent();
	    this.radGridView.Sorting += this.radGridView_Sorting;    
	}
	private void radGridView_Sorting( object sender, GridViewSortingEventArgs e )
	{
	}
{{endregion}}

#### __VB.NET__

{{region gridview-sorting-custom_1}}

	Public Sub New()
	    InitializeComponent()       
	    AddHandler Me.radGridView.Sorting, AddressOf Me.radGridView_Sorting
	End Sub
	Private Sub radGridView_Sorting(ByVal sender As Object, ByVal e As GridViewSortingEventArgs)
	End Sub
{{endregion}}

>When performing a custom sorting, you need to set the __IsCustomSortingEnabled__ property of the column to True.

Take a look at the __GridViewSortingEventArgs__ argument of the event handler. There are a few properties that require your attention:
        
* __DataControl__ - this one holds the instance of the __RadGridView__ owning the column that was clicked and is going to be sorted.
            
* __Cancel__ - this boolean property defines whether the internal handling of the sorting event should be canceled. The default value is __False__, which means that the event will be handled internally by __RadGridView__ and the built-in sorting functionality will be executed. If you set it to __True__ the event won't be handled by the __RadGridView__ and the built-in sorting functionality will be bypassed.

* __OldSortingState__ - defines the current sorting state of the column being sorted.

* __NewSortingState__ - defines the new sorting state of the column and controls the sorting indicator of the column's header. Even if you don't want the built-in sorting functionality to be executed you have to properly set this property, otherwise the visual state of the sort indicator won't match the sort state of the data.

* __Column__ - the gridview column which is being sorted.

For the example you have to sort the __ItemsSource of RadGridView__ in the __Sorting__ event handler using LINQ extension methods. For that purpose be sure that you are using the __System.Linq__ namespace.

The first thing to do is to get the value of the __ItemsSource__ property of your __RadGridView__ and assure that it is not null. In the already created event handler for the __sorting__ event add the following lines of code.

#### __C#__

{{region gridview-sorting-custom_2}}

	private void radGridView_Sorting( object sender, GridViewSortingEventArgs e )
	{
	    //Gets the value of the ItemsSource property as IEnumerable.
	    IEnumerable<Employee> employees = e.DataControl.ItemsSource as IEnumerable<Employee>;
	    //Checks if the value of the collection is null.
	    if ( employees == null )
	    {
	        e.Cancel = true;
	        return;
	    }
	}
{{endregion}}

#### __VB.NET__

{{region gridview-sorting-custom_3}}

	Private Sub radGridView_Sorting(ByVal sender As Object, ByVal e As GridViewSortingEventArgs)
	    'Gets the value of the ItemsSource property as IEnumerable.'
	    Dim employees As IEnumerable(Of Employee) = TryCast(e.DataControl.ItemsSource, IEnumerable(Of Employee))
	
	    'Checks if the value of the collection is null.'
	    If employees Is Nothing Then
	        e.Cancel = True
	        Exit Sub
	    End If
	End Sub
{{endregion}}

Next you have to check the value of the current sorting direction. To do that use the __OldSortingState__ property of the __GridViewSortingEventArgs__, adding the following lines of code to the sorting event handler.
        

#### __C#__

{{region gridview-sorting-custom_4}}

	//If the sorting state is none, sort the items ascending.
	if ( e.OldSortingState == SortingState.None )
	{
	    e.NewSortingState = SortingState.Ascending;
	}
	//If the sorting state is none, sort the items descending.
	else if ( e.OldSortingState == SortingState.Ascending )
	{
	    e.NewSortingState = SortingState.Descending;
	}
	//If the sorting state is descending, apply default sorting to the items.
	else
	{
	    e.NewSortingState = SortingState.None;
	}
{{endregion}}

#### __VB.NET__

{{region gridview-sorting-custom_5}}

	'If the sorting state is none, sort the items ascending.'
	If e.OldSortingState = SortingState.None Then
	    e.NewSortingState = SortingState.Ascending
	'If the sorting state is none, sort the items descending.'
	ElseIf e.OldSortingState = SortingState.Ascending Then
	    e.NewSortingState = SortingState.Descending
	'If the sorting state is descending, apply default sorting to the items.'
	Else
	    e.NewSortingState = SortingState.None
	End If
{{endregion}}

You can see that after determining the sorting state, the __NewSortingState__ property is set to match the new sorting state.

To sort the employees collection use the __OrderBy__ and the __OrderByDescending__ extension methods provided by the __System.Linq__ namespace. The extension methods work with lambda expressions.
        

#### __C#__

{{region gridview-sorting-custom_6}}

	//Via the SortPropertyName value get 
	//the value of the property to sort your data by.
	employees = employees.OrderBy( employee => employee.GetType()
	                                                   .GetProperty( (e.Column as GridViewDataColumn).GetDataMemberName() )
	                                                   .GetValue( employee, null ) );
{{endregion}}

#### __VB.NET__

{{region gridview-sorting-custom_7}}

	'Via the SortPropertyName value get' 
	'the value of the property to sort your data by.'
	employees = employees.OrderBy(Function(employee) employee.[GetType]()
	                                                         .GetProperty(TryCast(e.Column, GridViewDataColumn).GetDataMemberName())
	                                                         .GetValue(employee, Nothing))
{{endregion}}

Do the same with the __OrderByDescending__ extension method. In the end, set the __ItemsSource__ property of your __RadGridView__ to the sorted employees collection and set the __Cancel__ property of the __RadGridViewEventArgs__ to __True__ , so the built-in sorting functionality would be bypassed.

#### __C#__

{{region gridview-sorting-custom_8}}

	e.DataControl.ItemsSource = employees.ToList();
	e.Cancel = true;
{{endregion}}

#### __VB.NET__

{{region gridview-sorting-custom_9}}

	e.DataControl.ItemsSource = employees.ToList()
	e.Cancel = True
{{endregion}}

Here is the final code that should represent your __Sorting__ event handler.

#### __C#__

{{region gridview-sorting-custom_10}}

	private void CustomSortingGrid_Sorting( object sender, GridViewSortingEventArgs e )
	{
	    //Gets the value of the ItemsSource property as IEnumerable.
	    IEnumerable<Employee> employees = e.DataControl.ItemsSource as IEnumerable<Employee>;
	    //Checks if the value of the collection is null.
	    if ( employees == null )
	    {
	        e.Cancel = true;
	        return;
	    }
	    //If the sorting state is none, sort the items ascending.
	    if ( e.OldSortingState == SortingState.None )
	    {
	        e.NewSortingState = SortingState.Ascending;
	        employees = employees.OrderBy( employee => employee.GetType()
	                                                           .GetProperty( (e.Column as GridViewDataColumn).GetDataMemberName() )
	                                                           .GetValue( employee, null ) );
	    }
	    //If the sorting state is none, sort the items descending.
	    else if ( e.OldSortingState == SortingState.Ascending )
	    {
	        e.NewSortingState = SortingState.Descending;
	        employees = employees.OrderByDescending( employee => employee.GetType()
	                                                            .GetProperty( (e.Column as GridViewDataColumn).GetDataMemberName() )
	                                                            .GetValue( employee, null ) );
	    }
	    //If the sorting state is descending, apply default sorting to the items.
	    else
	    {
	        e.NewSortingState = SortingState.None;
	        employees = employees.OrderBy( employee => employee.EmployeeID );
	    }
	    //Set the sorted collection as source of the RadGridView
	    e.DataControl.ItemsSource = employees.ToList();
	    e.Cancel = true;
	}
{{endregion}}

#### __VB.NET__

{{region gridview-sorting-custom_11}}

	Private Sub radGridView_Sorting(ByVal sender As Object, ByVal e As GridViewSortingEventArgs)
	    'Gets the value of the ItemsSource property as IEnumerable.'
	    Dim employees As IEnumerable(Of Employee) = TryCast(e.DataControl.ItemsSource, IEnumerable(Of Employee))
	
	    'Checks if the value of the collection is null.'
	    If employees Is Nothing Then
	        e.Cancel = True
	        Exit Sub
	    End If
	
	    'If the sorting state is none, sort the items ascending.'
	    If e.OldSortingState = SortingState.None Then
	        e.NewSortingState = SortingState.Ascending
	        employees = employees.OrderBy(Function(employee) employee.[GetType]().GetProperty(TryCast(e.Column, GridViewDataColumn).GetDataMemberName()).GetValue(employee, Nothing))
	    'If the sorting state is none, sort the items descending.'
	    ElseIf e.OldSortingState = SortingState.Ascending Then
	        e.NewSortingState = SortingState.Descending
	        employees = employees.OrderByDescending(Function(employee) employee.[GetType]().GetProperty(TryCast(e.Column, GridViewDataColumn).GetDataMemberName()).GetValue(employee, Nothing))
	    Else
	        'If the sorting state is descending, apply default sorting to the items.'
	        e.NewSortingState = SortingState.None
	        employees = employees.OrderBy(Function(employee) employee.EmployeeID)
	    End If
	
	    'Set the sorted collection as source of the RadGridView'
	    e.DataControl.ItemsSource = employees.ToList()
	    e.Cancel = True
	End Sub
{{endregion}}

The same technique is not only usable with LINQ extension methods and the __ItemsSource__ of the __RadGridView__. You can implement whatever logic you like for getting your data and sorting it. This is just a simple example that clarifies the logic around the implementation of the custom sorting and not the sorting functionality itself. Another example for custom sorting is the multi-column sorting, which is described in the [Multi-column Sorting]({%slug gridview-multiple-column-sorting%}) topic.

# See Also

 * [Basic Sorting]({%slug gridview-sorting-basics%})

 * [Programmatic Sorting]({%slug gridview-sorting-programmatic%})

 * [Multiple-column Sorting]({%slug gridview-multiple-column-sorting%})
