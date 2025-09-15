---
title: Move to point
page_title: Move to point
description: Check our &quot;Move to point&quot; documentation article for the RadSlider {{ site.framework_name }} control.
slug: radslider-move-to-point
tags: move,to,point
published: True
position: 5
---

# Move to point



## 

When the __IsMoveToPointEnabled__ property is set to __true__ and you click somewhere on the track, the thumb will move directly to the point of click, ignoring the __LargeChange__ property.

#### __XAML__

```XAML
	<telerik:RadSlider Maximum="10" IsMoveToPointEnabled="True"/>
```

![{{ site.framework_name }} RadSlider Move To Point Enabled](images/moveToPoint.png)

#### __XAML__

```XAML
	<telerik:RadSlider IsMoveToPointEnabled="True" 
	           IsSelectionRangeEnabled="True"
	           Maximum="10"
	           SelectionEnd="5"
	           SelectionStart="3" />
```

![{{ site.framework_name }} RadSlider Move To Point Selection](images/moveToPoint_selectionRange.png)
