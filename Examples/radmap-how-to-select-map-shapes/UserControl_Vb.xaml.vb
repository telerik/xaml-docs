Public Class Default_Vb


' #region radmap-how-to-select-map-shapes_3
   Private initialized As Boolean

		' selected segment and polyline 
		Private selectedLine As MapLine
		Private selectedPolyline As MapPolyline

		Public Sub New()
			InitializeComponent()
		End Sub

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
			Me.SetDefaultStyle(polyline)

			Me.polylineLayer.Items.Add(polyline)
			Me.BuildLines(polyline)
		End Sub
' #endregion

' #region radmap-how-to-select-map-shapes_5
Private Sub BuildLines(ByVal polyline As MapPolyline)
			For i As Integer = 0 To polyline.Points.Count - 2
				Dim point1 As Location = polyline.Points(i)
				Dim point2 As Location = polyline.Points(i + 1)
				Dim line As New MapLine() With {.Point1 = point1, .Point2 = point2}

				Me.SetDefaultStyle(line)

				AddHandler line.MouseLeftButtonDown, AddressOf line_MouseLeftButtonDown
				line.Tag = polyline

				Me.lineLayer.Items.Add(line)
			Next i
   End Sub

		Private Sub line_MouseLeftButtonDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
			Dim line As MapLine = TryCast(sender, MapLine)
			If line IsNot Nothing Then
				If Me.selectedLine IsNot Nothing Then
					Me.SetDefaultStyle(Me.selectedLine)
				End If

				If Me.selectedPolyline IsNot Nothing Then
					Me.SetDefaultStyle(Me.selectedPolyline)
				End If

				Me.selectedLine = line
				Me.selectedPolyline = TryCast(line.Tag, MapPolyline)

				Me.SetSelectedStyle(Me.selectedLine)
				Me.SetSelectedStyle(Me.selectedPolyline)
			End If
		End Sub
' #endregion

' #region radmap-how-to-select-map-shapes_7
Private Sub SetDefaultStyle(ByVal shape As MapShape)
			If TypeOf shape Is MapLine Then
				shape.Style = TryCast(Me.Resources("defaultLineStyle"), Style)
			Else
				shape.Style = TryCast(Me.Resources("defaultPolylineStyle"), Style)
			End If
End Sub

		Private Sub SetSelectedStyle(ByVal shape As MapShape)
			If TypeOf shape Is MapLine Then
				shape.Style = TryCast(Me.Resources("selectedLineStyle"), Style)
			Else
				shape.Style = TryCast(Me.Resources("selectedPolylineStyle"), Style)
			End If
		End Sub
' #endregion
End Class
