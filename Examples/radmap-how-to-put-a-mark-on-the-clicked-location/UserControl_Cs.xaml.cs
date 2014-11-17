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

#region radmap-how-to-put-a-mark-on-the-clicked-location_1
private void radMap_MapMouseClick( object sender, MapMouseRoutedEventArgs eventArgs )
{
    this.informationLayer.Items.Clear();
    this.informationLayer.Items.Add( eventArgs.Location );
}
#endregion
}
