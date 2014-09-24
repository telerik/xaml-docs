Public Class Default_Vb
' #region radtimeline-mvvm-support_1
Public Class Product
	Public Property Duration() As TimeSpan
	Public Property [Date]() As Date

	Public Shared Function GetData(ByVal count As Integer) As ObservableCollection(Of Product)
		Dim startDate = New Date(2010, 1, 1)
		Dim endDate = New Date(2012, 2, 1)
		Dim r As New Random()
		Dim result As New ObservableCollection(Of Product)()

		Dim i As Date = startDate
		Do While i < endDate
			result.Add(New Product() With {.Date = i, .Duration = TimeSpan.FromDays(r.Next(50, 100))})
			i = i.AddMonths(1)
		Loop

		For i As Integer = 0 To 14
			result.Add(New Product() With {.Date = startDate.AddMonths(r.Next(0, 25)).AddDays(15)})
		Next i

		Return result
	End Function
End Class
' #endregion

' #region radtimeline-mvvm-support_2
Public Class ExampleViewModel
	Inherits ViewModelBase
		Private _data As ObservableCollection(Of Product)
		Public Property Data() As ObservableCollection(Of Product)
			Get
				Return Me._data
			End Get
			Set(ByVal value As ObservableCollection(Of Product))
				If Me._data IsNot value Then
					Me._data = value
					Me.OnPropertyChanged("Data")
				End If
			End Set
		End Property

		Public Sub New()
			Me.Data = Product.GetData(15)
		End Sub
End Class
' #endregion
End Class
