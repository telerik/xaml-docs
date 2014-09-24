Public Class Default_Vb


' #region radmap-howto-resize-map-shapes-with-mouse-dragging_3
Private Sub radMap_InitializeCompleted(ByVal sender As Object, ByVal e As EventArgs)
			If Not initialized Then
				initialized = True

				Me.BuildPolyline()
			End If
End Sub

		Private Sub BuildPolyline()
			Dim points As New LocationCollection()
			points.Add(New Location(40, -100))
			points.Add(New Location(41, -101))
			points.Add(New Location(40, -102))
			points.Add(New Location(43, -103))
			points.Add(New Location(45, -97))

			Dim polyline As New MapPolyline()
			polyline.Points = points

			Me.polylineLayer.Items.Add(polyline)
		End Sub
' #endregion

' #region radmap-howto-resize-map-shapes-with-mouse-dragging_4
  Private Sub pinPoint_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			If Not Me.isDragging Then
				Return
			End If

			Dim pinPoint = TryCast(sender, MapPinPoint)
			Dim oldLocation = MapLayer.GetLocation(pinPoint)
			Dim location = Location.GetCoordinates(radMap, e.GetPosition(radMap))
			MapLayer.SetLocation(TryCast(sender, DependencyObject), location)

			Dim polyline = TryCast(Me.polylineLayer.Items(0), MapPolyline)
			For i As Integer = 0 To polyline.Points.Count - 1
				Dim locationPoint = polyline.Points(i)
				If locationPoint Is oldLocation Then
					polyline.Points(i) = location
					Exit For
				End If
			Next i
  End Sub
' #endregion
End Class
