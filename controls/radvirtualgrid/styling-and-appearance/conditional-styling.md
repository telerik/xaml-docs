---
title: Conditional Styling
page_title: Conditional Styling
description: Conditional Styling
slug: virtualgrid-conditional-styling
tags: conditional,styling
published: True
position: 1
---

# Conditional Styling

This topic will demonstrate how the cells of __RadVirtualGrid__ can be styled conditionally.

This is achieved through the usage of the following two events in conjunction.

* __OverlayBrushesNeeded__: The event arguments expose a __Brushes__ collection which can be populated with the Brushes that will be conditionally applied further. When they are preliminarily known, the respective Geometry can be easily drawn at once, instead of applying a style for each cell individually. Thus, the rendering performance of the control is kept unaffected.

* __CellDecorationsNeeded__: This is the event through which the actual styling of the cells can be applied. The event arguments expose the following properties:

	- __Background__: Its value must be set to be one of the Brushes provided by the __Brushesh__ collection populated through the __OverlayBrushesNeeded__ event
	- __ColumnIndex__: The column the given cell corresponds to
	- __RowIndex__: The row the given cell corresponds to
	- __FontFamily__: Sets the FontFamily of the cell
	- __FontSize__: Sets the FontSize of the cell
	- __Foreground__: Sets the Brush for the Foreground of the cell

## See also

* [Styling and Appearance]({%slug virtualgrid-styling-and-appearance%})


