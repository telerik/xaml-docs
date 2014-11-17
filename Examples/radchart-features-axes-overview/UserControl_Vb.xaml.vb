Public Class Default_Vb


' #region radchart-features-axes-overview_2
Dim radChart As New Telerik.Windows.Controls.RadChart()
radChart.DefaultView.ChartArea.AxisX.AutoRange = True
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "0.0"
radChart.DefaultView.ChartArea.AxisX.Title = "Kilovolt [kV]"
radChart.DefaultView.ChartArea.AxisY.AutoRange = False
radChart.DefaultView.ChartArea.AxisY.MinValue = 100
radChart.DefaultView.ChartArea.AxisY.MaxValue = 200
radChart.DefaultView.ChartArea.AxisY.[Step] = 5
radChart.DefaultView.ChartArea.AxisY.DefaultLabelFormat = "0"
radChart.DefaultView.ChartArea.AxisY.Title = "Ampere [A]"
' #endregion
End Class
