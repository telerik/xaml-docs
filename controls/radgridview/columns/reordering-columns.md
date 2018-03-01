---
title: Reordering Columns
page_title: Reordering Columns
description: Reordering Columns
slug: gridview-columns-reordering-columns
tags: reordering,columns
published: True
position: 11
---

# Reordering Columns

__RadGridView__ supports column reordering and it can be done by the user in run-time. The user can drag the desired column's header at the desired position among the other headers and drop it there.

![RadGridView reordering columns](images/RadGridView_ReorderingColumns_1.png)

## Reordering modes 

RadGridView suggests different modes when reordering a column. You can control it through the __ReorderColumnsMode__ property.
        
You can find the possible values you can assign for it bellow:
        
* __DropIndicator__ - Displays only drop mark indicating the destination drop location
            
* __None__ - Does not display any indicators
            
* __ReorderColumns__ - Reorder columns while dragging cells
            
* __Interactive__ - Reorder columns and show drop indicator
            
## Disabling Reordering

There are two ways to disable reordering. 

**1**. The first one is to disable it on __RadGridView__ level by setting the __CanUserReorderColumns__ property to __False__, which means that none of the columns will be re-orderable.

#### __[XAML] Example 1: Disable Reordering__

{{region xaml-gridview-columns-reordering-columns_0}}
	<telerik:RadGridView x:Name="radGridView"
	                 CanUserReorderColumns="False">
	    <!-- ... -->
	</telerik:RadGridView>
{{endregion}}

#### __[C#] Example 2: Disable Reordering in code__

{{region cs-gridview-columns-reordering-columns_4}}
	this.radGridView.CanUserReorderColumns = false;
{{endregion}}

#### __[VB.NET] Example 2: Disable Reordering in code__

{{region vb-gridview-columns-reordering-columns_5}}
	Me.radGridView.CanUserReorderColumns = False
{{endregion}}

The headers will be still draggable, but when you drop them nothing will happen.

**2**. You can also disable the reordering for a particular column by setting its __IsReorderable__ property.

#### __[XAML] Example 3: Disable Reordering for a particular column__

{{region xaml-gridview-columns-reordering-columns_1}}
	<telerik:GridViewDataColumn DataMemberBinding="{Binding Name}"
	                Header="Name"
	                IsReorderable="False" />
{{endregion}}

#### __[C#] Example 4: Disable Reordering for a particular column in code__
{{region cs-gridview-columns-reordering-columns_6}}
	this.radGridView.Columns[0].IsReorderable = false;
{{endregion}}

#### __[VB.NET] Example 4: Disable Reordering for a particular column in code__
{{region vb-gridview-columns-reordering-columns_7}}
	Me.radGridView.Columns(0).IsReorderable = False
{{endregion}}

## Reordering programmatically 

The order of the columns may also be configured by setting the __DisplayIndex__ property of each of them:

#### __[XAML] Example 5: Reorder using DisplayIndex__
{{region xaml-gridview-columns-reordering-columns_2}}
	<telerik:RadGridView.Columns>
	    <telerik:GridViewDataColumn DataMemberBinding="{Binding Name}" DisplayIndex="0"/>
	    <telerik:GridViewDataColumn DataMemberBinding="{Binding Number}" DisplayIndex="2"/>
	    <telerik:GridViewDataColumn DataMemberBinding="{Binding Country}" DisplayIndex="1"/>
	</telerik:RadGridView.Columns>
{{endregion}}

#### __[C#] Example 6: Reorder using DisplayIndex in code__
{{region cs-gridview-columns-reordering-columns_8}}
	this.radGridView.Columns[0].DisplayIndex = 0;
	this.radGridView.Columns[1].DisplayIndex = 2;
	this.radGridView.Columns[2].DisplayIndex = 1;
{{endregion}}

#### __[VB.NET] Example 6: Reorder using DisplayIndex in code__
{{region vb-gridview-columns-reordering-columns_9}}
	Me.radGridView.Columns(0).DisplayIndex = 0
    Me.radGridView.Columns(1).DisplayIndex = 2
    Me.radGridView.Columns(2).DisplayIndex = 1
{{endregion}}

In this case the columns will be visualized in the following order - Name, Country and Number.

## Scrolling Behavior while Reordering

The default scrolling behavior of __RadGridView__ while dragging its columns can be modified by configuring the __ScrollingSettingsBehavior__.

#### __[XAML] Example 7: Using the ScrollingSettingsBehavior__
 {{region xaml-gridview-columns-reordering-columns_3}}
	<telerik:RadGridView x:Name="radGridView" 
                     ScrollViewer.HorizontalScrollBarVisibility="Visible"
                     telerik:ScrollingSettingsBehavior.IsEnabled="True"
                     telerik:ScrollingSettingsBehavior.ScrollAreaPadding="5 20 5 20"
                     telerik:ScrollingSettingsBehavior.ScrollStep="1.5"
                     telerik:ScrollingSettingsBehavior.ScrollStepTime="00:00:00.5"/>
{{endregion}}

#### __[C#] Example 8: Using the ScrollingSettingsBehavior in code__
 {{region cs-gridview-columns-reordering-columns_10}}
	ScrollViewer.SetHorizontalScrollBarVisibility(this.radGridView, ScrollBarVisibility.Visible);
	ScrollingSettingsBehavior.SetIsEnabled(this.radGridView, true);
	ScrollingSettingsBehavior.SetScrollAreaPadding(this.radGridView, new Thickness(5, 20, 5, 20));
	ScrollingSettingsBehavior.SetScrollStep(this.radGridView, 1.5);
	ScrollingSettingsBehavior.SetScrollStepTime(this.radGridView, new TimeSpan(0, 0, 0, 5));
{{endregion}}

#### __[VB.NET] Example 9: Using the ScrollingSettingsBehavior in code__
 {{region vb-gridview-columns-reordering-columns_11}}
	ScrollViewer.SetHorizontalScrollBarVisibility(Me.radGridView, ScrollBarVisibility.Visible)
    ScrollingSettingsBehavior.SetIsEnabled(Me.radGridView, True)
    ScrollingSettingsBehavior.SetScrollAreaPadding(Me.radGridView, New Thickness(5, 20, 5, 20))
    ScrollingSettingsBehavior.SetScrollStep(Me.radGridView, 1.5)
    ScrollingSettingsBehavior.SetScrollStepTime(Me.radGridView, New TimeSpan(0, 0, 0, 5))
{{endregion}}

To learn more read the [Scrolling]({%slug gridview-scrolling%}) topic.

## See Also
 * [Frozen Columns]({%slug gridview-columns-frozen-columns%})
 * [Bound/Unbound Columns]({%slug gridview-columns-bound-unbound-columns%})
