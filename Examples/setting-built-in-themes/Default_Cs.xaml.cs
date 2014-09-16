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

#region setting-built-in-themes_3
public partial class App : Application
{
      public App()
      {
Telerik.Windows.Controls.StyleManager.ApplicationTheme = new SummerTheme();
            InitializeComponent();
      }
}
#endregion
}
