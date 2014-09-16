---
title: Auto Ellipsis
page_title: Auto Ellipsis
description: Auto Ellipsis
slug: raddatapager-features-auto-ellipsis
tags: auto,ellipsis
publish: True
position: 6
---

# Auto Ellipsis



## 

>tipIf you are new to the __RadDataPager__ control, you can consider reading the [Getting Started]({%slug raddatapager-getting-started%}) topic before continuing.

The __AutoEllipsis__ appears when the __PageCount__ is greater than the __NumericButtonCount__. You can specify where the __AutoEllipsis__ is allowed to appear by setting the __AutoEllipsisMode__property to one of the following values: 

* __After__ - displays __AutoEllipsis__ only after the Numeric Buttons. 

* __Before__ - displays __AutoEllipsis__ only before the Numeric Buttons. 

* __Both__ - displays __AutoEllipsis__ before and after the Numeric Buttons. 

* __None -__doesn't display __AutoEllipsis__.

Here is an example of a __RadDataPager__ control with an __AutoEllipsisMode__ set to __Both__.

#### __XAML__

{{region raddatapager-features-auto-ellipsis_0}}
	<telerik:RadDataPager x:Name="radDataPager"
	                        PageSize="3"
	                        DisplayMode="All"
	                        AutoEllipsisMode="Both" />
	{{endregion}}






         
      ![](images/RadDataPager_Features_AutoEllipsis_01.png)

# See Also

 * [Display Modes]({%slug raddatapager-features-display-modes%})

 * [Page Size]({%slug raddatapager-features-page-size%})

 * [Infinite Paging]({%slug raddatapager-features-infinite-paging%})
