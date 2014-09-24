Public Class Default_Vb


' #region radchart-features-annotations-marked-zone_1
InitializeComponent()
Dim series1 As New DataSeries() With
{ New DataPoint(145),
New DataPoint(132),
New DataPoint(164),
New DataPoint(187),
New DataPoint(186), 
New DataPoint(131), 
New DataPoint(173),
New DataPoint(172),
New DataPoint(140), 
New DataPoint(129), 
New DataPoint(158), 
New DataPoint(149)
}
series1.Definition = New LineSeriesDefinition()
series1.Definition.Appearance.Fill = New SolidColorBrush(Colors.Black)
series1.Definition.Appearance.Stroke = New SolidColorBrush(Colors.Black)
series1.Definition.Appearance.PointMark.Stroke = New SolidColorBrush(Colors.Black)
RadChart1.DefaultView.ChartArea.DataSeries.Add(series1)
' #endregion

' #region radchart-features-annotations-marked-zone_4
Dim redZone As New MarkedZone()
redZone.StartY = 110
redZone.EndY = 130
redZone.Background = New SolidColorBrush(Color.FromArgb(255, 248, 109, 90))
Dim yellowZone As New MarkedZone()
yellowZone.StartY = 130
yellowZone.EndY = 170
yellowZone.Background = New SolidColorBrush(Color.FromArgb(255, 234, 244, 81))
Dim greenZone As New MarkedZone()
greenZone .StartY = 170
greenZone .EndY = 200
greenZone .Background = New SolidColorBrush(Color.FromArgb(255, 154, 216, 70))
Me.radChart.DefaultView.ChartArea.Annotations.Add(redZone)
Me.radChart.DefaultView.ChartArea.Annotations.Add(yellowZone)
Me.radChart.DefaultView.ChartArea.Annotations.Add(greenZone)
' #endregion
End Class
