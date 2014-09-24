Public Class Default_Vb


' #region radchart-howto-highlight-pointmark-on-click_1
Public Sub New() 'MainWindow() for WPF
                  InitializeComponent()
                  Dim r As New Random()
                  Dim chartData As New List(Of ItemData)()
                  For i As Integer = 0 To 19
                        chartData.Add(New ItemData(i, r.Next(0, 100)))
                  Next i
                  Me.radChart.ItemsSource = chartData
                  Me.SetUpMappings()
       End Sub
            Private Sub SetUpMappings()
                  Dim mapping As New SeriesMapping()
                  mapping.SeriesDefinition = New LineSeriesDefinition() With {.ShowItemToolTips = True, .ShowItemLabels = False}
                  mapping.ItemMappings.Add(New ItemMapping("YValue", DataPointMember.YValue))
                  mapping.ItemMappings.Add(New ItemMapping("XValue", DataPointMember.XValue))
                  Me.radChart.SeriesMappings.Add(mapping)
            End Sub
            Public Class ItemData
                  Public Property XValue() As Double
                  Public Property YValue() As Double
                  Public Sub New(ByVal xValue As Double, ByVal yValue As Double)
                        Me.XValue = xValue
                        Me.YValue = yValue
                  End Sub
            End Class
' #endregion

' #region radchart-howto-highlight-pointmark-on-click_3
Private Sub ChartArea_ItemClick(ByVal sender As Object, ByVal e As ChartItemClickEventArgs)
Me.ClearPointMarkSelectedState()
Dim pointMarks = radChart.DefaultView.ChartArea.ChildrenOfType(Of PointMark)().ToList(Of PointMark)()
Me.selectedPointMark = pointMarks.Where(Function(x) x.DataContext = e.DataPoint).SingleOrDefault()
Me.SetPointMarkSelectedState()
End Sub
' #endregion

' #region radchart-howto-highlight-pointmark-on-click_5
Private Sub SetPointMarkSelectedState()
If Me.selectedPointMark Is Nothing Then
Return
End If
Me.selectedPointMark.Fill = New SolidColorBrush(Colors.Red)
Me.selectedPointMark.Shape = MarkerShape.Triangle
Me.selectedPointMark.Size = 12
End Sub
Private Sub ClearPointMarkSelectedState()
If Me.selectedPointMark Is Nothing Then
Return
End If
Me.selectedPointMark.Fill = New SolidColorBrush(Colors.White)
Me.selectedPointMark.Shape = MarkerShape.Circle
End Sub
' #endregion
End Class
