---
title: Change the Default Selected Filter Operators
page_title: Change the Default Selected Filter Operators
description: Get started with the filtering functionality of Telerik's {{ site.framework_name }} DataGrid and learn how to change the default selected filter operators.
slug: gridview-filtering-howto-change-the-default-selected-filter-operator
tags: change,the,default,selected,filter,operators
published: True
position: 5
---

# Change the Default Selected Filter Operators

To change the default selected filter operators, you have to handle the __FilterOperatorsLoading__ event of RadGridView and set them in the event arguments. When the [FilteringMode]({%slug gridview-filtering-howto-configure-the-filtering-mode%}) is __FilterRow__, you only need to set the first operator.



```C#
	private void OnRadGridViewFilterOperatorsLoading(object sender, Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs e)
	{
	    if (e.Column.UniqueName == "HireDate")
	    {
	        e.DefaultOperator1 = Telerik.Windows.Data.FilterOperator.IsGreaterThan;
	        e.DefaultOperator2 = Telerik.Windows.Data.FilterOperator.IsLessThan;
	    }
	}
```
```VB.NET
	Private Sub OnRadGridViewFilterOperatorsLoading(sender As Object, e As Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs)
	    If e.Column.UniqueName = "HireDate" Then
	        e.DefaultOperator1 = Telerik.Windows.Data.FilterOperator.IsGreaterThan
	        e.DefaultOperator2 = Telerik.Windows.Data.FilterOperator.IsLessThan
	    End If
	End Sub
```

>Please, note that you cannot reorder the available operators.
