Public Class Default_Vb


' #region radchart-features-axes-X-axis_2
Dim radChart As New Telerik.Windows.Controls.RadChart()
radChart.DefaultView.ChartArea.AxisX.IsDateTime = True
radChart.DefaultView.ChartArea.AxisX.Step = 5
radChart.DefaultView.ChartArea.AxisX.LabelStep = 2
radChart.DefaultView.ChartArea.AxisX.StepLabelLevelCount = 3
radChart.DefaultView.ChartArea.AxisX.StepLabelLevelHeight = 10
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM"
...
Dim sm As New SeriesMapping()
sm.SeriesDefinition = New SplineSeriesDefinition()
sm.SeriesDefinition.ShowItemLabels = False
DirectCast( sm.SeriesDefinition, SplineSeriesDefinition ).ShowPointMarks = False
sm.ItemMappings.Add(New ItemMapping( "Date", DataPointMember.XValue ) )
sm.ItemMappings.Add(New ItemMapping( "Value", DataPointMember.YValue ) )
radChart.SeriesMappings.Add( sm )
' #endregion

' #region radchart-features-axes-X-axis_5
Dim radChart As New Telerik.Windows.Controls.RadChart()
radChart.DefaultView.ChartArea.AxisX.AutoRange = True
radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM"
...
Dim sm As New SeriesMapping()
sm.SeriesDefinition = New SplineSeriesDefinition()
sm.SeriesDefinition.ShowItemLabels = False
DirectCast( sm.SeriesDefinition, SplineSeriesDefinition ).ShowPointMarks = False
sm.ItemMappings.Add(New ItemMapping( "Date", DataPointMember.XValue ) )
sm.ItemMappings.Add(New ItemMapping( "Value", DataPointMember.YValue ) )
radChart.SeriesMappings.Add( sm )
' #endregion

' #region radchart-features-axes-X-axis_8
....
radChart.DefaultView.ChartArea.AxisX.TicksDistance = 15
....
' #endregion

' #region radchart-features-axes-X-axis_11
radChart.DefaultView.ChartArea.AxisX.AutoRange = False
radChart.DefaultView.ChartArea.AxisX.MinValue = New DateTime( 2009, 1, 1 ).ToOADate()
radChart.DefaultView.ChartArea.AxisX.MaxValue = New DateTime( 2009, 3, 31 ).ToOADate()
radChart.DefaultView.ChartArea.AxisX.Step = 5
radChart.DefaultView.ChartArea.AxisX.LabelStep = 2
radChart.DefaultView.ChartArea.AxisX.LabelRotationAngle = 45
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "dd-MMM"
' #endregion
End Class
