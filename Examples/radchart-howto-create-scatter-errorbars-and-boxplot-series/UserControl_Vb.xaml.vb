Public Class Default_Vb


' #region radchart-howto-create-scatter-errorbars-and-boxplot-series_2
Partial Public Class MainPage
Inherits UserControl
Public Sub New()
InitializeComponent()
Dim series As New DataSeries()
series.Definition = New CustomCandleStickSeriesDefinition() With {.ItemStyle = TryCast(Me.LayoutRoot.Resources("CustomCandleStickStyle"), Style)}
series.Add(New DataPoint() With {.Open = 10, .High = 30, .Low = 5, .Close = 15})
series.Add(New DataPoint() With {.Open = 15, .High = 40, .Low = 10, .Close = 20})
series.Add(New DataPoint() With {.Open = 20, .High = 35, .Low = 15, .Close = 30})
series.Add(New DataPoint() With {.Open = 10, .High = 25, .Low = 5, .Close = 18})
series.Add(New DataPoint() With {.Open = 15, .High = 40, .Low = 10, .Close = 20})
series.Add(New DataPoint() With {.Open = 20, .High = 35, .Low = 9, .Close = 30})
series.Add(New DataPoint() With {.Open = 10, .High = 25, .Low = 5, .Close = 15})
series.Add(New DataPoint() With {.Open = 15, .High = 30, .Low = 7, .Close = 25})
RadChart1.DefaultView.ChartArea.DataSeries.Add(series)
RadChart1.DefaultView.ChartLegend.Visibility = System.Windows.Visibility.Collapsed
RadChart1.DefaultView.ChartArea.AxisX.Title = "Experiment No"
RadChart1.DefaultView.ChartArea.AxisY.Title = "Results"
RadChart1.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside
End Sub
End Class
Public Class CustomCandleStick
Inherits CandleStick
Private ReadOnly Property CustomLine() As ParametricLine
Get
Return TryCast(Me.GetTemplateChild("PART_CustomLine"), ParametricLine)
End Get
End Property
Protected Overrides Sub UpdateParametricLinesCoordinates(ByVal constraint As Size)
MyBase.UpdateParametricLinesCoordinates(constraint)
Dim middleValue As Double = (Me.DataPoint.Open + Me.DataPoint.Close) / 2
Dim minRange As DataRange = Me.CalculateRange(middleValue) * constraint.Height
UpdateParametricLineCoordinates(Me.CustomLine, Me.Center - constraint.Width \ 2, minRange.From, Me.Center + constraint.Width \ 2, minRange.From)
End Sub
Protected Overrides Sub UpdateParametricLinesParameters()
MyBase.UpdateParametricLinesParameters()
UpdateParametricLineParameter(Me.CustomLine, False)
End Sub
Private Function CalculateRange(ByVal value As Double) As DataRange
Dim axisRange As New DataRange(Me.ChartArea.AxisY.ActualMinValue, Me.ChartArea.AxisY.ActualMaxValue)
Dim itemY As Double = axisRange.Normalize(value)
Dim zero As Double = axisRange.Normalize(0R)
Dim restrictedRange As New DataRange(DataRange.Unit.Restrict(zero), itemY)
Return DataRange.Unit.Invert(restrictedRange)
End Function
End Class
Public Class CustomCandleStickSeriesDefinition
Inherits CandleStickSeriesDefinition
Public Overrides Function CreateChartItem() As IChartItem
Return New CustomCandleStick()
End Function
End Class
' #endregion

