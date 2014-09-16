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

#region radbusyindicator-features-delayed-display_1
private void showIndicatorButton_Click( object sender, RoutedEventArgs e )
{
    this.radBusyIndicator.IsBusy = true;
}
#endregion
}
