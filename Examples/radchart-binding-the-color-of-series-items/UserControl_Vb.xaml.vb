Public Class UserControl_Vb

' #region radchartview-populating-with-data-binding-the-color-of-series-items_0
Public Class ChartData
	Implements INotifyPropertyChanged
	Private _category As String
	Public Property Category() As String
		Get
			Return Me._category
		End Get
		Set
			Me._category = value
			Me.OnPropertyChanged("Category")
		End Set
	End Property

	Private _value As Double
	Public Property Value() As Double
		Get
			Return Me._value
		End Get
		Set
			Me._value = value
			Me.OnPropertyChanged("Value")
		End Set
	End Property

	Private _color As Brush
	Public Property Color() As Brush
		Get
			Return Me._color
		End Get
		Set
			Me._color = value
			Me.OnPropertyChanged("Color")
		End Set
	End Property

	Public Event PropertyChanged As PropertyChangedEventHandler
	Private Sub OnPropertyChanged(propertyName As String)
		RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
	End Sub
End Class
' #endregion

' #region radchartview-populating-with-data-binding-the-color-of-series-items_1
Public Sub New()
	InitializeComponent()
	DataContext = GetData(12)
End Sub

Public Shared Function GetData(dataSize As Integer) As List(Of ChartData)
	Dim rnd As New Random()
	Dim result = New List(Of ChartData)()

	For i As Integer = 0 To dataSize - 1
		result.Add(New ChartData() With { _
			.Category = i, _
			.Value = rnd.[Next](1, 100), _
			.Color = New SolidColorBrush(Color.FromArgb(255, CByte(rnd.[Next](0, 256)), CByte(rnd.[Next](0, 256)), CByte(rnd.[Next](0, 256)))) _
		})
	Next

	Return result
End Function
' #endregion

' #region radchartview-populating-with-data-binding-the-color-of-series-items_2
Public Class CustomSelector
	Inherits StyleSelector
	Public Overrides Function SelectStyle(item As Object, container As DependencyObject) As Style
		Dim dataPoint = TryCast(item, PieDataPoint)
		Dim dataItem = TryCast(dataPoint.DataItem, ChartData)

		Dim style As New Style(GetType(Path))
		style.Setters.Add(New Setter(Path.FillProperty, dataItem.Color))
		style.Setters.Add(New Setter(Path.StrokeProperty, New SolidColorBrush(Colors.White)))

		Return style
	End Function
End Class
' #endregion

End Class
