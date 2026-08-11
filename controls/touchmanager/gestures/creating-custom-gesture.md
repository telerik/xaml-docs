---
title: Creating a Custom Gesture
page_title: Creating a Custom Gesture
description: Custom Gesture.
slug: touchmanager-creating-custom-gesture
tags: creating,gestures,gesture,custom,touch,manager,touchmanager
published: True
position: 2
---

# Creating a custom gesture

This article demonstrates how to implement a custom gesture and register it in TouchManager. The following example will guide you through the creation of a __two fingers tap__ gesture.

* [Implementing the gesture recognizer](#implementing-the-gesture-recognizer)
* [Implementing the gesture recognizer factory](#implementing-the-gesture-recognizer-factory)
* [Using the gesture](#using-the-gesture)

## Implementing the gesture recognizer 

To begin creating the gesture recognizer, you must first define a class that derives from GestureRecognizerBase and override its abstract methods. 	
	
__Example 1: Defining the gesture recognizer__	
<snippet id='touchmanager-gestures-creating-custom-gesture-block_1-cs' />
<snippet id='touchmanager-gestures-creating-custom-gesture-block_2-vb' />
	
For this example, we will use only three of the gesture recognizer's methods: OnTouchDown, OnTouchUp and OnTouchLeave.

The example will use several helper fields:

* __AllowedInterval__: A readonly field of type TimeSpan that contains the allowed timeframe in which the gesture can be executed. If the time between the touch down and touch up is more than the allowed timespan, the gesture won't be executed.
* __MaxTouchCount__: A readonly field of type Int32 that defines the count of the required touches for executing the gesture.
* __originTouchTime__: A field of type DateTime that holds the time when the first finger was down.
* __isTwoFingerGesture__: A field of type Boolean that tells if two fingers are on the screen and if the gesture can be executed.		
* __touchIds__: A field of type List<int> that holds the touch ids. The list is used to store the ids of the touches on the screen.		
* __handlers__: A field of type List<WeakReference> that holds references to the event handlers attached to the recognizer.

You can find the code definitions of the helper fields in the following code snippet:

__Example 2: Defining the fields of the recognizer__  
<snippet id='touchmanager-gestures-creating-custom-gesture-block_3-cs' />
<snippet id='touchmanager-gestures-creating-custom-gesture-block_4-vb' />

When we add the properties we can use them in the overrides of the gesture recognizer's methods. 

* __OnTouchDown__: When this method is called, we can store the touch id in the *touchIds* collection. If this is the first touch, we are setting the *originTouchTime* to the current time. If this is the second touch, we set the *isTwoFingerGesture* property to __true__.
	
	__Example 3: Implementing logic in the OnTouchDown method__
	<snippet id='touchmanager-gestures-creating-custom-gesture-block_5-cs' />
	<snippet id='touchmanager-gestures-creating-custom-gesture-block_6-vb' />

* __OnTouchLeave__: When this method is called, we can remove the touch id of the leaving touch from the *touchIds* collection.
	
	__Example 4: Implementing logic in the OnTouchLeave method__
	<snippet id='touchmanager-gestures-creating-custom-gesture-block_7-cs' />
	<snippet id='touchmanager-gestures-creating-custom-gesture-block_8-vb' />
		
* __OnTouchUp__: When this method is called, we can remove the touch id of the leaving touch from the collection. Here we can also check if the gesture can be executed. 
	
	__Example 5: Implementing logic in the OnTouchUp method__
	<snippet id='touchmanager-gestures-creating-custom-gesture-block_9-cs' />
	<snippet id='touchmanager-gestures-creating-custom-gesture-block_10-vb' />

	Note that we are using the __CanActivateGesture()__ and __ActivateGesture()__ methods of the __GestureManager__ class. This way we ensure that the gesture will be activated only if there is no collision between this gesture and the one that is currently active (if any). 
	
	> The GestureExtensions is a class that holds a custom routed event and fires it when the gesture is executed. We will discuss its implementation in the [Using the gesture](#using-the-gesture) section of this article.		

Example 6 is the main logic of the recognizer. In this example you'll see how to implement logic for storing the event handlers for the gesture. We can do this through a couple of public methods that accept event handlers as arguments and add/remove them in the *handlers* collection defined earlier.

__Example 6: Implementing logic for associating event handlers with the recognizer__
<snippet id='touchmanager-gestures-creating-custom-gesture-block_11-cs' />
<snippet id='touchmanager-gestures-creating-custom-gesture-block_12-vb' />
	
## Implementing the gesture recognizer factory

To add the gesture to a specific UIElement we need to create a recognizer factory that creates our gesture. The factory is a class that implements the __IGestureRecognizerFactory__ interface.

__Example 7: Defining the gesture recognizer factory__
<snippet id='touchmanager-gestures-creating-custom-gesture-block_13-cs' />
<snippet id='touchmanager-gestures-creating-custom-gesture-block_14-vb' />

## Using the gesture

Lets start with defining the UIElement on which the gesture will be performed.

__Example 8: Defining the UI of the example__
<snippet id='touchmanager-gestures-creating-custom-gesture-block_15-xaml' />

To use the gesture we will need to register the gesture recognizer factory and create a recogonizer for the UIElement that should listen for it. Then we can add an event handler for the UIElement.

__Example 9: Creating a new instance of the recognizer and associating it with a UIElement__
<snippet id='touchmanager-gestures-creating-custom-gesture-block_16-cs' />
<snippet id='touchmanager-gestures-creating-custom-gesture-block_17-vb' />

In example 10 we will wrap the TwoFingerTapEvent and the logic for adding handlers in a helper class called GestureExtensions.

__Example 10: Creating a helper class that raises an event when the gesture is performed__
<snippet id='touchmanager-gestures-creating-custom-gesture-block_18-cs' />
<snippet id='touchmanager-gestures-creating-custom-gesture-block_19-vb' />
	
Here is an example for using the GestureExtensions class and adding logic that is executed when the two-finger tap gesture is activated:

__Example 11: Associating the gesture recognizer with a UIElement__
<snippet id='touchmanager-gestures-creating-custom-gesture-block_20-cs' />
<snippet id='touchmanager-gestures-creating-custom-gesture-block_21-vb' />

The following picture demonstrates the end result - changing the opacity when a two-fingers tap is performed on the Rectangle element.

![Creating Custom Gestures 01](images/touchmanager_creating_custom_gesture_01.png)
	
## See Also
* [Overivew]({%slug touchmanager-overview%})
* [Getting Started]({%slug touchmanager-getting-started%})
* [Events]({%slug touchmanager-events%})
* [Custom Gestures]({%slug touchmanager-custom-gestures-overview%})