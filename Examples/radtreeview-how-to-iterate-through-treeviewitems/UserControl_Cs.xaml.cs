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

#region radtreeview-how-to-iterate-through-treeviewitems_0
this.Loaded += new RoutedEventHandler( IterateTreeViewItems_Loaded );
#endregion

#region radtreeview-how-to-iterate-through-treeviewitems_2
private void IterateTreeViewItems_Loaded( object sender, RoutedEventArgs e )
{
    this.GetContainers();
}

private void GetContainers()
{
    // gets all nodes from the TreeView  
    Collection<RadTreeViewItem> allTreeContainers = GetAllItemContainers( this.radTreeView );
    // gets all nodes (recursively) for the first node  
    RadTreeViewItem firstNode = this.radTreeView.ItemContainerGenerator.ContainerFromIndex( 0 ) as RadTreeViewItem;
    if ( firstNode != null )
    {
        Collection<RadTreeViewItem> firstNodeContainers = GetAllItemContainers( firstNode );
    }
}

private Collection<RadTreeViewItem> GetAllItemContainers( Telerik.Windows.Controls.ItemsControl itemsControl )
{
    Collection<RadTreeViewItem> allItems = new Collection<RadTreeViewItem>();
    for ( int i = 0; i < itemsControl.Items.Count; i++ )
    {
        // try to get the item Container  
        RadTreeViewItem childItemContainer = itemsControl.ItemContainerGenerator.ContainerFromIndex( i ) as RadTreeViewItem;
        // the item container maybe null if it is still not generated from the runtime  
        if ( childItemContainer != null )
        {
            allItems.Add( childItemContainer );
            Collection<RadTreeViewItem> childItems = GetAllItemContainers( childItemContainer );
            foreach ( RadTreeViewItem childItem in childItems )
            {
                allItems.Add( childItem );
            }
        }
    }
    return allItems;
}
#endregion

#region radtreeview-how-to-iterate-through-treeviewitems_4
private void IterateTreeViewItems_Loaded( object sender, RoutedEventArgs e )
{
    this.GetContainers();
}

private void GetContainers()
{
    // gets all nodes from the TreeView  
    Collection<RadTreeViewItem> allTreeContainers = GetAllItemContainers( this.radTreeView );
    // gets all nodes (recursively) for the first node  
    RadTreeViewItem firstNode = this.radTreeView.ItemContainerGenerator.ContainerFromIndex( 0 ) as RadTreeViewItem;
    if ( firstNode != null )
    {
        Collection<RadTreeViewItem> firstNodeContainers = GetAllItemContainers( firstNode );
    }
}

private Collection<RadTreeViewItem> GetAllItemContainers( System.Windows.Controls.ItemsControl itemsControl )
{
    Collection<RadTreeViewItem> allItems = new Collection<RadTreeViewItem>();
    for ( int i = 0; i < itemsControl.Items.Count; i++ )
    {
        // try to get the item Container  
        RadTreeViewItem childItemContainer = itemsControl.ItemContainerGenerator.ContainerFromIndex( i ) as RadTreeViewItem;
        // the item container maybe null if it is still not generated from the runtime  
        if ( childItemContainer != null )
        {
            allItems.Add( childItemContainer );
            Collection<RadTreeViewItem> childItems = GetAllItemContainers( childItemContainer );
            foreach ( RadTreeViewItem childItem in childItems )
            {
                allItems.Add( childItem );
            }
        }
    }
    return allItems;
}
#endregion
}
