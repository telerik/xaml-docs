---
title:  Get Cell from Point
page_title:  Get Cell from Point
description:  Get Cell from Point.
components: ["spreadsheet"]
slug: radspreadsheet-get-cell-from-point
tags: cell, point, location
published: True
position: 20
---

# Get Cell from Point

This article describes how you can get a cell index by using a specific location on the screen.

In order to get the cell under the mouse you need the position related to the top left corner of the grid that contains all cells. This is why you need to get the position relative to the WorksheetEditorPresenter. Then you can use the __GetCellIndexFromViewPoint__ method to get the cell under the mouse. 

__Get the Cell under the Mouse__

<snippet id='radspreadsheet-howto-get-cell-from-point-block_1-cs' />

## See Also

* [Selection]({%slug radspreadsheet-ui-working-with-selection%})
