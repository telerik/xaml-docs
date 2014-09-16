Public Class Default_Vb


' #region radchart-features-datetime-support_1
Public Class TradeData
    ....
    Private _FromDate As DateTime
    Public Property FromDate() As DateTime
        Get
            Return _FromDate
        End Get
        Set(ByVal value As DateTime)
            _FromDate = value
        End Set
    End Property
    Private _Close As Double
    Public Property Close() As Double
        Get
            Return _Close
        End Get
        Set(ByVal value As Double)
            _Close = value
        End Set
    End Property
    ....
End Class
' #endregion

' #region radchart-features-datetime-support_4
Dim radChart As New Telerik.Windows.Controls.RadChart()
Dim seriesMapping As New SeriesMapping()
seriesMapping.LegendLabel = "MSFT"
seriesMapping.SeriesDefinition = New LineSeriesDefinition()
seriesMapping.ItemMappings.Add( New ItemMapping( "FromDate", DataPointMember.XValue ) )
seriesMapping.ItemMappings.Add( New ItemMapping( "Close", DataPointMember.YValue ) )
radChart.SeriesMappings.Add( seriesMapping )
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM"
radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45
' #endregion

' #region radchart-features-datetime-support_7
Dim radChart As New Telerik.Windows.Controls.RadChart()
....
radChart.DefaultView.ChartArea.AxisX.IsDateTime = True
radChart.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside
radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM"
....
Dim lineSeries As New DataSeries()
lineSeries.Definition = New LineSeriesDefinition()
lineSeries.Add( New DataPoint( New DateTime( 2009, 1, 31 ).ToOADate(), 154 ) )
lineSeries.Add( New DataPoint( New DateTime( 2009, 2, 28 ).ToOADate(), 138 ) )
lineSeries.Add( New DataPoint( New DateTime( 2009, 3, 31 ).ToOADate(), 143 ) )
lineSeries.Add( New DataPoint( New DateTime( 2009, 4, 30 ).ToOADate(), 120 ) )
lineSeries.Add( New DataPoint( New DateTime( 2009, 5, 31 ).ToOADate(), 135 ) )
lineSeries.Add( New DataPoint( New DateTime( 2009, 6, 30 ).ToOADate(), 125 ) )
lineSeries.Add( New DataPoint( New DateTime( 2009, 7, 31 ).ToOADate(), 179 ) )
lineSeries.Add( New DataPoint( New DateTime( 2009, 8, 31 ).ToOADate(), 170 ) )
lineSeries.Add( New DataPoint( New DateTime( 2009, 9, 30 ).ToOADate(), 198 ) )
lineSeries.Add( New DataPoint( New DateTime( 2009, 10, 31 ).ToOADate(), 187 ) )
lineSeries.Add( New DataPoint( New DateTime( 2009, 11, 30 ).ToOADate(), 193 ) )
lineSeries.Add( New DataPoint( New DateTime( 2009, 12, 31 ).ToOADate(), 176 ) )
radChart.DefaultView.ChartArea.DataSeries.Add( lineSeries )
' #endregion
End Class
