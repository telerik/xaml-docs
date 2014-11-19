Public Class Default_Vb

    '#Region radspreadprocessing-working-with-worksheets-activate-worksheet_0
    Public Sub ActivateWorksheetDemo()
        Dim workbook As New Workbook()

        AddHandler workbook.ActiveSheetChanged, AddressOf Me.Workbook_ActiveSheetChanged

        workbook.Worksheets.Add()
        workbook.Worksheets.Add()

        workbook.ActiveWorksheet = workbook.Worksheets(1)
    End Sub

    Private Sub Workbook_ActiveSheetChanged(sender As Object, e As EventArgs)
        ' the active worksheet is changed
    End Sub
    '#End Region

End Class