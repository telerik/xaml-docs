Public Class Default_Vb


' #region radmap-howto-custom-provider_1
Public Class MyMapProvider
 Inherits TiledProvider
 ''' <summary>
 ''' Initializes a new instance of the MyMapProvider class.
 ''' </summary>
 Public Sub New()
  MyBase.New()
  Dim source As New MyMapSource()
  Me.MapSources.Add(source.UniqueId, source)
 End Sub
 ''' <summary>
 ''' Returns the SpatialReference for the map provider.
 ''' </summary>
 Public Overrides ReadOnly Property SpatialReference() As ISpatialReference
  Get
   Return New MercatorProjection()
  End Get
 End Property
End Class
Public Class MyMapSource
 Inherits TiledMapSource
 ''' <summary>
 ''' Initializes a new instance of the MyMapSource class.
 ''' </summary>
 Public Sub New()
  MyBase.New(1, 20, 256, 256)
 End Sub
 ''' <summary>
 ''' Initialize provider.
 ''' </summary>
 Public Overrides Sub Initialize()
  ' Raise provider intialized event.
  Me.RaiseIntializeCompleted()
 End Sub
 ''' <summary>
 ''' Gets the image URI.
 ''' </summary>
 ''' <param name="tileLevel">Tile level.</param>
 ''' <param name="tilePositionX">Tile X.</param>
 ''' <param name="tilePositionY">Tile Y.</param>
 ''' <returns>URI of image.</returns>
 Protected Overrides Function GetTile(tileLevel As Integer, tilePositionX As Integer, tilePositionY As Integer) As Uri
  Dim zoomLevel As Integer = ConvertTileToZoomLevel(tileLevel)
  ' Prepare tile url somehow ...
  Dim url As String = CustomHelper.GetTileUrl(tileLevel, tilePositionX, tilePositionY)
  Return New Uri(url)
 End Function
End Class
' #endregion
End Class
