---
title: Insert and Remove Cells 
page_title: Insert and Remove Cells 
description: Insert and Remove Cells 
slug: radspreadsheet-features-insert-delete
tags: insert,and,remove,cells,
publish: False
position: 1
---

# Insert and Remove Cells 



Worksheets in __RadSpreadsheet__'s document model consist of cells organized in rows and columns. Each worksheet allows you
        to insert and remove cells through shifting the contents of the surrounding cells in a specified direction. This article demonstrates how to insert
        and remove cells.
      

## Insert Cells

In order to insert cells, you need to create a __CellSelection__ instance that indicates where the new cells are to be inserted
          in the worksheet. Also, you have to specify the direction of the shift. Whenever cells insertion is performed, all values that appear to the right
          or below the CellSelection region including the selected region are shifted. There are two shift directions: right and down. When you choose to shift
          cells to the right, all cells that appear to the right of the selected region including the selected region will be shifted, thus, causing no loss
          of data. Similarly, choosing to shift the values down moves all values in the selected region columns downwards and expands the
          __UsedCellRange__.
        

The __CellSelection__ class exposes an __Insert()__ method that takes one argument which indicates the direction
          of the shift. Also, the class offers a __CanInsertOrRemove()__ method that determines if the insertion is possible. The following
          example shows how to insert cells using methods mentioned above:
        

#### __C#__

{{region radspreadsheet-insert-delete_0}}
	
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            CellRange range = new CellRange(1, 1, 10, 10);
	            CellSelection selection = worksheet.Cells[range];
	
	            if (selection.CanInsertOrRemove(range, ShiftType.Right))
	            {
	                selection.Insert(InsertShiftType.Right);
	            }
	
	{{endregion}}



#### __VB__

{{region radspreadsheet-insert-delete_0}}
	
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim range As New CellRange(1, 1, 10, 10)
	        Dim selection As CellSelection = worksheet.Cells(range)
	
	        If selection.CanInsertOrRemove(range, ShiftType.Right) Then
	            selection.Insert(InsertShiftType.Right)
	        End If
	
	        '#End Region
	    End Sub
	
	    Public Sub RemoveCells()
	        '#Region radspreadsheet-insert-delete_1
	
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim range As New CellRange(1, 1, 10, 10)
	        Dim selection As CellSelection = worksheet.Cells(range)
	
	        If selection.CanInsertOrRemove(range, ShiftType.Up) Then
	            selection.Remove(RemoveShiftType.Up)
	        End If
	
	        '#End Region
	    End Sub
	
	End Class



## Remove Cells

In order to remove cells, you need to create a __CellSelection__ object that indicates the region of cells you would like to 
          remove. Also, you have to specify the direction of the shift. Whenever you remove cells, all values that appear to the right or below the 
          CellSelection region are shifted. There are two shift directions: left and up. When you choose to shift cells to the left, all cells that appear 
          to the right of the selected region will be shifted to the left. Similarly, choosing to shift the values up moves all values in the selected region 
          columns upwards.
        

The __CellSelection__ class exposes a __Remove()__ method that takes one argument which indicates the direction 
          of the shift. Also, the class offers a __CanInsertOrRemove()__ method that determines if the removal is possible. The following 
          example shows how to remove cells using methods mentioned above:
        

#### __C#__

{{region radspreadsheet-insert-delete_1}}
	
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            CellRange range = new CellRange(1, 1, 10, 10);
	            CellSelection selection = worksheet.Cells[range];
	
	            if (selection.CanInsertOrRemove(range, ShiftType.Up))
	            {
	                selection.Remove(RemoveShiftType.Up);
	            }
	
	{{endregion}}



#### __VB__

{{region radspreadsheet-insert-delete_1}}
	
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim range As New CellRange(1, 1, 10, 10)
	        Dim selection As CellSelection = worksheet.Cells(range)
	
	        If selection.CanInsertOrRemove(range, ShiftType.Up) Then
	            selection.Remove(RemoveShiftType.Up)
	        End If
	
	        '#End Region
	    End Sub
	
	End Class



# See Also
