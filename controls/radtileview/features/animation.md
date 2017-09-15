---
title: Animation
page_title: Animation
description: Animation
slug: radtileview-animation
tags: animation
published: True
position: 4
---

# Animation

This article describes how you can control the __RadTileView__ animations. By default the animations are enabled. This can be changed using the __IsItemsAnimationEnabled__ property.

#### __[XAML] Example 1: Disabling the animations__
{{region radtileview-animation-0}}
	<telerik:RadTileView IsItemsAnimationEnabled="False">
		<telerik:RadTileViewItem Header="Item 1" />
		<telerik:RadTileViewItem Header="Item 2" />
		<telerik:RadTileViewItem Header="Item 3" />
		<telerik:RadTileViewItem Header="Item 4" />
		<telerik:RadTileViewItem Header="Item 5" />
		<telerik:RadTileViewItem Header="Item 6" />
	</telerik:RadTileView>	
{{endregion}}

There are two different animations available with the control.

## Reordeing animation

It occurs when items are swapped using drag. Or when the __Position__ property's value of a __RadTileViewItem__ is changed. The __RadTileView__ control allows you to change the animation duration and easing function. To do that use the __ReorderingDuration__ and __ReorderingEasing__ properties. 

#### __[XAML] Example 2: Setting animation duration__
{{region radtileview-animation-1}}
	<telerik:RadTileView ReorderingDuration="0:0:2">
{{endregion}}

#### __[C#] Example 3: Setting animation duration in code__
{{region radtileview-animation-2}}
	tileview.ReorderingDuration = TimeSpan.FromSeconds(2);
{{endregion}}

The __ReorderingEasing__ property is of type __IEasingFunction__ which means that you can use any of the easing functions provided by the {{ site.framework_name }} framework or create a custom one.

#### __[XAML] Example 4: Setting animation easing__
{{region radtileview-animation-3}}
	<telerik:RadTileView>
		<telerik:RadTileView.ReorderingEasing>
			<BackEase />
		</telerik:RadTileView.ReorderingEasing>            
	</telerik:RadTileView>
{{endregion}}
	
## Resizing animation

It occurs when the items change their __TileState__ (minimized, maximized, restored). The __RadTileView__ control allows you to change the animation duration and easing function. To do that use the __ResizingDuration__ and __ResizingEasing__ properties. The properties are set in the same manner as the reordering animation properties (see Examples 2 to 4).

## See Also
 * [Getting Started]({%slug radtileview-getting-started%})
 * [Events]({%slug radtileview-events%})
 * [Reordering Tiles]({%slug radtileview-features-reordering-tiles%})
