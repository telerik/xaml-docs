Public Class Default_Vb


' #region chart-animation-settings-api_3
Private Sub Page_Loaded(sender As Object, e As RoutedEventArgs)
 Dim settings As New AnimationSettings()
 settings.ItemDelay = TimeSpan.FromSeconds(0.5)
 settings.ItemAnimationDuration = TimeSpan.FromSeconds(1)
 'This DataSeries uses animation settings of its own.
 Dim barSeries1 As New DataSeries()
 barSeries1.Definition = New BarSeriesDefinition()
 barSeries1.Definition.AnimationSettings = settings
 barSeries1.Label = "Bar Series 1"
 Me.FillWithSampleData(barSeries1, 10)
 'This DataSeries relies on the animation settings of RadChart or          
 'the default animation settings.
 Dim barSeries2 As New DataSeries()
 barSeries2.Definition = New BarSeriesDefinition()
 barSeries2.Label = "Bar Series 2"
 Me.FillWithSampleData(barSeries2, 10)
 RadChart1.DefaultView.ChartArea.DataSeries.Add(barSeries1)
 RadChart1.DefaultView.ChartArea.DataSeries.Add(barSeries2)
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
