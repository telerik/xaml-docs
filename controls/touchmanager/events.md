---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the TouchManager {{ site.framework_name }} control.
slug: touchmanager-events
tags: events,touch,manager,touchmanager,touchenter,touchdown,touchleave,touchup,touchmove
published: True
position: 3
---

# Events

__TouchManager__ uses an event-based model to build the touch interface between the device and the application. The TouchManager's events can be separated logically in two categories by their type: basic touch events and gesture events.

## Basic touch events

These events handle the basic interactions.

* __TouchEnter__: Occurs when a touch input appears over the element. The event handler arguments are of type __TouchEventArgs__.

* __TouchDown__: Occurs when a touch input appears over the element. The event handler arguments are of type __TouchEventArgs__.

* __TouchMove__: Occurs when a touch input is moved along the bounds of the element. The event handler arguments are of type __TouchEventArgs__.

* __TouchUp__: Occurs when a touch input leaves the element. The event handler arguments are of type __TouchEventArgs__.

* __TouchLeave__: Occurs when a touch input leaves the element. The event handler arguments are of type __TouchEventArgs__.

> The basic events are listed in the order of their invoking. 

* __LostTouchCapture__: Occurs when an element loses the touch capture. The event handler arguments are of type __TouchEventArgs__.

## Gesture events

These events handle more complex gesture interactions that are combinations of basic touch events.

> All predefined gestures are an interpretation of the five basic events. A gesture recognizer works only with the touch events it receives. When a gesture event is raised, say Swipe, it is during the TouchMove event of the element. This makes the Swipe to look as if it has a Bubbling routed strategy, but actually it has a Direct strategy. When the Swipe event is marked as handled, this automatically marks the TouchMove event as handled, preventing a parent element from receving the touch move event, hence preventing from Swipe being raised. In order to avoid gesture inconsistency accross different elements in nested scenarios, all Swipe related events need to be marked as handled - SwipeStarted, Swipe, SwipeFinished. Same rule applies to Drag and Pinch

* __Tap__: Occurs when a tap gesture is executed on the element. The event handler arguments are of type __TapEventArgs__.

* __TapAndHold__: Occurs when the user taps the element and hold their finger down. The event handler arguments are of type __TouchEventArgs__.

* __TapHoldAndRelease__: Occurs when the user taps and holds the element for a moment and then touch up. The event handler arguments are of type __TouchEventArgs__.

* __SwipeStarted__: Occurs when a swipe operation is started. The event handler arguments are of type __TouchEventArgs__.

* __Swipe__: Occurs after the SwipeStarted event, while the swipe operation is running. The event handler arguments are of type __SwipeEventArgs__.

* __SwipeFinished__: Occurs when the swipe operation finishes. The event handler arguments are of type __TouchEventArgs__.

* __SwipeInertiaStarted__: Occurs when the touch input leaves the screen while the swipe operation is running. This event is fired after SwipeFinished. The event handler arguments are of type __RadRoutedEventArgs__.

* __SwipeInertia__: Occurs after the SwipeInertiaStarted event while the swipe inertial operation is running. The event handler arguments are of type __SwipeInertiaEventArgs__.

	> The SwipeInertia event won't be fired unless SwipeInertiaStarted is handled.
	
* __SwipeInertiaFinished__: Occurs when the swipe inertia finishes. The event handler arguments are of type __RadRoutedEventArgs__.

* __PinchStarted__: Occurs when a pinch operation starts. The event handler arguments are of type __PinchEventArgs__.

* __Pinch__: Occurs while pinching is in action. The event handler arguments are of type __PinchEventArgs__.

* __PinchFinished__: Occurs when the pinch operation ends. The event handler arguments are of type __PinchEventArgs__.

* __DragStarted__: Occurs when a drag operation is started. The event handler arguments are of type __TouchEventArgs__.

* __Drag__: Occurs when the drag operation is running. The event handler arguments are of type __TouchEventArgs__.

* __DragFinished__: Occurs when the drag operation is finished. The event handler arguments are of type __TouchEventArgs__.

## Subscribing for TouchManager events

The TouchManager expose public methods for all events that could be subscribed to. The following code snippet illustrates how to subscribe to the TouchManager events:

__Example 1: Subscribing to TouchManager events__  
```C#
	TouchManager.AddTapEventHandler(uiElement, new TapEventHandler(OnUIElementTap));
	TouchManager.AddTouchDownEventHandler(uiElement, new TouchEventHandler(OnUIElementTouchDown));
	//-------------
	private void OnUIElementTap(object sender, TapEventArgs args)
	{
	}
	
	private void OnUIElementTouchDown(object sender, TouchEventArgs args)
	{		
	}
```
```VB.NET
	TouchManager.AddTapEventHandler(uiElement, New TapEventHandler(AddressOf OnUIElementTap))
	TouchManager.AddTouchDownEventHandler(uiElement, New TouchEventHandler(AddressOf OnUIElementTouchDown))	
	'--------------'
	Private Sub OnUIElementTap(sender As Object, args As TapEventArgs)
	End Sub

	Private Sub OnUIElementTouchDown(sender As Object, args As TouchEventArgs)
	End Sub
```

## See Also
* [Overview]({%slug touchmanager-overview%})
* [Getting Started]({%slug touchmanager-getting-started%})
* [Features]({%slug touchmanager-features%})
