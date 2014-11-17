Public Class Default_Vb


' #region radchart-features-smart-labels_2
Me.radChart.DefaultView.ChartArea.SmartLabelsEnabled = True;
' #endregion

' #region radchart-features-smart-labels_5
Dim settings As New LabelSettings()
settings.Distance = 10
settings.ShowConnectors = True
Dim lineSeries As New LineSeriesDefinition()
lineSeries.LabelSettings = settings
Me.radChart.DefaultSeriesDefinition = New LineSeriesDefinition()
Me.radChart.DefaultView.ChartArea.SmartLabelsEnabled = True
' #endregion

' #region radchart-features-smart-labels_8
Dim barSettings As New BarLabelSettings()
barSettings.Distance = 10
barSettings.LabelDisplayMode = LabelDisplayMode.Outside
barSettings.ShowConnectors = False
Dim barSeries As New BarSeriesDefinition()
barSeries.LabelSettings = barSettings
Me.radChart.DefaultSeriesDefinition = barSeries
Me.radChart.DefaultView.ChartArea.SmartLabelsEnabled = True
' #endregion

' #region radchart-features-smart-labels_11
Dim radialSettings As New RadialLabelSettings()
radialSettings.SpiderModeEnabled = True
radialSettings.ShowConnectors = True
Dim pieSeries As New PieSeriesDefinition()
pieSeries.LabelSettings = radialSettings
Me.radChart.DefaultSeriesDefinition = pieSeries
Me.radChart.DefaultView.ChartArea.SmartLabelsEnabled = True
' #endregion
End Class
