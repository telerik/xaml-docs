Public Class Default_Vb


' #region radupload-how-to-rename-a-file_1
Private counter As Integer = 1
Private Sub radUpload_FileUploadStarting(sender As Object, e As FileUploadStartingEventArgs)
 Dim newFileName As String = "MyCustomFileName" + counter + e.SelectedFile.File.Extension
 e.UploadData.FileName = newFileName
 counter += 1
End Sub
' #endregion

' #region radupload-how-to-rename-a-file_3
Private counter As Integer = 1
Public Overloads Overrides Function GetFilePath(fileName As String) As String
 Dim newFileName As String = "MyCustomFileName" + counter + fileName.Substring(fileName.LastIndexOf("."C))
 Return MyBase.GetFilePath(newFileName)
End Function
' #endregion
End Class
