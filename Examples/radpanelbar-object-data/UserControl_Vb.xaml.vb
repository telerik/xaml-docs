Partial Public Class App
	Inherits Application

#Region "radpanelbar-object-data_0"
	Dim myListDataSource As New List(Of String)()
	myListDataSource.Add("Item 1")
	myListDataSource.Add("Item 2")
	myListDataSource.Add("Item 3")
	Dim myPanel As New RadPanelBar()
	myPanel.ItemsSource = myListDataSource
#End Region

End Class
#Region "radpanelbar-object-data_1"
Partial Public Class Example
	Inherits UserControl
	Public Sub New()
		InitializeComponent()

		Dim sourceCollection As New List(Of SourceCollection)()

		sourceCollection.Add(New SourceCollection())
		sourceCollection.Add(New SourceCollection())
		sourceCollection.Add(New SourceCollection())
		Dim myPanel As New RadPanelBar()
		myPanel.ItemsSource = sourceCollection

		myPanel.DisplayMemberPath = "Text"
	End Sub
End Class
Public Class SourceCollection
	Private m_number As Random
	Public Sub New()
		m_number = New Random(CInt(DateTime.Now.Ticks))
	End Sub
	Public ReadOnly Property Time() As DateTime
		Get
			Return DateTime.Now
		End Get
	End Property
	Public ReadOnly Property Number() As Integer
		Get
			Return m_number.[Next](0, 1000)
		End Get
	End Property
	Public ReadOnly Property Text() As String
		Get
			' Return a string of 8 random characters from A to Z
			Dim randomText As New System.Text.StringBuilder(8)
			For i As Integer = 0 To 7
				randomText.Append(ChrW(65 + (m_number.NextDouble() * 25)))
			Next
			Return randomText.ToString()
		End Get
	End Property
End Class
#End Region

