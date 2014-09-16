using System;HeaderContextMenuItems
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

#region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_2
public class MenuItem : INotifyPropertyChanged
{
    private bool isEnabled = true;
    private string text;
    private ObservableCollection<MenuItem> subItems;
    public event PropertyChangedEventHandler PropertyChanged;
    public bool IsEnabled
    {
        get
        {
            return this.isEnabled;
        }
        set
        {
            if ( this.isEnabled != value )
            {
                this.isEnabled = value;
                this.OnNotifyPropertyChanged( "IsEnabled" );
            }
        }
    }
    public string Text
    {
        get
        {
            return this.text;
        }
        set
        {
            if ( this.text != value )
            {
                this.text = value;
                this.OnNotifyPropertyChanged( "Text" );
            }
        }
    }
    public ObservableCollection<MenuItem> SubItems
    {
        get
        {
            if ( this.subItems == null )
            {
                this.subItems = new ObservableCollection<MenuItem>();
            }
            return this.subItems;
        }
        set
        {
            if ( this.subItems != value )
            {
                this.subItems = value;
                this.OnNotifyPropertyChanged( "SubItems" );
            }
        }
    }
    private void OnNotifyPropertyChanged( string ptopertyName )
    {
        if ( this.PropertyChanged != null )
        {
            this.PropertyChanged( this, new PropertyChangedEventArgs( ptopertyName ) );
        }
    }
}
#endregion

#region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_7
private ObservableCollection<MenuItem> headerContextMenuItems;
private ObservableCollection<MenuItem> rowContextMenuItems;
#endregion

#region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_9
public RadGridViewIntegration()
{
    InitializeComponent();
    this.radGridView.ItemsSource = RadGridViewSampleData.GetEmployees();
    this.InitializeHeaderContextMenuItems();
    this.InitializeRowContextMenuItems();
}
private void InitializeRowContextMenuItems()
{
    ObservableCollection<MenuItem> items = new ObservableCollection<MenuItem>();
    MenuItem addItem = new MenuItem();
    addItem.Text = "Add";
    items.Add( addItem );
    MenuItem editItem = new MenuItem();
    editItem.Text = "Edit";
    items.Add( editItem );
    MenuItem deleteItem = new MenuItem();
    deleteItem.Text = "Delete";
    items.Add( deleteItem );
    this.rowContextMenuItems = items;
}
private void InitializeHeaderContextMenuItems()
{
    ObservableCollection<MenuItem> headerItems = new ObservableCollection<MenuItem>();
    ObservableCollection<MenuItem> sortItems = new ObservableCollection<MenuItem>();
    MenuItem sortAscItem = new MenuItem();
    sortAscItem.Text = "Ascending";
    sortItems.Add( sortAscItem );
    MenuItem sortDescItem = new MenuItem();
    sortDescItem.Text = "Descending";
    sortItems.Add( sortDescItem );
    MenuItem sortNoneItem = new MenuItem();
    sortNoneItem.Text = "None";
    sortItems.Add( sortNoneItem );
    MenuItem sortItem = new MenuItem();
    sortItem.Text = "Sort";
    sortItem.SubItems = sortItems;
    headerItems.Add( sortItem );
    MenuItem moveLeftItem = new MenuItem();
    moveLeftItem.Text = "Move Left";
    headerItems.Add( moveLeftItem );
    MenuItem moveRightItem = new MenuItem();
    moveRightItem.Text = "Move Right";
    headerItems.Add( moveRightItem );
    this.headerContextMenuItems = headerItems;
}
#endregion

#region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_11
private GridViewHeaderCell ClickedHeader
{
    get
    {
        return this.GridContextMenu.GetClickedElement<GridViewHeaderCell>();
    }
}
private GridViewRow ClickedRow
{
    get
    {
        return this.GridContextMenu.GetClickedElement<GridViewRow>();
    }
}
#endregion

#region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_14
private void GridContextMenu_Opened( object sender, RoutedEventArgs e )
{
    if ( this.ClickedHeader != null )
    {
        this.GridContextMenu.ItemsSource = this.headerContextMenuItems;
    }
    else if ( this.ClickedRow != null )
    {
        this.radGridView.SelectedItem = this.ClickedRow.DataContext;
        foreach ( var item in this.rowContextMenuItems )
        {
            item.IsEnabled = true;
        }
        this.GridContextMenu.ItemsSource = this.rowContextMenuItems;
    }
    else
    {
        foreach ( var item in this.rowContextMenuItems )
        {
            if ( !item.Text.Equals( "Add" ) )
            {
                item.IsEnabled = false;
            }
        }
        this.GridContextMenu.ItemsSource = this.rowContextMenuItems;
    }
}
#endregion

#region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_17
private void GridContextMenu_ItemClick( object sender, Telerik.Windows.RadRoutedEventArgs e )
{
    MenuItem item = ( e.OriginalSource as RadMenuItem ).DataContext as MenuItem;
    switch ( item.Text )
    {
        case "Add":
            this.radGridView.BeginInsert();
            break;
        case "Edit":
            this.radGridView.BeginEdit();
            break;
        case "Delete":
            this.radGridView.Items.Remove( this.radGridView.SelectedItem );
            break;
        case "Ascending":
            this.radGridView.SortDescriptors.Clear();
            this.radGridView.SortDescriptors.Add( new SortDescriptor()
            {
                Member = this.ClickedHeader.Column.UniqueName,
                SortDirection = ListSortDirection.Ascending
            } );
            break;
        case "Descending":
            this.radGridView.SortDescriptors.Clear();
            this.radGridView.SortDescriptors.Add( new SortDescriptor()
            {
                Member = this.ClickedHeader.Column.UniqueName,
                SortDirection = ListSortDirection.Descending
            } );
            break;
        case "None":
            this.radGridView.SortDescriptors.Clear();
            break;
        case "Move Left":
            if ( this.ClickedHeader.Column.DisplayIndex > 0 )
                this.ClickedHeader.Column.DisplayIndex -= 1;
            break;
        case "Move Right":
            if ( this.ClickedHeader.Column.DisplayIndex < this.radGridView.Columns.Count - 1 )
                this.ClickedHeader.Column.DisplayIndex += 1;
            break;
    }
}
#endregion
}
