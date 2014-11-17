Public Class Default_Vb


' #region gridview-access-editing-element_1
Private Sub clubsGrid_PreparingCellForEdit(sender As Object, e As GridViewPreparingCellForEditEventArgs)
 If DirectCast(e.Column.Header, String) = "Name" Then
  Dim tb = TryCast(e.EditingElement, TextBox)
  tb.TextWrapping = TextWrapping.Wrap
 End If
End Sub
' #endregion

' #region gridview-access-editing-element_3
Private Sub clubsGrid_PreparedCellForEdit(sender As Object, e As GridViewPreparingCellForEditEventArgs)
 If DirectCast(e.Column.Header, String) = "Name" Then
  Dim tb = TryCast(e.EditingElement, TextBox)
  tb.SelectionLength = 0
  tb.SelectionStart = tb.Text.Length
 End If
End Sub
' #endregion
End Class
