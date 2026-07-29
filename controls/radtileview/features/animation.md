---
title: Animation
page_title: Animation
description: Check our &quot;Animation&quot; documentation article for the RadTileView {{ site.framework_name }} control.
slug: radtileview-animation
tags: animation
published: True
position: 4
---

# Animation

This article describes how you can control the __RadTileView__ animations. By default the animations are enabled. This can be changed using the __IsItemsAnimationEnabled__ property.

__Example 1: Disabling the animations__
<snippet id='radtileview-features-animation-block_1-xaml' />

There are two different animations available with the control.

## Reordeing animation

It occurs when items are swapped using drag. Or when the __Position__ property's value of a __RadTileViewItem__ is changed. The __RadTileView__ control allows you to change the animation duration and easing function. To do that use the __ReorderingDuration__ and __ReorderingEasing__ properties. 

__Example 2: Setting animation duration__
<snippet id='radtileview-features-animation-block_2-xaml' />

__Example 3: Setting animation duration in code__
<snippet id='radtileview-features-animation-block_3-cs' />

The __ReorderingEasing__ property is of type __IEasingFunction__ which means that you can use any of the easing functions provided by the {{ site.framework_name }} framework or create a custom one.

__Example 4: Setting animation easing__
<snippet id='radtileview-features-animation-block_4-xaml' />
	
## Resizing animation

It occurs when the items change their __TileState__ (minimized, maximized, restored). The __RadTileView__ control allows you to change the animation duration and easing function. To do that use the __ResizingDuration__ and __ResizingEasing__ properties. The properties are set in the same manner as the reordering animation properties (see Examples 2 to 4).

## See Also
 * [Getting Started]({%slug radtileview-getting-started%})
 * [Events]({%slug radtileview-events%})
 * [Reordering Tiles]({%slug radtileview-features-reordering-tiles%})