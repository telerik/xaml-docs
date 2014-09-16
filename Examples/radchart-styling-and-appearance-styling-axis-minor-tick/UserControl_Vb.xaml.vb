Public Class Default_Vb


' #region radchart-styling-and-appearance-styling-axis-minor-tick_3
Me.radChart.DefaultView.ChartArea.AxisY.AxisStyles.MinorTickLineStyle = TryCast(Me.Resources("AxisYMinorTickStyle"), Style)
Me.radChart.DefaultView.ChartArea.AxisY.AxisStyles.TickLineStyle = TryCast(Me.Resources("AxisYTickStyle"), Style)
' #endregion
End Class
