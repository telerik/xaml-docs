Public Class Default_Vb


' #region radupload-how-to-redirect-to-page-from-server_1
Public Overrides Function GetAssociatedData() As Dictionary(Of String, Object)
 Dim associatedData As Dictionary(Of String, Object) = MyBase.GetAssociatedData()
 If Me.IsFinalFileRequest() Then
  associatedData.Add(RadUploadConstants.RedirectPage, "http://www.google.com")
 End If
 Return associatedData
End Function
' #endregion
End Class
