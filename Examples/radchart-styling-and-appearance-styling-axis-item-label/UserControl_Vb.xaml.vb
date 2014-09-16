Public Class Default_Vb


' #region radchart-styling-and-appearance-styling-axis-item-label_2
Me.radChart.DefaultView.ChartArea.AxisX.AxisStyles.ItemLabelStyle = TryCast(Me.Resources("ItemLabelStyle"), Style)
Me.radChart.DefaultView.ChartArea.AxisY.AxisStyles.ItemLabelStyle = TryCast(Me.Resources("ItemLabelStyle"), Style)
' #endregion
End Class
