Public Class Default_Vb


' #region radchart-howto-create-location-crosshair-for-radchart_1
Private Sub OnChartLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
	Dim plotAreaPanel = Me.chart.DefaultView.ChartArea.ChildrenOfType(Of ClipPanel)().FirstOrDefault()
	plotAreaPanel.MouseEnter += Me.OnPlotAreaPanelMouseEnter
	plotAreaPanel.MouseMove += Me.OnPlotAreaPanelMouseMove
	plotAreaPanel.MouseLeave += Me.OnPlotAreaPanelMouseLeave
End Sub
' #endregion

' #region radchart-howto-create-location-crosshair-for-radchart_3
Private Sub OnPlotAreaPanelMouseEnter(ByVal sender As Object, ByVal e As MouseEventArgs)
	Me.chart.DefaultView.ChartArea.Annotations.Add(xGridLine)
	Me.chart.DefaultView.ChartArea.Annotations.Add(yGridLine)
End Sub

Private Sub OnPlotAreaPanelMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
	Dim plotAreaPanel = TryCast(sender, ClipPanel)
	Dim position = e.GetPosition(plotAreaPanel)

	Dim x = Me.chart.DefaultView.ChartArea.AxisX.ConvertPhysicalUnitsToData(position.X)
	Dim y = Me.chart.DefaultView.ChartArea.AxisY.ConvertPhysicalUnitsToData(position.Y)

	xGridLine.XIntercept = x
	yGridLine.YIntercept = y

	Me.textX.Text = String.Format("X: {0:N2}", x)
	Me.textY.Text = String.Format("Y: {0:N2}", y)
End Sub

Private Sub OnPlotAreaPanelMouseLeave(ByVal sender As Object, ByVal e As MouseEventArgs)
	Me.chart.DefaultView.ChartArea.Annotations.Remove(xGridLine)
	Me.chart.DefaultView.ChartArea.Annotations.Remove(yGridLine)
End Sub
' #endregion
End Class
