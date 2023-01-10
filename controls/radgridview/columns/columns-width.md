---
title: Columns Width
page_title: Columns Width
description: Check out our examples of how you can control the column width either on a grid or column level within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-setting-columns-width
tags: width,columns
published: True
position: 13
---

# {{ site.framework_name }} RadGridView Controlling Columns Width

There are a couple of approaches available for setting the width of the columns within RadGridView:

* [On RadGridView Level](#on-radgridview-level)

* [On a Column Level](#on-column-level)

## On RadGridView Level

You can set RadGridView's **ColumnWidth** property which will affect all columns' width (unless the width is set explicitly for the column). 

#### **[XAML] Example 1: Setting RadGridView's ColumnWidth**

{{region xaml-gridview-setting-columns-width_0}}

		<telerik:RadGridView Name="clubsGrid" 
                             ItemsSource="{Binding Clubs}"
                             ColumnWidth="*">	
{{endregion}}

#### **[C#] Example 2: Setting RadGridView's ColumnWidth in code**

{{region cs-gridview-setting-columns-width_1}}

	this.clubsGrid.ColumnWidth = new Telerik.Windows.Controls.GridViewLength(1, Telerik.Windows.Controls.GridViewLengthUnitType.Star);
{{endregion}}

#### **[VB.NET] Example 2: Setting RadGridView's ColumnWidth in code**

{{region vb-gridview-setting-columns-width_2}}

	Me.clubsGrid.ColumnWidth = New Telerik.Windows.Controls.GridViewLength(1, Telerik.Windows.Controls.GridViewLengthUnitType.Star)
{{endregion}}

There are several values that you can assign to the property:

* **SizeToCells**: The width is set according to the longest text from the cells.

* **SizeToHeader**: The width is set according to the length of the column's header. This is the default value. 

* **Auto**: The width is set according to the longest value(might be the header or a value within the cell).

* __* (Star)__: The columns would take as much space as there is available.

* **Fixed Width**: You can set a fixed width for all the columns.


## On Column Level

Apart from setting the width for all the columns within the **RadGridView**, you can set the width for each individual column through its **Width** property. 

#### **[XAML] Example 3: Setting the width of a specific column**

{{region xaml-gridview-setting-columns-width_3}}

		<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
                                    Width="Auto" />	
{{endregion}}

#### **[C#] Example 4: Setting the width of a specific column in code**

{{region cs-gridview-setting-columns-width_4}}

	this.clubsGrid.Columns[0].Width = Telerik.Windows.Controls.GridViewLength.Auto;	
{{endregion}}

#### **[VB.NET] Example 4: Setting the width of a specific column in code**

{{region vb-gridview-setting-columns-width_5}}

	Me.clubsGrid.Columns(0).Width = Telerik.Windows.Controls.GridViewLength.Auto	
{{endregion}}

The values that could be assigned to the property are enumerated below:

* **SizeToCells**: The width is set according to the longest text from the cells.

* **SizeToHeader**: The width is set according to the length of the column's header.

* **Auto**: The width is set according to the longest value(might be the header or a value within the cell). This is the default value. 

* __* (Star)__: The column would take as much space as there is available.

* **Fixed Width**: You can set a fixed width for each column.


## See Also

 * [Reordering Columns]({%slug gridview-columns-reordering-columns%})
 
 * [Resizing Columns]({%slug gridview-columns-resizing-columns%})

 * [Frozen Columns]({%slug gridview-columns-frozen-columns%})

 * [Bound/Unbound Columns]({%slug gridview-columns-bound-unbound-columns%})
