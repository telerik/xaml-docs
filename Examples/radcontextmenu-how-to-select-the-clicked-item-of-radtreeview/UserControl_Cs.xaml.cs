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

#region radcontextmenu-how-to-select-the-clicked-item-of-radtreeview_2
private void RadContextMenu_Opened( object sender, RoutedEventArgs e )
{
}
#endregion

#region radcontextmenu-how-to-select-the-clicked-item-of-radtreeview_4
private void RadContextMenu_Opened( object sender, RoutedEventArgs e )
{
    RadTreeViewItem item = this.radContextMenu.GetClickedElement<RadTreeViewItem>();
}
#endregion

#region radcontextmenu-how-to-select-the-clicked-item-of-radtreeview_6
private void RadContextMenu_Opened( object sender, RoutedEventArgs e )
{
    RadTreeViewItem item = this.radContextMenu.GetClickedElement<RadTreeViewItem>();
    if ( item != null )
    {
        this.radTreeView.SelectedItem = item;
    }
}
#endregion
}
