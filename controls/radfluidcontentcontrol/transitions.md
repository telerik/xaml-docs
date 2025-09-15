---
title: Transitions
page_title: Transitions
description: The RadFluidContentControl supports transition animations that are triggered when you change between the contents.
slug: fluidcontentcontrol-transitions
tags: transitions,animation,effect
published: True
position: 4
---

# Transitions

The RadFluidContentControl supports transition animations that are triggered when you change between the contents - small, normal and large. The default transition is a fade effect.

The transition effect can be replace via the __Transition__ property of the control. It expects an object of type __TransitionProvider__, which is the abstract class inherited by all transition implementations. 

>tip The transition objecs are part of the RadTransitionControl. You can find a list of all the supported effects in the corresponding [Transitions]({%slug radtransition-features-transitions%}) article.

The transition duration is controlled via the __TransitionDuration__ property.

__Example 1: Setting transition in XAML__
```XAML
	<telerik:RadFluidContentControl x:Name="radFluidContentControl" 
								    TransitionDuration="0:0:0.500"> 
		<telerik:RadFluidContentControl.Transition>
			<telerik:MotionBlurredZoomTransition />
		</telerik:RadFluidContentControl.Transition>
	</telerik:RadFluidContentControl>
```

__Example 2: Setting transition in code__
```C#
	this.radFluidContentControl.Transition = new MotionBlurredZoomTransition();
	this.radFluidContentControl.TransitionDuration = TimeSpan.FromMilliseconds(500);
```
```VB.NET
	Me.radFluidContentControl.Transition = New MotionBlurredZoomTransition()
    Me.radFluidContentControl.TransitionDuration = TimeSpan.FromMilliseconds(500)
```

## See Also
* [Getting Started]({%slug fluidcontentcontrol-getting-started%})
* [Data Binding]({%slug fluidcontentcontrol-data-binding%})
* [Events]({%slug fluidcontentcontrol-events%})