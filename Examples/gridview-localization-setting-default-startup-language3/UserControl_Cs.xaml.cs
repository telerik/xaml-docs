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

#region gridview-localization-setting-default-startup-language3_1
private void Application_Startup(object sender, StartupEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es");
            this.RootVisual = new MainPage();
        }
#endregion
#region gridview-localization-setting-default-startup-language3_3
public App()
      {
          Thread.CurrentThread.CurrentCulture = new CultureInfo("es");
          Thread.CurrentThread.CurrentUICulture = new CultureInfo("es");
      }

#endregion
}
