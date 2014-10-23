---
title: Events
page_title: Events
description: Events
slug: radtransition-events-overview
tags: events
published: True
position: 4
---

# Events

This article will cover the events of __RadTransitionControl__.

## TransitionStatusChanged event

RadTransitionControl exposes __TransitionStatusChanged__ event which is fired anytime there is a change in the content and the transition animation. The __TransitionStatusChangedEventArgs__ exposes a Status property which is of enum __TransitionStatus__. The property value could be one of the Started, Interrupted or Completed members.

__TransitionStatus__:

* __Started__ indicates that the transition has been idle and new transition is triggered.

* __Interrupted__ indicates new transition start before the old one has completed.

* __Completed__ means the transition completes and the RadTransitionControl is now idle.

## When Does a Transition Start?

To check if new content is available and has started a transition you should take care to handle __both__ cases of __Started__ and __Interrupted__. They both indicate a new transition has started the difference is whether the RadTransitionControl has been playing other transition or not.    	

## Is There a Transition Currently Playing?

If you want to do some UI related logic like disabling buttons while a transition is in progress you could use the __Started__ and __Interrupted__ to set the buttons to disabled and __Completed__ to reset them back to enabled.    	

For this purpose also a read-only dependency property __IsTransitionIdle__ is available so you could bind IsEnabled of the buttons to __IsTransitionIdle__.
