---
title: Handle Cell\Row Mouse Events
page_title: Handle Cell\Row Mouse Events
description: Check out our article demonstrating how to add handlers for the various mouse events to the cell and row elements in RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-how-to-handle-cell-row-mouse-events
tags: handle,cell,row,mouse,events
published: True
position: 6
---

# Handle Cell\Row Mouse Events

This article will demonstrate how to handle RadGridView's [CellLoaded](#cellloaded-event) & [RowLoaded](#rowloaded-event) events to add handlers for the various mouse events to the control's cell and row elements. The [CellUnloaded](#cellunloaded-event) and [RowUnloaded](#rowunloaded-event) events can in turn be used to remove those handlers in order to avoid memory leaks.

>important You should **not** directly set properties of the visual elements (**GridViewCell**, **GridViewRow**) as this will result in inconsistent behavior due to the control's [UI Virtualization]({%slug radgridview-features-ui-virtualization%}) mechanism. Instead, you should use the underlying data items.

## CellLoaded Event

The **CellLoaded** event fires anytime a cell appears in the viewport.

The **CellLoaded** event handler receives two arguments:

* The **sender** argument contains the **RadGridView**. This argument is of type **object**, but can be cast to the **RadGridView** type.

* A **CellEventArgs** object. This object exposes a **Cell** property - the loaded cell.

**Example 1** uses the CellLoaded event to handle the left-click on a **GridViewCell** and **GridViewHeaderCell**.

__Example 1: Handling CellLoaded__
<snippet id='radgridview-how-to-handle-cell-row-mouse-events-example_1_handling_cellloaded-cs' />

<snippet id='radgridview-how-to-handle-cell-row-mouse-events-example_1_handling_cellloaded-vb' />


## CellUnloaded event

The **CellUnloaded** event occurs anytime a cell disappears from the viewport.

The **CellUnloaded** event handler receives two arguments:

* The sender argument contains the **RadGridView**. This argument is of type **object**, but can be cast to the **RadGridView** type.

* A **CellEventArgs** object. This object exposes a **Cell** property - the unloaded cell.

A common scenario in which the CellUnloaded can be used is to remove the handler(s) added in the CellLoaded event.

__Example 2: Handling CellUnloaded__
<snippet id='radgridview-how-to-handle-cell-row-mouse-events-example_2_handling_cellunloaded-cs' />

<snippet id='radgridview-how-to-handle-cell-row-mouse-events-example_2_handling_cellunloaded-vb' />


## RowLoaded Event

The **RowLoaded** event fires anytime a row appears in the viewport.

The **RowLoaded** event handler receives two arguments:

* The **sender** argument contains the **RadGridView**. This argument is of type **object**, but can be cast to the **RadGridView** type.

* A **RowLoadedEventArgs** object. This object has the following properties:

	* **DataElement**: Gets the data element (data context) for the row being loaded.
	
	* **GridViewDataControl**: The **GridViewDataControl** control holding the row being loaded.
	
	* **Row**: The row being loaded.

**Example 1** uses the RowLoaded event to handle the right-click on a **GridViewRow**.

__Example 3: Handling RowLoaded\RowUnloaded__
<snippet id='radgridview-how-to-handle-cell-row-mouse-events-example_3_handling_rowloaded_rowunloaded-cs' />

<snippet id='radgridview-how-to-handle-cell-row-mouse-events-example_3_handling_rowloaded_rowunloaded-vb' />


## RowUnloaded event

The **RowUnloaded** event occurs anytime a row disappears from the viewport.

The **RowUnloaded** event handler receives two arguments:

* The sender argument contains the **RadGridView**. This argument is of type **object**, but can be cast to the **RadGridView** type.

* A **RowLoadedEventArgs** object. This object has the following properties:

	* **DataElement**: Gets the data element (data context) for the row being unloaded.

	* **GridViewDataControl**: The gridview control holding the row being unloaded.

	* **Row**: The row being unloaded.

A common scenario in which the RowUnloaded can be used is to remove the handler(s) added in the RowLoaded event.

__Example 4: Handling CellUnloaded__
<snippet id='radgridview-how-to-handle-cell-row-mouse-events-example_4_handling_cellunloaded-cs' />

<snippet id='radgridview-how-to-handle-cell-row-mouse-events-example_4_handling_cellunloaded-vb' />

