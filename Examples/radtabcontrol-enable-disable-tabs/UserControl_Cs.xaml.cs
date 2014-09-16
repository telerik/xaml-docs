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

#region radtabcontrol-enable-disable-tabs_1
RadTabItem newTabItem = new RadTabItem();
newTabItem.Header = "Disabled Item";
// Add the newly created tab item to
// an existing tab control “tabControl”
radTabControl.Items.Add( newTabItem );
// Disable the newly created tab item
newTabItem.IsEnabled = false;
#endregion
}
