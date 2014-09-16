---
title: Reordering Columns
page_title: Reordering Columns
description: Reordering Columns
slug: gridview-columns-reordering-columns
tags: reordering,columns
publish: True
position: 10
---

# Reordering Columns



The __RadGridView__ control supports column reordering and it can be done by the user in run-time. The user has just to drag the desired column's header at the desired position among the other headers and drop it there.

![](images/RadGridView_ReorderingColumns_1.png)

## Reordering modes 

RadGridView suggests different modes when reordering a column. You can control it through the __ReorderColumnsMode__ property.
        

You can find the possible values you can assign for it bellow:
        

* __DropIndicator__ - Displays only drop mark indicating the destination drop location
            

* __None__ - Does not display any indicators
            

* __ReorderColumns__ - Reorder columns while dragging cells
            

* __Interactive__ - Reorder columns and show drop indicator
            

## Disabling Reordering

There are two ways to disable reordering. The first one is to disable it on __RadGridView__ level by setting the __CanUserReorderColumns__property to __False__, which means that none of the columns will be re-orderable.

#### __XAML__

{{region gridview-columns-reordering-columns_0}}
	<telerik:RadGridView x:Name="radGridView"
	                         CanUserReorderColumns="False">
	    ...
	</telerik:RadGridView>
	{{endregion}}



The headers will be still draggable, but when you drop them nothing will happen.

You can also disable the reordering for a particular column by setting its __IsReorderable__ property.

#### __XAML__

{{region gridview-columns-reordering-columns_1}}
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
	                                Header="Name"
	                                IsReorderable="False" />
	{{endregion}}



## Reordering programmatically 

The order of the columns may also be configured by setting the DisplayIndex property of each of them:

#### __XAML__

{{region gridview-columns-reordering-columns_2}}
	<telerik:RadGridView.Columns>
	     <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" DisplayIndex="0"/>
	     <telerik:GridViewDataColumn DataMemberBinding="{Binding Number}" DisplayIndex="2"/>
	     <telerik:GridViewDataColumn DataMemberBinding="{Binding Country}" DisplayIndex="1"/>
	</telerik:RadGridView.Columns>
	{{endregion}}



In this case the columns will be visualized in the following order - Name, Country and Number.



# See Also

 * [Frozen Columns]({%slug gridview-columns-frozen-columns%})

 * [Bound/Unbound Columns]({%slug gridview-columns-bound-unbound-columns%})
