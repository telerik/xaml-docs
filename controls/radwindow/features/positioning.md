---
title: Positioning
page_title: Positioning
description: This article will describe the ways to position a RadWindow prior to opening.
slug: radwindow-features-positioning
tags: positioning
published: True
position: 2
---

# Positioning

This article will describe the ways to position a RadWindow prior to opening.

## WindowStartupLocation

The __WindowStartupLocation__ property is an enumeration that provides you with the following values:

* __CenterScreen__: Positions the __RadWindow__ in the center of the screen, when opened.

* __CenterOwner__: Positions the __RadWindow__ in the center of its owner, if there is one.

>tip The __Owner__ property specifies the control, that owns the __RadWindow__. When the WindowStartupLocation is __CenterOwner__, the __RadWindow__ will get centered relatively to its owner. Note that the __Owner__ property should be of type __RadWindow__{% if site.site_name == 'WPF' %} or __WPF Window__{% endif %}.

>If you assign the __Owner__ to be a __RadWindow__, make sure that you have opened the owner window prior to opening the child. Otherwise, you will get an __InvalidOperationException__.

* __Manual__: Positions the __RadWindow__ in the top-left corner of the screen. (default)

## Top/Left

When the __WindowStartupLocation__ is set to __Manual__ you can use the __Top__ and __Left__ properties to specify the absolute distance in pixels from the top-left corner of the page.

>tip You can use these properties to cascade the windows in your application.

## See Also

 * [States]({%slug radwindow-features-states%})

 * [Resizing]({%slug radwindow-features-resizing%})

 * [Moving]({%slug radwindow-features-moving%})
