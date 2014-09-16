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

#region radtabcontrol-using-themes_2
VistaTheme theme = new VistaTheme();
RadTabControl radTabControl= new RadTabControl();
StyleManager.SetTheme( radTabControl, theme );
#endregion

#region radtabcontrol-using-themes_4
StyleManager.ApplicationTheme = new VistaTheme();
#endregion

#region radtabcontrol-using-themes_6
new VistaTheme().IsApplicationTheme = true;
#endregion

#region radtabcontrol-using-themes_9
Theme theme = new Theme( new Uri( "PathToMyTheme.xaml", UriKind.RelativeOrAbsolute ) );
RadTabControl radTabControl = new RadTabControl();
StyleManager.SetTheme( radTabControl, theme );
#endregion
}
