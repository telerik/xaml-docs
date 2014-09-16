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

#region radmap-features-providers_0
BingMapProvider bingMap = new BingMapProvider( MapMode.Aerial, true, "key" );
this.radMap.Provider = bingMap;
#endregion

#region radmap-features-providers_2
OpenStreetMapProvider openStreetMap = new OpenStreetMapProvider();
this.radMap.Provider = openStreetMap;
#endregion
}
