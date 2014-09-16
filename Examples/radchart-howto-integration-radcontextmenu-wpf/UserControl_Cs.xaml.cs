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

#region radchart-howto-integration-radcontextmenu-wpf_0
public class MenuItem : INotifyPropertyChanged
{
    private bool isChecked;
    private bool isEnabled = true;
    private string text;
    private string groupName;
    private bool isCheckable;
    private bool isSeparator;
    private string imageUrl;
    private bool staysOpenOnClick;
    private MenuItemsCollection items;
    private MenuItem parent;
    public MenuItem()
    {
        this.items = new MenuItemsCollection( this );
    }
    public event PropertyChangedEventHandler PropertyChanged;
    public string Text
    {
        get
        {
            return this.text;
        }
        set
        {
            this.text = value;
        }
    }
    public string GroupName
    {
        get
        {
            return this.groupName;
        }
        set
        {
            this.groupName = value;
        }
    }
    public bool IsCheckable
    {
        get
        {
            return this.isCheckable;
        }
        set
        {
            this.isCheckable = value;
        }
    }
    public bool IsSeparator
    {
        get
        {
            return this.isSeparator;
        }
        set
        {
            this.isSeparator = value;
        }
    }
    public string ImageUrl
    {
        get
        {
            return this.imageUrl;
        }
        set
        {
            this.imageUrl = value;
        }
    }
    public bool StaysOpenOnClick
    {
        get
        {
            return this.staysOpenOnClick;
        }
        set
        {
            this.staysOpenOnClick = value;
        }
    }
    public MenuItemsCollection Items
    {
        get
        {
            return this.items;
        }
    }
    public MenuItem Parent
    {
        get
        {
            return this.parent;
        }
        set
        {
            this.parent = value;
        }
    }
    public bool IsEnabled
    {
        get
        {
            return this.isEnabled;
        }
        set
        {
            if ( value != this.isEnabled )
            {
                this.isEnabled = value;
                this.OnPropertyChanged( "IsEnabled" );
            }
        }
    }
    public bool IsChecked
    {
        get
        {
            return this.isChecked;
        }
        set
        {
            if ( value != this.isChecked )
            {
                this.isChecked = value;
                this.OnPropertyChanged( "IsChecked" );
                if ( !string.IsNullOrEmpty( this.GroupName ) )
                {
                    if ( this.IsChecked )
                    {
                        this.UncheckOtherItemsInGroup();
                    }
                    else
                    {
                        this.IsChecked = true;
                    }
                }
            }
        }
    }
    public Image Image
    {
        get
        {
            if ( string.IsNullOrEmpty( this.ImageUrl ) )
                return null;
            return new Image()
            {
                Source = new BitmapImage( new Uri( this.ImageUrl, UriKind.RelativeOrAbsolute ) )
            };
        }
    }
    private void UncheckOtherItemsInGroup()
    {
        IEnumerable<MenuItem> groupItems = this.Parent.Items.Where( ( MenuItem item ) => item.GroupName == this.GroupName );
        foreach ( MenuItem item in groupItems )
        {
            if ( item != this )
            {
                item.isChecked = false;
                item.OnPropertyChanged( "IsChecked" );
            }
        }
    }
    private void OnPropertyChanged( string propertyName )
    {
        if ( null != this.PropertyChanged )
        {
            this.PropertyChanged( this, new PropertyChangedEventArgs( propertyName ) );
        }
    }
}
#endregion

#region radchart-howto-integration-radcontextmenu-wpf_2
public class MenuItemsCollection : ObservableCollection<MenuItem>
{
    private MenuItem parent;
    public MenuItemsCollection()
        : this( null )
    {
    }
    public MenuItemsCollection( MenuItem parent )
    {
        this.parent = parent;
    }
    public MenuItem Parent
    {
        get
        {
            return this.parent;
        }
        set
        {
            this.parent = value;
        }
    }
    protected override void InsertItem( int index, MenuItem item )
    {
        item.Parent = this.Parent;
        base.InsertItem( index, item );
    }
}
#endregion

#region radchart-howto-integration-radcontextmenu-wpf_4
public class ChartDataItem : INotifyPropertyChanged
{
    private double yValue;
    private MenuItemsCollection menuItems;
    public event PropertyChangedEventHandler PropertyChanged;
    public double YValue
    {
        get
        {
            return this.yValue;
        }
        set
        {
            if ( this.yValue != value )
            {
                this.yValue = value;
                this.OnPropertyChanged( "YValue" );
            }
        }
    }
    public MenuItemsCollection MenuItems
    {
        get
        {
            if ( this.menuItems == null )
            {
                this.menuItems = new MenuItemsCollection();
            }
            return this.menuItems;
        }
    }
    private void OnPropertyChanged( string propertyName )
    {
        if ( null != this.PropertyChanged )
        {
            this.PropertyChanged( this, new PropertyChangedEventArgs( propertyName ) );
        }
    }
}
#endregion

#region radchart-howto-integration-radcontextmenu-wpf_6
public class ChartDataCollection : ObservableCollection<ChartDataItem>
{
}
#endregion

#region radchart-howto-integration-radcontextmenu-wpf_8
public class ChartViewModel
{
    private Random rand = new Random( DateTime.Now.Millisecond );
    private ChartDataCollection data;
    public ChartDataCollection Data
    {
        get
        {
            if ( data == null )
            {
                data = new ChartDataCollection();
                data.Add( CreateChartDataItem( "Test {0}" ) );
                data.Add( CreateChartDataItem( "Foo {0}" ) );
                data.Add( CreateChartDataItem( "Bar {0}" ) );
            }
            return data;
        }
    }
    private ChartDataItem CreateChartDataItem( string menuItemTextFormat )
    {
        ChartDataItem item = new ChartDataItem();
        item.YValue = rand.Next( 10, 100 );
        for ( int i = 0; i < rand.Next( 2, 5 ); i++ )
        {
            item.MenuItems.Add( new MenuItem()
            {
                Text = string.Format( menuItemTextFormat, i )
            } );
        }
        return item;
    }
}
#endregion

#region radchart-howto-integration-radcontextmenu-wpf_13
this.DataContext = new ChartViewModel();
private void OnContextMenuClick(object sender, Telerik.Windows.RadRoutedEventArgs e)
{
    // Get the clicked item
    MenuItem menuItem = (e.OriginalSource as RadMenuItem).Header as MenuItem;
    if (menuItem.Text == "Foo 0")
    {
        //...
    }
}
#endregion
}
