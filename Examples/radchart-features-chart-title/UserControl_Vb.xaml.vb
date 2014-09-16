Public Class Default_Vb


' #region radchart-features-chart-title_2
radChart.DefaultView.ChartTitle.Content = "Monthly Sales for 2009"
' #endregion

' #region radchart-features-chart-title_5
Dim radChart As New Telerik.Windows.Controls.RadChart()
....
Dim border As New Border()
border.BorderThickness = New Thickness( 2 )
border.CornerRadius = New CornerRadius( 5 )
border.BorderBrush = New SolidColorBrush(Color.FromArgb( 255, 173, 216, 230 ))
border.Child = New TextBlock()
'Set the content of the ChartTitle
radChart.DefaultView.ChartTitle.Content = border
' #endregion
End Class
