---
title: Iterate Through Worksheets
page_title: Iterate Through Worksheets
description: Iterate Through Worksheets
slug: radspreadsheet-model-working-with-worksheets-iterate-through-worksheets
tags: iterate,through,worksheets
published: False
position: 4
---

# Iterate Through Worksheets



In a number of scenarios you may need to iterate through all worksheets in a given workbook. The API of the __Workbook__ class
        exposes a __Worksheets__ collection that allows you to retrieve worksheets both by name and index. Also, the collection allows you
        to iterate all worksheets effortlessly.
      

## 

The following example illustrates how to retrieve worksheets that have already been added to the workbook:
        

#### __C#__

{{region radspreadsheet-model-working-with-worksheets-iterate-through-worksheets_0}}
	            Workbook workbook = new Workbook();
	
	            WorksheetCollection worksheets = workbook.Worksheets;
	            worksheets.Add();
	            worksheets.Add();
	
	            Worksheet firstWorksheet = worksheets[0];
	            Worksheet secondWorksheet = worksheets["Sheet2"];
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-worksheets-iterate-through-worksheets_0}}
	        Dim workbook As New Workbook()
	
	        Dim worksheets As WorksheetCollection = workbook.Worksheets
	        worksheets.Add()
	        worksheets.Add()
	
	        Dim firstWorksheet As Worksheet = worksheets(0)
	        Dim secondWorksheet As Worksheet = worksheets("Sheet2")
	        '#End Region
	    End Sub
	
	    Public Sub IterateWorksheets()
	        '#Region radspreadsheet-model-working-with-worksheets-iterate-through-worksheets_1
	        Dim workbook As New Workbook()
	
	        For i As Integer = 0 To 9
	            workbook.Worksheets.Add()
	        Next
	
	        Dim foregroundColor As New ThemableColor(Colors.Red)
	        Dim backgroundColor As Color = Colors.Green
	        Dim backgroundFill As IFill = New PatternFill(PatternType.Solid, backgroundColor, backgroundColor)
	
	        For Each worksheet As Worksheet In workbook.Worksheets
	            Dim cell As CellSelection = worksheet.Cells(0, 0)
	            cell.SetValue("The name of this worksheet is: " + worksheet.Name)
	            cell.SetForeColor(foregroundColor)
	            cell.SetFill(backgroundFill)
	        Next
	        '#End Region
	    End Sub
	
	End Class



The next snippet creates a new workbook with three worksheets. The code further iterates through all worksheets and sets the value cell 
          *A1* to the name of the corresponding worksheet. Also, the example sets the ForeColor and BackgrounFill of the cell:
        

#### __C#__

{{region radspreadsheet-model-working-with-worksheets-iterate-through-worksheets_1}}
	            Workbook workbook = new Workbook();
	
	            workbook.Worksheets.Add();
	            workbook.Worksheets.Add();
	            workbook.Worksheets.Add();
	
	            ThemableColor foregroundColor = new ThemableColor(Colors.Red);
	            Color backgroundColor = Colors.Green;
	            IFill backgroundFill = new PatternFill(PatternType.Solid, backgroundColor, backgroundColor);
	
	            foreach (Worksheet worksheet in workbook.Worksheets)
	            {
	                CellSelection cell = worksheet.Cells[0, 0];
	                cell.SetValue("The name of this worksheet is: " + worksheet.Name);
	                cell.SetForeColor(foregroundColor);
	                cell.SetFill(backgroundFill);
	            }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-worksheets-iterate-through-worksheets_1}}
	        Dim workbook As New Workbook()
	
	        For i As Integer = 0 To 9
	            workbook.Worksheets.Add()
	        Next
	
	        Dim foregroundColor As New ThemableColor(Colors.Red)
	        Dim backgroundColor As Color = Colors.Green
	        Dim backgroundFill As IFill = New PatternFill(PatternType.Solid, backgroundColor, backgroundColor)
	
	        For Each worksheet As Worksheet In workbook.Worksheets
	            Dim cell As CellSelection = worksheet.Cells(0, 0)
	            cell.SetValue("The name of this worksheet is: " + worksheet.Name)
	            cell.SetForeColor(foregroundColor)
	            cell.SetFill(backgroundFill)
	        Next
	        '#End Region
	    End Sub
	
	End Class



# See Also
