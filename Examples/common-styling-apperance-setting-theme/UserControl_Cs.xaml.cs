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

#region common-styling-apperance-setting-theme_1
StyleManager.SetTheme( radSlider, new VistaTheme() );
#endregion

#region common-styling-apperance-setting-theme_3
StyleManager.ApplicationTheme = new VistaTheme();
#endregion

#region common-styling-apperance-setting-theme_5
public partial class MainPage : UserControl
{
    public MainPage()
    {
        StyleManager.ApplicationTheme = new VistaTheme();
        InitializeComponent();
    }
}
#endregion

#region common-styling-apperance-setting-theme_7
Telerik.Windows.Controls.StyleManager.ApplicationTheme = new Theme( Uri( "/Telerik.Windows.Themes.CustomTheme;component/Themes/Generic.xaml", UriKind.Relative ) );
#endregion

#region common-styling-apperance-setting-theme_9
public class CustomTheme : Telerik.Windows.Controls.Theme
{
}
#endregion

#region common-styling-apperance-setting-theme_11
[ThemeLocation( ThemeLocation.BuiltIn )]
public class CustomTheme : Telerik.Windows.Controls.Theme
{
}
#endregion

#region common-styling-apperance-setting-theme_13
public CustomTheme()
{
    this.Source = new Uri( "/Telerik.Windows.Themes.CustomTheme;component/themes/Generic.xaml", UriKind.Relative );
}
#endregion
}
