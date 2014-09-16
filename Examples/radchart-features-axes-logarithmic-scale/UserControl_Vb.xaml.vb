Public Class Default_Vb


' #region radchart-features-axes-logarithmic-scale_2
Me.radChart.ItemsSource = New Integer() {10, 100, 1000, 10000, 100000, 1000000}
' #endregion

' #region radchart-features-axes-logarithmic-scale_5
Me.radChart.DefaultView.ChartArea.AxisY.IsLogarithmic = True
' #endregion
End Class
