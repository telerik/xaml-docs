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

#region radwindow-features-modal-windows_0
RadWindow = new RadWindow();
radWindow.Show();
#endregion

#region radwindow-features-modal-windows_2
RadWindow radWindow = new RadWindow();
radWindow.ShowDialog();
#endregion
}
