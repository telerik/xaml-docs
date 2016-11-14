---
title: Resizing
page_title: Resizing
description: Resizing
slug: radoutlookbar-resizing
tags: resizing
published: True
position: 2
---

# Resizing

Users can use the horizontal splitter to resize the selected and active
area. The following properties are related to the size of those two areas:

* __MinContentHeight__ - the minimum height of the selected content area. 

* __ActiveItemsMaxCount__ - the maximum number of items in the active area. When the items are more they go to the minimize or overflow area automatically.

* __MinimimizedAreaMinHeight__ - the minimum height of the minimized area.

#### __XAML__
{{region xaml-radoutlookbar-resizing_0}}
	<telerik:RadOutlookBar MinContentHeight="300">
	    <telerik:RadOutlookBarItem Header="Item 1" Icon="Letter.png">
	        <TextBlock Text="Item 1 Content" />
	    </telerik:RadOutlookBarItem>
	    <telerik:RadOutlookBarItem Header="Item 2" 
	                               Icon="Letter.png"
	                               IsSelected="True">
	        <TextBlock Text="Item 2 Content" />
	    </telerik:RadOutlookBarItem>
	    <telerik:RadOutlookBarItem Header="Item 3" Icon="Letter.png">
	        <TextBlock Text="Item 3 Content" />
	    </telerik:RadOutlookBarItem>
	</telerik:RadOutlookBar>
{{endregion}}

## Handle when item changes its position in the RadOutlookBar

To handle the changes in the position of the item you can subscribe to the __ItemPositionChanged__ event in the way showed below:

#### __XAML__
{{region xaml-radoutlookbar-resizing_1}}
	<telerik:RadOutlookBar ActiveItemsMaxCount="1"
	                       ItemPositionChanged="RadOutlookBar1_ItemPositionChanged">
	    <telerik:RadOutlookBarItem Header="Item 1" Icon="Letter.png">
	        <TextBlock Text="Item 1 Content" />
	    </telerik:RadOutlookBarItem>
	    <telerik:RadOutlookBarItem Header="Item 2" 
	                               Icon="Letter.png"
	                               IsSelected="True">
	        <TextBlock Text="Item 2 Content" />
	    </telerik:RadOutlookBarItem>
	    <telerik:RadOutlookBarItem Header="Item 3" Icon="Letter.png">
	        <TextBlock Text="Item 3 Content" />
	    </telerik:RadOutlookBarItem>
	</telerik:RadOutlookBar>
{{endregion}}

#### __C#__
{{region cs-radoutlookbar-resizing_2}}
	private void RadOutlookBar1_ItemPositionChanged(object sender, PositionChangedEventArgs e)
	{
		RadOutlookBarItem outlookBarItem = e.OriginalSource as RadOutlookBarItem;
		OutlookBarItemPosition oldPosition = e.OldPosition;
		OutlookBarItemPosition newPosition = e.NewPosition;
	}
{{endregion}}

#### __VB.NET__
{{region vb-radoutlookbar-resizing_3}}
	Private Sub RadOutlookBar1_ItemPositionChanged(ByVal sender As Object, ByVal e As PositionChangedEventArgs)
	    Dim outlookBarItem As RadOutlookBarItem = TryCast(e.OriginalSource, RadOutlookBarItem)
	    Dim oldPosition As OutlookBarItemPosition = e.OldPosition
	    Dim newPosition As OutlookBarItemPosition = e.NewPosition
	End Sub
{{endregion}}

# See Also
 * [Getting Started]({%slug radoutlookbar-getting-started%})
 * [Visual Structure]({%slug radoutlookbar-visual-structure%})