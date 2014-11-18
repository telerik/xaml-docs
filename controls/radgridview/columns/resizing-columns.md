---
title: Resizing Columns
page_title: Resizing Columns
description: Resizing Columns
slug: gridview-columns-resizing-columns
tags: resizing,columns
published: True
position: 9
---

# Resizing Columns

The columns inside the __RadGridView__ are resizable by default. The user is able to easily change the column width by positioning the mouse over the columns vertical grid line and dragging it until the desired size is achieved.

![](images/RadGridView_ResizingColumns_1.png)

To resize the columns programmatically you can use the __Width__ property. For example:

#### __XAML__

{{region gridview-columns-resizing-columns_0}}

	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
                                Header="Name"
                                Width="100" />
{{endregion}}

## Disabling Resizing

There are two ways to disable the resizing. The first one is by setting the __CanUserResize__ columns to __False__.

#### __XAML__

{{region gridview-columns-resizing-columns_1}}

	<telerik:RadGridView x:Name="radGridView"
	                     CanUserResizeColumns="False">
	    ...
	</telerik:RadGridView>
{{endregion}}

This will disable resizing on __RadGridView__ level, which means that all of the columns won't be resizable. If you want to disable resizing only for a particular column use the __IsResizable__ property of the column.

#### __XAML__

{{region gridview-columns-resizing-columns_2}}

	<telerik:GridViewDataColumn Header="ID"
                                DataMemberBinding="{Binding EmployeeID}"
                                UniqueName="ID" 
                                IsResizable="False" />
{{endregion}}

## Resizing Events

When the user resizes the column the __ColumnWidthChanging__ event is fired and if it is not canceled the __ColumnWidthChanged__ event fires after the resize is completed. Note that the user can resize columns only if the __CanUserResizeColumns__ is set to __True__ (which is the default value). Read more [here]({%slug gridview-column-resize-event%}).

# See Also

 * [Reordering Columns]({%slug gridview-columns-reordering-columns%})

 * [Frozen Columns]({%slug gridview-columns-frozen-columns%})

 * [Bound/Unbound Columns]({%slug gridview-columns-bound-unbound-columns%})
