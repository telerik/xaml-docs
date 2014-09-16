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

#region raddocking-how-to-disable-the-close-button_2
private void HideTheCloseButton()
{
    radPane.CanUserClose = false;
}
#endregion

#region raddocking-how-to-disable-the-close-button_5
private void radDocking_PreviewClose( object sender, StateChangeEventArgs e )
{
    e.Handled = true;
}
#endregion
}
