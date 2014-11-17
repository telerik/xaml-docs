Public Class Default_Vb


' #region radmap-features-dynamic-layer_2
Public Class MapDynamicSource
      Implements IMapDynamicSource
                  Public Sub ItemsRequest(ByVal sender As Object, ByVal e As ItemsRequestEventArgs)
                        Dim items As New List(Of Object)()
                        Dim minZoom As Double = e.MinZoom
                        Dim upperLeft As Location = e.UpperLeft
                        Dim lowerRight As Location = e.LowerRight
                           Dim centerSpot As New HotSpot()
                        centerSpot.X = 0.5
                        centerSpot.Y = 0.5
                        Dim bulgariaLocation As New Location(42.7669999748468, 25.2819999307394)
                        Dim currentRegion As New LocationRect(upperLeft, lowerRight)
                        If currentRegion.Contains(bulgariaLocation) Then
                              If minZoom = 3 Then
                                    Dim ellipse As New Ellipse()
                                    ellipse.Width = 15
                                    ellipse.Height = 15
                                    ellipse.Fill = New SolidColorBrush(Colors.Red)
                                    ellipse.SetValue(MapLayer.LocationProperty, bulgariaLocation)
                                    MapLayer.SetHotSpot(ellipse, centerSpot)
                                    ToolTipService.SetToolTip(ellipse, "Bulgaria")
                                    items.Add(ellipse)
                              ElseIf minZoom = 6 Then
                                    Dim sofiaEllipse As New Ellipse()
                                    sofiaEllipse.Width = 20
                                    sofiaEllipse.Height = 20
                                    sofiaEllipse.Stroke = New SolidColorBrush(Colors.Red)
                                    sofiaEllipse.Fill = New SolidColorBrush(Colors.Transparent)
                                    sofiaEllipse.StrokeThickness = 3
                                    sofiaEllipse.SetValue(MapLayer.LocationProperty, New Location(42.6957539183824, 23.3327663758679))
                                    MapLayer.SetHotSpot(sofiaEllipse, centerSpot)
                                    ToolTipService.SetToolTip(sofiaEllipse, "Sofia")
                                    items.Add(sofiaEllipse)
                              End If
                        End If
                        e.CompleteItemsRequest(items)
                  End Sub
End Class
' #endregion

' #region radmap-features-dynamic-layer_4
Public Sub New()
InitializeComponent()
Me.radMap.Provider = New BingMapProvider(MapMode.Aerial, True, "--Your Key here--")
Me.dynamicLayer.DynamicSource = New MapDynamicSource()
End Sub
' #endregion
End Class
