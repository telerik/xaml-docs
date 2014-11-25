Public Class Default_Vb


' #region radupload-how-to-implement-simple-authentication_1
Public Overrides Function SaveChunkData(filePath As String, position As Long, buffer As Byte(), contentLength As Integer, savedBytes As Integer) As Boolean
 Return MyBase.SaveChunkData(filePath, position, buffer, contentLength, savedBytes)
End Function
' #endregion

' #region radupload-how-to-implement-simple-authentication_3
Public Overrides Function SaveChunkData(filePath As String, position As Long, buffer As Byte(), contentLength As Integer, savedBytes As Integer) As Boolean
 Dim authorized As String = Me.GetQueryParameter("Authorized")
 Dim isAuthorized As Boolean = Not String.IsNullOrEmpty(authorized) AndAlso authorized.ToLower() = "true"
 If Not isAuthorized Then
 End If
 Return MyBase.SaveChunkData(filePath, position, buffer, contentLength, savedBytes)
End Function
' #endregion

' #region radupload-how-to-implement-simple-authentication_5
Public Overrides Function SaveChunkData(filePath As String, position As Long, buffer As Byte(), contentLength As Integer, savedBytes As Integer) As Boolean
 Dim authorized As String = Me.GetQueryParameter("Authorized")
 Dim isAuthorized As Boolean = Not String.IsNullOrEmpty(authorized) AndAlso authorized.ToLower() = "true"
 If Not isAuthorized Then
  Me.AddReturnParam(RadUploadConstants.ParamNameMessage, "Security token is required. Please login.")
  Dim fileName As String = Me.GetQueryParameter(RadUploadConstants.ParamNameFileName)
  Me.AddReturnFileParam(RadUploadConstants.ParamNameSuccess, False)
  Me.AddReturnFileParam(RadUploadConstants.ParamNameFileName, fileName)
  Me.AddReturnFileParam(RadUploadConstants.ParamNameFinalFileRequest, True)
  savedBytes = 0
  Return False
 End If
 Return MyBase.SaveChunkData(filePath, position, buffer, contentLength, savedBytes)
End Function
' #endregion
End Class
