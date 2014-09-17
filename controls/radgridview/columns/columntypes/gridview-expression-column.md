---
title: Expression Column
page_title: Expression Column
description: Expression Column
slug: gridview-expression-column
tags: expression,column
published: True
position: 11
---

# Expression Column



## 

The __GridViewExpressionColumn__ derives from the __GridViewColumn__ class and allows you to display various calculations in RadGridView itself. The __GridViewExpressionColumn__ can be sorted and grouped like any other. The value of a GridViewExpressionColumn cells updates automatically when a concerned property on the data item changes.

#### __XAML__

{{region gridview-expression-column_0}}
	<telerik:RadGridView x:Name="RadGridView1" ItemsSource="{Binding Products}" AutoGenerateColumns="False" ColumnWidth="*">
	 <telerik:RadGridView.Columns>
	         <telerik:GridViewDataColumn Header="Product ID" DataMemberBinding="{Binding ProductID}" />
	         <telerik:GridViewDataColumn Header="Product name" DataMemberBinding="{Binding ProductName}" />
	         <telerik:GridViewDataColumn Header="Unit price" DataMemberBinding="{Binding UnitPrice}" DataFormatString="{}{0:C}" />
	         <telerik:GridViewDataColumn Header="Units in stock" DataMemberBinding="{Binding UnitsInStock}" />
	         <telerik:GridViewExpressionColumn Header="Total value in stock" UniqueName="TotalValue" DataFormatString="{}{0:C}" />
	 </telerik:RadGridView.Columns>
	</telerik:RadGridView>
	{{endregion}}



The most important property to be set in the code is the 
        __Expressionhttp://msdn.microsoft.com/en-us/library/bb397687.aspx__ property of the GridViewExpressionColumn.

#### __C#__

{{region gridview-expression-column_1}}
	Expression<Func<Products, double>> expression = prod => prod.UnitPrice * prod.UnitsInStock;
	GridViewExpressionColumn column = this.RadGridView1.Columns["TotalValue"] as GridViewExpressionColumn;
	column.Expression = expression;
	{{endregion}}



More information about expressions could be found
          __herehttp://www.telerik.com/help/silverlight/radexpressioneditor-expressions-overview.html__
