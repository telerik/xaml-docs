---
title: Implement custom map provider
page_title: Implement custom map provider
description: Implement custom map provider
slug: radmap-howto-custom-provider
tags: implement,custom,map,provider
published: True
position: 1
---

# Implement custom map provider



## 

Here is a list of all provider-related changes:

* The __IMapProvider__ interface no longer exists.

* The __MapProviderBase__ class exists but it should not be used as a base class for custom providers any more. 

* All custom map providers should inherit either from __TiledProvider__, or __ImageProvider__.

* __TiledProvider__ is a base class for map providers that show map as a sequence of tiles (e.g. BingMaps, OpenStreetMap).

* __ImageProvider__ is a base class for providers that show map as a single image (UriImageProvider). 

* Since all existing custom providers (prior to Q1 2011) show map as a sequence of tiles, they should be changed to inherit from the __TiledProvider__ class. The only property which must be overridden in these custom providers is __SpatialReference__ -- it should return the actual projection used by the provider (in all existing custom providers prior to Q1 2011 it should be __MercatorProjection__).



Here is a list of all map source-related changes:

* The map provider cannot be used as a map source by itself as it was allowed before.

* The logic which provides tiles must be moved to separate class – map source.

* All map source classes should inherit either from __TiledMapSource__, or __ImageMapSource__ classes and override methods depending on the specific map source type. 

* __TiledMapSource__is a base class for map sources that return map tiles (that includes all BingMaps sources: aerial, road, birds eye, and all OpensStreetMap sources: Mapnik and Osmarenderer)

* __ImageMapSource__ is a base class for map sources that return single map image.

* Since all existing providers prior to Q1 2011 show map as a sequence of tiles, their new map source classes should inherit from the __TiledMapSource__ class and meet the following requirements:

* Override the __Initialize__ method.

* Override the __GetTile__ method and existing custom logic should be moved here.

* Call __RaiseInitializeCompleted__ method when the respective custom provider is initialized (in case of simple providers it is enough to call this method from the override Initialize method).



Simple map provider that supports one map source can be as simple as following:

#### __C#__

{{region radmap-howto-custom-provider_0}}
	public class MyMapProvider : TiledProvider
	{
	       /// <summary>
	       /// Initializes a new instance of the MyMapProvider class.
	       /// </summary>
	       public MyMapProvider()
	             : base()
	       {
	             MyMapSource source = new MyMapSource();
	             this.MapSources.Add(source.UniqueId, source);
	       }
	       /// <summary>
	       /// Returns the SpatialReference for the map provider.
	       /// </summary>
	       public override ISpatialReference SpatialReference
	       {
	             get
	             {
	                    return new MercatorProjection();
	             }
	       }
	}
	public class MyMapSource : TiledMapSource
	{
	       /// <summary>
	       /// Initializes a new instance of the MyMapSource class.
	       /// </summary>
	       public MyMapSource()
	             : base(1, 20, 256, 256)
	       {
	       }
	       /// <summary>
	       /// Initialize provider.
	       /// </summary>
	       public override void Initialize()
	       {
	             // Raise provider initialized event.
	             this.RaiseIntializeCompleted();
	       }
	       /// <summary>
	       /// Gets the image URI.
	       /// </summary>
	       /// <param name="tileLevel">Tile level.</param>
	       /// <param name="tilePositionX">Tile X.</param>
	       /// <param name="tilePositionY">Tile Y.</param>
	       /// <returns>URI of image.</returns>
	       protected override Uri GetTile(int tileLevel, int tilePositionX, int tilePositionY)
	       {
	             int zoomLevel = ConvertTileToZoomLevel(tileLevel);
	             // Prepare tile url somehow ...
	             string url = CustomHelper.GetTileUrl(tileLevel, tilePositionX, tilePositionY);
	             return new Uri(url);
	       }
	}
	{{endregion}}



#### __VB.NET__

{{region radmap-howto-custom-provider_1}}
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
	{{endregion}}


