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

#region radwindow-features-window-icon_0
RadWindow radWindow = new RadWindow();
radWindow.Icon = new Image()
{
    Source = new BitmapImage(new Uri("../../Images/WindowIcon.png", UriKind.Relative ))
};
#endregion

#region radwindow-features-window-icon_3
RadWindow radWindow = new RadWindow();
radWindow.IconTemplate = this.Resources["WindowIconTemplate"] as DataTemplate;
#endregion
}
