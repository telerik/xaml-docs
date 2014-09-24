Public Class Default_Vb


' #region chart-customize-axis-appearance-through-style_3
Dim customAxisYStyle As Style = TryCast(Me.Resources("CustomAxisYStyle"), Style)
Dim customTickStyle As Style = TryCast(Me.Resources("CustomTickStyle"), Style)
Dim customGridlineStyle As Style = TryCast(Me.Resources("CustomGridlineStyle"), Style)
Dim customStriplineStyle As Style = TryCast(Me.Resources("CustomStriplineStyle"), Style)
Dim customItemLabelStyle As Style = TryCast(Me.Resources("CustomItemLabelStyle"), Style)
Dim customAxisTitleStyle As Style = TryCast(Me.Resources("CustomAxisTitleStyle"), Style)
RadChart1.DefaultView.ChartArea.AxisY.AxisStyles.AxisLineStyle = customAxisYStyle
RadChart1.DefaultView.ChartArea.AxisX.AxisStyles.AxisLineStyle = customAxisYStyle
RadChart1.DefaultView.ChartArea.AxisY.AxisStyles.TickLineStyle = customTickStyle
RadChart1.DefaultView.ChartArea.AxisX.AxisStyles.TickLineStyle = customTickStyle
RadChart1.DefaultView.ChartArea.AxisY.AxisStyles.GridLineStyle = customGridlineStyle
RadChart1.DefaultView.ChartArea.AxisX.AxisStyles.GridLineStyle = customGridlineStyle
RadChart1.DefaultView.ChartArea.AxisY.AxisStyles.StripLineStyle = customStriplineStyle
RadChart1.DefaultView.ChartArea.AxisX.AxisStyles.StripLineStyle = customStriplineStyle
RadChart1.DefaultView.ChartArea.AxisY.AxisStyles.ItemLabelStyle = customItemLabelStyle
RadChart1.DefaultView.ChartArea.AxisX.AxisStyles.ItemLabelStyle = customItemLabelStyle
RadChart1.DefaultView.ChartArea.AxisY.AxisStyles.TitleStyle = customAxisTitleStyle
RadChart1.DefaultView.ChartArea.AxisX.AxisStyles.TitleStyle = customAxisTitleStyle
RadChart1.ItemsSource = New Integer() {1, 5, 6, 9, 5, 7}
' #endregion
End Class
