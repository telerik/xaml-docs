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
private void Application_Startup( object sender, StartupEventArgs e )
{
    this.RootVisual = new MainPage();
}
#endregion

#region common-styling-apperance-setting-theme_5
StyleManager.ApplicationTheme = new VistaTheme();
#endregion

#region common-styling-apperance-setting-theme_7
public partial class MainPage : UserControl
{
    public MainPage()
    {
        StyleManager.ApplicationTheme = new VistaTheme();
        InitializeComponent();
    }
}
#endregion

#region common-styling-apperance-setting-theme_9
public partial class App : Application
{
    public App()
    {
        this.Startup += this.Application_Startup;
        this.Exit += this.Application_Exit;
        this.UnhandledException += this.Application_UnhandledException;
        StyleManager.ApplicationTheme = new VistaTheme();
        InitializeComponent();
    }
}
#endregion

#region common-styling-apperance-setting-theme_11
Telerik.Windows.Controls.StyleManager.ApplicationTheme = new Theme( Uri( "/Telerik.Windows.Themes.CustomTheme;component/Themes/Generic.xaml", UriKind.Relative ) );
#endregion

#region common-styling-apperance-setting-theme_13
public class CustomTheme : Telerik.Windows.Controls.Theme
{
}
#endregion

#region common-styling-apperance-setting-theme_15
[ThemeLocation( ThemeLocation.BuiltIn )]
public class CustomTheme : Telerik.Windows.Controls.Theme
{
}
#endregion

#region common-styling-apperance-setting-theme_17
public CustomTheme()
{
    this.Source = new Uri( "/Telerik.Windows.Themes.CustomTheme;component/themes/Generic.xaml", UriKind.Relative );
}
#endregion

#region common-styling-apperance-setting-theme_19
public CustomTheme()
{
   public class MyCustomGrid:RadGridView
   {
       static MyCustomGrid()
       {
           DefaultStyleKeyProperty.OverrideMetadata(typeof(MyCustomGrid), new FrameworkPropertyMetadata(typeof(MyCustomGrid)));
       }
 
       protected override void OnInitialized(EventArgs e)
       {
           base.OnInitialized(e);
           Theme theme = StyleManager.GetTheme(this);
           Type themeType = null;
           if (theme != null)
           {
               themeType = theme.GetType();
           }
           this.DefaultStyleKey = new ThemeResourceKey() { ElementType = typeof(RadGridView), ThemeType = themeType };
       }
   }
}
#endregion

}
