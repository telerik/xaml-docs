---
title: Auto Ellipsis
page_title: Auto Ellipsis
description: Check our &quot;Auto Ellipsis&quot; documentation article for the RadDataPager {{ site.framework_name }} control.
slug: raddatapager-features-auto-ellipsis
tags: auto,ellipsis
published: True
position: 6
---

# Auto Ellipsis

>tip If you are new to the __RadDataPager__ control, you can consider reading the [Getting Started]({%slug raddatapager-getting-started%}) topic before continuing.

The __AutoEllipsis__ appears when the __PageCount__ is greater than the __NumericButtonCount__. You can specify where the __AutoEllipsis__ is allowed to appear by setting the __AutoEllipsisMode__ property to one of the following values: 

* __After__ - displays __AutoEllipsis__ only after the __Numeric Buttons__. 

* __Before__ - displays __AutoEllipsis__ only before the __Numeric Buttons__. 

* __Both__ - displays __AutoEllipsis__ before and after the __Numeric Buttons__. 

* __None__ - doesn't display __AutoEllipsis__.

Here is an example of a __RadDataPager__ control with an __AutoEllipsisMode__ set to __Both__.


```XAML	
	<telerik:RadDataPager x:Name="radDataPager"
	                        PageSize="3"
	                        DisplayMode="All"
	                        AutoEllipsisMode="Both" />
```


![{{ site.framework_name }} RadDataPager with AutoEllipsisMode Both](images/RadDataPager_Features_AutoEllipsis_01.png)

## See Also  
 * [Display Modes]({%slug raddatapager-features-display-modes%})
 * [Page Size]({%slug raddatapager-features-page-size%})
 * [Infinite Paging]({%slug raddatapager-features-infinite-paging%})
