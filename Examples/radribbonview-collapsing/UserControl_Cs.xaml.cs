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

#region radribbonview-collapsing_2
private void radRibbonView_CollapsedChanged(object sender, Telerik.Windows.RadRoutedEventArgs e)
{
 RadRibbonView ribbonView = sender as RadRibbonView;
 bool isCollapsed = ribbonView.IsCollapsed;
}
#endregion
}
