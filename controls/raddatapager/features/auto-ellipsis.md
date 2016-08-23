---
title: Auto Ellipsis
page_title: Auto Ellipsis
description: Auto Ellipsis
slug: raddatapager-features-auto-ellipsis
tags: auto,ellipsis
published: True
position: 6
---

# Auto Ellipsis



## 

>tip If you are new to the __RadDataPager__ control, you can consider reading the [Getting Started]({%slug raddatapager-getting-started%}) topic before continuing.

The __AutoEllipsis__ appears when the __PageCount__ is greater than the __NumericButtonCount__. You can specify where the __AutoEllipsis__ is allowed to appear by setting the __AutoEllipsisMode__ property to one of the following values: 

* __After__ - displays __AutoEllipsis__ only after the __Numeric Buttons__. 

* __Before__ - displays __AutoEllipsis__ only before the __Numeric Buttons__. 

* __Both__ - displays __AutoEllipsis__ before and after the __Numeric Buttons__. 

* __None__ - doesn't display __AutoEllipsis__.

__Example 1__ shows a __RadDataPager__ control with an __AutoEllipsisMode__ set to __Both__.

#### __[XAML]Example 1: Set RadDataPager`s AutoEllipsisMode__
{{region xaml-raddatapager-features-auto-ellipsis_0}}	

	<telerik:RadDataPager x:Name="radDataPager"
	                        PageSize="3"
	                        DisplayMode="All"
	                        AutoEllipsisMode="Both" />
{{endregion}}

#### __Figure 1: RadDataPager with AutoEllipsisMode set to Both__
![](images/RadDataPager_Features_AutoEllipsis_01.png)

# See Also

 * [Display Modes]({%slug raddatapager-features-display-modes%})

 * [Page Size]({%slug raddatapager-features-page-size%})

 * [Infinite Paging]({%slug raddatapager-features-infinite-paging%})
