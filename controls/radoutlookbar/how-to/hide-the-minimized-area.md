---
title: How to Hide the Minimized Area
page_title: How to Hide the Minimized Area
description: Check our &quot;How to Hide the Minimized Area&quot; documentation article for the RadOutlookBar {{ site.framework_name }} control.
slug: radoutlookbar-how-to-hide-the-minimized-area
tags: how,to,hide,the,minimized,area
published: True
position: 1
---

# How to Hide the Minimized Area

To hide the minimize area you can use the __MinimizedAreaVisibility__ property and set its value to __Collapsed__.

![{{ site.framework_name }} RadOutlookBar Hide the Minimized Area](images/outlook_minimizedareavisibility.png)

#### __XAML__
```XAML
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
```