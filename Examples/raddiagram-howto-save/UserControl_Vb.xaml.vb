 Partial Public Class MainWindow
	  Inherits Window
		Private fileName As String
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub saveButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim fileStream As Stream = Nothing
			Try
				Dim dialog = New SaveFileDialog()
				If dialog.ShowDialog() = True Then
					fileStream = dialog.OpenFile()
					Me.fileName = dialog.FileName
				End If

				Using fileStream
					Dim serializationString = Me.diagram.Save()
					Dim writer = New StreamWriter(fileStream)
					writer.Write(serializationString)
					writer.Flush()
				End Using
			Finally
				If fileStream IsNot Nothing Then
					fileStream.Close()
				End If
			End Try

		End Sub

		Private Sub loadButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim fileStream As Stream = Nothing
			Try
				Dim dialog = New OpenFileDialog()
				dialog.ShowDialog()
				fileStream = dialog.OpenFile()
				Using fileStream
					Dim reader As New StreamReader(fileStream)
					Using reader
						Dim serializedString As String = reader.ReadToEnd()
						Me.diagram.Load(serializedString)
					End Using
				End Using
			Finally
				If fileStream IsNot Nothing Then
					fileStream.Close()
				End If
			End Try
		End Sub
