'#region raddiagrams-features-pan-zoom-0
DiagramConstants.MinimumZoom = 0.2
DiagramConstants.MaximumZoom = 10	
'#endregion
'#region raddiagrams-features-pan-zoom-1
'zoom in with a factor of 0.67
Private Sub CustomZoomIn()
    Me.xDiagram.ZoomIn(0.67)
End Sub
'zoom out with a factor of 0.67
Private Sub CustomZoomOut()
    Me.xDiagram.ZoomOut(0.67)
End Sub
'#endregion
'#region raddiagrams-features-pan-zoom-2
'zoom in around the point with coordinates of (125,200)
Private Sub ZoomIn(sender As Object, e As RoutedEventArgs)
    Me.xDiagram.ZoomIn(Nothing, New Point(125, 200))
End Sub
'zoom out around the point with coordinates of (100,125)
Private Sub ZoomOut(sender As Object, e As RoutedEventArgs)
    Me.xDiagram.ZoomOut(Nothing, New Point(100, 125))
End Sub
'#endregion
'#region raddiagrams-features-pan-zoom-3
'zoom in around the point with coordinates of (125,200) with a zoom factor of 0.67
Private Sub ZoomIn(sender As Object, e As RoutedEventArgs)
    Me.xDiagram.ZoomIn(0.67, New Point(125, 200))
End Sub
'zoom out around the point with coordinates of (100,125) with a zoom factor of 0.67
Private Sub ZoomOut(sender As Object, e As RoutedEventArgs)
    Me.xDiagram.ZoomOut(0.67, New Point(100, 125))
End Sub
'#endregion
'#region raddiagrams-features-pan-zoom-4
Private Sub xDiagram_PreviewZoom(sender As Object, e As DiagramZoomEventArgs)
    Dim delta As Double = e.TargetZoom - e.Zoom
    Dim newZoom = If(delta > 0, e.Zoom * 1.5, e.Zoom / 1.5)

    If DiagramConstants.MinimumZoom <= newZoom AndAlso newZoom <= DiagramConstants.MaximumZoom Then
        e.TargetZoom = newZoom
    Else
        e.Handled = True
    End If
End Sub
'#endregion
'#region raddiagrams-features-pan-zoom-5
Private availableZooms As New List(Of Double)() From { 0.1, 0.125, 0.16, 0.2, 0.25, 0.33, 0.5, 0.67, 1, 1.5, 2, 3, 4, 5, 6, 8, 10}
Private Sub xDiagram_PreviewZoom(sender As Object, e As DiagramZoomEventArgs)
    Dim delta As Double = e.TargetZoom - e.Zoom
    Dim index As Integer = Me.availableZooms.IndexOf(e.Zoom)
    Dim newIndex = If(delta > 0, index + 1, index - 1)

    If delta <> 0 AndAlso 0 <= newIndex AndAlso newIndex < Me.availableZooms.Count Then
        e.TargetZoom = Me.availableZooms.ElementAt(newIndex)
    Else
        e.Handled = True
    End If

End Sub
'#endregion