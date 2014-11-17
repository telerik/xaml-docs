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

#region radwindow-styles-and-templates-styling-the-predefined-windows_0
DialogParameters parameters = new DialogParameters();
parameters.ContentStyle = this.Resources["RadAlertStyle"] as Style;
parameters.Content = "Hello";
RadWindow.Alert(parameters);
#endregion
}
