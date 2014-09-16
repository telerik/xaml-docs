Public Class Default_Vb


' #region radchart-features-axes-inverse-axis_1
InitializeComponent()
Dim lineSeries As New DataSeries()
    lineSeries.LegendLabel = "Turnover"
    lineSeries.Definition = New LineSeriesDefinition()
    Dim dataPoint As New DataPoint()
    dataPoint.YValue = 154
    dataPoint.XCategory = "Jan"
    lineSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 138
    dataPoint.XCategory = "Feb"
    lineSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 143
    dataPoint.XCategory = "Mar"
    lineSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 120
    dataPoint.XCategory = "Apr"
    lineSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 135
    dataPoint.XCategory = "May"
    lineSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 125
    dataPoint.XCategory = "Jun"
    lineSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 179
    dataPoint.XCategory = "Jul"
    lineSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 170
    dataPoint.XCategory = "Aug"
    lineSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 198
    dataPoint.XCategory = "Sep"
    lineSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 187
    dataPoint.XCategory = "Sep"
    lineSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 193
    dataPoint.XCategory = "Nov"
    lineSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 176
    dataPoint.XCategory = "Dec"
    lineSeries.Add(dataPoint)
    telerikChart.DefaultView.ChartArea.DataSeries.Add(lineSeries)
    'Bar Chart
    Dim barSeries As New DataSeries()
    barSeries.LegendLabel = "Expenses"
    barSeries.Definition = New BarSeriesDefinition()
    dataPoint = New DataPoint()
    dataPoint.YValue = 45
    dataPoint.XCategory = "Jan"
    barSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 48
    dataPoint.XCategory = "Feb"
    barSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 53
    dataPoint.XCategory = "Mar"
    barSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 41
    dataPoint.XCategory = "Apr"
    barSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 32
    dataPoint.XCategory = "May"
    barSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 28
    dataPoint.XCategory = "Jun"
    barSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 63
    dataPoint.XCategory = "Jul"
    barSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 74
    dataPoint.XCategory = "Aug"
    barSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 77
    dataPoint.XCategory = "Sep"
    barSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 85
    dataPoint.XCategory = "Oct"
    barSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 89
    dataPoint.XCategory = "Nov"
    barSeries.Add(dataPoint)
    dataPoint = New DataPoint()
    dataPoint.YValue = 80
    dataPoint.XCategory = "Dec"
    barSeries.Add(dataPoint)
    telerikChart.DefaultView.ChartArea.DataSeries.Add(barSeries)
' #endregion

' #region radchart-features-axes-inverse-axis_3
telerikChart.DefaultView.ChartArea.AxisX.IsInverse = true
' #endregion
End Class
