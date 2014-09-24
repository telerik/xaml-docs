Public Class Default_Vb
' #region radmap-features-information-layer-clustereddatasource_2
 Public Sub New()
		InitializeComponent()

		Dim rect As New LocationRect(New Location(39, -120), New Location(32, -113))
		Dim items As ObservableCollection(Of Location) = Me.CreatePointsInRect(1000, rect)

		Dim dataSource As New ClusteredDataSource()
		dataSource.GenerateClustersOnZoom = True
		dataSource.ItemsSource = items
		Me.informationLayer.ClusteredDataSource = dataSource
   End Sub

	Private Function CreatePointsInRect(ByVal count As Integer, ByVal rect As LocationRect) As ObservableCollection(Of Location)
		Dim collection As New ObservableCollection(Of Location)()

		rect.MapControl = Me.radMap

		For i As Integer = 0 To count - 1
			Dim loc As New Location(rect.North - rect.GeoSize.Height * rnd.NextDouble(), rect.West + rect.GeoSize.Width * rnd.NextDouble())

			collection.Add(loc)
		Next i

		Return collection
	End Function
' #endregion

' #region radmap-features-information-layer-clustereddatasource_5
Private Sub ClusterMouseClick(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
	Dim element As FrameworkElement = TryCast(sender, FrameworkElement)
	If element IsNot Nothing Then
		Dim cluster As ClusterItem = TryCast(element.DataContext, ClusterItem)
		If cluster IsNot Nothing Then
			If cluster.ClusterState = ClusterState.ExpandedToPolygon OrElse cluster.ClusterState = ClusterState.Expanded Then
				cluster.ClusterState = ClusterState.Collapsed
			Else
				cluster.HideExpanded = False
				cluster.ClusterState = ClusterState.ExpandedToPolygon
			End If
		End If
	End If
End Sub

Private Sub ClusterRightMouseClick(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
	Dim element As FrameworkElement = TryCast(sender, FrameworkElement)
	If element IsNot Nothing Then
		Dim cluster As ClusterItem = TryCast(element.DataContext, ClusterItem)
		If cluster IsNot Nothing Then
			cluster.HideExpanded = True
			cluster.ClusterState = ClusterState.Expanded
		End If
	End If

	e.Handled = True
End Sub

Private Sub ClusteredItemMouseClick(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
	Dim element As FrameworkElement = TryCast(sender, FrameworkElement)
	If element IsNot Nothing Then
		Dim item As ClusteredItem = TryCast(element.DataContext, ClusteredItem)
		If item IsNot Nothing Then
			Dim dataSource As ClusteredDataSource = item.DataSource
			If dataSource IsNot Nothing Then
				dataSource.Collapse(item.Data)
			End If
		End If
	End If
End Sub
' #endregion
End Class
