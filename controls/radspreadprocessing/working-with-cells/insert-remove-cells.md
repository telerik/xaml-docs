---
title: Insert and Remove Cells
page_title: Insert and Remove Cells
description: Insert and Remove Cells
slug: radspreadprocessing-working-with-cells-insert-remove-cells
tags: insert,and,remove,cells
published: True
position: 1
---

# Insert and Remove Cells



Worksheets in the document model consist of cells organized in rows and columns. Each worksheet allows you to insert and remove cells through shifting the contents of the surrounding cells in a specified direction. This article demonstrates how to insert and remove cells.
      

* [Insert Cells](#insert-cells)

## Insert Cells

In order to insert cells, you need to create a __CellSelection__ instance that indicates where the new cells are to be inserted in the worksheet. Also, you have to specify the direction of the shift.
        

Whenever cells insertion is performed, all values that appear to the right or below the CellSelection region including the selected region are shifted. There are two shift directions: right and down. When you choose to shift cells to the right, all cells that appear to the right of the selected region including the selected region are shifted, thus, causing no loss of data. Similarly, choosing to shift the values down moves all values in the selected region columns downwards and expands the __UsedCellRange__.
        

The __CellSelection__ class exposes an __Insert()__ method that takes one argument which indicates the direction of the shift. Also, the class offers a __CanInsertOrRemove()__ method that determines if the insertion is possible. __Example 1__ shows how to insert cells using methods mentioned above:
        

#### __[C#] Example 1: Insert cells__

{{region radspreadprocessing-working-with-cells-insert-remove-cells_0}}
	
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            CellRange range = new CellRange(1, 1, 10, 10);
	            CellSelection selection = worksheet.Cells[range];
	
	            if (selection.CanInsertOrRemove(range, ShiftType.Right))
	            {
	                selection.Insert(InsertShiftType.Right);
	            }
	
	{{endregion}}



## Remove Cells

In order to remove cells, you need to create a __CellSelection__ object that indicates the region of cells you would like to remove. Also, you have to specify the direction of the shift.
        

Whenever you remove cells, all values that appear to the right or below the CellSelection region are shifted. There are two shift directions: left and up. When you choose to shift cells to the left, all cells that appear to the right of the selected region аре shifted to the left. Similarly, choosing to shift the values up moves all values in the selected region columns upwards.
        

The __CellSelection__ class exposes a __Remove()__ method that takes one argument which indicates the direction of the shift. Тhe class also offers a __CanInsertOrRemove()__ method that determines if the removal is possible. __Example 2__ shows how to remove cells using methods mentioned above:
        

#### __[C#] Example 2: Remove cells__

{{region radspreadprocessing-working-with-cells-insert-remove-cells_1}}
	
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            CellRange range = new CellRange(1, 1, 10, 10);
	            CellSelection selection = worksheet.Cells[range];
	
	            if (selection.CanInsertOrRemove(range, ShiftType.Up))
	            {
	                selection.Remove(RemoveShiftType.Up);
	            }
	
	{{endregion}}


