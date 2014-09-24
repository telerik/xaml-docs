Public Class Default_Vb

    Public Sub RetrievingTheActiveCellAndAllSelectedCellsExample()
        '#Region radspreadsheet-ui-working-with-selection_0
        Dim selection As Selection = Me.radSpreadsheet.ActiveWorksheetEditor.Selection

        selection.ActiveCellMode = ActiveCellMode.Edit
        '#End Region
    End Sub

    Public Sub ChangingTheUISelection1()
        '#Region radspreadsheet-ui-working-with-selection_1
        Dim selection As Selection = Me.radSpreadsheet.ActiveWorksheetEditor.Selection

        selection.[Select](New CellIndex(0, 0), False)
        '#End Region
    End Sub

    Public Sub ChangingTheUISelection2()
        '#Region radspreadsheet-ui-working-with-selection_2
        Dim selection As Selection = Me.radSpreadsheet.ActiveWorksheetEditor.Selection

        selection.[Select](New CellRange(0, 0, 2, 2))
        '#End Region
    End Sub

    Public Sub ChangingTheUISelection3()
        '#Region radspreadsheet-ui-working-with-selection_3
        Dim selection As Selection = Me.radSpreadsheet.ActiveWorksheetEditor.Selection

        selection.[Select](6, 1, 2, 4)
        '#End Region
    End Sub

    Public Sub SelectingAllCellsInAWorksheet()
        '#Region radspreadsheet-ui-working-with-selection_4
        Dim selection As Selection = Me.radSpreadsheet.ActiveWorksheetEditor.Selection

        selection.SelectAll()

        Dim usedRange As CellRange = Me.radSpreadsheet.ActiveWorksheet.UsedCellRange
        selection.[Select](usedRange)
        '#End Region
    End Sub

    Public Sub SelectionEvents()
        '#Region radspreadsheet-ui-working-with-selection_5
        Dim selection As Selection = Me.radSpreadsheet.ActiveWorksheetEditor.Selection

        selection.BeginUpdate()

        selection.[Select](New CellRange(4, 3, 8, 5))
        selection.[Select](New CellRange(5, 2, 3, 3), clearSelection:=False)
        selection.[Select](New CellIndex(2, 1), clearSelection:=False)

        selection.EndUpdate()
        '#End Region
    End Sub

    Public Sub SavingAndRestoringTheUISelection()
        '#Region radspreadsheet-ui-working-with-selection_6
        Dim selection As Selection = Me.radSpreadsheet.ActiveWorksheetEditor.Selection

        selection.[Select](New CellRange(4, 3, 8, 5))

        Dim selectionState As SelectionState = selection.CreateSelectionState()

        selection.[Select](New CellRange(5, 2, 3, 3), clearSelection:=False)
        selection.[Select](New CellIndex(2, 1), clearSelection:=False)

        selection.RestoreSelectionState(selectionState)
        '#End Region
    End Sub

End Class