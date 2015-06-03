---
title: Expression Column
page_title: Expression Column
description: Expression Column
slug: gridview-expression-column
tags: expression,column
published: True
position: 7
---

# Expression Column

__GridViewExpressionColumn__ derives from [GridViewColumn]({%slug radgridview-columns-column-types-basic-column%}) class and allows you to display various calculations in RadGridView itself. __GridViewExpressionColumn__ can be sorted and grouped like any other. 

>noteThe values displayed in GridViewExpressionColumn will be updated automatically when a concerned property on the data item changes.

#### __[XAML] Example 1: Define GridViewExpressionColumn in XAML.__

{{region gridview-expression-column_0}}

	<telerik:RadGridView ItemsSource="{Binding Products}" AutoGenerateColumns="False" ColumnWidth="*">
	 <telerik:RadGridView.Columns>
	         <telerik:GridViewDataColumn Header="Product ID" DataMemberBinding="{Binding ProductID}" />
	         <telerik:GridViewDataColumn Header="Product name" DataMemberBinding="{Binding ProductName}" />
	         <telerik:GridViewDataColumn Header="Unit price" DataMemberBinding="{Binding UnitPrice}" DataFormatString="{}{0:C}" />
	         <telerik:GridViewDataColumn Header="Units in stock" DataMemberBinding="{Binding UnitsInStock}" />
	         <telerik:GridViewExpressionColumn Header="Total value in stock" UniqueName="TotalValue" DataFormatString="{}{0:C}" />
	 </telerik:RadGridView.Columns>
	</telerik:RadGridView>
{{endregion}}

The most important property to be set in code is [Expression](http://msdn.microsoft.com/en-us/library/bb397687.aspx property of the GridViewExpressionColumn).

#### __[#] Example 2: Set Expression for GridViewExpressionColumn in code.__

{{region gridview-expression-column_1}}

	Expression<Func<Products, double>> expression = prod => prod.UnitPrice * prod.UnitsInStock;
	GridViewExpressionColumn column = this.RadGridView1.Columns["TotalValue"] as GridViewExpressionColumn;
	column.Expression = expression;
{{endregion}}

More information about expressions could be found [here](http://www.telerik.com/help/silverlight/radexpressioneditor-expressions-overview.html).
