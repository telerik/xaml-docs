---
title: Events
page_title: Events
description: Events
slug: touchmanager-events
tags: events,touch,manager,touchmanager
published: True
position: 3
---

# Events

__TouchManager__ uses an event based model to build the touch interface between the device and the application. The manager events could be separated logically in two categories by their type.

## Basic touch events

This category includes the events that handles the basic interactions.

* __TouchEnter__: Occurs when a touch input appears over the element. The event handler arguments are of type __TouchEventArgs__.

* __TouchDown__: Occurs when a touch input appears over the element. The event handler arguments are of type __TouchEventArgs__.

* __TouchMove__: Occurs when a touch input is moved along the bounds of the element. The event handler arguments are of type __TouchEventArgs__.

* __TouchUp__: Occurs when a touch input leaves the element. The event handler arguments are of type __TouchEventArgs__.

* __TouchLeave__: Occurs when a touch input leaves the element. The event handler arguments are of type __TouchEventArgs__.

> The basic events are listed in the order of their invoking. 

* __LostTouchCapture__: Occurs when an element loses the touch capture. The event handler arguments are of type __TouchEventArgs__.

## Gesture events

This category includes the events that handles more complex gesture interactions which are combinations of basic touch events.

* __Tap__: Occurs when a tap gesture is executed on the element. The event handler arguments are of type __TapEventArgs__.

* __TapAndHold__: Occurs when the user tap the element and hold its finger down. The event handler arguments are of type __TouchEventArgs__.

* __TapHoldAndRelease__: Occurs when the user tap and hold the element for a moment and then touch up. The event handler arguments are of type __TouchEventArgs__.

* __SwipeStarted__: Occurs when a swipe operation is started. The event handler arguments are of type __TouchEventArgs__.

* __Swipe__: Occurs after the SwipeStarted event, while the swipe operation is running. The event handler arguments are of type __SwipeEventArgs__.

* __SwipeFinished__: Occurs when the swipe operation finishes. The event handler arguments are of type __TouchEventArgs__.

* __SwipeInertiaStarted__: Occurs when the touch input leaves the screen while the swipe operation is running. This event is fired after SwipeFinished. The event handler arguments are of type __RadRoutedEventArgs__.

* __SwipeInertia__: Occurs after the SwipeInertiaStarted event while the swipe inertial operation is running. The event handler arguments are of type __SwipeInertiaEventArgs__.

	> The SwipeInertial event won't be fired unless SwipeInertiaStarted is handled.
	
* __SwipeInertiaFinished__: Occurs when the swipe inertia finishes. The event handler arguments are of type __RadRoutedEventArgs__.

* __PinchStarted__: Occurs when a pinch operation starts. The event handler arguments are of type __PinchEventArgs__.

* __Pinch__: Occurs while pinching is in action. The event handler arguments are of type __PinchEventArgs__.

* __PinchFinished__: Occurs when the pinch operation ends. The event handler arguments are of type __PinchEventArgs__.

* __DragStarted__: Occurs when a drag operation is started. The event handler arguments are of type __TouchEventArgs__.

* __Drag__: Occurs when the element the drag operation is running. The event handler arguments are of type __TouchEventArgs__.

* __DragFinished__: Occurs when the drag operation is finished. The event handler arguments are of type __TouchEventArgs__.

## Subscribing for TouchManager events

The manager expose public methods for all events which could be used for subscribing to them. The following code snippet illustrates how to subscribe to the TouchManager events:

#### __[C#] Example 1: Subscribing to TouchManager events__  
	TouchManager.AddTapEventHandler(uiElement, new TapEventHandler(OnUIElementTap));
	TouchManager.AddTouchDownEventHandler(uiElement, new TouchEventHandler(OnUIElementTouchDown));
	//-------------
	private void OnUIElementTap(object sender, TapEventArgs args)
	{
	}
	
	private void OnUIElementTouchDown(object sender, TouchEventArgs args)
	{		
	}
	
#### __[VB.NET] Example 1: Subscribing to TouchManager events__  
	TouchManager.AddTapEventHandler(uiElement, New TapEventHandler(AddressOf OnUIElementTap))
	TouchManager.AddTouchDownEventHandler(uiElement, New TouchEventHandler(AddressOf OnUIElementTouchDown))	
	'--------------'
	Private Sub OnUIElementTap(sender As Object, args As TapEventArgs)
	End Sub

	Private Sub OnUIElementTouchDown(sender As Object, args As TouchEventArgs)
	End Sub
	
## See Also
* [Overview]({%slug touchmanager-overview%})
* [Getting Started]({%slug touchmanager-getting-started%})
* [Features]({%slug touchmanager-features%})