Public Class Default_Vb


' #region raddatapager-how-to-interact-with-with-user-before-page-changes_2
Private myCondition As Boolean
Private Sub radDataPager_PageIndexChanging(sender As Object, e As PageIndexChangingEventArgs)
 If myCondition Then
  Dim result As MessageBoxResult = MessageBox.Show("There is unsaved data! Are you sure you want to continue?", "Confirm", MessageBoxButton.OKCancel)
  If result = MessageBoxResult.Cancel Then
   e.Cancel = True
  End If
 End If
End Sub
' #endregion
End Class
