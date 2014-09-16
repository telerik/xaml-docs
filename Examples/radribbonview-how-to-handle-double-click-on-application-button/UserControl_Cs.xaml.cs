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

#region radribbonview-keyboard-support_4
private void KeyTipActivation_Activated(object sender, Telerik.Windows.RadRoutedEventArgs e)
{
  MessageBox.Show("The key tip of the "+(e.OriginalSource as RadRibbonButton).Text.ToString() + "was activated.");
}
private void HomeButton1_Click(object sender, RoutedEventArgs e)
{
  MessageBox.Show((sender as RadRibbonButton).Text.ToString() + "was clicked.");
}
#endregion
}
