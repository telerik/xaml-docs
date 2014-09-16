---
title: Add and Remove Worksheets
page_title: Add and Remove Worksheets
description: Add and Remove Worksheets
slug: radspreadsheet-model-working-with-worksheets-add-remove-worksheets
tags: add,and,remove,worksheets
publish: False
position: 1
---

# Add and Remove Worksheets



This article demonstrates how to add and remove worksheets from a workbook.
      

## Add Worksheets

Adding a new worksheet to a workbook can be easily achieved through its __Worksheets__ collection. It exposes an
          __Add()__ method that does not take arguments and returns the instance of the newly created worksheet. By default worksheets
          are assigned the first available name in the sequence Sheet1, Sheet2, Sheet3… You can easily change the name of the worksheet through the
          __Worksheet.Name__ property. More information about renaming a worksheet is available in the
         [Rename a Worksheet]({%slug radspreadsheet-model-working-with-worksheets-rename-worksheet%}) article.
        

The following example creates a workbook from scratch and adds a single worksheet to it. Since this is the first worksheet in the workbook, it
          is also set as the active worksheet. All worksheets added after it will not become active.
        

#### __C#__

{{region radspreadsheet-working-with-worksheets-add-remove-worksheets_0}}
	            Workbook workbook = new Workbook();
	            Worksheet newWorksheet = workbook.Worksheets.Add();
	{{endregion}}



#### __VB__

{{region radspreadsheet-working-with-worksheets-add-remove-worksheets_0}}
	        Dim workbook As New Workbook()
	        Dim newWorksheet As Worksheet = workbook.Worksheets.Add()
	        '#End Region
	    End Sub
	
	    Public Sub RemoveWorksheet()
	        '#Region radspreadsheet-working-with-worksheets-add-remove-worksheets_1
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add() ' Sheet1
	        Dim secondWorksheet As Worksheet = workbook.Worksheets.Add() ' Sheet2
	        workbook.Worksheets.Add() ' Sheet3
	        workbook.Worksheets.Add() ' Sheet4
	        workbook.Worksheets.RemoveAt(3) ' Removed Sheet4
	        workbook.Worksheets.Remove("Sheet1") ' Removed Sheet1
	        workbook.Worksheets.Remove(secondWorksheet) ' Removed Sheet2
	        ' the only worksheet left is Sheet3
	        '#End Region
	    End Sub
	
	End Class



## Remove Worksheets

The __Worksheets__ collection of the workbook offers two methods for removing worksheets: __Remove()__
          and __RemoveAt()__. The former method requires the worksheet name or the worksheet instance to be passed as an argument.
          The latter allows you specify the index of the worksheet you would like to remove.
        

The following sample snippet creates a workbook and adds four worksheets. All worksheets are with their default names: Sheet1, Sheet2, Sheet3 
          and Sheet4. The code further demonstrates how to remove three worksheets using all of the aforementioned remove methods:
        

#### __C#__

{{region radspreadsheet-working-with-worksheets-add-remove-worksheets_1}}
	            Workbook workbook = new Workbook();
	            workbook.Worksheets.Add(); // Sheet1
	            Worksheet secondWorksheet = workbook.Worksheets.Add(); // Sheet2
	            workbook.Worksheets.Add(); // Sheet3
	            workbook.Worksheets.Add(); // Sheet4
	
	            workbook.Worksheets.RemoveAt(3); // Removed Sheet4
	            workbook.Worksheets.Remove("Sheet1"); // Removed Sheet1
	            workbook.Worksheets.Remove(secondWorksheet); // Removed Sheet2
	            // the only worksheet left is Sheet3
	{{endregion}}



#### __VB__

{{region radspreadsheet-working-with-worksheets-add-remove-worksheets_1}}
	        Dim workbook As New Workbook()
	        workbook.Worksheets.Add() ' Sheet1
	        Dim secondWorksheet As Worksheet = workbook.Worksheets.Add() ' Sheet2
	        workbook.Worksheets.Add() ' Sheet3
	        workbook.Worksheets.Add() ' Sheet4
	        workbook.Worksheets.RemoveAt(3) ' Removed Sheet4
	        workbook.Worksheets.Remove("Sheet1") ' Removed Sheet1
	        workbook.Worksheets.Remove(secondWorksheet) ' Removed Sheet2
	        ' the only worksheet left is Sheet3
	        '#End Region
	    End Sub
	
	End Class



# See Also
