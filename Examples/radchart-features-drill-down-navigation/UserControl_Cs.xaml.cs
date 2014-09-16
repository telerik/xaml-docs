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

#region radchart-features-drill-down-navigation_1
private void BackButton_Click( object sender, RoutedEventArgs e )
{
    this.radChart.HierarchyManager.Back();
}
private void ForwardButton_Click( object sender, RoutedEventArgs e )
{
    this.radChart.HierarchyManager.Forward();
}
#endregion
}
