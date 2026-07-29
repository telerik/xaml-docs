---
title: Events
page_title: Events
description: This article lists the events that the RadTransitionControl exposes. 
slug: radtransition-events-overview
tags: events, radtransition, triggeringtransion, transitionstatuschanged, istransitionidle
published: True
position: 4
---

# {{ site.framework_name }} TransitionControl Events

The RadTransitionControl raises the following specific events:

* __TriggeringTransion__: This event is fired before a transition is started. The event handler receives two arguments:

    * The __sender__ argument contains the RadTransitionControl. This argument is of type object but can be cast to the RadTransitionControl type.

    * A __TriggeringTransitionEventArgs__ object. It exposes only the __Cancel__ property, which allows you to cancel the transition, as demonstrated in __Example 1__. Note, that even if the transition is cancelled, the Content will still be changed. 

    __Example 1: Canceling the TriggeringTransion event__ 	
    <snippet id='radtransitioncontrol-radtransition-events-overview-block_1-cs' />
	<snippet id='radtransitioncontrol-radtransition-events-overview-block_2-vb' />

* __TransitionStatusChanged__: This event is fired anytime there is a change in the content and the transition animation. The event handler receives two arguments:

    * The __sender__ argument contains the RadTransitionControl. This argument is of type object, but can be cast to the RadTransitionControl type.

    * A __TransitionStatusChangedEventArgs__ object. It exposes a __Status__ property which is of type [TransitionStatus](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.transitioncontrol.transitionstatus). 

    __Example 2: Handling the TransitionStatusChanged event__ 	
    <snippet id='radtransitioncontrol-radtransition-events-overview-block_3-cs' />
	<snippet id='radtransitioncontrol-radtransition-events-overview-block_4-vb' />

## When Does a Transition Start?

To check if new content is available or whether a transition has started, you should take care to handle __both__ cases: __Started__ and __Interrupted__. They both indicate that a new transition has started/new content is available, with the difference being whether the RadTransitionControl has been playing another transition or not.    	

## Is There a Transition Currently Playing?

If you want to do some UI related logic, like disabling buttons, while a transition is in progress, you could use the __Started__ and __Interrupted__ states to set the buttons to disabled and the __Completed__ state to reset them back to enabled.    	

You can also use the __IsTransitionIdle__ property. It allows you to bind the __IsEnabled__ of a UIElement to the __IsTransitionIdle__ property, as demonstrated in __Example 3__.

__Example 3: Using the IsTransitionIdle property__ 	
<snippet id='radtransitioncontrol-radtransition-events-overview-block_5-xaml' />