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

#region radtreeview-events-working-with-item-prepared-event_0
public class DataItem
{
    public DataItem()
    {
        this.Items = new List<DataItem>();
    }
    public string Name
    {
        get;
        set;
    }
    public System.Windows.Automation.ToggleState CheckState
    {
        get;
        set;
    }
    public List<DataItem> Items
    {
        get;
        set;
    }
}
#endregion

#region radtreeview-events-working-with-item-prepared-event_2
public class RawDataSource : List<DataItem>
{
    public RawDataSource()
    {
        Random rand = new Random( ( int )DateTime.Now.Ticks );
        for ( int i = 1; i < 11; i++ )
        {
            DataItem item = new DataItem()
            {
                Name = String.Format( "Item {0}", i.ToString() ),
                CheckState = GetToggleState( rand.Next( 0, 3 ) )
            };
            for ( int j = 1; j < 11; j++ )
            {
                DataItem subItem = new DataItem()
                {
                    Name = String.Format( "Item {0}.{1}", i.ToString(), j.ToString() ),
                    CheckState = GetToggleState( rand.Next( 0, 3 ) )
                };
                item.Items.Add( subItem );
            }
            this.Add( item );
        }
    }
    private System.Windows.Automation.ToggleState GetToggleState( int code )
    {
        switch ( code )
        {
            case 0:
                return System.Windows.Automation.ToggleState.Off;
            case 1:
                return System.Windows.Automation.ToggleState.On;
            case 2:
                return System.Windows.Automation.ToggleState.Indeterminate;
            default:
                return System.Windows.Automation.ToggleState.Off;
        }
    }
}
#endregion

#region radtreeview-events-working-with-item-prepared-event_8
private void radTreeView_ItemPrepared( object sender, Telerik.Windows.Controls.RadTreeViewItemPreparedEventArgs e )
{
    e.PreparedItem.CheckState = ( e.PreparedItem.Item as DataItem ).CheckState;
}
#endregion

#region radtreeview-events-working-with-item-prepared-event_10
private void radTreeView_ItemPrepared( object sender, Telerik.Windows.Controls.RadTreeViewItemPreparedEventArgs e )
{
    e.PreparedItem.CheckState = ( e.PreparedItem.Item as DataItem ).CheckState;
    e.PreparedItem.Checked += new EventHandler<Telerik.Windows.RadRoutedEventArgs>( PreparedItem_Checked );
    e.PreparedItem.Unchecked += new EventHandler<Telerik.Windows.RadRoutedEventArgs>( PreparedItem_Unchecked );
}
void PreparedItem_Unchecked( object sender, Telerik.Windows.RadRoutedEventArgs e )
{
    RadTreeViewItem item = sender as RadTreeViewItem;
    if ( item != null )
    {
        ( item.Item as DataItem ).CheckState = System.Windows.Automation.ToggleState.Off;
    }
}
void PreparedItem_Checked( object sender, Telerik.Windows.RadRoutedEventArgs e )
{
    RadTreeViewItem item = sender as RadTreeViewItem;
    if ( item != null )
    {
        ( item.Item as DataItem ).CheckState = System.Windows.Automation.ToggleState.On;
    }
}
#endregion
}
