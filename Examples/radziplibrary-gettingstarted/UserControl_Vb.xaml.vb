Imports System.IO
Imports Telerik.Windows.Zip

Namespace RadZipLibraryDocumentationSourceCode.Examples.GettingStarted
	Partial Public Class Default_Cs
		Inherits UserControl

		Private Sub OpenArchive()
'			#Region "radziplibrary-gettingstarted_16"
			Using stream As Stream = File.Open("test.zip", FileMode.Open)
				Using archive As New ZipArchive(stream)
					' Display the list of the files in the selected zip file using the ZipArchive.Entries property.
				End Using
			End Using
'			#End Region
		End Sub

		Private Sub CreateArchive()
'			#Region "radziplibrary-gettingstarted_17"
			Using stream As Stream = File.Open("test.zip", FileMode.Create)
				Using archive As New ZipArchive(stream, ZipArchiveMode.Create, False, Nothing)
					Using entry As ZipArchiveEntry = archive.CreateEntry("text.txt")
						Dim writer As New StreamWriter(entry.Open())
						writer.WriteLine("Hello world!")
						writer.Flush()
					End Using
				End Using
			End Using
'			#End Region
		End Sub
	End Class
End Namespace