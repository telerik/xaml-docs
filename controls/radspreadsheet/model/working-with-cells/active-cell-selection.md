---
title: Accessing Cells of a Worksheet
page_title: Accessing Cells of a Worksheet
description: Accessing Cells of a Worksheet
slug: radspreadsheet-active-cell-selection
tags: accessing,cells,of,a,worksheet
published: False
position: 2
---

# Accessing Cells of a Worksheet



Each worksheet consists of cells organized in rows and columns. In order to manipulate the data and properties of the cells, you need to create and
        use an instance of the __CellSelection__ class.
      

## 

As a worksheet contains a considerable number of rows and columns, it is unusual to perform an operation to the whole range of cells. Typically, you 
          would like to set the value of a single cell or, for example, apply formatting to a range of cells. In order to perform an operation on a specified 
          range of cells you need to create a __CellSelection__ object that holds the desired cell region and then invoke the appropriate 
          action for this __CellSelection__ instance. This class exposes a rich API that allows you to get, set and clear cell’s value, 
          colors, borders and style.
        

__RadSpreadsheet__'s document model offers multiple ways to create a __CellSelection__ object. The 
          following list contains all approaches you can use to retrieve a __CellSelection__ instance. Note that each example creates a 
          new workbook, adds one worksheet and creates a selection for its cells.
        

1. Create CellSelection using CellIndex
            

#### __C#__

