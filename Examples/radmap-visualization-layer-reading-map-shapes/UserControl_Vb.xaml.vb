Public Class Default_Vb

' #region radmap_visualization_layer_reading_map_shapes_0
Partial Public Class EsriFileReader
	Inherits UserControl
	Public Sub New()
		InitializeComponent()

		AddHandler Me.Loaded, AddressOf Me.ExampleLoaded
	End Sub

	Private Sub ExampleLoaded(sender As Object, e As RoutedEventArgs)
		Me.busyIndicator.IsIndeterminate = False
		Me.busyIndicator.IsBusy = True
		Me.mapShapeDataReader.Source = New Uri("/TestMapFeatures;component/Resources/GeoData/zt06_d00.shp", UriKind.Relative)
	End Sub

	Private Sub OnProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs)
		Me.busyIndicator.ProgressValue = e.ProgressPercentage
		If e.ProgressPercentage >= 100 Then
			Me.busyIndicator.IsIndeterminate = True
			Me.busyIndicator.BusyContent = "Refresh layer"
		End If
	End Sub

	Private Sub OnReadShapeDataCompleted(sender As Object, e As Telerik.Windows.Controls.Map.ReadShapeDataCompletedEventArgs)
		If Me.busyIndicator IsNot Nothing Then
			Me.busyIndicator.IsBusy = False
		End If
	End Sub
End Class
' #endregion

' #region radmap_visualization_layer_reading_map_shapes_1
Me.visualizationLayer.Reader.ToolTipFormat = "CNTRY_NAME"
' #endregion

' #region radmap_visualization_layer_reading_map_shapes_2
Me.visualizationLayer.Reader.ToolTipFormat = "{SQKM|F2}"
' #endregion

' #region radmap_visualization_layer_reading_map_shapes_3
Me.visualizationLayer.Reader.ToolTipFormat = "{CNTRY_NAME} - {SQKM|#,#.0} sq. km."
' #endregion

' #region radmap_visualization_layer_reading_map_shapes_4
Me.mapShapeDataReader.SourceCollection.Add( _
	New AsyncReaderSource() With _
	{
		.Source = New Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_base.shp", UriKind.RelativeOrAbsolute) _
	})
Me.mapShapeDataReader.SourceCollection.Add( _
	New AsyncReaderSource() With _
	{
		.Source = New Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_Corridors.shp", UriKind.RelativeOrAbsolute) _
	})
Me.mapShapeDataReader.SourceCollection.Add( _
	New AsyncReaderSource() With _
	{
		.Source = New Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_ServiceRooms.shp", UriKind.RelativeOrAbsolute) _
	})
Me.mapShapeDataReader.SourceCollection.Add( _
	New AsyncReaderSource() With _
	{
		.Source = New Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_LiftsAndLadders.shp", UriKind.RelativeOrAbsolute) _
	})
Me.mapShapeDataReader.SourceCollection.Add( _
	New AsyncReaderSource() With _
	{
		.Source = New Uri("/TestMapFeatures;component/Resources/GeoData/Hotel/Hotel_Rooms.shp", UriKind.RelativeOrAbsolute) _
	})

Me.mapShapeDataReader.ReadAsync()
' #endregion

' #region radmap_visualization_layer_reading_map_shapes_5

' #endregion

End Class
