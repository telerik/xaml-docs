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

#region radmap-features-information-layer_4
private void radMap_InitializeCompleted( object sender, EventArgs e )
{
    this.informationLayer.Visibility = System.Windows.Visibility.Collapsed;
}
#endregion
}
