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

#region common-styling-themes-mscontrols_2
public App()
      {
          this.Startup += this.Application_Startup;
          this.Exit += this.Application_Exit;
          this.UnhandledException += this.Application_UnhandledException;
          StyleManager.ApplicationTheme = new Windows7Theme();
          InitializeComponent();
         StyleManager.SetBasedOn(((Style)Current.Resources[typeof(Button)]), StyleManager.ApplicationTheme);
      }
#endregion

}
