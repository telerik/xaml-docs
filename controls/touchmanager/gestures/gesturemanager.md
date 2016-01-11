---
title: GestureManager
page_title:  GestureManager | Gestures | TouchManager
description: GestureManager
slug: touchmanager-gesturemanager
tags: gestures,touch,manager,touchmanager,gesturemanager
published: True
position: 0
---

# GestureManager

__GestureManager__ is a utility class that exposes methods that allow management of the __TouchManager__'s gestures. _GestureManager__ stores all available gestures that can be performed via TouchManager and provides a mechanism to register new gestures and ensure their proper exectuion. 

__GestureManager__ exposes the following methods:

* __ActivateGesture__: A method that activates a particular gesture for the UIElement. If there is an active gesture, the manager will deactivate it. The method returns a deactivation token object that can be used to deactivate the gesture manually.

* __CanActivateGesture__: A method that indicates whether the candidate gesture can be activated. The gesture cannot be activated if there is already an active gesture and the transition is not allowed.

* __RegisterGestureRecognizerFactory__: A method that registers a gesture recognizer factory.

* __DeregisterGestureRecognizerFactory__: A method that deregisters a gesture recognizer factory.

> You can read more about the gesture recognizer factory in the [Custom Gestures]({%slug touchmanager-custom-gestures-overview%}) help article.

* __GetActiveGesture__: A method that gets the name of the active gesture for the UIElement.

* __GetOrCreateGestureRecognizer__: A method that gets the gesture recognizer for the UIElement.

* __GetRegisteredGestureRecognizerFactories__: A method that gets the registered gesture recognizer factories.

* __GetRegisteredGestureTransitions__: A method that gets the allowed gesture transition for this gesture.

* __IsGestureTransitionAllowed__: A method that indicates if a transition is allowed.

> The [Creating Custom Gesture]({%slug touchmanager-creating-custom-gesture%}) help article demonstrates how to use GestureManager to register a new gesture factory and activate the gesture.

## See Also
* [Overview]({%slug touchmanager-overview%})
* [Getting Started]({%slug touchmanager-getting-started%})
* [Events]({%slug touchmanager-events%})
* [Custom Gestures]({%slug touchmanager-custom-gestures-overview%})
* [Creating Custom Gesture]({%slug touchmanager-creating-custom-gesture%})
