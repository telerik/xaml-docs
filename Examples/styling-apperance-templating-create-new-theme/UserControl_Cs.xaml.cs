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

#region styling-apperance-templating-create-new-theme_0
Telerik.Windows.Controls.StyleManager.ApplicationTheme = new Theme( Uri( "/Telerik.Windows.Themes.CustomTheme;component/Themes/Generic.xaml", UriKind.Relative ) );
#endregion

#region styling-apperance-templating-create-new-theme_2
public class CustomTheme : Telerik.Windows.Controls.Theme
{
}
#endregion

#region styling-apperance-templating-create-new-theme_4
[ThemeLocation( ThemeLocation.BuiltIn )]
public class CustomTheme : Telerik.Windows.Controls.Theme
{
}
#endregion

#region styling-apperance-templating-create-new-theme_6
public CustomTheme()
{
    this.Source = new Uri( "/Telerik.Windows.Themes.CustomTheme;component/themes/Generic.xaml", UriKind.Relative );
}
#endregion
}
