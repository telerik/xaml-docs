Public Class Default_Vb


' #region radupload-how-to-cancel-delete_1
radUpload.AddHandler(RadUploadItem.PreviewDeleteEvent, New DeleteEventHandler(AddressOf PreviewDelete))
' #endregion

' #region radupload-how-to-cancel-delete_3
Private Sub PreviewDelete(ByVal sender As Object, ByVal e As DeleteEventArgs)
 e.Handled = True
End Sub
' #endregion
End Class
