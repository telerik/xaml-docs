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

#region extend-and-modify-builtin-themes_4
Telerik.Windows.Controls.StyleManager.ApplicationTheme =
                  new Theme(Uri("/Telerik.Windows.Themes.CustomTheme;component/Themes/generic.xaml",
                              UriKind.Relative));
#endregion

#region extend-and-modify-builtin-themes_5
public partial class App : Application
{
      public App()
      {
Telerik.Windows.Controls.StyleManager.ApplicationTheme =
                  new Theme(Uri("/Telerik.Windows.Themes.CustomTheme;component/Themes/generic.xaml",
                              UriKind.Relative));
            InitializeComponent();
      }
}
#endregion
}
