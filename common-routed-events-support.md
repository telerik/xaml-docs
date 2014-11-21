---
title: Routed Events Support
page_title: Routed Events Support
description: Routed Events Support
slug: common-routed-events-support
tags: routed,events,support
published: True
position: 6
site_name: Silverlight
---

# Routed Events Support

## General Description

With the Windows Presentation Foundation a new type of events were introduced - the Routed Events. They have provided the developer with an entirely new approach to the eventing and the event handling.
     
Basically, Routed Events traverse the logical tree upwards or downwards, depending on their Routing Strategy – Bubble and Tunnel respectively.  Most Routed Events have a corresponding CLR event that wraps them and allows developers to use the Routed Event as a standard CLR one, as well as to add handlers to it in the XAML. Another interesting thing to know is that by WPF convention, all tunnelling events are prefixed with Preview – e.g. PreviewExpand. 
        
For more details, please check the following MSDN article [Routed Events Overview](http://msdn.microsoft.com/en-us/library/ms742806.aspx)

## Implementation

Telerik UI for Silverlight implement Routed Events in the way they are in WPF. By default, the Silverlight platform does not allow you to create custom Routed Events. However, Telerik managed to implement custom Routed Events for RadControls for Silverlight. To overcome the limitation of the platform Telerik introduced EventManager, RoutedEvent and RoutingStrategy types in the controls. These same types are available with WPF by default. Telerik RadControls for Silverlight used an equal mechanism as the one present in WPF.  The functionality from the WPF is mirrored exactly the same, so the use in Silverlight is identical.
        
Almost all of the events in the controls from UI for Silverlight are Routed Events. This gives you more freedom when you design your applications since you can write instance handlers as well as class handlers for our controls.       