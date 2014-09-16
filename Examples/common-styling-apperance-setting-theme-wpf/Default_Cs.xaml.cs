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

#region common-styling-apperance-setting-theme-wpf_1
StyleManager.SetTheme( radSlider, new VistaTheme() );
#endregion

#region common-styling-apperance-setting-theme-wpf_4
StyleManager.ApplicationTheme = new VistaTheme();
#endregion

#region common-styling-apperance-setting-theme-wpf_6
public partial class Window1 : Window
{
    public Window1()
    {
        StyleManager.ApplicationTheme = new VistaTheme();
        InitializeComponent();
    }
}
#endregion
}
