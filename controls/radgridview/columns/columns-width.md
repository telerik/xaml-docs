---
title: Columns Width
page_title: Columns Width
description: Columns Width
slug: gridview-setting-columns-width
tags: width,columns
published: True
position: 13
---

# Controlling Columns Width

There are a couple of approaches available for setting the width of the columns within the RadGridView:

* [On RadGridView Level](#on-radgridview-level)

* [On a Column level](#on-a-column-level)

## On RadGridView Level

You can set RadGridView's **ColumnWidth** property which will affect all columns width(unless the width is set explicitly fo r the column). 

#### **[XAML] Example 1: Setting RadGridView's ColumnWidth**

		<telerik:RadGridView Name="clubsGrid" 
                             ItemsSource="{Binding Clubs}"
                             ColumnWidth="*">	

There are several values that you can assign to the property:

* **SizeToCells** - The width is set according to the longest text from the cells

* **SizeToHeader** 	-  The width is set according to the length of the column's header

* **Auto** - the width is set according to the longest value(might be the header or a value within the cell)

* **Asterisk** - The columns would take as much space as there is available 

* **Fixed Width** - You can set a fixed width for all the columns


## On a Column Level

Apart from setting the width for all the columns within the **RadGridView**, you can set the width for each individual column through its **Width** property. 

#### **[XAML] Example 2: Setting the width of a specific column**

		<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
                                    Width="Auto" />	

The values that could be assigned to the property are enumerated below:

* **SizeToCells** - The width is set according to the longest text from the cells

* **SizeToHeader** 	-  The width is set according to the length of the column's header

* **Auto** - the width is set according to the longest value(might be the header or a value within the cell)

* **Asterisk** - The column would take as much space as there is available 

* **Fixed Width** - You can set a fixed width for each column



# See Also

 * [Reordering Columns]({%slug gridview-columns-reordering-columns%})
 
 * [Resizing Columns]({%slug gridview-columns-resizing-columns%})

 * [Frozen Columns]({%slug gridview-columns-frozen-columns%})

 * [Bound/Unbound Columns]({%slug gridview-columns-bound-unbound-columns%})
