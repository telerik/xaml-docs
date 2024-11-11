---
title: Events Overview
page_title: Events Overview
description: Check our &quot;Events Overview&quot; documentation article for the RadSlider {{ site.framework_name }} control.
slug: radslider-events-overview
tags: events,overview
published: True
position: 3
---

# Events Overview

This topic covers the specific events exposed by the RadSlider control.	  

## Drag Events

* `DragStarted`&mdash;Occurs when a user starts dragging a `Thumb` control with the mouse. The event arguments are of type `RadDragStartedEventArgs`.

* `DragDelta`&mdash;Occurs one or multiple times while a user drags a `Thumb` control with the mouse. The event arguments are of type `RadDragDeltaEventArgs`.

* `DragCompleted`&mdash;Occurs when a user completes a drag operation of a `Thumb` control with the mouse.  The event arguments are of type `RadDragCompletedEventArgs`.

## Selection Events

* `SelectionStartChanged`&mdash;Occurs when the `SelectionStart` property of `RadSlider` is changed. The event arguments are of type `RoutedPropertyChangedEventArgs<double>`.

* `SelectionEndChanged`&mdash;Occurs when the `SelectionEnd` property of `RadSlider` is changed. The event arguments are of type `RoutedPropertyChangedEventArgs<double>`.

* `SelectionChanged`&mdash;Occurs when the `Selection` property of `RadSlider` is changed.  The event arguments are of type `RadRoutedEventArgs`.

## See Also

 * [Getting Started]({%slug radslider-declaration%}) 
 * [Selection Range]({%slug radslider-selection-range%}) 
 * [Keyboard and Mouse support]({%slug radslider-keyboard-mouse-support%})
