---
title: Positioning
page_title: Positioning
description: Positioning
slug: radwindow-features-positioning
tags: positioning
publish: True
position: 2
---

# Positioning



There are several ways to position the __RadWindow__ prior to opening:

* [Use the WindowStartupLocation property](#WindowStartupLocation)

* [Use the Top/Left or TopOffset/LeftOffset properties](#Top_Left_and_TopOffset_LeftOffset)

>tipTo learn how to preserve the size and the location for each state of the __RadWindow__ read [this section](#Preserving_the_size_and_the_location_of_the_window).

## WindowStartupLocation

The __WindowStartupLocation__ property is an enumeration that provides you with the following values:

* __CenterScreen__ - positions the __RadWindow__ in the center of the screen, when opened.

* __CenterOwner__ - positions the __RadWindow__ in the center of its owner, if any.


>tipThe __Owner__ property specifies the control, that owns the __RadWindow__. When having the __CenterOwner__ enumeration value, the __RadWindow__ will get centered relatively to its owner.Note that the __Owner__ property should be of type __RadWindow__{% if site.site_name == 'WPF' %}or __WPF Window__{% endif %}.

>If you assign the __Owner__ to be a __RadWindow__, make sure that you have opened the owner window prior to opening the child. Otherwise, you will get an __InvalidOperationException__.

* __Manual__ - positions the __RadWindow__ in the top-left corner of the screen. (default)

## Top/Left and TopOffset/LeftOffset

When having the __WindowStartupLocation__ set to __Manual__ you can use the __Top__ and __Left__ properties to specify the absolute distance in pixels from the most top left corner of the page.

When having the __WindowStartupLocation__ set to __CenterScreen__ or __CenterOwner__ you can use the __TopOffset__ and __LeftOffset__ properties to specify the offset distance in pixels from the top left corner of __RadWindow__.

>tipYou can use these properties to cascade the windows in your application.

## Preserving the size and the location of the window

The __RestoreMinimizedLocation__ property allows the __RadWindow__ to store its size and position for the __Normal__ and the __Minimized__states. For example, if you minimize a window in the center of the screen and then drag it to the leftmost corner, __RadWindow__ will store its position separately. Thus,  if you restore the __RadWindow__ to __Normal__, it will appear in the center of the screen, respectively if you minimize it, it will get positioned in the leftmost corner.

>tipTo learn more about the __States__ of the __RadWindow__ read [here]({%slug radwindow-features-states%}).

# See Also

 * [States]({%slug radwindow-features-states%})

 * [Resizing]({%slug radwindow-features-resizing%})

 * [Moving]({%slug radwindow-features-moving%})
