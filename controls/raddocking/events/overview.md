---
title: Overview
page_title: Overview
description: Learn more about the different events of the RadDocking control.
slug: raddocking-events-overview
tags: overview
published: True
position: 0
---

# Overview

This help article covers the specific events exposed by the __RadDocking__ control. The events are grouped by their general purpose.

## State Changed Events

* __ActivePaneChanged__: Occurs when the ActivePane is changed. The passed event argument is of type __ActivePangeChangedEventArgs__.

	* __ActivePangeChangedEventArgs__: Exposes information about NewPane (activated) and OldPane (deactivated).
	
* __PaneStateChange__: This event is fired whenever the state of the RadPane is changed (e.g., pin, unpin, close, show, etc.). The passed event argument is of type __RadRoutedEventArgs__. The modified __RadPane__ element can be accessed via the __OriginalSource__ property of the event arguments.
	
#### __Pin\Unpin Events__

* __PreviewUnpin__: Occurs before the RadPane is unpinned. The passed event argument is of type __StateChangeEventArgs__. 

* __Unpin__: Occurs when the RadPane is unpinned. The passed event argument is of type __StateChangeEventArgs__.

* __PreviewPin__: Occurs before the RadPane is pinned. The passed event argument is of type __StateChangeEventArgs__.

* __Pin__: Occurs when the RadPane is pinned. The passed event argument is of type __StateChangeEventArgs__.
	
>For example, when you [unpin]({%slug raddocking-panes-pinned-unpinned-panes%}) a RadPane, the events fire in this order:                   
>	* __PreviewUnpin__
>	* __Unpin__
>	* __PaneStateChange__ 

## Show\Hide Events

* __PreviewShow__: Occurs before the RadPane is shown. The passed event argument is of type __StateChangeEventArgs__. 

* __Show__: Occurs when the RadPane is shown. The passed event argument is of type __StateChangeEventArgs__. 

* __PreviewClose__: Occurs before the RadPane is closed. The passed event argument is of type __StateChangeEventArgs__. 

* __Close__: Occurs when the RadPane is closed. The passed event argument is of type __StateChangeEventArgs__. 

>tip __PreviewClose__ and __Close__ events are fired whenever you press the [Close]({%slug raddocking-visual-structure%}) button.

>tip __PreviewShow__ and __Show__ events are fired when you invoke the __ShowAllPanes__ method of the __RadPaneGroup__ class. This method will show all hidden panes.

>When you close a floatable window, the "close" events fired in this order:
> 	* __PreviewWindowClose__
> 	* __PreviewClose__
> 	* __WindowClose__
> 	* __Close__

## Compass Events

* __PreviewShowCompass__: Occurs when the [Compass]({%slug raddocking-features-compass%}) is shown.

## Save\Load Layout Events

* __ElementLoading__: Raised when a docking element (__Pane__, __PaneGroup__ or __SplitContainer__) is about to be loaded. The passed event argument is of type __LayoutSerializationLoadingEventArgs__. Element loading can be canceled by setting the __Cancel__ property from the event arguments.

* __ElementLoaded__: Raised after a docking element (__Pane__, __PaneGroup__ or __SplitContainer__) is loaded. The passed event argument is of type __LayoutSerializationEventArgs__.

* __ElementLayoutSaving__ (introduced with R2 2016 of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}) - Raised when a docking element (__Pane__, __PaneGroup__ or __SplitContainer__) starts saving. The passed event argument is of type __LayoutSerializationSavingEventArgs__. Element layout saving can be canceled by setting the __Cancel__ property from the event arguments.

* __ElementSaved__: Raised after a docking element (__Pane__, __PaneGroup__ or __SplitContainer__) is saved. The passed event argument is of type __LayoutSerializationEventArgs__.

* __ElementLayoutCleaning__ (introduced with R2 2016 of UI for {% if site.site_name == 'WPF' %}WPF{% else %}Silverlight{% endif %}) - Raised when a docking element (__Pane__, __PaneGroup__ or __SplitContainer__) starts cleaning up. The passed event argument is of type __LayoutSerializationCleaningEventArgs__. Element layout cleaning can be canceled by setting the __Cancel__ property from the event arguments.

* __ElementCleaned__: Raised after a docking element (__Pane__, __PaneGroup__ or __SplitContainer__) is cleaned. The passed event argument is of type __LayoutSerializationEventArgs__.

* __CustomElementLoading__: Raised when a custom docking element (that derives from __RadPane__, __RadPaneGroup__ or __RadSplitContainer__) is about to be loaded. The passed event argument is of type __LayoutSerializationCustomLoadingEventArgs__.

>tipElements are __cleaned just before loading__ the layout: This operation is performed to prepare the Docking control for the new layout.

>tipFor more information about saving and loading __RadDocking__ layout, take a look at the [Save\Load Layout]({%slug raddocking-features-save-load-layout-overview%}) topic.

## ElementCreated Events

* __ToolWindowCreated__: Raised when a ToolWindow instance is internally auto-generated by RadDocking.

* __PaneGroupCreated__: Raised when a PaneGroup instance is internally auto-generated by RadDocking.

* __SplitContainerCreated__: Raised when a SplitContainer instance is internally auto-generated by RadDocking.
	
Using the ElementCreatedEventArgs provided by each of the above events, the user could get information about the root UIElement that raises the event and the newly generated element - ToolWindow, PaneGroup or SplitContainer.

>The __ElementCreated__ events are expected to be raised only when the PaneGroup, SplitContainer or ToolWindow are automatically and internally generated by RadDocking, not by the user. The events are not raised when __RadDocking__ is initially loading.

## Other Events

* __Loaded__: Occurs when the __RadDocking__ has been constructed and added to the object tree.
* __LayoutUpdated__: Occurs when the layout of the visual tree changes.	

## See Also

 * [RadPane]({%slug raddocking-panes-radpane%})
 * [RadDocumentPane]({%slug raddocking-panes-raddocumentpane%})
 * [Docked/Floating Panes]({%slug raddocking-features-panes-docked-floating-panes%})
 * [Pinned/Unpinned Panes]({%slug raddocking-panes-pinned-unpinned-panes%})
