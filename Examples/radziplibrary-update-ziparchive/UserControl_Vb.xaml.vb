Imports System.IO
Imports Telerik.Windows.Zip

Namespace RadZipLibraryDocumentationSourceCode.Examples.UpdateZipArchive
	Public Class UserControl_Cs
		Private Sub OpenArchive()
'			#Region "radziplibrary-update-ziparchive_0"
			Using stream As Stream = File.Open("test.zip", FileMode.Open)
				Using archive As New ZipArchive(stream, ZipArchiveMode.Update, False, Nothing)
					' Display the list of the files in the selected zip file using the ZipArchive.Entries property.
				End Using
			End Using
'			#End Region
		End Sub

		Private Sub AddEntry(ByVal archive As ZipArchive)
'			#Region "radziplibrary-update-ziparchive_1"
			Using entry As ZipArchiveEntry = archive.CreateEntry("text.txt")
				Dim writer As New StreamWriter(entry.Open())
				writer.WriteLine("Hello world!")
				writer.Flush()
			End Using
'			#End Region
		End Sub

		Private Sub DeleteEntry(ByVal archive As ZipArchive)
'			#Region "radziplibrary-update-ziparchive_2"
			Dim entry As ZipArchiveEntry = archive.GetEntry("text.txt")
			If entry IsNot Nothing Then
				entry.Delete()
			End If
'			#End Region
		End Sub

		Private Sub UpdateEntry(ByVal archive As ZipArchive)
'			#Region "radziplibrary-update-ziparchive_3"
			Dim entry As ZipArchiveEntry = archive.GetEntry("text.txt")
			If entry IsNot Nothing Then
				Dim entryStream As Stream = entry.Open()
				Dim reader As New StreamReader(entryStream)
				Dim content As String = reader.ReadToEnd()

				entryStream.Seek(0, SeekOrigin.End)
				Dim writer As New StreamWriter(entryStream)
				writer.WriteLine("Updated line.")
				writer.Flush()
			End If
'			#End Region
		End Sub
	End Class
End Namespace