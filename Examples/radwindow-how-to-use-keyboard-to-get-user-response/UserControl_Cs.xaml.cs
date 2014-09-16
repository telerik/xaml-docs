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

#region radwindow-how-to-use-keyboard-to-get-user-response_1
private void OnButtonAcceptClicked( object sender, RoutedEventArgs e )
{
    this.DialogResult = true;
    this.Close();
}
private void OnButtonCancelClicked( object sender, RoutedEventArgs e )
{
    this.DialogResult = false;
    this.Close();
}
#endregion
}
