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

#region radribbonview-ribbon-window-wpf_1
public partial class MainWindow : RadRibbonWindow
{
 public MainWindow()
 {
  InitializeComponent();
 }
}
#endregion

#region radribbonview-ribbon-window-wpf_2
public partial class MainWindow : RadRibbonWindow
{
	static MainWindow()
	{
		RadRibbonWindow.IsWindowsThemeEnabled = false;
	}
	public MainWindow()
	{
		InitializeComponent();
	}
}
#endregion
}
