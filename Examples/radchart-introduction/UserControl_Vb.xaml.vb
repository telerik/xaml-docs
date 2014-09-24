Public Class UserControl_Vb


    ' #region radchart-introduction_4vb
    Dim chart As New RadCartesianChart()
    Dim catAxis As New CategoricalAxis()
    Dim lineAxis As New LinearAxis()
    chart.HorizontalAxis = catAxis
    chart.VerticalAxis = lineAxis

    Dim barSeries As New BarSeries()
    barSeries.DataPoints.Add(New CategoricalDataPoint() With { Key .Category = "Apples", Key .Value = 20 })
    barSeries.DataPoints.Add(New CategoricalDataPoint() With { Key .Category = "Bananas", Key .Value = 28 })
    barSeries.DataPoints.Add(New CategoricalDataPoint() With { Key .Category = "Oranges", Key .Value = 17 })
    barSeries.DataPoints.Add(New CategoricalDataPoint() With { Key .Category = "Strawberries", Key .Value = 30 })
    chart.Series.Add(barSeries)

    Me.LayoutRoot.Children.Add(chart)
    ' #endregion
    ' #region radchart-introduction_5vb
    Imports Telerik.Charting
    Imports Telerik.Windows.Controls
    Imports Telerik.Windows.Controls.ChartView
    ' #endregion
End Class
