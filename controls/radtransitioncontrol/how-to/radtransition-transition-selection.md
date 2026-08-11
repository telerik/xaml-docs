---
title: Transition Selection
page_title: Transition Selection
description: Check our &quot;Transition Selection&quot; documentation article for the RadTransitionControl {{ site.framework_name }} control.
slug: radtransition-how-to-transition-selection
tags: transition,selection
published: True
position: 4
---

# Transition Selection

We had many requests on tips how to change the transitions based on some application logic. Such logic is for example:

* Navigating back and forth between UserControls that follow some sequence – slide left or right

* Implement History – slide left or right

* Drill down – zoom data in or out

The __Transition__ property of the RadTransitionControl is of type __TransitionProvider__ so it works pretty much as a DataTemplate that can create object when asked. Setting properties on it will not change the instances that have been generated. It is not a DependencyObject so its properties are not bindable. In other words you can’t bind the Direction property of the __SlideAndZoomTransition__.    

One of the possible solutions to set the __Transition__ property of the __RadTransitionControl__ to new __TransitionProvider__ such as __SlideAndZoomTransition__ with __Direction__ set to __Left__ or __Right__ based on some custom logic.    

* This could happen in code behind.

* In MVVM application you could bind the Transition to property of your ViewModel and use a IValueConverter implementation that will convert to the right TransitionProvider.

* You could create a custom TransitionProvider implementation that would use the parameters passed to an override of CreateTransition to generate a Transition.

All approaches have pros and cons. For small applications the first one is recommended as you could easily drop a few lines of code on the back of your UserControl and alter the RadTransitionControl.	

In large projects it is a common practice to separate code from presentation so you may have the RadTransitionControl placed within a ControlTemplate in a ResourceDictionary where it would be hard to add codebehind. In such cases the second and the third approach are preferred. Which one to choose? It depends on that whether you are willing to keep navigation state in your ViewModel and if the data items or controls passed in the Content property of the RadTransitionControl are enough to select the proper transition.	

## Switch Transition in Code Behind

For example if you have a __ListBox__ and a __RadTransitionControl__ with its __Content__ bound to the __ListBox__’ __SelectedItem__ you could easily handle the __SelectionChanged__ event of the __ListBox__ and switch the Transition property of the __RadTransitionControl__.

## Switch through a Binding and a Converter

You may not wish to add navigation and state data to your __ViewModel__ and desire to keep it focused on application logic and data. Yet in complex application such data gets in your application through implementation of history tracking, deep link functionality etc. In such case you could use that data In RadTransitionControl.

For example you may have a list of items and keep the currently selected item as well as history of the previously selected items in your __ViewModel__. In such case you could easily add property that indicates whether the last navigation was __Backward__ or __Forward__. If you have for example a bool property __IsNavigatingForward__ you could bind the __Transition__ of the RadTransitionControl to that boolean property and convert it to a __Transition__ via a __IValueConverter__.

Such converter would look like:



<snippet id='radtransitioncontrol-how-to-radtransition-transition-selection-block_1-cs' />

And could be used in XAML:



<snippet id='radtransitioncontrol-how-to-radtransition-transition-selection-block_2-xaml' />

## Switch in a Custom TransitionProvider

This could be a very MVVM friendly approach if the parameters provided in the __TransitionContext__ instance in the __CreateTransition__ method of the __TransitionProvider__ are enough. If you are binding the __Content__ property of __RadTransitionControl__ to objects from your __ViewModel__ and you could compare these objects, then you could implement a very decent solution to transition switching.	

For example if you drill down you could check if the new Content contains larger or smaller data range and respectively pick a zoom in or zoom out animation.	

If you navigate between indexed items you could check the indices of the items and slide left or right.	

If you need some additional data for the comparison this approach won’t work and you will have to stick to the CodeBehind transition selection.	

In general implementing a custom TransitionProvider would use quite a few lines of code:	



<snippet id='radtransitioncontrol-how-to-radtransition-transition-selection-block_3-cs' />

And in XAML you could use it like:



<snippet id='radtransitioncontrol-how-to-radtransition-transition-selection-block_4-xaml' />

If the Content is non-UI element you could define simple properties that can be compared in the if-statements.      	

If the Content is UI you could create a class that extends UserControl or Control and add properties there. Also an AttachedProperty could be used so you could attach data for comparison on Controls without having to extend them.      	