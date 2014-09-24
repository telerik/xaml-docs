using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radmap-howto-custom-provider_0
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
#endregion
}
