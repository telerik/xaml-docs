---
title: Insert and Remove Rows and Columns
page_title: Insert and Remove Rows and Columns
description: Insert and Remove Rows and Columns
slug: radspreadsheet-model-working-with-rows-and-columns-insert-and-remove
tags: insert,and,remove,rows,and,columns
published: False
position: 1
---

# Insert and Remove Rows and Columns



Worksheets in __RadSpreadsheet__'s document model consist of cells organized in rows and columns. Each worksheet allows you to
        insert and remove rows and columns through shifting the contents of the surrounding rows and columns. This article demonstrates how to insert and
        remove rows and columns.
      

## Insert Rows

In order to insert rows, you need to create a __RowSelection__ instance that indicates where the new rows are to be inserted in 
          the worksheet. Whenever rows insertion is performed, all values that appear down of the __RowSelection__ region including the 
          selected region are shifted down, thus, causing no loss of data.
        

The __RowSelection__ class exposes __CanInsert()__ and __Insert()__ methods that 
          indicate whether the insert is possible and perform the insert operation respectively. The following example shows how to insert rows using the two 
          methods:
        

#### __C#__

{{region radspreadsheet-model-working-with-rows-and-columns-insert-and-remove_0}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            int index = 2;
	            int itemCount = 3;
	
	            if (worksheet.Rows.CanInsert(index, itemCount))
	            {
	                RowSelection selection = worksheet.Rows[index, index + itemCount];
	                selection.Insert();
	            }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-rows-and-columns-insert-and-remove_0}}
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim index As Integer = 2
	        Dim itemCount As Integer = 3
	
	        If worksheet.Rows.CanInsert(index, itemCount) Then
	            Dim selection As RowSelection = worksheet.Rows(index, index + itemCount)
	            selection.Insert()
	        End If
	        '#End Region
	    End Sub
	
	    Public Sub RemoveRows()
	        '#Region radspreadsheet-model-working-with-rows-and-columns-insert-and-remove_1
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim index As Integer = 2
	        Dim itemCount As Integer = 3
	
	        Dim selection As RowSelection = worksheet.Rows(index, index + itemCount)
	        selection.Remove()
	        '#End Region
	    End Sub
	
	    Public Sub InsertColumns()
	        '#Region radspreadsheet-model-working-with-rows-and-columns-insert-and-remove_2
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim index As Integer = 2
	        Dim itemCount As Integer = 3
	
	        If worksheet.Columns.CanInsert(index, itemCount) Then
	            Dim selection As ColumnSelection = worksheet.Columns(index, index + itemCount)
	            selection.Insert()
	        End If
	        '#End Region
	    End Sub
	
	    Public Sub RemoveColumns()
	        '#Region radspreadsheet-model-working-with-rows-and-columns-insert-and-remove_3
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim index As Integer = 2
	        Dim itemCount As Integer = 3
	
	        Dim selection As ColumnSelection = worksheet.Columns(index, index + itemCount)
	        selection.Remove()
	        '#End Region
	    End Sub
	
	End Class



## Remove Rows

In order to remove rows, you need to create a __RowSelection__ instance that specifies the region of rows you would like to 
          remove. Whenever you remove rows, all values that appear down of the __RowSelection__ region are shifted up.
        

The __RowSelection__ class exposes a __Remove()__ method that performs the removal of the selected rows. 
          The following example shows how to remove rows:
        

#### __C#__

{{region radspreadsheet-model-working-with-rows-and-columns-insert-and-remove_1}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            int index = 2;
	            int itemCount = 3;
	
	            RowSelection selection = worksheet.Rows[index, index + itemCount];
	            selection.Remove();
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-rows-and-columns-insert-and-remove_1}}
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim index As Integer = 2
	        Dim itemCount As Integer = 3
	
	        Dim selection As RowSelection = worksheet.Rows(index, index + itemCount)
	        selection.Remove()
	        '#End Region
	    End Sub
	
	    Public Sub InsertColumns()
	        '#Region radspreadsheet-model-working-with-rows-and-columns-insert-and-remove_2
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim index As Integer = 2
	        Dim itemCount As Integer = 3
	
	        If worksheet.Columns.CanInsert(index, itemCount) Then
	            Dim selection As ColumnSelection = worksheet.Columns(index, index + itemCount)
	            selection.Insert()
	        End If
	        '#End Region
	    End Sub
	
	    Public Sub RemoveColumns()
	        '#Region radspreadsheet-model-working-with-rows-and-columns-insert-and-remove_3
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim index As Integer = 2
	        Dim itemCount As Integer = 3
	
	        Dim selection As ColumnSelection = worksheet.Columns(index, index + itemCount)
	        selection.Remove()
	        '#End Region
	    End Sub
	
	End Class



## Insert Columns

In order to insert columns, you need to create a __ColumnSelection__ instance that specifies where the new columns are to be 
          inserted in the worksheet. Whenever columns insertion is performed, all values that appear to the right of the __ColumnSelection__ 
          region including the selected region are shifted right, thus, causing no loss of data.
        

The __ColumnSelection__ class exposes __CanInsert()__ and __Insert()__ methods that 
          indicate whether the insert is possible and the perform the insert operation respectively. The following example shows how to insert columns using the 
          two methods:
        

#### __C#__

{{region radspreadsheet-model-working-with-rows-and-columns-insert-and-remove_2}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            int index = 2;
	            int itemCount = 3;
	
	            if (worksheet.Columns.CanInsert(index, itemCount))
	            {
	                ColumnSelection selection = worksheet.Columns[index, index + itemCount];
	                selection.Insert();
	            }
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-rows-and-columns-insert-and-remove_2}}
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim index As Integer = 2
	        Dim itemCount As Integer = 3
	
	        If worksheet.Columns.CanInsert(index, itemCount) Then
	            Dim selection As ColumnSelection = worksheet.Columns(index, index + itemCount)
	            selection.Insert()
	        End If
	        '#End Region
	    End Sub
	
	    Public Sub RemoveColumns()
	        '#Region radspreadsheet-model-working-with-rows-and-columns-insert-and-remove_3
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim index As Integer = 2
	        Dim itemCount As Integer = 3
	
	        Dim selection As ColumnSelection = worksheet.Columns(index, index + itemCount)
	        selection.Remove()
	        '#End Region
	    End Sub
	
	End Class



## Remove Columns

In order to remove columns, you need to create a __ColumnSelection__ instance that indicates the region of columns you would like 
          to remove. Whenever you remove columns, all values that appear to the right of the __ColumnSelection__ region are shifted to the 
          left.
        

The __ColumnSelection__ class exposes a __Remove()__ method that executes the removal of the selected rows. 
          The following example illustrates how to remove rows:
        

#### __C#__

{{region radspreadsheet-model-working-with-rows-and-columns-insert-and-remove_3}}
	            Workbook workbook = new Workbook();
	            Worksheet worksheet = workbook.Worksheets.Add();
	
	            int index = 2;
	            int itemCount = 3;
	
	            ColumnSelection selection = worksheet.Columns[index, index + itemCount];
	            selection.Remove();
	{{endregion}}



#### __VB__

{{region radspreadsheet-model-working-with-rows-and-columns-insert-and-remove_3}}
	        Dim workbook As New Workbook()
	        Dim worksheet As Worksheet = workbook.Worksheets.Add()
	
	        Dim index As Integer = 2
	        Dim itemCount As Integer = 3
	
	        Dim selection As ColumnSelection = worksheet.Columns(index, index + itemCount)
	        selection.Remove()
	        '#End Region
	    End Sub
	
	End Class



# See Also
