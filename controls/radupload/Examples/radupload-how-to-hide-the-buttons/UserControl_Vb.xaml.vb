Public Class Default_Vb


' #region radupload-how-to-hide-the-buttons_1
Private Sub radUpload_FilesSelected(sender As Object, e As Telerik.Windows.Controls.FilesSelectedEventArgs)
 Dim uploadButton As Button = Me.radUpload.ChildrenOfType(Of Button)().Where(Function(b As ) b.Name.Equals("UploadButton")).FirstOrDefault()
 Dim cancelButton As Button = Me.radUpload.ChildrenOfType(Of Button)().Where(Function(b As ) b.Name.Equals("CancelButton")).FirstOrDefault()
 If uploadButton <> Nothing Then
  uploadButton.Opacity = 0
  uploadButton.IsHitTestVisible = False
 End If
 If cancelButton <> Nothing Then
  cancelButton.Opacity = 0
  cancelButton.IsHitTestVisible = False
 End If
End Sub
' #endregion
End Class
