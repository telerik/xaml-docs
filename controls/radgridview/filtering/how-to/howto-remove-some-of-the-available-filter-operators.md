---
title: Remove Some of the Available Filter Operators
page_title: Remove Some of the Available Filter Operators
description: Learn how to attach to the FilterOperatorsLoading event of Telerik's {{ site.framework_name }} DataGrid in order to hide some of the available filter operators.
slug: gridview-filtering-howto-remove-some-of-the-available-filter-operators
tags: remove,some,of,the,available,filter,operators
published: True
position: 4
---

# Remove Some of the Available Filter Operators

In case you want to hide some of the available filter operators, you have to attach to the __FilterOperatorsLoading__ event of RadGridView. In the event arguments there is a property called AvailableOperators. The data engine will fill this collection with all operators supported for the respective column data type. You can only remove existing operators from this collection. You cannot add new ones. Trying to do so will result in an exception because the data engine will not be able to handle them. If you remove the default filter operator from the list, it might be a good idea to specify what should be selected by default by using the __DefaultFilterOperator1__ and __DefaultFilterOperator2__ properties.

#### __C#__

```C#
	private void OnRadGridViewFilterOperatorsLoading(object sender, Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs e)
	{
	    if (e.Column.UniqueName == "HireDate")
	    {
	        e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsEqualTo);
	        e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNotEqualTo);
	
	        e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsGreaterThanOrEqualTo);
	        e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsLessThanOrEqualTo);
	
	        e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNull);
	        e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNotNull);
	
	        e.DefaultOperator1 = Telerik.Windows.Data.FilterOperator.IsGreaterThan;
	        e.DefaultOperator2 = Telerik.Windows.Data.FilterOperator.IsLessThan;
	    }
	}
```

#### __VB.NET__

```VB.NET
	Private Sub OnRadGridViewFilterOperatorsLoading(sender As Object, e As Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs)
	    If e.Column.UniqueName = "HireDate" Then
	        e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsEqualTo)
	        e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNotEqualTo)
	
	        e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsGreaterThanOrEqualTo)
	        e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsLessThanOrEqualTo)
	
	        e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNull)
	        e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNotNull)
	
	        e.DefaultOperator1 = Telerik.Windows.Data.FilterOperator.IsGreaterThan
	        e.DefaultOperator2 = Telerik.Windows.Data.FilterOperator.IsLessThan
	    End If
	End Sub
```

>Please note that you cannot reorder the available operators.

