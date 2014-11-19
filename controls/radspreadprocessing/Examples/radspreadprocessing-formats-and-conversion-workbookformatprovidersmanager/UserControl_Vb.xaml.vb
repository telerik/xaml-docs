Public Class Default_Vb
    Private Sub RegisterXlsxFormatProvider()
        '#Region radspreadsheet-model-import-export-format-providers-manager_0
        WorkbookFormatProvidersManager.RegisterFormatProvider(New XlsxFormatProvider())
        '#End Region
    End Sub

    Private Sub UnregisterTxtFormatProvider()
        '#Region radspreadsheet-model-import-export-format-providers-manager_1
        Dim provider As IWorkbookFormatProvider = WorkbookFormatProvidersManager.GetProviderByName("TxtFormatProvider")
        If provider IsNot Nothing Then
            WorkbookFormatProvidersManager.UnregisterFormatProvider(provider)
        End If
        '#End Region
    End Sub

    Private Sub Import()
        '#Region radspreadsheet-model-import-export-format-providers-manager_2
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = FileDialogsHelper.GetOpenFileDialogFilter()
        If openFileDialog.ShowDialog() = True Then
            Try
                Dim extension As String = Path.GetExtension(openFileDialog.GetFileName())
                Using input As Stream = openFileDialog.OpenFileStream()
                    editor.Owner.Workbook = WorkbookFormatProvidersManager.Import(extension, input)
                End Using
            Catch ex As IOException
                Throw New IOException("The file cannot be opened. It might be locked by another application.", ex)
            End Try
        End If
        '#End Region
#If silverlight Then
        '#Region radspreadsheet-model-import-export-format-providers-manager_4
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = FileDialogsHelper.GetOpenFileDialogFilter()
        If openFileDialog.ShowDialog() = True Then
            Try
                Dim extension As String = Path.GetExtension(openFileDialog.File.Name);
                Using input As Stream = openFileDialog.File.OpenRead())
                    editor.Owner.Workbook = WorkbookFormatProvidersManager.Import(extension, input)
                End Using
            Catch ex As IOException
                Throw New IOException("The file cannot be opened. It might be locked by another application.", ex)
            End Try
        End If
        '#End Region
#End If
    End Sub

    Private Sub ExportCsvCustomDelimiter()
        '#Region radspreadsheet-model-import-export-format-providers-manager_3
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = FileDialogsHelper.GetSaveFileDialogFilter()

        If saveFileDialog.ShowDialog() = True Then
            Dim extension As String = Path.GetExtension(saveFileDialog.SafeFileName)
            Using output As Stream = saveFileDialog.OpenFile()
                WorkbookFormatProvidersManager.Export(editor.Owner.Workbook, extension, output)
            End Using
        End If

        '#End Region
    End Sub
End Class
