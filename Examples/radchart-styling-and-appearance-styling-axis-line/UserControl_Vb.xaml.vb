Public Class Default_Vb


' #region radchart-styling-and-appearance-styling-axis-line_2
Me.radChart.DefaultView.ChartArea.AxisX.AxisStyles.AxisLineStyle = TryCast(Me.Resources("AxisLineStyle"), Style)
Me.radChart.DefaultView.ChartArea.AxisY.AxisStyles.AxisLineStyle = TryCast(Me.Resources("AxisLineStyle"), Style)
' #endregion

' #region radchart-styling-and-appearance-styling-axis-line_6
Public Sub New()
 InitializeComponent()
 RadChart1.[AddHandler](MouseLeftButtonDownEvent, New MouseButtonEventHandler(MouseLeftButtonDownEventHandler), True)
End Sub
' #endregion

' #region radchart-styling-and-appearance-styling-axis-line_8
Public Sub MouseLeftButtonDownEventHandler(sender As Object, e As MouseButtonEventArgs)
 Dim txtBlock As TextBlock = TryCast(e.OriginalSource, TextBlock)
 If txtBlock Is Nothing Then
  Return
 End If
 Dim axis = txtBlock.GetVisualParent(Of AxisX2D)()
 If axis IsNot Nothing Then
  axis.Foreground = New SolidColorBrush(Colors.Red)
 End If
End Sub
' #endregion
End Class
