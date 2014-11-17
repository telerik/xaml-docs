Public Class Default_Vb


' #region radchart-styling-and-appearance-styling-axis-tick_3
Me.radChart.DefaultView.ChartArea.AxisX.AxisStyles.TickLineStyle = TryCast(Me.Resources("AxisXTickStyle"), Style)
Me.radChart.DefaultView.ChartArea.AxisY.AxisStyles.TickLineStyle = TryCast(Me.Resources("AxisYTickStyle"), Style)
' #endregion
End Class
