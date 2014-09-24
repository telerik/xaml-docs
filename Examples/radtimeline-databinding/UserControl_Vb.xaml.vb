Public Class Default_Vb
' #region radtimeline-databinding_0
	Public Class Product
		Public Property Data() As IEnumerable(Of Item)

		Public Property StartDate() As Date
		Public Property EndDate() As Date
	End Class

	Public Class Item
		Public Property Duration() As TimeSpan
		Public Property [Date]() As Date
	End Class
' #endregion

' #region radtimeline-databinding_1
Public Sub New() 'MainWindow in WPF
	InitializeComponent()

	Dim startDate = New Date(2010, 1, 1)
	Dim endDate = New Date(2012, 2, 1)

	Dim items = New List(Of Item)()
	Dim r As New Random()
	Dim i As Date = startDate
	Do While i < endDate
		items.Add(New Item() With {.Date = i, .Duration = TimeSpan.FromDays(r.Next(50, 100))})
		i = i.AddMonths(1)
	Loop

	For i As Integer = 0 To 14
		items.Add(New Item() With {.Date = startDate.AddMonths(r.Next(0, 25)).AddDays(15)})
	Next i

	Me.DataContext = New Product() With {.Data = items, .StartDate = startDate, .EndDate = endDate}
End Sub
' #endregion
End Class
