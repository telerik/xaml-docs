Public Class Default_Vb


' #region radupload-how-to-personalize-the-file-storage_1
Private authorized As Boolean = False
Private accountName As String = String.Empty
Private Sub PrepareAccountSession()
 Dim dataAuthorized As String = Me.GetQueryParameter("Authorized")
 Me.authorized = Not String.IsNullOrEmpty(dataAuthorized) AndAlso dataAuthorized.ToLower() = "true"
 Me.accountName = Me.GetQueryParameter("Account")
 If Not Me.authorized OrElse String.IsNullOrEmpty(Me.accountName) Then
  Me.accountName = "Anonymous"
 End If
End Sub
' #endregion

' #region radupload-how-to-personalize-the-file-storage_3
Public Overloads Overrides Function GetTargetFolder() As String
 Dim path As String = MyBase.GetTargetFolder()
 If Not String.IsNullOrEmpty(Me.accountName) Then
  path += Path.DirectorySeparatorChar + Me.accountName
 End If
 Return path
End Function
' #endregion

' #region radupload-how-to-personalize-the-file-storage_5
Private Function PrepareStorageFolder() As Boolean
 Dim folderPath As String = Me.GetTargetFolder()
 If Not Directory.Exists(folderPath) Then
  Directory.CreateDirectory(folderPath)
 End If
 Return Directory.Exists(folderPath)
End Function
' #endregion

' #region radupload-how-to-personalize-the-file-storage_7
Public Overrides Function SaveChunkData(filePath__1 As String, position As Long, buffer As Byte(), contentLength As Integer, ByRef savedBytes As Integer) As Boolean
	Dim result As Boolean
	Me.PrepareAccountSession()
	If Not Me.PrepareStorageFolder() Then
		result = False
	End If
	Dim FilePath__2 As String = Me.GetFilePath()
	result = MyBase.SaveChunkData(FilePath__2, position, buffer, contentLength, savedBytes)
	Return result
End Function
' #endregion
End Class
