Public Class Default_Vb


' #region chart-customize-chart-series-appearance-itemstyle_2
Private Sub Page_Loaded(sender As Object, e As RoutedEventArgs)
 Dim barSeries As New DataSeries()
 barSeries.Definition = New BarSeriesDefinition()
 barSeries.Definition.ItemStyle = TryCast(Me.FindResource("MyStyle"), Style)
 barSeries.Definition.ItemStyle = TryCast(Me.Resources("MyStyle"), Style)
 RadChart1.DefaultView.ChartArea.AxisX.StripLinesVisibility = Visibility.Collapsed
 RadChart1.DefaultView.ChartArea.AxisY.MajorGridLinesVisibility = Visibility.Visible
 RadChart1.DefaultView.ChartArea.AxisY.StripLinesVisibility = Visibility.Collapsed
 Me.FillWithSampleData(barSeries, 10)
 Me.RadChart1.DefaultView.ChartArea.DataSeries.Add(barSeries)
End Sub
Private Sub FillWithSampleData(series As DataSeries, numberOfItems As Integer)
 Dim random As New Random(DirectCast((series.GetHashCode() + DateTime.Now.Ticks), Integer))
 Dim i As Integer = 0
 While i < numberOfItems
  Dim randomNumber As Integer = random.[Next](30, 100)
  series.Add(New DataPoint())
  System.Math.Max(System.Threading.Interlocked.Increment(i),i - 1)
 End While
End Sub
' #endregion
End Class
