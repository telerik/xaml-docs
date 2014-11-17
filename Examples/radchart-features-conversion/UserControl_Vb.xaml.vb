Public Class UserControl_Vb

' #region radchartview-features-conversion_0
Private Sub UIElement_MouseMove(sender As Object, e As MouseEventArgs)
	Dim mousePosition As Point = e.GetPosition(radCartesianChart1)
	Dim tuple As DataTuple = radCartesianChart1.ConvertPointToData(mousePosition)

	Dim Category As String = DirectCast(tuple.FirstValue, String)
	Dim Value As Double = CDbl(tuple.SecondValue)
	'...
End Sub
' #endregion

' #region radchartview-features-conversion_1

' #endregion

' #region radchartview-features-conversion_2

' #endregion

End Class
