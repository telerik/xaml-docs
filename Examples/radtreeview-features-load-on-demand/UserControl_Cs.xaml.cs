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

#region radtreeview-features-load-on-demand_2
private void EnableLoadOnDemand( RadTreeViewItem radTreeViewItem )
{
    radTreeViewItem.IsLoadOnDemandEnabled = true;
}
#endregion

#region radtreeview-features-load-on-demand_5
private void RadTreeViewItem_LoadOnDemand( object sender, Telerik.Windows.RadRoutedEventArgs e )
{
    // get the clicked Item
    RadTreeViewItem clickedItem = sender as RadTreeViewItem;
    // add the new items
    RadTreeViewItem newItem = new RadTreeViewItem()
    {
        Header = "Soccer"
    };
    clickedItem.Items.Add( newItem );
}
#endregion

#region radtreeview-features-load-on-demand_8
private void radTreeView_LoadOnDemand( object sender, RadRoutedEventArgs e )
{
    // get the treeview
    Telerik.Windows.Controls.RadTreeView tree = sender as Telerik.Windows.Controls.RadTreeView;
    // get the clicked Item
    RadTreeViewItem clickedItem = e.OriginalSource as RadTreeViewItem;
    // add the new items
    RadTreeViewItem newItem = new RadTreeViewItem()
    {
        Header = "New Item"
    };
    clickedItem.Items.Add( newItem );
    clickedItem.IsLoadOnDemandEnabled = false;
}
#endregion
}
