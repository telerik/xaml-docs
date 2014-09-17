---
title: History
page_title: History
description: History
slug: radspreadsheet-model-features-history
tags: history
published: False
position: 7
---

# History



The document model of __RadSpreadsheet__ maintains a history stack that tracks all changes introduced to the content of the workbook.
        The history is implemented via the __WorkbookHistory__ class and the __Workbook__ exposes a property of this
        type. __RadSpreadsheet__ automatically records all changes introduced to the workbook, however, it also allows manual control over
        the history.
      

## Undo / Redo Actions

By default the __WorkbookHistory__ class records all changes introduced to the workbook. That said, you can invoke its
          __Undo()__ and __Redo()__ methods to perform undo and redo actions respectively. Both methods return a
          __Boolean__ value that indicates whether the operations were successful. The __Workbook__ class exposes the
          *Boolean* properties __CanUndo__ and __CanRedo__ that indicate whether the
          respective action is applicable.
        

The following example creates a new workbook with a single worksheet and sets the value of cell
          *A1* twice. Further, the snippet performs the undo and redo actions.
        

#### __C#__

{{region radspreadsheet-model-features-history_0}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            worksheet.Cells[0, 0].SetValue("First cell value");
	            worksheet.Cells[0, 0].SetValue("Second cell value");
	
	            workbook.History.Undo();
	            workbook.History.Redo();
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-features-history_0}}
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        worksheet.Cells(0, 0).SetValue("First cell value")
	        worksheet.Cells(0, 0).SetValue("Second cell value")
	
	        workbook.History.Undo()
	        workbook.History.Redo()
	        '#End Region
	    End Sub
	
	    Public Shared Sub IterateCellsAndWorksheetsInWorkbookUndoGroup()
	        '#Region radspreadsheet-model-features-history_1
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        workbook.History.BeginUndoGroup()
	
	        worksheet.Cells(0, 0).SetValue(15)
	        worksheet.Cells(0, 0).SetFormat(New CellValueFormat("0.00"))
	
	        workbook.History.EndUndoGroup()
	
	        workbook.History.Undo()
	        workbook.History.Redo()
	        '#End Region
	    End Sub
	
	    Public Shared Sub DisableHistory()
	        '#Region radspreadsheet-model-features-history_2
	        Dim workbook As New Workbook()
	        workbook.History.IsEnabled = False
	        '#End Region
	    End Sub
	
	
	    Public Shared Sub ClearHistory()
	        '#Region radspreadsheet-model-features-history_3
	        Dim workbook As New Workbook()
	        workbook.History.Clear()
	        '#End Region
	    End Sub
	
	End Class



## Smart Undo

The __Workbook__ history offers a friendly API that allows grouping multiple changes into one undo step. For example, 
          you may want to set the value of a cell and apply formatting to the same cell, and treat these two actions as a single undo operation. This 
          can be easily achieved through enclosing the assignments with __BeginUndoGroup()__ and __EndUndoGroup()__ 
          methods. Here is a sample snippet that demonstrates how to create an undo group:
        

#### __C#__

{{region radspreadsheet-model-features-history_1}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            workbook.History.BeginUndoGroup();
	
	            worksheet.Cells[0, 0].SetValue(15);
	            worksheet.Cells[0, 0].SetFormat(new CellValueFormat("0.00"));
	
	            workbook.History.EndUndoGroup();
	
	            workbook.History.Undo();
	            workbook.History.Redo();
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-features-history_1}}
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        workbook.History.BeginUndoGroup()
	
	        worksheet.Cells(0, 0).SetValue(15)
	        worksheet.Cells(0, 0).SetFormat(New CellValueFormat("0.00"))
	
	        workbook.History.EndUndoGroup()
	
	        workbook.History.Undo()
	        workbook.History.Redo()
	        '#End Region
	    End Sub
	
	    Public Shared Sub DisableHistory()
	        '#Region radspreadsheet-model-features-history_2
	        Dim workbook As New Workbook()
	        workbook.History.IsEnabled = False
	        '#End Region
	    End Sub
	
	
	    Public Shared Sub ClearHistory()
	        '#Region radspreadsheet-model-features-history_3
	        Dim workbook As New Workbook()
	        workbook.History.Clear()
	        '#End Region
	    End Sub
	
	End Class



## Enable / Disable History

There are scenarios that do not need the history feature. For example, if you construct an entire document from code behind, you do not need 
          to record each action you perform. In such cases you can disable the history for the workbook via the __IsEnabled__ 
          property of the __WorkbookHistory__ class.
        

#### __C#__

{{region radspreadsheet-model-features-history_2}}
	            Workbook workbook = new Workbook();
	            workbook.History.IsEnabled = false;
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-features-history_2}}
	        Dim workbook As New Workbook()
	        workbook.History.IsEnabled = False
	        '#End Region
	    End Sub
	
	
	    Public Shared Sub ClearHistory()
	        '#Region radspreadsheet-model-features-history_3
	        Dim workbook As New Workbook()
	        workbook.History.Clear()
	        '#End Region
	    End Sub
	
	End Class



## Clear History

To clear the history you just have to call the __Clear()__ method of the __WorkbookHistory__ class. Note that 
          cannot clear the history if you are recording an undo group. If you attempt to call the method after invoking __BeginUndoGroup()__ 
          an exception will be thrown. The following snippet illustrates how to clear workbook’s history.
        

#### __C#__

{{region radspreadsheet-model-features-history_3}}
	            Workbook workbook = new Workbook();
	            workbook.History.Clear();
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-features-history_3}}
	        Dim workbook As New Workbook()
	        workbook.History.Clear()
	        '#End Region
	    End Sub
	
	End Class



# See Also
