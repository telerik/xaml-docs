Public Class Default_Vb


' #region radtreeview-how-to-get-underlying-on-mouse-move_2
Private Sub radTreeView_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
    Dim element As FrameworkElement = TryCast(e.OriginalSource, FrameworkElement)
    If element IsNot Nothing Then
        While VisualTreeHelper.GetParent(element) IsNot Nothing
            element = TryCast(VisualTreeHelper.GetParent(element), FrameworkElement)
            Dim item As RadTreeViewItem = TryCast(element, RadTreeViewItem)
            If item IsNot Nothing Then
                    ' Perform custom logic here
                    ' You have to return here because otherwise the method will traverse
                    ' the whole visual tree on every mouse move and there will be performance
                    ' implications
                Exit Sub
            End If
        End While
    End If
End Sub
' #endregion
End Class
