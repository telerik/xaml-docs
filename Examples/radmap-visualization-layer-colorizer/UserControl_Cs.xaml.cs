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

#region radmap-features-click-modes_2
private void radMap_MapMouseClick( object sender, MapMouseRoutedEventArgs e )
{
    //implement logic regarding single click here
}
private void radMap_MapMouseDoubleClick( object sender, MapMouseRoutedEventArgs e )
{
    //implement logic regarding double click here
}
#endregion
}
