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

#region radtreeview-how-to-bind-wcf-service-load-on-demand_2
public class TableItem
{
    public TableItem()
    {
        this.Children = new List<TableItem>();
    }
    public int Id
    {
        get;
        set;
    }
    public int ParentId
    {
        get;
        set;
    }
    public string Text
    {
        get;
        set;
    }
    public List<TableItem> Children
    {
        get;
        set;
    }
}
#endregion

#region radtreeview-how-to-bind-wcf-service-load-on-demand_4
public class HierarchicalDataSource : ObservableCollection<TableItem>
{
    public HierarchicalDataSource()
    {
    }
}
#endregion

#region radtreeview-how-to-bind-wcf-service-load-on-demand_6
public class HierarchicalDataSource : ObservableCollection<TableItem>
{
    // This list holds all the items that come from the web service result
    private List<TableItem> unsortedList = new List<TableItem>();
    public HierarchicalDataSource()
    {
        SampleWcfServiceClient serviceClient = new SampleWcfServiceClient();
        serviceClient.LoadHierarchicalDataCompleted += new EventHandler<LoadHierarchicalDataCompletedEventArgs>( serviceClient_LoadHierarchicalDataCompleted );
        serviceClient.LoadHierarchicalDataAsync();
    }
    private void serviceClient_LoadHierarchicalDataCompleted( object sender, LoadHierarchicalDataCompletedEventArgs e )
    {
        // transfer all the items from the result to the unsorted list
        foreach ( TableItem item in e.Result )
        {
            TableItem genericItem = new TableItem()
            {
                Text = item.Text,
                Id = item.Id,
                ParentId = item.ParentId
            };
            this.unsortedList.Add( genericItem );
        }
        // Get all the first level nodes.
        var rootNodes = this.unsortedList.Where( x => x.ParentId == 0 );
        // Foreach root node, get all its children and add the node to the HierarchicalDataSource.
        // see below how the FindChildren method works
        foreach ( TableItem node in rootNodes )
        {
            this.FindChildren( node );
            this.Add( node );
        }
    }
}
#endregion

#region radtreeview-how-to-bind-wcf-service-load-on-demand_7
public class HierarchicalDataSource : ObservableCollection<TableItem>
{
    // This list holds all the items that come from the web service result
    private List<TableItem> unsortedList = new List<TableItem>();
    public HierarchicalDataSource()
    {
        SampleWcfServiceClient serviceClient = new SampleWcfServiceClient();
        foreach ( TableItem item in serviceClient.LoadHierarchicalData() )
        {
            // transfer all the items from the result to the unsorted list
            TableItem genericItem = new TableItem()
            {
                Text = item.Text,
                Id = item.Id,
                ParentId = item.ParentId
            };
            this.unsortedList.Add( genericItem );
        }
        // Get all the first level nodes.
        var rootNodes = this.unsortedList.Where( x => x.ParentId == 0 );
        // Foreach root node, get all its children and add the node to the HierarchicalDataSource.
        // see below how the FindChildren method works
        foreach ( TableItem node in rootNodes )
        {
            node.Children = new ObservableCollection<TableItem>();
            this.FindChildren( node );
            this.Add( node );
        }
    }
}
#endregion

#region radtreeview-how-to-bind-wcf-service-load-on-demand_10
private void FindChildren( TableItem item )
{
    // find all the children of the item
    var children = unsortedList.Where( x => x.ParentId == item.Id && x.Id != item.Id );
    // add the child to the item's children collection and call the FindChildren recursively, in case the child has children
    foreach ( TableItem child in children )
    {
        // By not calling iteratively FindChildren() here we prevent
        // the automatic loading of all items in the data
        // source and load only the next level in the hierarchy
        item.Children.Add( child );
    }
}
#endregion

#region radtreeview-how-to-bind-wcf-service-load-on-demand_12
public void LoadItemChildren( TableItem item )
{
    foreach ( TableItem i in item.Children )
    {
        FindChildren( i );
    }
}
#endregion

#region radtreeview-how-to-bind-wcf-service-load-on-demand_15
private void radTreeView_Expanded( object sender, Telerik.Windows.RadRoutedEventArgs e )
{
    Telerik.Windows.Controls.RadTreeView tree = sender as Telerik.Windows.Controls.RadTreeView;
    RadTreeViewItem item = e.OriginalSource as RadTreeViewItem;
    if ( ( tree != null ) && ( item != null ) )
    {
        // Load the next level from the data hierarchy
        HierarchicalDataSource source = this.Resources[ "Source" ] as HierarchicalDataSource;
        TableItem ti = item.DataContext as TableItem;
        if ( ( ti != null ) && ( source != null ) )
        {
            source.LoadItemChildren( ti );
        }
    }
}
#endregion
}
