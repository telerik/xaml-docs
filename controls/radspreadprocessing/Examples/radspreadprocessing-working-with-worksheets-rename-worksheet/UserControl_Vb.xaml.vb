Public Class Default_Vb

    Public Sub RenameSingleWorksheet()
        '#Region radspreadprocessing-working-with-worksheets-rename-worksheet_0
        Dim workbook As New Workbook()
        Dim worksheet As Worksheet = workbook.Worksheets.Add()
        worksheet.Name = "Sam's Worksheet"
        '#End Region
    End Sub

    Public Sub RenameWorksheet()
        '#Region radspreadprocessing-working-with-worksheets-rename-worksheet_1
        Dim workbook As New Workbook()
        workbook.Worksheets.Add()
        workbook.Worksheets.Add()

        Dim newWorksheetName As String = "July's Worksheet"
        Dim indexOfWorksheetToRename As Integer = 0

        Dim index As Integer = Me.radSpreadsheet.Workbook.Worksheets.IndexOf(newWorksheetName)

        If index = -1 OrElse index = indexOfWorksheetToRename Then
            workbook.Worksheets(indexOfWorksheetToRename).Name = newWorksheetName
        Else
            ' There already exists worksheet with this name
        End If
        '#End Region
    End Sub

End Class