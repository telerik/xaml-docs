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

#region common-styling-apperance-themes-custom-theme-project_2
using System;
namespace MyTheme
{
    public class MyTheme : Telerik.Windows.Controls.Theme
    {
        public MyTheme()
        {
            this.Source = new Uri( "/MyTheme;component/Themes/Generic.xaml", UriKind.Relative );
        }
    }
}
#endregion

#region common-styling-apperance-themes-custom-theme-project_4
Telerik.Windows.Controls.StyleManager.ApplicationTheme = new MyTheme.MyTheme();
#endregion
}
