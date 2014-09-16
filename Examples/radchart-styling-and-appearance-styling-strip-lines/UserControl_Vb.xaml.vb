Public Class Default_Vb


' #region radchart-styling-and-appearance-styling-strip-lines_3
RadChart1.DefaultView.ChartArea.AxisY.AxisStyles.AlternateStripLineStyle = TryCast(Me.Resources("HorizontalAlternateStripLineStyle"), Style)
RadChart1.DefaultView.ChartArea.AxisY.AxisStyles.StripLineStyle = TryCast(Me.Resources("HorizontalStripLineStyle"), Style)
' #endregion

' #region radchart-styling-and-appearance-styling-strip-lines_5
RadChart1.DefaultView.ChartArea.AxisY.StripLinesVisibility = System.Windows.Visibility.Visible
' #endregion
End Class
