Public Class Default_Vb


' #region check-box-support_3
Private Sub EnableCheckBoxes()
    radTreeView.IsOptionElementsEnabled = True
End Sub
' #endregion

' #region check-box-support_6
Private Sub EnableRadioButtons()
    radTreeView.IsOptionElementsEnabled = True
End Sub
' #endregion

' #region check-box-support_9
radTreeView.IsTriStateMode = True
' #endregion

' #region check-box-support_14
Private Sub radTreeView_Checked(ByVal sender As Object, ByVal e As RadRoutedEventArgs)
    TryCast(e.Source, RadTreeViewItem).Foreground = New SolidColorBrush(Colors.Green)
End Sub
' #endregion
End Class
