Public Class Default_Vb


' #region raddocking-save-load-the-content-of-the-panes_3
    Private Sub radDocking_ElementLoaded(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.LayoutSerializationLoadingEventArgs)
        Dim pane = TryCast(e.AffectedElement, RadPane)
        If pane IsNot Nothing Then
            pane.Content = Me.GetPaneContent(e.AffectedElementSerializationTag)
        End If
    End Sub
' #endregion
End Class
