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

#region radmap-getting-started_2
this.radMap.Provider = new BingMapProvider( MapMode.Aerial, true, "key" );
#endregion
}
