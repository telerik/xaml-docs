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

#region radmap-features-kml-data-import_1
this.informationLayer.Reader = new MapShapeReader();
this.informationLayer.Reader.Source = new Uri( "/Silverlight.Help.RadMapSamples;component/Data/bulgaria.kml", UriKind.RelativeOrAbsolute );
#endregion

#region radmap-features-kml-data-import_4
private void LoadKMLData()
{
    StreamResourceInfo streamResource = Application.GetResourceStream( new Uri( "/Sample;component/Data/bulgaria.kml", UriKind.RelativeOrAbsolute ) );
    List<FrameworkElement> elements = KmlReader.Read( streamResource.Stream );
    foreach ( FrameworkElement element in elements )
    {
        this.informationLayer.Items.Add( element );
    }
}
#endregion
}
