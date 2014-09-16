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

#region radtoolbar-declaration_0
using Telerik.Windows.Controls;
RadToolBar toolBar = new RadToolBar();
#endregion

#region radtoolbar-declaration_2
using Telerik.Windows.Controls;
RadToolBar toolBar = new RadToolBar();
Button button = new Button(){ Content="Button" };
toolBar.Items.Add(button);
#endregion

#region radtoolbar-declaration_4
using Telerik.Windows.Controls;
RadToolBar toolBar = new RadToolBar();
this.LayoutRoot.Children.Add(toolBar);
Button button = new Button(){ Content="Button" };
toolBar.Items.Add(button);
RadToolBar.SetOverflowMode(button, OverflowMode.Never);
OverflowMode om = RadToolBar.GetOverflowMode(toolBar);
#endregion

#region radtoolbar-declaration_6
using Telerik.Windows.Controls;
RadToolBar toolBar = new RadToolBar();
this.LayoutRoot.Children.Add(toolBar);
toolBar.ItemsSource = new List<object>()
{
new CheckBox() { IsChecked = true, Content = "Check box"},
new Button() { Content = "Button"},
new Image() { Source = new BitmapImage(new Uri("Images/image.png", UriKind.RelativeOrAbsolute))}
};
#endregion

#region radtoolbar-declaration_8
using Telerik.Windows.Controls;
RadToolBarTray toolBarTray = new RadToolBarTray();
RadToolBar toolBar = new RadToolBar();
this.LayoutRoot.Children.Add(toolBarTray);
toolBarTray.Items.Add(toolBar);
toolBar.Band = 0;
toolBar.BandIndex = 3;
#endregion
}
