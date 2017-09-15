---
title: Features
page_title: Features | TouchManager
description: Features
slug: touchmanager-features
tags: touch,manager,touchmanager,features
published: True
position: 1
---

# Features

Here you can find common information about the properties and methods of TouchManager.

* [Properties](#properties)
* [Methods](#methods)
* [Touch Indicator](#touch-indicator)

## Properties

TouchManager exposes the following public properties:

* __IsTouchEnabled__: A static property of type __bool__ that indicates whether the TouchManager will respond to any touch events. It can be used to enable or disable the touch interactions with the elements that use the TouchManager.

* __TouchMode__: An attached property of type __Telerik.Windows.Input.Touch.TouchMode__ enumeration that gets or sets the touch mode of the control. You can read more about the property in the [Touch Modes]({%slug touchmanager-overview%}) help article.

* __ScrollViewerSwipeMode__: An attached property of type __Telerik.Windows.Input.Touch.ScrollViewerSwipeMode__ enumeration that gets or sets the mode that defines the additional swipe logic for a ScrollViewer or an element in a ScrollViewer. The enumeration contains the following modes.
	* __None__ (default): The element does not have additional logic for swiping.
	* __Self__: If an unhandled swipe gesture occurs, the ScrollViewer will get panned.
		> The element on which this value is set should be a ScrollViewer. Otherwise, an exception will be thrown.
	* __Parent__: If an unhandled swipe gesture occurs for this element, the first ScrollViewer parent will get panned.
	
	#### __[XAML] Example 1: Setting ScrollViewerSwipeMode in XAML__
	{{region touchmanager-features-0}}
		<ListBox x:Name="element" telerik:TouchManager.ScrollViewerSwipeMode="Parent">
	{{endregion}}
		
	#### __[C#] Example 2: Setting ScrollViewerSwipeMode in code__
	{{region touchmanager-features-1}}
		TouchManager.SetScrollViewerSwipeMode(this.element, ScrollViewerSwipeMode.Parent);
	{{endregion}}
		
	#### __[VB.NET] Example 2: Setting ScrollViewerSwipeMode in code__
	{{region touchmanager-features-2}}
		TouchManager.SetScrollViewerSwipeMode(Me.element, ScrollViewerSwipeMode.Parent);
	{{endregion}}

* __ShouldSuspendMousePromotion__: An attached property of type __bool__ that indicates whether mouse events should be suspended during touch input.
		
* __DragStartDistance__: A static property of type __double__ that gets or sets the minimum distance a touch point has to move before the action is considered a drag. The distance is measured in pixels.

* __PinchStartDistance__: A static property of type __double__ that gets or sets the minimum distance a touch point has to move before the action is considered a pinch. The distance is measured in pixels.

* __SwipeStartDistance__: A static property of type __double__ that gets or sets the minimum distance a touch point has to move before the action is considered a swipe. The distance is measured in pixels.

* __SwipeInertiaDuration__: A static property of type __int__ that gets or sets the duration of the swipe inertia. The duration is measured in milliseconds.

* __TapTime__: A static property of type __int__ that gets or sets the time that can elapse between a touch down and a touch up for the action to be considered a tap. The time is measured in milliseconds.

* __TapVicinity__: A static property of type __double__ that gets or sets the maximum distance a touch point can move for the action to be considered a tab. The distance is measured in pixels.

* __MultiTapTime__: A static property of type __int__ that gets or sets the time that can elapse between two successive tap actions for the TouchManager to consider them as multiple taps. The time is measured in milliseconds.

* __MultiTapVicinity__: A static property of type __int__ that gets or sets the distance between two successive tap actions for the TouchManager to consider them as multiple taps. The distance is measured in pixels.

* __DragStartTrigger__: An attached property of type __Telerik.Windows.Input.Touch.TouchDragStartTrigger__ enumeration that gets or sets the touch action that triggers the drag operation. The enumeration contains the following triggers.
	* __TapHoldAndMove__: The drag operation will be triggered during a TouchMove event after a TapAndHold.
	* __TouchMove__: The drag operation will be triggered during a TouchMove, regardless of whether a TapAndHold event has occured or not.
	* __TapAndHold__ (default): The drag operation will be triggered during a TapAndHold event.

	#### __[XAML] Example 3: Setting DragStartTrigger in XAML__
	{{region touchmanager-features-3}}
		<Border x:Name="element" telerik:TouchManager.DragStartTrigger="TapHoldAndMove">
	{{endregion}}
		
	#### __[C#] Example 4: Setting DragStartTrigger in code__
	{{region touchmanager-features-4}}
		TouchManager.SetDragStartTrigger(this.element, TouchDragStartTrigger.TapHoldAndMove);
	{{endregion}}
		
	#### __[VB.NET] Example 4: Setting DragStartTrigger in code__
	{{region touchmanager-features-5}}
		TouchManager.SetDragStartTrigger(Me.element, TouchDragStartTrigger.TapHoldAndMove);
	{{endregion}}

>important The __IsTouchHitTestVisibility__ property is __obsolete__ and __replaced__ by the __TouchMode__ property.

## Methods

TouchManager exposes the following methods:

* __CeaseGestures__: This method ceases the execution of any active gestures for elements within the root UIElement.

* __CaptureTouch__: This method attempts to capture the touch device.

* __ReleaseTouchCapture__: This method releases the captured touch device.

* __GetCaptured__: This method gets the UIElement that has captured the touch device.

## Touch Indicator

TouchManager visualizes an animated touch indicator when there is a tap and hold gesture performed on the screen. 
![](images/touchmanager_features_01.png)

> The indicator supports theming and it will have a different appearance in the different themes.

## See Also
* [Overview]({%slug touchmanager-overview%})
* [GettingStarted]({%slug touchmanager-getting-started%})
* [Events]({%slug touchmanager-events%})
* [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})
