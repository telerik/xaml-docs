Public Class Default_Vb


' #region gridview-copying_1
Me.radGridView.ClipboardCopyMode = GridViewClipboardCopyMode.Cells Or GridViewClipboardCopyMode.Header
' #endregion

' #region gridview-copying_3
Private Sub radGridView_CopyingCellClipboardContent(sender As Object, e As GridViewCellClipboardEventArgs)
 If e.Cell.Column.UniqueName = "FullName" Then
  Dim person = TryCast(e.Cell.Item, Person)
  e.Value = String.Format("{0} {1} {2}", person.FirstName, person.MiddleName, person.MiddleName)
 End If
End Sub
' #endregion
End Class
