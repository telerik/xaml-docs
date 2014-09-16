Public Class Default_Vb


' #region radchart-features-axes-Y-axis_2
Dim radChart As New Telerik.Windows.Controls.RadChart()
....
radChart.DefaultView.ChartArea.AxisY.MinorTicksVisibility = Visibility.Visible
radChart.DefaultView.ChartArea.AxisY.MinorTickPointMultiplier = 5
radChart.DefaultView.ChartArea.AxisY.ExtendDirection = AxisExtendDirection.Down
radChart.DefaultView.ChartArea.AxisY.DefaultLabelFormat = "0"
radChart.DefaultView.ChartArea.AxisY.Title = "Ampere [A]"
....
' #endregion
End Class
