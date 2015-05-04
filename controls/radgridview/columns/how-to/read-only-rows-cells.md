---
title: Read Only Rows and Cells
page_title: Read Only Rows and Cells
description: Read Only Rows and Cells
slug: gridview-read-only-rows-cells
tags: read,only,rows,and,cells
published: True
position: 9
---

# Read Only Rows and Cells

This article shows how to control which rows or cells to be read only.

Before __Q2 2010 SP2__, the RadGridView had only one property to control the read-only state - __IsReadOnly__, which either enables or disables editing at gridview level. The only solution was to subscribe to the [BeginningEdit]({%slug gridview-events-edit%}) event and cancel it if you do not want to edit a particular cell.

In Q2 2010 SP2, we added a new property - __IsReadOnlyBinding__ at a gridview and a column level. You can bind it to a boolean property of your business object. Here is how it works depending on where it is set:

## IsReadOnlyBinding at RadGridView level [Read Only Rows]

When you set __IsReadOnlyBinding__ property of RadGridView to True - the __full row__ becomes __read only__ when the underlying property is True. 

#### __[XAML] Example 1: Binding IsReadOnlyBinding at RadGridView level.__

{{region gridview-read-only-rows-cells_0}}

	<telerik:RadGridView x:Name="radGridView" IsReadOnlyBinding="{Binding IsActive}" />
{{endregion}}

## IsReadOnlyBinding at column level [Read Only Cells]

When you set the __IsReadOnlyBinding__ property of the GridViewDataColumn - only the cells of that column are affected.

#### __[XAML] Example 2: Binding IsReadOnlyBinding at column level.__

{{region gridview-read-only-rows-cells_1}}

	<telerik:RadGridView x:Name="radGridView" >
	...
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Age}" 
	                            IsReadOnlyBinding="{Binding IsActive}" />
	...
	</telerik:RadGridView>
{{endregion}}

In both cases the property to which IsReadOnlyBinding is bound is exposed by the business object. In the example above "IsActive" as well as "Age" are properties of one and the same data item.