' #region radchart-howto-create-scatter-errorbars-and-boxplot-series_5
Partial Public Class MainPage
Inherits UserControl
Public Sub New()
InitializeComponent()
RadChart1.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside
RadChart1.DefaultView.ChartArea.AxisX.Title = "Experiment No"
RadChart1.DefaultView.ChartArea.AxisY.Title = "Results"
RadChart1.DefaultView.ChartArea.AxisY.IsZeroBased = True
RadChart1.DefaultView.ChartArea.AxisY.AutoRange = False
RadChart1.DefaultView.ChartArea.AxisY.AddRange(0, 20, 1)
RadChart1.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside
RadChart1.DefaultSeriesDefinition = New ScatterErrorBarSeriesDefinition() With {.PointSize = 12, .ItemStyle = TryCast(Me.LayoutRoot.Resources("CustomScatterPointStyle"), Style)}
Dim mapping As New SeriesMapping()
mapping.ItemMappings.Add(New ItemMapping("YValue", DataPointMember.YValue))
RadChart1.SeriesMappings.Add(mapping)
RadChart1.ItemsSource = GetData()
RadChart1.DefaultView.ChartArea.EnableAnimations = False
End Sub
Private Shared Function GetData() As List(Of ChartData)
Dim data As New List(Of ChartData)()
data.Add(New ChartData() With {.YValue = 10, .MinValue = 7, .MaxValue = 12})
data.Add(New ChartData() With {.YValue = 6, .MinValue = 4, .MaxValue = 8})
data.Add(New ChartData() With {.YValue = 5, .MinValue = 2, .MaxValue = 7})
data.Add(New ChartData() With {.YValue = 8, .MinValue = 6, .MaxValue = 10})
data.Add(New ChartData() With {.YValue = 10, .MinValue = 8, .MaxValue = 12})
data.Add(New ChartData() With {.YValue = 4, .MinValue = 3, .MaxValue = 6})
data.Add(New ChartData() With {.YValue = 7, .MinValue = 4, .MaxValue = 9})
data.Add(New ChartData() With {.YValue = 11, .MinValue = 8, .MaxValue = 13})
Return data
End Function
End Class
Public Class ScatterErrorBarSeriesDefinition
Inherits ScatterSeriesDefinition
Public Overrides Function CreateChartItem() As IChartItem
Return New ScatterErrorBar()
End Function
End Class
Public Class ScatterErrorBar
Inherits ScatterPoint
''' <summary>
''' Identifies the <see cref="MinValueY"/> dependency property.
''' </summary>
Public Shared ReadOnly MinValueYProperty As DependencyProperty = DependencyProperty.Register("MinValueY", GetType(Double), GetType(ScatterErrorBar), New PropertyMetadata(0R))
''' <summary>
''' Identifies the <see cref="MaxValueY"/> dependency property.
''' </summary>
Public Shared ReadOnly MaxValueYProperty As DependencyProperty = DependencyProperty.Register("MaxValueY", GetType(Double), GetType(ScatterErrorBar), New PropertyMetadata(0R))
''' <summary>
''' Gets or sets the MaxValueY.
''' </summary>
<Description("Gets or sets the MaxValueY")>
Public Property MaxValueY() As Double
Get
Return CDbl(Me.GetValue(MaxValueYProperty))
End Get
Set(ByVal value As Double)
Me.SetValue(MaxValueYProperty, value)
End Set
End Property
''' <summary>
''' Gets or sets the MinValueY.
''' </summary>
<Description("Gets or sets the MinValueY")>
Public Property MinValueY() As Double
Get
Return CDbl(Me.GetValue(MinValueYProperty))
End Get
Set(ByVal value As Double)
Me.SetValue(MinValueYProperty, value)
End Set
End Property
Protected Overrides Sub CreatePoints(ByVal arrangedBounds As Size)
MyBase.CreatePoints(arrangedBounds)
Me.MinValueY = Me.CalculateMinValueY(arrangedBounds)
Me.MaxValueY = Me.CalculateMaxValueY(arrangedBounds)
End Sub
Private Function CalculateMinValueY(ByVal arrangedBounds As Size) As Double
Dim minValue As Double = (TryCast(Me.DataPoint.DataItem, ChartData)).MinValue
Dim minRange As DataRange = Me.CalculateRange(minValue) * arrangedBounds.Height
Return minRange.From
End Function
Private Function CalculateMaxValueY(ByVal arrangedBounds As Size) As Double
Dim maxValue As Double = (TryCast(Me.DataPoint.DataItem, ChartData)).MaxValue
Dim maxRange As DataRange = Me.CalculateRange(maxValue) * arrangedBounds.Height
Return maxRange.From
End Function
Private Function CalculateRange(ByVal value As Double) As DataRange
Dim axisRange As New DataRange(Me.ChartArea.AxisY.ActualMinValue, Me.ChartArea.AxisY.ActualMaxValue)
Dim itemY As Double = axisRange.Normalize(value)
Dim zero As Double = axisRange.Normalize(0R)
Dim restrictedRange As New DataRange(DataRange.Unit.Restrict(zero), itemY)
Return DataRange.Unit.Invert(restrictedRange)
End Function
End Class
Public Class ChartData
Public Property YValue() As Double
Public Property MinValue() As Double
Public Property MaxValue() As Double
End Class
' #endregion
End Class
