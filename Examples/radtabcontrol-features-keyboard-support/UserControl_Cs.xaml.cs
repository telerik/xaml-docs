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

#region radtabcontrol-features-keyboard-support_1
private void tabControl_KeyDown( System.Object sender, System.Windows.Input.KeyEventArgs e)
{
    MessageBox.Show("The pressed key is: " + e.Key.ToString());
}
private void tabControl_KeyUp( System.Object sender, System.Windows.Input.KeyEventArgs e)
{
    MessageBox.Show("The released key is: " + e.Key.ToString());
}
#endregion
}
