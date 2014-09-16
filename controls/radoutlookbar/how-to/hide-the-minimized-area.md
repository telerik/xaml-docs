---
title: How to Hide the Minimized Area
page_title: How to Hide the Minimized Area
description: How to Hide the Minimized Area
slug: radoutlookbar-how-to-hide-the-minimized-area
tags: how,to,hide,the,minimized,area
publish: True
position: 1
---

# How to Hide the Minimized Area



## 

To hide the minimize area you can use the __MinimizedAreaVisibility__ property and set its value to __Collapsed__.

![](images/outlook_minimizedareavisibility.png)

#### __XAML__

{{region radoutlookbar-how-to-hide-the-minimized-area_0}}
	<telerik:RadOutlookBar x:Name="RadOutlookBar1" MinimizedAreaVisibility="Collapsed">
	 <telerik:RadOutlookBarItem Header="Item 1">
	  <TextBlock Text="Item 1 Content" />
	 </telerik:RadOutlookBarItem>
	 <telerik:RadOutlookBarItem Header="Item 2">
	  <TextBlock Text="Item 2 Content" />
	 </telerik:RadOutlookBarItem>
	 <telerik:RadOutlookBarItem Header="Item 3">
	  <TextBlock Text="Item 3 Content" />
	 </telerik:RadOutlookBarItem>
	</telerik:RadOutlookBar>
	{{endregion}}


