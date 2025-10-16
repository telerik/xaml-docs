---
title: Read Only Rows and Cells
page_title: Read Only Rows and Cells
description: Learn how to control the read-only state of the Telerik {{ site.framework_name }} DataGrid either on grid or column level by binding it to a boolean property of your business object.
slug: gridview-read-only-rows-cells
tags: read,only,rows,and,cells
published: True
position: 10
---

# Read Only Rows and Cells

This article shows how to control which rows or cells to be read only.

Before __Q2 2010 SP2__, the RadGridView had only one property to control the read-only state - __IsReadOnly__, which either enables or disables editing at gridview level. The only solution was to subscribe to the [BeginningEdit]({%slug gridview-events-edit%}) event and cancel it if you do not want to edit a particular cell.

In Q2 2010 SP2, we added a new property - __IsReadOnlyBinding__ at a gridview and a column level. You can bind it to a boolean property of your business object. Here is how it works depending on where it is set:

## IsReadOnlyBinding at RadGridView level [Read Only Rows]

When you set __IsReadOnlyBinding__ property of RadGridView to True - the __full row__ becomes __read only__ when the underlying property is True. 

__Example 1: Binding IsReadOnlyBinding at RadGridView level.__

```XAML
	<telerik:RadGridView x:Name="radGridView" IsReadOnlyBinding="{Binding IsActive}" />
```

## IsReadOnlyBinding at column level [Read Only Cells]

When you set the __IsReadOnlyBinding__ property of the GridViewDataColumn - only the cells of that column are affected.

__Example 2: Binding IsReadOnlyBinding at column level.__

```XAML
	<telerik:RadGridView>
	    <telerik:RadGridView.Columns>
	        <telerik:GridViewDataColumn DataMemberBinding="{Binding Age}" 
	                    IsReadOnlyBinding="{Binding IsActive}" />
	        <!--...-->
	    </telerik:RadGridView.Columns>
	</telerik:RadGridView>
```

In both cases the property to which IsReadOnlyBinding is bound is exposed by the business object. In the example above "IsActive" as well as "Age" are properties of one and the same data item.

>tipYou can download a __runnable project__ illustrating the different setups from our online SDK repository [here](https://github.com/telerik/xaml-sdk/tree/master/GridView/ReadOnlyBinding).

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. 


