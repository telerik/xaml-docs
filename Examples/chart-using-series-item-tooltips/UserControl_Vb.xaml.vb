Public Class Default_Vb


' #region chart-using-series-item-tooltips_1
Dim dataSeries As New DataSeries()
dataSeries.Definition = New BarSeriesDefinition()
' Enable the ToolTip functionality
dataSeries.Definition.ShowItemToolTips = True
Dim random As New Random(Me.GetHashCode() Or DirectCast((DateTime.Now.Ticks), Integer))
Dim i As Integer = 0
While i < random.[Next](7, 20)
 Dim dataPoint As New DataPoint()
 dataPoint.YValue = random.[Next](0, 100)
 dataSeries.Add(dataPoint)
 System.Math.Max(System.Threading.Interlocked.Increment(i),i - 1)
End While
RadChart1.DefaultView.ChartArea.DataSeries.Add(dataSeries)
' #endregion

' #region chart-using-series-item-tooltips_3
Dim dataSeries As New DataSeries()
dataSeries.Definition = New BarSeriesDefinition()
' Enable the ToolTip functionality
dataSeries.Definition.ShowItemToolTips = True
Dim random As New Random(Me.GetHashCode() Or DirectCast((DateTime.Now.Ticks), Integer))
Dim i As Integer = 0
While i < random.[Next](7, 20)
 Dim dataPoint As New DataPoint()
 dataPoint.YValue = random.[Next](0, 100)
 dataSeries.Add(dataPoint)
 System.Math.Max(System.Threading.Interlocked.Increment(i),i - 1)
End While
RadChart1.DefaultView.ChartArea.DataSeries.Add(dataSeries)
' Set the delay to 500 milliseconds
RadChart1.DefaultView.ChartArea.ItemToolTipDelay = 500
' #endregion

' #region chart-using-series-item-tooltips_5
Private Sub ExampleLoaded(sender As Object, e As System.Windows.RoutedEventArgs)
 RadChart1.DefaultView.ChartTitle.Content = "Financial Overview"
 RadChart1.DefaultView.ChartArea.AxisX.Title = "Years"
 RadChart1.DefaultView.ChartArea.AxisY.DefaultFormat = "{0:C}"
 Dim series As New DataSeries()
 series.Definition.ShowItemToolTips = True
 series.FillWithSampleData(10)
 RadChart1.DefaultView.ChartArea.DataSeries.Clear()
 RadChart1.DefaultView.ChartArea.DataSeries.Add(series)
 RadChart1.DefaultView.ChartArea.ItemToolTipOpening += Me.ChartItemToolTipOpening
End Sub
Private Sub ChartItemToolTipOpening(tooltip As ItemToolTip2D, args As ItemToolTipEventArgs)
 ' format the tooltip value as currency
 tooltip.Content = args.DataPoint.YValue.ToString("{0:C}")
End Sub
' #endregion
End Class
