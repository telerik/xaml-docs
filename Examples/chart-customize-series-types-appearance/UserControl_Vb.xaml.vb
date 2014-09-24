Public Class Default_Vb


' #region chart-customize-series-types-appearance_3
Public Sub New()
 InitializeComponent()
 RadChart1.DefaultView.ChartArea.SeriesStyles.BarSeriesStyle = Me.CustomBarStyle
 RadChart1.DefaultView.ChartArea.SeriesStyles.BarSeriesStyle = TryCast(Me.LayoutRoot.Resources("CustomBarStyle"), Style)
 RadChart1.DefaultView.ChartTitle.Content = "Financial Overview"
 RadChart1.DefaultView.ChartLegend.Header = "Revenue (Millions)"
 RadChart1.DefaultView.ChartArea.DataSeries.Add(CreateDataSeries(New BarSeriesDefinition()))
 RadChart1.DefaultView.ChartArea.DataSeries.Add(CreateDataSeries(New BarSeriesDefinition()))
End Sub
Private Function CreateDataSeries(definition As ISeriesDefinition) As DataSeries
 Dim rand As New Random(DateTime.Now.Millisecond)
 Dim series As New DataSeries()
 Dim i As Integer = 0
 While i < 5
  series.Add(New DataPoint(rand.[Next](10, 100)))
  System.Math.Max(System.Threading.Interlocked.Increment(i),i - 1)
 End While
 Return series
End Function
' #endregion
End Class
