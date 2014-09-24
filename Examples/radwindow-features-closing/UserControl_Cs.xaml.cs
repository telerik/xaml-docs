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

#region radwindow-features-closing_0
RadWindow radWindow = new RadWindow();
radWindow.Show();
...
radWindow.Close();
#endregion

#region radwindow-features-closing_2
RadWindow radWindow = new RadWindow();
radWindow.CanClose = false;
#endregion
}
