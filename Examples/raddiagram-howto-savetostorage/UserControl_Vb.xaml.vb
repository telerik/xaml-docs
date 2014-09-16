Partial Public Class MainPage
	Inherits UserControl
		Private Shared folderName As String = "Diagrams"
		Private Shared fileName As String = "StoreDiagram"
		Private Shared ReadOnly Property FullName() As String
			Get
				Return folderName & "\" & fileName
			End Get
		End Property
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub saveButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Using store = IsolatedStorageFile.GetUserStoreForApplication()
				If Not store.DirectoryExists(folderName) Then
					store.CreateDirectory(folderName)
				End If

				Using isoStream = store.OpenFile(FullName, FileMode.OpenOrCreate)
					Dim serializationString = Me.diagram.Save()
					Dim writer = New StreamWriter(isoStream)
					writer.Write(serializationString)
					writer.Flush()
				End Using
			End Using
		End Sub

		Private Sub loadButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Using store = IsolatedStorageFile.GetUserStoreForApplication()
				If store.FileExists(FullName) Then
					Using isoStream = store.OpenFile(FullName, FileMode.Open)
						If isoStream IsNot Nothing Then
							Dim reader = New StreamReader(isoStream)
							Dim stringRead = reader.ReadToEnd()
							Me.diagram.Load(stringRead)
						End If
					End Using
				End If
			End Using
		End Sub
