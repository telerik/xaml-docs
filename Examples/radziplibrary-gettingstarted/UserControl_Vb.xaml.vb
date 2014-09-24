Public Class Default_Vb


' #region radziplibrary-gettingstarted_2
Private Sub buttonOpen_Click(sender As Object, e As RoutedEventArgs)
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Zip File | *.zip"
        Dim dialogResult As System.Nullable(Of Boolean) = dialog.ShowDialog()
End Sub
' #endregion

' #region radziplibrary-gettingstarted_4
If dialogResult = True Then
        Dim stream As Stream = dialog.File.OpenRead()
                        'display the list of files compressed in the selected zip file using the zipPackage.ZipPackageEntries
        Using _zipPackage As ZipPackage = ZipPackage.Open(stream, FileAccess.Read)
        End Using
End If
' #endregion

' #region radziplibrary-gettingstarted_6
Private Sub buttonOpen_Click(sender As Object, e As RoutedEventArgs)
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Zip File | *.zip"
        Dim dialogResult As System.Nullable(Of Boolean) = dialog.ShowDialog()
        If dialogResult = True Then
                Dim stream As Stream = dialog.OpenFile()
                Using _zipPackage As ZipPackage = ZipPackage.Open(stream, FileAccess.Read)
                        'display the list of files compressed in the selected zip file using the zipPackage.ZipPackageEntries
                End Using
        End If
End Sub
' #endregion

' #region radziplibrary-gettingstarted_9
Private Sub buttonOpen_Click(sender As Object, e As RoutedEventArgs)
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Zip File | *.zip"
        Dim dialogResult As System.Nullable(Of Boolean) = dialog.ShowDialog()
        If dialogResult = True Then
                Dim stream As Stream = dialog.File.OpenRead()
                Using _zipPackage As ZipPackage = ZipPackage.Open(stream, FileAccess.Read)
                        FileList.ItemsSource = _zipPackage.ZipPackageEntries
                End Using
        End If
End Sub
' #endregion

' #region radziplibrary-gettingstarted_11
Private Sub buttonOpen_Click(sender As Object, e As RoutedEventArgs)
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Zip File | *.zip"
        Dim dialogResult As System.Nullable(Of Boolean) = dialog.ShowDialog()
        If dialogResult = True Then
                Dim stream As Stream = dialog.OpenFile()
                Using _zipPackage As ZipPackage = ZipPackage.Open(stream, FileAccess.Read)
                        FileList.ItemsSource = _zipPackage.ZipPackageEntries
                End Using
        End If
End Sub
' #endregion

' #region radziplibrary-gettingstarted_13
Public Class DataFile
	Public Property FileStream() As MemoryStream
		Get
			Return m_FileStream
		End Get
		Set
			m_FileStream = Value
		End Set
	End Property
	Private m_FileStream As MemoryStream
	Public Property FileName() As String
		Get
			Return m_FileName
		End Get
		Set
			m_FileName = Value
		End Set
	End Property
	Private m_FileName As String
End Class
' #endregion

' #region radziplibrary-gettingstarted_16
Private Sub buttonSave_Click(sender As Object, e As RoutedEventArgs)
	Dim dialog As New SaveFileDialog()
	dialog.Filter = "Zip File | *.zip"
	Dim dialogResult As System.Nullable(Of Boolean) = dialog.ShowDialog()
	If dialogResult = True Then
		Using zipPackage__1 As ZipPackage = ZipPackage.Create(dialog.OpenFile())
			For Each file As DataFile In SelectedFiles
				zipPackage__1.AddStream(file.FileName, file.FileStream)
			Next
		End Using
	End If
End Sub
' #endregion
End Class
