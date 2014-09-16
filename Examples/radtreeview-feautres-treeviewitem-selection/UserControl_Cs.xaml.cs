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

#region radtreeview-feautres-treeviewitem-selection_1
radTreeViewItem.IsSelected = true;
#endregion

#region radtreeview-feautres-treeviewitem-selection_3
radTreeView.SelectedItems.Add( radTreeViewItem );
#endregion

#region radtreeview-feautres-treeviewitem-selection_5
radTreeView.SelectedItems.Add( myViewModel );
#endregion

#region radtreeview-feautres-treeviewitem-selection_9
private void radTreeView_Selected( object sender, RadRoutedEventArgs e )
{
    ( e.Source as RadTreeViewItem ).FontSize = 14;
}
#endregion

#region radtreeview-feautres-treeviewitem-selection_11
private void radTreeView_SelectionChanged( object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e )
{
    // Get a reference to the treeview
    Telerik.Windows.Controls.RadTreeView treeView = sender as Telerik.Windows.Controls.RadTreeView;
    // Get the currently selected items
    ObservableCollection<Object> selectedItems = treeView.SelectedItems;
    // Get the newly added items to the collection
    IList addedItems = e.AddedItems;
    // Get the removed items from the collection
    IList removedItems = e.RemovedItems;
}
#endregion

#region radtreeview-feautres-treeviewitem-selection_13
private class MyViewModel
{
    public string Title
    {
        get;
        set;
    }
    public string Price
    {
        get;
        set;
    }
    public IList<MyViewModel> Children
    {
        get;
        set;
    }
}
#endregion
}
