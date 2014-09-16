Public Class Default_Vb

    ' #region gridview-export-troubleshooting-export-string_1
    Private Sub clubsGrid_ElementExporting(sender As Object, e As GridViewElementExportingEventArgs)
        If e.Element = ExportElement.Cell Then
            If column.Header.ToString() = "My String Column" Then
                e.Value = String.Format("=T(""{0}"")", e.Value)
            End If
        End If
    End Sub
' #endregion

End Class
