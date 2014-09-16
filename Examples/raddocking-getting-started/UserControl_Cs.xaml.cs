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

#region raddocking-getting-started_6
private void ButtonShow_Click(object sender, RoutedEventArgs e)
{
 this.hiddenPane.IsHidden = false;
}
private void ButtonHide_Click(object sender, RoutedEventArgs e)
{
 this.hiddenPane.IsHidden = true;
}
#endregion
}
