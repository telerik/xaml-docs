Public Class Default_Vb


' #region how-to-create-custom-upload_1
Dim upload As New RadUpload()
' get some files from the local system
Dim files As New List(Of FileInfo)()
' add some files 
' . . . 
' insert files in the RadUpload
If files.Count > 0 Then
 For Each file As FileInfo In files
  Dim f As New RadUploadSelectedFile(file)
  upload.CurrentSession.SelectedFiles.Add(f)
 Next
 ' prepare for upload
End If
' #endregion

' #region how-to-create-custom-upload_3
' prepare for upload
upload.PrepareSelectedFilesForUpload()
' #endregion

' #region how-to-create-custom-upload_5
upload.StartUpload()
' #endregion
End Class
