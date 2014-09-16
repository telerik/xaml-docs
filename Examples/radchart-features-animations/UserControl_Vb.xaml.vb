Public Class Default_Vb


' #region radchart-features-animations_2
Dim radChart As New Telerik.Windows.Controls.RadChart()
radChart.DefaultView.ChartArea.AnimationSettings = New AnimationSettings()
radChart.DefaultView.ChartArea.AnimationSettings.ItemDelay = New TimeSpan( 0 )
radChart.DefaultView.ChartArea.AnimationSettings.ItemAnimationDuration = New TimeSpan( 0, 0, 3 )
Dim barSeries As New DataSeries()
barSeries.Definition = New BarSeriesDefinition()
barSeries.Add( New DataPoint( 154 ) )
barSeries.Add( New DataPoint( 138 ) )
barSeries.Add( New DataPoint( 143 ) )
barSeries.Add( New DataPoint( 120 ) )
barSeries.Add( New DataPoint( 135 ) )
barSeries.Add( New DataPoint( 125 ) )
barSeries.Add( New DataPoint( 179 ) )
barSeries.Add( New DataPoint( 170 ) )
barSeries.Add( New DataPoint( 198 ) )
barSeries.Add( New DataPoint( 187 ) )
barSeries.Add( New DataPoint( 193 ) )
barSeries.Add( New DataPoint( 176 ) )
radChart.DefaultView.ChartArea.DataSeries.Add(barSeries)
barSeries = New DataSeries()
barSeries.Definition = New BarSeriesDefinition()
barSeries.Definition.AnimationSettings = New AnimationSettings()
barSeries.Definition.AnimationSettings.ItemAnimationDuration = New TimeSpan( 0, 0, 0, 0, 500 )
barSeries.Definition.AnimationSettings.TotalSeriesAnimationDuration = New TimeSpan( 0, 0, 3 )
barSeries.Add( New DataPoint( 45 ) )
barSeries.Add( New DataPoint( 48 ) )
barSeries.Add( New DataPoint( 53 ) ) 
barSeries.Add( New DataPoint( 41 ) ) 
barSeries.Add( New DataPoint( 32 ) )
barSeries.Add( New DataPoint( 28 ) )
barSeries.Add( New DataPoint( 63 ) )
barSeries.Add( New DataPoint( 74 ) )
barSeries.Add( New DataPoint( 77 ) )
barSeries.Add( New DataPoint( 85 ) )
barSeries.Add( New DataPoint( 89 ) )
barSeries.Add( New DataPoint( 80 ) )
radChart.DefaultView.ChartArea.DataSeries.Add( barSeries )
' #endregion

' #region radchart-features-animations_5
....
radChart.DefaultView.ChartArea.EnableAnimations = False
radChart.DefaultView.ChartArea.EnableStripLinesAnimation = False
....
' #endregion
End Class
