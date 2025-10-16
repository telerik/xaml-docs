---
title: Custom Gestures
page_title:  Custom Gestures - Gestures - TouchManager
description: Check our &quot;Custom Gestures&quot; documentation article for the TouchManager {{ site.framework_name }} control.
slug: touchmanager-custom-gestures-overview
tags: gestures,custom,touch,manager,touchmanager,overview
published: True
position: 1
---

# Custom Gestures

With __TouchManager__ you can create and use custom gestures using the basic events as TouchDown, TouchUp, TouchMove, etc. To implement a custom gesture you will need to create a gesture recognizer that defines the touch behavior and a gesture factory.

## Gesture recognizer

The gesture recognizer should be a class that derives from the abstract __GestureRecognizerBase__ class and handles the basic touch events translating them to specific gesture-related events.

__GestureRecognizerBase__ exposes the __Element__ property that holds the element the recognizer is assigned to and the __HasGestureHandlers__ property that indicates if there are any attached handlers to the specific gesture.

The __GestureRecognizerBase__ class exposes methods for the basic event handlers of __TouchManager__ that are used for implementing the custom gesture.
* __OnTouchEnter__: This method will be called when the TouchEnter event for the element is fired.
* __OnTouchDown__: This method will be called when the TouchDown event for the element is fired.
* __OnTouchMove__: This method will be called when a TouchMove event for the element is fired.
* __OnTouchUp__: This method will be called when a TouchUp event for the element is fired.
* __OnTouchLeave__: This method will be called when a TouchLeave event for the element is fired.

__Example 1: Sample gesture recognizer__
```C#
	public class MyGestureRecognizer : GestureRecognizerBase
    {
		public override void OnTouchEnter(GestureRecognizerEventArgs args)
        {
        }
		
        public override void OnTouchDown(GestureRecognizerEventArgs args)
        {   
        }       

		public override void OnTouchMove(GestureRecognizerEventArgs args)
        {
        }
		
		public override void OnTouchUp(GestureRecognizerEventArgs args)
        {
        }
		
        public override void OnTouchLeave(GestureRecognizerEventArgs args)
        {
        }
    }
```
```VB.NET
	Public Class MyGestureRecognizer
		Inherits GestureRecognizerBase
		Public Overrides Sub OnTouchEnter(args As GestureRecognizerEventArgs)
		End Sub
		
		Public Overrides Sub OnTouchDown(args As GestureRecognizerEventArgs)
		End Sub	

		Public Overrides Sub OnTouchMove(args As GestureRecognizerEventArgs)
		End Sub

		Public Overrides Sub OnTouchUp(args As GestureRecognizerEventArgs)
		End Sub
		
		Public Overrides Sub OnTouchLeave(args As GestureRecognizerEventArgs)
		End Sub		
	End Class
```

## Gesture recognizer factory

The recognizer factory creates recognizers for the UI elements. In order to register a gesture recognizer you will need to implement a factory that creates the recognizer and defines its priority. The custom recognizer factory should implement the __IGestureRecognizerFactory__ interface which exposes the following API:
* __Priority__: A property of type __int__ that defines the priority of the gesture.
* __CreateGestureRecognizer__: A method that creates a new instance of a recognizer dedicated to the UI element.
* __RegisterGestureTransitions__: A method that can be used to register the allowed gesture transitions.

__Example 2: Sample gesture recognizer factory__
```C#
	public class MyGestureRecognizerFactory : IGestureRecognizerFactory
    {
        public GestureRecognizerBase CreateGestureRecognizer(System.Windows.UIElement element)
        {
            return new MyGestureRecognizer(element);
        }

        public int Priority
        {
            get
            {
                return 0;
            }
        }

        public void RegisterGestureTransitions()
        {
        }
    }
```
```VB.NET
	Public Class MyGestureRecognizerFactory
		Implements IGestureRecognizerFactory
		Public Function CreateGestureRecognizer(element As System.Windows.UIElement) As GestureRecognizerBase
			Return New MyGestureRecognizer(element)
		End Function

		Public ReadOnly Property Priority() As Integer
			Get
				Return 0
			End Get
		End Property

		Public Sub RegisterGestureTransitions()
		End Sub
	End Class	
```
	
> You can see how to implement a gesture in the [Creating Custom Gesture]() help article.

## See Also
* [Getting Started]({%slug touchmanager-getting-started%})
* [Events]({%slug touchmanager-events%})
* [Creating Custom Gesture]({%slug touchmanager-creating-custom-gesture%})
