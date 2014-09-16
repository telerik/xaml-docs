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

#region radtreeview-events-working-mouse-left-button-down-event_1
using Telerik.Windows;
this.radTreeView.AddHandler(RadTreeViewItem.MouseLeftButtonDownEvent, new MouseButtonEventHandler(this.radTreeView_MouseLeftButtonDown), true);
private void radTreeView_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
{
    Telerik.Windows.Controls.RadTreeView treeView = sender as Telerik.Windows.Controls.RadTreeView;
}
#endregion
}
