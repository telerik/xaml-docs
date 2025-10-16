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
    ```C#
        private void RadTransitionControl_TriggeringTransition(object sender, TriggeringTransitionEventArgs e)
        {
            // you can specify a condition for cancelling here
            e.Cancel = true;
        }
    ```
	```VB.NET
        Private Sub RadTransitionControl_TriggeringTransition(ByVal sender As Object, ByVal e As TriggeringTransitionEventArgs)
			' you can specify a condition for cancelling here
			e.Cancel = True
        End Sub
    ```

* __TransitionStatusChanged__: This event is fired anytime there is a change in the content and the transition animation. The event handler receives two arguments:

    * The __sender__ argument contains the RadTransitionControl. This argument is of type object, but can be cast to the RadTransitionControl type.

    * A __TransitionStatusChangedEventArgs__ object. It exposes a __Status__ property which is of type [TransitionStatus](https://docs.telerik.com/devtools/wpf/api/telerik.windows.controls.transitioncontrol.transitionstatus). 

    __Example 2: Handling the TransitionStatusChanged event__ 	
    ```C#
        private void RadTransitionControl_TransitionStatusChanged(object sender, TransitionStatusChangedEventArgs e)
        {
            switch (e.Status)
            {
                case TransitionStatus.Started:
                    // The transition has been idle and a new transition is triggered.
                    break;
                case TransitionStatus.Interrupted:
                    // A new transition has started before the old one has completed.
                    break;
                case TransitionStatus.Completed:
                    // The transition has completed and the RadTransitionControl is now idle.
                    break;
                default:
                    break;
            }
        }
    ```
	```VB.NET
        Private Sub RadTransitionControl_TransitionStatusChanged(ByVal sender As Object, ByVal e As TransitionStatusChangedEventArgs)
            Select Case e.Status
                Case TransitionStatus.Started
                    ' The transition has been idle and a new transition is triggered.
                Case TransitionStatus.Interrupted
                    ' A new transition has started before the old one has completed.
                Case TransitionStatus.Completed
                    ' The transition has completed and the RadTransitionControl is now idle.
                Case Else
            End Select
        End Sub
    ```

## When Does a Transition Start?

To check if new content is available or whether a transition has started, you should take care to handle __both__ cases: __Started__ and __Interrupted__. They both indicate that a new transition has started/new content is available, with the difference being whether the RadTransitionControl has been playing another transition or not.    	

## Is There a Transition Currently Playing?

If you want to do some UI related logic, like disabling buttons, while a transition is in progress, you could use the __Started__ and __Interrupted__ states to set the buttons to disabled and the __Completed__ state to reset them back to enabled.    	

You can also use the __IsTransitionIdle__ property. It allows you to bind the __IsEnabled__ of a UIElement to the __IsTransitionIdle__ property, as demonstrated in __Example 3__.

__Example 3: Using the IsTransitionIdle property__ 	
```XAML
    <Button Content="Sample button" IsEnabled="{Binding IsTransitionIdle, ElementName=RadTransitionControl}"/>
        
    <telerik:RadTransitionControl x:Name="RadTransitionControl">
        <telerik:RadTransitionControl.Transition>
            <telerik:SlideAndZoomTransition />
        </telerik:RadTransitionControl.Transition>
    </telerik:RadTransitionControl>
```
