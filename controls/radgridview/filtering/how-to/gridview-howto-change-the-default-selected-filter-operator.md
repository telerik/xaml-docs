---
title: Change the Default Selected Filter Operators
page_title: Change the Default Selected Filter Operators
description: Change the Default Selected Filter Operators
slug: gridview-filtering-howto-change-the-default-selected-filter-operator
tags: change,the,default,selected,filter,operators
publish: True
position: 5
---

# Change the Default Selected Filter Operators



## 

To change the default selected filter operators, you have to attach to the FilterOperatorsLoading event of RadGridView and set them in the event arguments. When in Filter Row mode you only need to set the first operator.

#### __C#__

{{region gridview-filtering-howto-change-the-default-selected-filter-operator_0}}
	private void OnRadGridViewFilterOperatorsLoading(object sender, Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs e)
	{
		if (e.Column.UniqueName == "HireDate")
		{
			e.DefaultOperator1 = Telerik.Windows.Data.FilterOperator.IsGreaterThan;
			e.DefaultOperator2 = Telerik.Windows.Data.FilterOperator.IsLessThan;
		}
	}
	{{endregion}}



#### __VB.NET__

{{region gridview-filtering-howto-change-the-default-selected-filter-operator_0}}
		Private Sub OnRadGridViewFilterOperatorsLoading(sender As Object, e As Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs)
			If e.Column.UniqueName = "HireDate" Then
				e.DefaultOperator1 = Telerik.Windows.Data.FilterOperator.IsGreaterThan
				e.DefaultOperator2 = Telerik.Windows.Data.FilterOperator.IsLessThan
			End If
		End Sub
	{{endregion}}



>Please note that you cannot reorder the available operators.

# See Also
