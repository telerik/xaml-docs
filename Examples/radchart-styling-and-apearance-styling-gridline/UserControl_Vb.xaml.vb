Public Class Default_Vb


' #region radchart-styling-and-apearance-styling-gridline_2
Me.radChart.DefaultView.ChartArea.AxisX.AxisStyles.GridLineStyle = TryCast(Me.Resources("GridLineStyle"), Style)
Me.radChart.DefaultView.ChartArea.AxisY.AxisStyles.GridLineStyle = TryCast(Me.Resources("GridLineStyle"), Style)
' #endregion
End Class
