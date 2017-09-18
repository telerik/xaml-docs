---
title: Enable Horizontal and Vertical Scrollbar 
page_title: Enable Horizontal and Vertical Scrollbar 
description: Enable Horizontal and Vertical Scrollbar 
slug: radgridview-how-to-enable-horiz-vertic-scrollbar
tags: enable,horizontal,and,vertical,scrollbar,
published: True
position: 1
---

# Enable Horizontal and Vertical Scrollbar 

In order to enable horizontal and/or vertical scrollbars you need to set the __ScrollViewer__'s attached properties __HorizontalScrollBarVisibility__ and/or __VerticalScrollBarVisibility__.

#### __[XAML] Example 1: Set Attached ScrollViewer Properties__

{{region xaml-radgridview-how-to-enable-horiz-vertic-scrollbar_0}}
	<telerik:RadGridView x:Name="radGridView" ScrollViewer.HorizontalScrollBarVisibility="Visible" ScrollViewer.VerticalScrollBarVisibility="Visible"/>
{{endregion}}

The same operation can be done in code-behind:

#### __[C#] Example 1: Set Attached ScrollViewer Properties__

{{region cs-radgridview-how-to-enable-horiz-vertic-scrollbar_1}}
	private void EnableScrollBars()
	{
	    ScrollViewer.SetHorizontalScrollBarVisibility(this.radGridView, ScrollBarVisibility.Visible);
	    ScrollViewer.SetVerticalScrollBarVisibility(this.radGridView, ScrollBarVisibility.Visible);
	}
{{endregion}}

#### __[VB.NET] Example 1: Set Attached ScrollViewer Properties__

{{region vb-radgridview-how-to-enable-horiz-vertic-scrollbar_2}}
	Private Sub EnableScrollBars()
	    ScrollViewer.SetHorizontalScrollBarVisibility(Me.radGridView, ScrollBarVisibility.Visible)
	    ScrollViewer.SetVerticalScrollBarVisibility(Me.radGridView, ScrollBarVisibility.Visible)
	End Sub
{{endregion}}

The result is illustrated in **Figure 1**.

#### __Figure 1: RadGridView with vertical and horizontal scrollbars__

![RadGridView with vertical and horizontal scrollbars](images/RadGridView_HowTo_HorizontalAndVerticalScrollbar_010.png)

## See Also

 * [Scrolling]({%slug gridview-scrolling%})
 * [Scroll to a Particular Row or Column]({%slug gridview-scroll-item%})
 * [UI Virtualization]({%slug radgridview-features-ui-virtualization%})
