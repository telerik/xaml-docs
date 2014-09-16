Public Class Default_Vb


' #region radziplibrary-compress-stream_1
Dim zipOutputStream As New ZipOutputStream(memoryStream)
' #endregion

' #region radziplibrary-compress-stream_3
Dim zipOutputStream As New ZipOutputStream(memoryStream, ZipCompression.Deflate64)
' #endregion

' #region radziplibrary-compress-stream_5
Dim inputStream As New ZipInputStream(compressedStream)
' #endregion
End Class