{{region radspreadsheet-active-cell-selection_0}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            CellIndex cellIndex = new CellIndex(0, 5);
	            CellSelection selection1 = worksheet.Cells[cellIndex];
	{{endregion}}



#### __VB__

{{region radspreadsheet-active-cell-selection_0}}
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim cellIndex As New CellIndex(0, 5)
	        Dim selection1 As CellSelection = worksheet.Cells(cellIndex)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection2()
	        '#Region radspreadsheet-active-cell-selection_1
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim cellRange As New CellRange(0, 0, 5, 5)
	        Dim selection2 As CellSelection = worksheet.Cells(cellRange)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection3()
	        '#Region radspreadsheet-active-cell-selection_2
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim ranges As New List(Of CellRange)()
	        ranges.Add(New CellRange(0, 0, 5, 5))
	        ranges.Add(New CellRange(0, 10, 5, 15))
	        Dim selection3 As CellSelection = worksheet.Cells(ranges)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection4()
	        '#Region radspreadsheet-active-cell-selection_3
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim fromIndex As New CellIndex(0, 0)
	        Dim toIndex As New CellIndex(5, 5)
	        Dim selection4 As CellSelection = worksheet.Cells(fromIndex, toIndex)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection5()
	        '#Region radspreadsheet-active-cell-selection_4
	
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim selection5 As CellSelection = worksheet.Cells(0, 5)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection6()
	        '#Region radspreadsheet-active-cell-selection_5
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim selection6 As CellSelection = worksheet.Cells(0, 0, 5, 5)
	        '#End Region
	    End Sub
	
	End Class



1. Create CellSelection using CellRange
            

#### __C#__

{{region radspreadsheet-active-cell-selection_1}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            CellRange cellRange = new CellRange(0, 0, 5, 5);
	            CellSelection selection2 = worksheet.Cells[cellRange];
	{{endregion}}



#### __VB__

{{region radspreadsheet-active-cell-selection_1}}
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim cellRange As New CellRange(0, 0, 5, 5)
	        Dim selection2 As CellSelection = worksheet.Cells(cellRange)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection3()
	        '#Region radspreadsheet-active-cell-selection_2
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim ranges As New List(Of CellRange)()
	        ranges.Add(New CellRange(0, 0, 5, 5))
	        ranges.Add(New CellRange(0, 10, 5, 15))
	        Dim selection3 As CellSelection = worksheet.Cells(ranges)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection4()
	        '#Region radspreadsheet-active-cell-selection_3
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim fromIndex As New CellIndex(0, 0)
	        Dim toIndex As New CellIndex(5, 5)
	        Dim selection4 As CellSelection = worksheet.Cells(fromIndex, toIndex)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection5()
	        '#Region radspreadsheet-active-cell-selection_4
	
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim selection5 As CellSelection = worksheet.Cells(0, 5)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection6()
	        '#Region radspreadsheet-active-cell-selection_5
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim selection6 As CellSelection = worksheet.Cells(0, 0, 5, 5)
	        '#End Region
	    End Sub
	
	End Class



1. Create CellSelection using multiple CellRange objects
            

#### __C#__

{{region radspreadsheet-active-cell-selection_2}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            List<CellRange> ranges = new List<CellRange>();
	            ranges.Add(new CellRange(0, 0, 5, 5));
	            ranges.Add(new CellRange(0, 10, 5, 15));
	            CellSelection selection3 = worksheet.Cells[ranges];
	{{endregion}}



#### __VB__

{{region radspreadsheet-active-cell-selection_2}}
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim ranges As New List(Of CellRange)()
	        ranges.Add(New CellRange(0, 0, 5, 5))
	        ranges.Add(New CellRange(0, 10, 5, 15))
	        Dim selection3 As CellSelection = worksheet.Cells(ranges)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection4()
	        '#Region radspreadsheet-active-cell-selection_3
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim fromIndex As New CellIndex(0, 0)
	        Dim toIndex As New CellIndex(5, 5)
	        Dim selection4 As CellSelection = worksheet.Cells(fromIndex, toIndex)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection5()
	        '#Region radspreadsheet-active-cell-selection_4
	
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim selection5 As CellSelection = worksheet.Cells(0, 5)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection6()
	        '#Region radspreadsheet-active-cell-selection_5
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim selection6 As CellSelection = worksheet.Cells(0, 0, 5, 5)
	        '#End Region
	    End Sub
	
	End Class



1. Create CellSelection using two CellIndex instances that specify a CellRange
            

#### __C#__

{{region radspreadsheet-active-cell-selection_3}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            CellIndex fromIndex = new CellIndex(0, 0);
	            CellIndex toIndex = new CellIndex(5, 5);
	            CellSelection selection4 = worksheet.Cells[fromIndex, toIndex];
	{{endregion}}



#### __VB__

{{region radspreadsheet-active-cell-selection_3}}
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim fromIndex As New CellIndex(0, 0)
	        Dim toIndex As New CellIndex(5, 5)
	        Dim selection4 As CellSelection = worksheet.Cells(fromIndex, toIndex)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection5()
	        '#Region radspreadsheet-active-cell-selection_4
	
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim selection5 As CellSelection = worksheet.Cells(0, 5)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection6()
	        '#Region radspreadsheet-active-cell-selection_5
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim selection6 As CellSelection = worksheet.Cells(0, 0, 5, 5)
	        '#End Region
	    End Sub
	
	End Class



1. Create CellSelection using two integers that indicate the CellIndex
            

#### __C#__

{{region radspreadsheet-active-cell-selection_4}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            CellSelection selection5 = worksheet.Cells[0, 5];
	{{endregion}}



#### __VB__

{{region radspreadsheet-active-cell-selection_4}}
	
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim selection5 As CellSelection = worksheet.Cells(0, 5)
	        '#End Region
	    End Sub
	
	    Public Sub CreateSelection6()
	        '#Region radspreadsheet-active-cell-selection_5
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim selection6 As CellSelection = worksheet.Cells(0, 0, 5, 5)
	        '#End Region
	    End Sub
	
	End Class



1. Create CellSelection using four integers that specify the CellRange
            

#### __C#__

{{region radspreadsheet-active-cell-selection_5}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            CellSelection selection6 = worksheet.Cells[0, 0, 5, 5];
	{{endregion}}



#### __VB__

{{region radspreadsheet-active-cell-selection_5}}
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim selection6 As CellSelection = worksheet.Cells(0, 0, 5, 5)
	        '#End Region
	    End Sub
	
	End Class



Once you have a __CellSelection__ object you can get, set and clear the properties of the selected cells. More information about 
          cell properties is available in the [Get, Set and Clear Cell Properties]({%slug radspreadsheet-features-formatting-cells%}) article.
        

# See Also
