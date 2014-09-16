Public Class Default_Vb


    ' #region gridview-pasting_1
    Private Sub radGridView1_Pasting(sender As Object, e As GridViewClipboardEventArgs)
        e.Cancel = True
    End Sub
    
Private Sub radGridView1_PastingCellClipboardContent(sender As Object, e As GridViewCellClipboardEventArgs)
 If e.Cell.Column.UniqueName = "Company" Then
  Dim companyName = e.Value.ToString()
  Dim company = Me.EFContext.Companies.Where(Function(c) c.Name = companyName).FirstOrDefault()
  If company IsNot Nothing Then
   e.Value = company
  Else
   e.Cancel = True
  End If
 End If
End Sub
' #endregion
End Class
