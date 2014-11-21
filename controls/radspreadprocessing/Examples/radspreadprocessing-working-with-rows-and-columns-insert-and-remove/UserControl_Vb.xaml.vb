Public Class Default_Vb

    Public Sub InsertRows()
        '#Region radspreadprocessing-working-with-rows-and-columns-insert-and-remove_0
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
        '#Region radspreadprocessing-working-with-rows-and-columns-insert-and-remove_1
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim index As Integer = 2
        Dim itemCount As Integer = 3

        Dim selection As RowSelection = worksheet.Rows(index, index + itemCount)
        selection.Remove()
        '#End Region
    End Sub

    Public Sub InsertColumns()
        '#Region radspreadprocessing-working-with-rows-and-columns-insert-and-remove_2
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
        '#Region radspreadprocessing-working-with-rows-and-columns-insert-and-remove_3
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()

        Dim index As Integer = 2
        Dim itemCount As Integer = 3

        Dim selection As ColumnSelection = worksheet.Columns(index, index + itemCount)
        selection.Remove()
        '#End Region
    End Sub

End Class