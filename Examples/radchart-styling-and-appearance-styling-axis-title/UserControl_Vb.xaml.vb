Public Class Default_Vb


' #region radchart-styling-and-appearance-styling-axis-title_1
Me.radChart.DefaultView.ChartArea.AxisX.AxisStyles.TitleStyle = TryCast(Me.Resources("AxisTitleStyle"), Style)
Me.radChart.DefaultView.ChartArea.AxisY.AxisStyles.TitleStyle = TryCast(Me.Resources("AxisTitleStyle"), Style)
' #endregion
End Class
