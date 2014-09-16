Public Class Default_Vb


' #region radchart-features-chart-area_2
Dim radChart As New Telerik.Windows.Controls.RadChart()
....
radChart.DefaultView.ChartArea.LabelFormatBehavior = LabelFormatBehavior.HumanReadable
radChart.DefaultView.ChartArea.AxisX.IsDateTime = True
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "MMM"
radChart.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Between
' #endregion
End Class
