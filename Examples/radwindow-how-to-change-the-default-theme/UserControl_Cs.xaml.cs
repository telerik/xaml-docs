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
#region radwindow-how-to-change-the-default-theme_1
var newWindow = new RadWindow()
{
    Width = 300,
    Height = 300               
};
newWindow.Show();
#endregion
}
