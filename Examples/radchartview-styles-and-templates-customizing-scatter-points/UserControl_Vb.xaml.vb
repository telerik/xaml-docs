Public Class UserControl_Vb


#region radchartview-styles-and-templates-customizing-scatter-points_2
 Public Class ChartData
	Private ReadOnly Red As Brush = New SolidColorBrush(Colors.Red)
	Private ReadOnly Orange As Brush = New SolidColorBrush(Colors.Orange)
	Private ReadOnly Green As Brush = New SolidColorBrush(Colors.Green)

	Public Sub New(ByVal x As Double, ByVal y As Double)
		Me.XValue = x
		Me.YValue = y
	End Sub

	Public Property XValue() As Double
	Public Property YValue() As Double

	Public ReadOnly Property Brush() As Brush
		Get
			If Me.YValue < 102 Then
				Return Red
			ElseIf Me.YValue < 105 Then
				Return Orange
			Else
				Return Green
			End If
		End Get
	End Property
 End Class
#endregion

#region radchartview-styles-and-templates-customizing-scatter-points_4
Public Class ViewModel
	Inherits ViewModelBase
		Private data As List(Of ChartData)

		Public Sub New()
			Me.Data = Me.GetData()
		End Sub

		Public Property Data() As List(Of ChartData)
			Get
				Return Me.data
			End Get
			Set(ByVal value As List(Of ChartData))
				If Me.data IsNot value Then
					Me.data = value
					Me.OnPropertyChanged("Data")
				End If
			End Set
		End Property

		Private Function GetData() As List(Of ChartData)
			Dim data As New List(Of ChartData)()
			data.Add(New ChartData(0.1, 100))
			data.Add(New ChartData(0.1, 101))
			data.Add(New ChartData(11, 106))
			data.Add(New ChartData(101, 104))
			data.Add(New ChartData(101, 108))
			Return data
		End Function
End Class
#endregion

#region radchartview-styles-and-templates-customizing-scatter-points_6
'NOTE: This code snippet uses implicit typing. You will need to set 'Option Infer On' in the VB file or set 'Option Infer' at the project level:

  Public Class ScatterPointTemplateSelector
	  Inherits DataTemplateSelector
		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim scatterPoint = DirectCast(item, ScatterDataPoint)
            Dim itemIndex = scatterPoint.Index
			Dim series = TryCast(container, ScatterPointSeries)
			Dim dataPoint = series.DataPoints(itemIndex)
			Dim chart = series.GetVisualParent(Of RadCartesianChart)()
			If dataPoint.YValue > 105 Then
				Return TryCast(chart.Resources("ellipseTemplate"), DataTemplate)
			Else
				Return TryCast(chart.Resources("rectangleTemplate"), DataTemplate)
			End If
		End Function
  End Class
#endregion
End Class
