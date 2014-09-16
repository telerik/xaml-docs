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

#region radmap-features-shapefiles-support_1
this.informationLayer.Reader = new MapShapeReader();
this.informationLayer.Reader.Source = new Uri( "/Silverlight.Help.RadMapSamples;component/Data/world.shp", UriKind.RelativeOrAbsolute );
this.informationLayer.Reader.DataSource = new Uri( "/Silverlight.Help.RadMapSamples;component/Data/world.dbf", UriKind.RelativeOrAbsolute );
#endregion

#region radmap-features-shapefiles-support_3
StreamResourceInfo shapeResourceInfo = Application.GetResourceStream( new Uri( "/Silverlight.Help.RadMapSamples;component/Data/world.shp", UriKind.RelativeOrAbsolute ) );
StreamResourceInfo dbfResourceInfo = Application.GetResourceStream( new Uri( "/Silverlight.Help.RadMapSamples;component/Data/world.dbf", UriKind.RelativeOrAbsolute ) );
List<FrameworkElement> shapes = ShapeFileReader.Read( shapeResourceInfo.Stream, dbfResourceInfo.Stream );
foreach ( var shape in shapes )
{
    this.informationLayer.Items.Add( shape );
}
#endregion
}
