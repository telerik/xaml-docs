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

#region radtreeview-how-to-bind-to-self-referencing-data_0
public class DataItem
{
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
    public DataItemCollection Owner
    {
        get;
        protected set;
    }
    internal void SetOwner( DataItemCollection collection )
    {
        this.Owner = collection;
    }
}
#endregion

#region radtreeview-how-to-bind-to-self-referencing-data_2
public class DataItemCollection : ObservableCollection<DataItem>
{
    protected override void InsertItem( int index, DataItem item )
    {
        this.AdoptItem( item );
        base.InsertItem( index, item );
    }
    protected override void RemoveItem( int index )
    {
        this.DiscardItem( this[ index ] );
        base.RemoveItem( index );
    }
    protected override void SetItem( int index, DataItem item )
    {
        this.AdoptItem( item );
        base.SetItem( index, item );
    }
    protected override void ClearItems()
    {
        foreach ( DataItem item in this )
        {
            this.DiscardItem( item );
        }
        base.ClearItems();
    }
    private void AdoptItem( DataItem item )
    {
        item.SetOwner( this );
    }
    private void DiscardItem( DataItem item )
    {
        item.SetOwner( null );
    }
}
#endregion

#region radtreeview-how-to-bind-to-self-referencing-data_6
public class HierarchyConverter : IValueConverter
{
    public object Convert( object value, Type targetType, object parameter, CultureInfo culture )
    {
        // We are binding an item
        DataItem item = value as DataItem;
        if ( item != null )
        {
            return item.Owner.Where( i => i.ParentId == item.Id );
        }
        // We are binding the treeview
        DataItemCollection items = value as DataItemCollection;
        if ( items != null )
        {
            return items.Where( i => i.ParentId == 0 );
        }
        return null;
    }
    public object ConvertBack( object value, Type targetType, object parameter, CultureInfo culture )
    {
        throw new NotImplementedException();
    }
}
#endregion

#region radtreeview-how-to-bind-to-self-referencing-data_8
this.DataContext = new DataItemCollection()
{
 new DataItem () { Text = "Item 1", Id = 1, ParentId = 0 },
 new DataItem () { Text = "Item 2", Id = 2, ParentId = 0 },
 new DataItem () { Text = "Item 3", Id = 3, ParentId = 0 },
 new DataItem () { Text = "Item 1.1", Id = 5, ParentId = 1 },
 new DataItem () { Text = "Item 1.2", Id = 6, ParentId = 1 },
 new DataItem () { Text = "Item 1.3", Id = 7, ParentId = 1 },
 new DataItem () { Text = "Item 2.1", Id = 8, ParentId = 2 },
 new DataItem () { Text = "Item 2.2", Id = 9, ParentId = 2 },
 new DataItem () { Text = "Item 2.3", Id = 10, ParentId = 2 },
 new DataItem () { Text = "Item 3.1", Id = 11, ParentId = 3 },
 new DataItem () { Text = "Item 3.2", Id = 12, ParentId = 3 },
 new DataItem () { Text = "Item 3.3", Id = 13, ParentId = 3 }
};
#endregion
}
