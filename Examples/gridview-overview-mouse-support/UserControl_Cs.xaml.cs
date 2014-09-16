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

#region gridview-overview-mouse-support_1
private void radGridView_MouseWheel( object sender, MouseWheelEventArgs e )
{
    MessageBox.Show( "The mouse wheel has changed: " + e.Delta );
}
    #endregion

#region gridview-overview-mouse-support_3
    public void AddHandler( RoutedEvent routedEvent, Delegate handler, bool handledEventsToo );
#endregion
}
