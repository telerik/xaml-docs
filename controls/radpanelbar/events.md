---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadPanelBar {{ site.framework_name }} control.
components: ["panelbar"]
slug: radpanelbar-events-overview
tags: overview
published: True
position: 2
---

# Events

This topic covers the specific events exposed by the __RadPanelBar__control. The events are grouped by their general purpose.	  

## Click Events

__RadPanelBar__ exposes the following events when a __RadPanelBarItem__ is clicked with the Mouse left button:		

* __ItemClick__ – raised on __MouseLeftButtonUp__ when a __RadPanelBarItem__ is clicked with Mouse left button.			

* __ItemDoubleClick__ – raised on __MouseLeftButtonUp__ when a __RadPanelBarItem__ is double clicked with Mouse left button. The time slot between two clicks must be less than or equal to 300ms in order to be registered as a double click.			

__RadPanelBarItem__ exposes the following events:		

* __Click__ – raised on __MouseLeftButtonUp__ when the item is clicked with Mouse left button.			

* __DoubleClick__ – raised on __MouseLeftButtonUp__ when the item is double clicked with Mouse left button. The time slot between the two clicks must be less than or equal to 300ms to register these clicks as a double click. 

## Click Events sequence.  

Currently a successful __RadPanelBarItem__ double click fires the following events:  

* __ItemClick__ event of the __RadPanelBar__

* __DoubleClick__ event of the __RadPanelBarItem__

* __ItemDoubleClick__ event of the __RadPanelBar__

* __Click__ event of the __RadPanelBarItem__
