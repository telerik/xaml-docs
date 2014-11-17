Public Class Default_Vb


' #region radchart-features-zooming-and-scrolling_1
Me.radChart.DefaultView.ChartArea.ZoomScrollSettingsX.MinZoomRange = 0.1
Me.radChart.DefaultView.ChartArea.ZoomScrollSettingsX.RangeEnd = 0.3
Me.radChart.DefaultView.ChartArea.ZoomScrollSettingsX.RangeStart = 0.2
Me.radChart.DefaultView.ChartArea.ZoomScrollSettingsX.ScrollMode = ScrollMode.ScrollAndZoom
' #endregion
End Class
