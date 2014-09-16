Public Class Default_Vb

    ' #region gridview-export-troubleshooting-export-header_2
Private Sub clubsGrid_ElementExporting(sender As Object, e As GridViewElementExportingEventArgs)
        If e.Value IsNot Nothing AndAlso e.Value.[GetType]() = GetType(TextBlock) Then
            e.Value = TryCast(e.Value, TextBlock).Text
        End If
    End Sub
' #endregion

End Class
