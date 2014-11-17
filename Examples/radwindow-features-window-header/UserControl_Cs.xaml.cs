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

#region radwindow-features-window-header_0
RadWindow radWindow = new RadWindow();
radWindow.Header = "My RadWindow";
#endregion

#region radwindow-features-window-header_3
RadWindow radWindow = new RadWindow();
radWindow.HeaderTemplate = this.Resources[ "WindowHeaderTemplate" ] as DataTemplate;
#endregion
}
