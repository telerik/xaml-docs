---
title: How to Hide the Header Row
page_title: How to Hide the Header Row
description: Check our &quot;How to Hide the Header Row&quot; documentation article for the RadOutlookBar {{ site.framework_name }} control.
slug: radoutlookbar-how-to-hide-the-header-row
tags: how,to,hide,the,header,row
published: True
position: 0
---

# How to Hide the Header Row

To hide the header row you can use the __HeaderVisibility__ property and set the value to __Collapsed__. 

![{{ site.framework_name }} RadOutlookBar Hide the Header Row](images/ob_headervisibility.png)


```XAML
	<telerik:RadOutlookBar x:Name="RadOutlookBar1" HeaderVisibility="Collapsed">
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

## See Also
 * [Getting Started]({%slug radoutlookbar-getting-started%})