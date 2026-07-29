---
title: Events
page_title: Events
description: This article describes the RadTabbedWindow events.
slug: radtabbedwindow-events
tags: overview
published: True
position: 3
---

# Events

The RadTabbedWindow control exposes a number of events to let you easily customize its behavior.

Most of these events are inherited from the [RadWindow]({%slug radwindow-events-overview%}) control. As the RadTabbedWindow contains a **TabbedWindowTabControl** which inherits from **RadTabControl**, most of its [events]({%slug radtabcontrol-features-pinandclose%}#events) bubble to the window as well.

## AddingNewTab

Occurs when a RadTabItem is being added via the 'Add' button in the UI. Its **AddingNewTabEventArgs** expose the following properties:

* **Cancel**: Gets or sets a value indicating whether adding the new tab via add button should be cancelled.

* **Item**: Gets or sets the newly added item. The type of the item depends on the scenario. 

	If the RadTabbedWindow control is __populated directly with RadTabItem elements__, the Item property contains an object of type RadTabItem which you can customize or completely replace. 
	
	__Handle the AddingNewTab event in data binding scenario__
	
	<snippet id='radtabbedwindow-events-block_1-cs' />
	<snippet id='radtabbedwindow-events-block_2-vb' />
	
	If the __ItemsSource of the control is populated (data binding scenario)__, the Item property will be empty (*null*) and you should manually set it to an object of your business type. Otherwise, no tab will added.
	
	__Handle the AddingNewTab event__
	
	<snippet id='radtabbedwindow-events-block_3-cs' />
	<snippet id='radtabbedwindow-events-block_4-vb' />
	
	>tip If the Item property is left empty (*null*), no tab will be added.

>important If the provided Item's **type** does not match the data type of the current **ItemsSource** an exception will be thrown.

## TabbedWindowCreating

Occurs when a new RadTabbedWindow is created via drag and drop and is about to be shown. Its **TabbedWindowCreatingEventArgs** expose the following properties:

* **Cancel**: Gets or sets a value indicating whether the creation of the new window should be cancelled.
* **SourceWindow**: The source window from which the drag drop operation is started.
* **NewWindow**: The new window created via drag drop operation.
* **DraggedTab**: The dragged RadTabItem from the source RadTabbedWindow. As of **R2 2019 SP1**, this property is **obsolete** and the **DraggedItem** property needs to be used instead.
* **DraggedItem**: The dragged RadTabItem in an unbound scenario or the dragged item (viewmodel) in a databinding scenario.

The following example demonstrates how you can cancel the creation of the new window or attach the same handler to its **AddingNewTab** event as that of the source window in an **unbound scenario**.

__Handle the TabbedWindowCreating event in an unbound scenario__

<snippet id='radtabbedwindow-events-block_5-cs' />
<snippet id='radtabbedwindow-events-block_6-vb' />

You can also use the TabbedWindowCreating event to clear, update or replace the ItemsSource of the new window. The following example demonstrates how to do so in a **databound scenario**.

__Change the ItemsSource of the new window in a databinding scenario__

<snippet id='radtabbedwindow-events-block_7-cs' />
<snippet id='radtabbedwindow-events-block_8-vb' />

## PreviewTabClosed

Occurs when a RadTabItem is about to be closed. This event can be cancelled by the **PreviewTabChangedEventArgs**'s boolean **Cancel** property to **True**. The event arguments expose the **TabItem** which was changed and its **DataContext**, if any.

## TabClosed

Occurs when a RadTabItem is closed. Its **TabChangedEventArgs** expose the **TabItem** which was changed and its **DataContext**, if any.

## PreviewTabPinned

Occurs when a RadTabItem is about to be pinned. This event can be cancelled by the **PreviewTabChangedEventArgs**'s boolean **Cancel** property to **True**. The event arguments expose the **TabItem** which was changed and its **DataContext**, if any.

## TabPinned

Occurs when a RadTabItem is pinned. Its **TabChangedEventArgs** expose the **TabItem** which was changed and its **DataContext**, if any.

## PreviewTabUnpinned

Occurs when a RadTabItem is about to be unpinned. This event can be cancelled by the **PreviewTabChangedEventArgs**'s boolean **Cancel** property to **True**. The event arguments expose the **TabItem** which was changed and its **DataContext**, if any.

## TabUnpinned

Occurs when a RadTabItem is unpinned. Its **TabChangedEventArgs** expose the **TabItem** which was changed and its **DataContext**, if any.

## PreviewSelectionChanged

Handling this event by setting the **RadSelectionChangedEventArgs**' **Handled** property to **True** rollbacks the selection.

## SelectionChanged

Occurs when a change has been made to the selection.

## See Also

* [Key Properties]({%slug radtabbedwindow-key-properties%})
* [Styles and Templates]({%slug radtabbedwindow-styles-and-templates%})