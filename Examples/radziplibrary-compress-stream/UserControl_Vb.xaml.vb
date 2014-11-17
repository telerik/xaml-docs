Imports System.IO
Imports Telerik.Windows.Zip

Namespace RadZipLibraryDocumentationSourceCode.Examples.CompressStream
	Partial Public Class Default_Cs
		Inherits UserControl

		Private Sub CompressStream(ByVal outputStream As Stream, ByVal inputStream As Stream)
'			#Region "radziplibrary-compress-stream_0"
			Using compressedStream As New CompressedStream(outputStream, StreamOperationMode.Write, New DeflateSettings())
				' write to compressed stream
			End Using
'			#End Region

'			#Region "radziplibrary-compress-stream_1"
			Using compressedStream As New CompressedStream(outputStream, StreamOperationMode.Write, New DeflateSettings())
				inputStream.CopyTo(compressedStream)
				compressedStream.Flush()
			End Using
'			#End Region
		End Sub

		Private Sub DecompressStream(ByVal outputStream As Stream, ByVal inputStream As Stream)
'			#Region "radziplibrary-compress-stream_2"
			Using compressedStream As New CompressedStream(inputStream, StreamOperationMode.Read, New DeflateSettings())
				compressedStream.CopyTo(outputStream)
			End Using
'			#End Region
		End Sub
	End Class
End Namespace