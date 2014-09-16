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

#region radtreeview-features-keyboard-support_1
private void radTreeView_KeyDown( object sender, KeyEventArgs e )
{
    MessageBox.Show( "The pressed key is: " + e.Key.ToString() );
}
private void radTreeView_KeyUp( object sender, KeyEventArgs e )
{
    MessageBox.Show( "The released key is: " + e.Key.ToString() );
}
#endregion
}
