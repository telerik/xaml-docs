Public Class Default_Vb


' #region radchart-styling-and-appearance-custom-item-style_1
Public Sub New()
 InitializeComponent()
 Me.radChart.CreateItemStyleDelegate = Me.BuildCustomItemStyle
End Sub
Public Function BuildCustomItemStyle(item As Control, style As Style, point As DataPoint, dataSeries As DataSeries) As Style
 Dim newStyle As New Style()
 newStyle.BasedOn = style
 Return style
End Function
' #endregion

' #region radchart-styling-and-appearance-custom-item-style_3
Partial Public Class MainPage
Inherits UserControl
Public Sub New()
InitializeComponent()
Dim maxItems As Integer = 10
Dim r As New Random()
Dim sampleData As New List(Of Company)()
For i As Integer = 0 To maxItems - 1
sampleData.Add(New Company(r.Next(200, 400)))
Next i
Dim seriesMapping As New SeriesMapping()
seriesMapping.LegendLabel = "My Custom Bars"
seriesMapping.SeriesDefinition = New BarSeriesDefinition()
seriesMapping.ItemMappings.Add(New ItemMapping("PurchasePrice", DataPointMember.YValue))
RadChart1.ItemsSource = sampleData
RadChart1.SeriesMappings.Add(seriesMapping)
Me.RadChart1.CreateItemStyleDelegate = AddressOf BuildCustomItemStyle
End Sub
Public Class Company
Public Property PurchasePrice() As Double
Public Sub New(ByVal price As Double)
PurchasePrice = price
End Sub
End Class
Public Function BuildCustomItemStyle(ByVal item As Control, ByVal style As Style, ByVal point As DataPoint, ByVal dataSeries As DataSeries) As Style
Dim newStyle As New Style(style.TargetType)
newStyle.BasedOn = style
Dim brush As Brush
If TypeOf item Is BaseChartItem Then
If dataSeries((TryCast(item, BaseChartItem)).CurrentIndex).YValue > 300 Then
brush = New SolidColorBrush(Colors.Red)
Else
brush = New SolidColorBrush(Colors.Green)
End If
newStyle.Setters.Add(New Setter(Shape.FillProperty, brush))
End If
If TypeOf item Is SeriesItemLabel Then
If (TryCast(item, SeriesItemLabel)).DataPoint.YValue > 300 Then
brush = New SolidColorBrush(Colors.Red)
Else
brush = New SolidColorBrush(Colors.Green)
End If
newStyle.Setters.Add(New Setter(SeriesItemLabel.FillProperty, brush))
newStyle.Setters.Add(New Setter(SeriesItemLabel.StrokeProperty, brush))
End If
If TypeOf item Is ChartLegendItem Then
brush = TryCast(Me.Resources("LegendItemStyle"), Brush)
newStyle.Setters.Add(New Setter(Path.FillProperty, brush))
End If
Return newStyle
End Function
End Class
' #endregion
End Class
