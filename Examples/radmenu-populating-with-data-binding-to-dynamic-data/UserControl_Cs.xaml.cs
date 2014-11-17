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

#region radmenu-populating-with-data-binding-to-dynamic-data_0
public class MenuItem
{
    public MenuItem()
    {
        this.SubItems = new ObservableCollection<MenuItem>();
    }
    public string Text
    {
        get;
        set;
    }
    public Uri IconUrl
    {
        get;
        set;
    }
    public ObservableCollection<MenuItem> SubItems
    {
        get;
        set;
    }
}
#endregion

#region radmenu-populating-with-data-binding-to-dynamic-data_2
public ObservableCollection<MenuItem> GetMenuItems()
{
    ObservableCollection<MenuItem> items = new ObservableCollection<MenuItem>();
    ObservableCollection<MenuItem> fileSubItems = new ObservableCollection<MenuItem>();
    MenuItem newItem = new MenuItem()
    {
        IconUrl = new Uri( "/Images/newFile.png", UriKind.Relative ),
        Text = "New File"
    };
    fileSubItems.Add( newItem );
    MenuItem openItem = new MenuItem()
    {
        IconUrl = new Uri( "/Images/open.png", UriKind.Relative ),
        Text = "Open File"
    };
    fileSubItems.Add( openItem );
    MenuItem saveItem = new MenuItem()
    {
        IconUrl = new Uri( "/Images/save.png", UriKind.Relative ),
        Text = "Save File"
    };
    fileSubItems.Add( saveItem );
    MenuItem fileItem = new MenuItem()
    {
        SubItems = fileSubItems,
        Text="File"
    };
    items.Add( fileItem );
    MenuItem editItem = new MenuItem()
    {
        Text = "Edit"
    };
    items.Add( editItem );
    MenuItem viewItem = new MenuItem()
    {
        Text = "View"
    };
    items.Add( viewItem );
    return items;
}
#endregion

#region radmenu-populating-with-data-binding-to-dynamic-data_4
public Sample()
{
    InitializeComponent();
    this.radMenu.ItemsSource = this.GetMenuItems();
}
#endregion
}
