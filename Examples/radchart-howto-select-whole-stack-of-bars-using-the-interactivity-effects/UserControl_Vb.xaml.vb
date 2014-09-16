Public Class Default_Vb


' #region radchart-howto-select-whole-stack-of-bars-using-the-interactivity-effects_1
Partial Public Class MainPage
         Inherits UserControl
            Public Class Company
                  Public Property Value1() As Double
                  Public Property Value2() As Double
                  Public Property Value3() As Double
                  Public Property Category() As Date
                  Public Sub New(ByVal category As Date, ByVal value1 As Double, ByVal value2 As Double, ByVal value3 As Double)
                        Me.Category = category
                        Me.Value1 = value1
                        Me.Value2 = value2
                        Me.Value3 = value3
                  End Sub
            End Class
            Public Sub New()
                  InitializeComponent()
                  AddHandler RadChart1.DefaultView.ChartArea.ItemClick, AddressOf ChartArea_ItemClick
                  Dim today As Date = Date.Today
                  Dim sampleData As New List(Of Company)()
                  Dim r As New Random()
                  For i As Integer = 0 To 2
                        sampleData.Add(New Company(today.AddDays(i), r.Next(0, 100), r.Next(0, 100), r.Next(0, 100)))
                  Next i
                  Dim seriesMapping As SeriesMapping = New SeriesMapping With {.LegendLabel = "Series 1"}
                  seriesMapping.ItemMappings.Add(New ItemMapping("Value1", DataPointMember.YValue))
                  seriesMapping.ItemMappings.Add(New ItemMapping("Category", DataPointMember.XCategory))
                  Dim seriesMapping1 As SeriesMapping = New SeriesMapping With {.LegendLabel = "Series 2"}
                  seriesMapping1.ItemMappings.Add(New ItemMapping("Value2", DataPointMember.YValue))
                  seriesMapping1.ItemMappings.Add(New ItemMapping("Category", DataPointMember.XCategory))
                  Dim seriesMapping2 As SeriesMapping = New SeriesMapping With {.LegendLabel = "Series 3"}
                  seriesMapping2.ItemMappings.Add(New ItemMapping("Value3", DataPointMember.YValue))
                  seriesMapping2.ItemMappings.Add(New ItemMapping("Category", DataPointMember.XCategory))
                  Dim horBar As New StackedBarSeriesDefinition()
                  horBar.InteractivitySettings.SelectionMode = ChartSelectionMode.Multiple
                  horBar.InteractivitySettings.SelectionScope = InteractivityScope.Item
                  seriesMapping2.SeriesDefinition = horBar
                  seriesMapping1.SeriesDefinition = horBar
                  seriesMapping.SeriesDefinition = horBar
                  RadChart1.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Inside
                  RadChart1.ItemsSource = sampleData
                  RadChart1.SeriesMappings.Add(seriesMapping)
                  RadChart1.SeriesMappings.Add(seriesMapping1)
                  RadChart1.SeriesMappings.Add(seriesMapping2)
            End Sub
            Private Sub ChartArea_ItemClick(ByVal sender As Object, ByVal e As ChartItemClickEventArgs)
                  If RadChart1.DefaultView.ChartArea.SelectedItems.Count > 1 Then
                        RadChart1.DefaultView.ChartArea.ClearSelection()
                  End If
                  Dim barsInStack As New List(Of DataPoint)()
                  For Each item As StackedBar In Me.RadChart1.DefaultView.ChartArea.ChildrenOfType(Of StackedBar)()
                        If item.DataPoint.XCategory = e.DataPoint.XCategory Then
                              barsInStack.Add(item.DataPoint)
                        End If
                  Next item
                  RadChart1.DefaultView.ChartArea.SelectItems(barsInStack)
            End Sub
   End Class
' #endregion
End Class
