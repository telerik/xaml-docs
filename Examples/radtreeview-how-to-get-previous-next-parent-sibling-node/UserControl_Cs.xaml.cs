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

#region radtreeview-how-to-get-previous-next-parent-sibling-node_2
private void radTreeView_SelectionChanged( object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e )
{
    // Get a reference to the treeview
    Telerik.Windows.Controls.RadTreeView treeView = sender as Telerik.Windows.Controls.RadTreeView;
    // Get the currently selected items
    ObservableCollection<Object> selectedItems = treeView.SelectedItems;
    RadTreeViewItem item = selectedItems[ 0 ] as RadTreeViewItem;
}
#endregion

#region radtreeview-how-to-get-previous-next-parent-sibling-node_4
private void radTreeView_SelectionChanged( object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e )
{
    // Get a reference to the treeview
    Telerik.Windows.Controls.RadTreeView treeView = sender as Telerik.Windows.Controls.RadTreeView;
    // Get the currently selected items
    ObservableCollection<Object> selectedItems = treeView.SelectedItems;
    RadTreeViewItem item = selectedItems[ 0 ] as RadTreeViewItem;
    // Get the previous item and the previous sibling item
    RadTreeViewItem previousItem = item.PreviousItem;
    RadTreeViewItem previousSiblingItem = item.PreviousSiblingItem;
}
#endregion

#region radtreeview-how-to-get-previous-next-parent-sibling-node_6
private void radTreeView_SelectionChanged( object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e )
{
    // Get a reference to the treeview
    Telerik.Windows.Controls.RadTreeView treeView = sender as Telerik.Windows.Controls.RadTreeView;
    // Get the currently selected items
    ObservableCollection<Object> selectedItems = treeView.SelectedItems;
    RadTreeViewItem item = selectedItems[ 0 ] as RadTreeViewItem;
    // Get the previous item and the previous sibling item
    RadTreeViewItem previousItem = item.PreviousItem;
    RadTreeViewItem previousSiblingItem = item.PreviousSiblingItem;
    // Get the next item and the next sibling item
    RadTreeViewItem nextItem = item.NextItem;
    RadTreeViewItem nextSiblingItem = item.NextSiblingItem;
}
#endregion

#region radtreeview-how-to-get-previous-next-parent-sibling-node_8
private void radTreeView_SelectionChanged( object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e )
{
    // Get a reference to the treeview
    Telerik.Windows.Controls.RadTreeView treeView = sender as Telerik.Windows.Controls.RadTreeView;
    // Get the currently selected items
    ObservableCollection<Object> selectedItems = treeView.SelectedItems;
    RadTreeViewItem item = selectedItems[ 0 ] as RadTreeViewItem;
    // Get the previous item and the previous sibling item
    RadTreeViewItem previousItem = item.PreviousItem;
    RadTreeViewItem previousSiblingItem = item.PreviousSiblingItem;
    // Get the next item and the next sibling item
    RadTreeViewItem nextItem = item.NextItem;
    RadTreeViewItem nextSiblingItem = item.NextSiblingItem;
    // Get the parent item and the root item
    RadTreeViewItem parentItem = item.ParentItem;
    RadTreeViewItem rootItem = item.RootItem;
}
#endregion
}
