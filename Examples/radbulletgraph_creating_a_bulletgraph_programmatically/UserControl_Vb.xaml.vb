Public Class Default_Vb


' #region radbulletgraph_creating_a_bulletgraph_programmatically_1
Dim horizontalBulletGraph As New RadHorizontalBulletGraph()
Me.LayoutRoot.Children.Add(horizontalBulletGraph)
' #endregion

' #region radbulletgraph_creating_a_bulletgraph_programmatically_3
horizontalBulletGraph.AutoRange = False
horizontalBulletGraph.Width = 300
horizontalBulletGraph.Height = 60
horizontalBulletGraph.Minimum = 0
horizontalBulletGraph.Maximum = 100
horizontalBulletGraph.FeaturedMeasure = 60R
horizontalBulletGraph.ComparativeMeasure = 65R
horizontalBulletGraph.ProjectedValue = 75R
Dim range As New QualitativeRange()
range.Value = 50
range.Brush = CombineAlphaAndColorInSolidColorBrush(1, "#A8A8A8")
horizontalBulletGraph.QualitativeRanges.Add(range)
Dim range1 As New QualitativeRange()
range1.Value = 70
range1.Brush = CombineAlphaAndColorInSolidColorBrush(1, "#C6C8C8")
horizontalBulletGraph.QualitativeRanges.Add(range1)
Dim range2 As New QualitativeRange()
range2.Brush = CombineAlphaAndColorInSolidColorBrush(1, "#E8E8E8")
horizontalBulletGraph.QualitativeRanges.Add(range2)
' #endregion

' #region radbulletgraph_creating_a_bulletgraph_programmatically_5
Public Sub New()
InitializeComponent()
Dim horizontalBulletGraph As New RadHorizontalBulletGraph()
horizontalBulletGraph.AutoRange = False
horizontalBulletGraph.Width = 300
horizontalBulletGraph.Height = 60
horizontalBulletGraph.Minimum = 0
horizontalBulletGraph.Maximum = 100
horizontalBulletGraph.FeaturedMeasure = 60R
horizontalBulletGraph.ComparativeMeasure = 65R
horizontalBulletGraph.ProjectedValue = 75R
Dim range As New QualitativeRange()
range.Value = 50
range.Brush = CombineAlphaAndColorInSolidColorBrush(1, "#A8A8A8")
horizontalBulletGraph.QualitativeRanges.Add(range)
Dim range1 As New QualitativeRange()
range1.Value = 70
range1.Brush = CombineAlphaAndColorInSolidColorBrush(1, "#C6C8C8")
horizontalBulletGraph.QualitativeRanges.Add(range1)
Dim range2 As New QualitativeRange()
range2.Brush = CombineAlphaAndColorInSolidColorBrush(1, "#E8E8E8")
horizontalBulletGraph.QualitativeRanges.Add(range2)
Me.LayoutRoot.Children.Add(horizontalBulletGraph)
End Sub
#Region "protected static SolidColorBrush CombineAlphaAndColorInSolidColorBrush(double opacity, string color)"
''' <summary>
''' adds the alpha (opacity) value to the front of the color string
''' </summary>
''' <param name="opacity"></param>
''' <param name="color"></param>
''' <returns></returns>
Protected Shared Function CombineAlphaAndColorInSolidColorBrush(ByVal opacity As Double, ByVal color As String) As SolidColorBrush
Dim theAnswer As New SolidColorBrush()
' deal with opacity
If opacity > 1.0 Then
opacity = 1.0
End If
If opacity < 0.0 Then
opacity = 0.0
End If
' get the hex value of the alpha chanel (opacity):
Dim a As Byte = CByte(Convert.ToInt32(255 * opacity))
' deal with the color
Try
Dim r As Byte = CByte(Convert.ToUInt32(color.Substring(1, 2), 16))
Dim g As Byte = CByte(Convert.ToUInt32(color.Substring(3, 2), 16))
Dim b As Byte = CByte(Convert.ToUInt32(color.Substring(5, 2), 16))
theAnswer.Color = Color.FromArgb(a, r, g, b)
Catch
theAnswer.Color = Color.FromArgb(255, 255, 0, 0)
End Try
Return theAnswer
End Function
#End Region
' #endregion
End Class
