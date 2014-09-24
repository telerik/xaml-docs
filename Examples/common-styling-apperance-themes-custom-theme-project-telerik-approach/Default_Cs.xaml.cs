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

#region common-styling-apperance-themes-custom-theme-project-telerik-approach_0
[Telerik.Windows.Controls.ThemeLocation(Telerik.Windows.Controls.ThemeLocation.BuiltIn)]
#endregion

#region common-styling-apperance-themes-custom-theme-project-telerik-approach_3
using System;
using Telerik.Windows.Controls;
namespace Silverlight.Help.RadCommon
{
    [ThemeLocation( ThemeLocation.BuiltIn )]
    public class MyTheme : Theme
    {
        public MyTheme()
        {
            this.Source = new Uri( "/MyTheme;component/themes/Generic.xaml", UriKind.RelativeOrAbsolute );
        }
    }
}
#endregion

#region common-styling-apperance-themes-custom-theme-project-telerik-approach_5
Telerik.Windows.Controls.StyleManager.ApplicationTheme = new MyTheme.MyTheme();
#endregion
}
