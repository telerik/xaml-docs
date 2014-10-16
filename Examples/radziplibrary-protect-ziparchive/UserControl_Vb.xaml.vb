Imports System.IO
Imports Telerik.Windows.Zip

Namespace RadZipLibraryDocumentationSourceCode.Examples.ProtectZipArchive
	Public Class UserControl_Cs
		Private Sub CreateProtectedArchive()
'			#Region "radziplibrary-protect-ziparchive_0"
			Using stream As Stream = File.Open("test.zip", FileMode.Create)
				Dim encryptionSettings As New DefaultEncryptionSettings()
				encryptionSettings.Password = "password"
				Using archive As New ZipArchive(stream, ZipArchiveMode.Create, False, Nothing, Nothing, encryptionSettings)
					Using entry As ZipArchiveEntry = archive.CreateEntry("text.txt")
						Dim writer As New StreamWriter(entry.Open())
						writer.WriteLine("Hello world!")
						writer.Flush()
					End Using
				End Using
			End Using
'			#End Region

		End Sub

		Private Sub ReadProtectedArchive()
'			#Region "radziplibrary-protect-ziparchive_1"
			Using stream As Stream = File.Open("test.zip", FileMode.Open)
				Dim encryptionSettings As New DefaultEncryptionSettings()
				encryptionSettings.Password = "password"
				Using archive As New ZipArchive(stream, ZipArchiveMode.Read, False, Nothing, Nothing, encryptionSettings)
						' Display the list of the files in the selected zip file using the ZipArchive.Entries property. 
				End Using
'			#End Region
			End Using
		End Sub
	End Class
End Namespace
