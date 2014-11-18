Public Class Default_Vb


' #region radupload-features-upload-service-parameters_1
Me.radUpload.AdditionalPostFields.Add( "MyParameter", "MyValue" )
' #endregion

' #region radupload-features-upload-service-parameters_4
private void radUpload_FileUploadStarting( object sender, FileUploadStartingEventArgs e )
{
    if ( e.SelectedFile.File.Extension == ".jpg" )
        e.FileParameters.Add( "MyFileParameter", "MyFileValue" );
}
' #endregion

' #region radupload-features-upload-service-parameters_6
Public Overrides Function SaveChunkData(filePath As String, position As Long, buffer As Byte(), contentLength As Integer, savedBytes As Integer) As Boolean
 Dim myParam As String = Me.GetQueryParameter("MyParameter")
 Return MyBase.SaveChunkData(filePath, position, buffer, contentLength, savedBytes)
End Function
' #endregion

' #region radupload-features-upload-service-parameters_8
Public Overloads Overrides Function GetAssociatedData() As Dictionary(Of String, Object)
 Dim associatedData As Dictionary(Of String, Object) = MyBase.GetAssociatedData()
 If Me.IsFinalFileRequest() Then
  associatedData.Add("MyReturnParam", "MyValue")
 End If
 Return associatedData
End Function
' #endregion

' #region radupload-features-upload-service-parameters_11
Private Sub radUpload_FileUploaded(sender As Object, e As FileUploadedEventArgs)
 Dim value As var = e.HandlerData.CustomData("MyReturnParam")
End Sub
' #endregion
End Class
