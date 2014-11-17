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

#region radwindow-how-to-prevent-dragging-off-the-screen_0
RadWindow radWindow = new RadWindow();
radWindow.IsRestricted = true;
#endregion
}
