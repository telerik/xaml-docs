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

#region radcontextmenu-populating-with-data-binding-to-dynamic-data_0
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
    public bool IsSeparator
    {
        get;
        set;
    }
    public ICommand Command
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

#region radcontextmenu-populating-with-data-binding-to-dynamic-data_2
public ObservableCollection<MenuItem> GetMenuItems()
{
    ObservableCollection<MenuItem> items = new ObservableCollection<MenuItem>();
    MenuItem copyItem = new MenuItem()
    {
        IconUrl = new Uri("Images/copy.png", UriKind.Relative),
        Text = "Copy",
    };
    items.Add(copyItem);
    MenuItem pasteItem = new MenuItem()
    {
        IconUrl = new Uri("Images/paste.png", UriKind.Relative),
        Text = "Paste",
    };
    items.Add(pasteItem);
    MenuItem cutItem = new MenuItem()
    {
        IconUrl = new Uri("Images/cut.png", UriKind.Relative),
        Text = "Cut",
    };
    items.Add(cutItem);
    MenuItem separatorItem = new MenuItem()
    {
        IsSeparator = true
    };
    items.Add(separatorItem);
    MenuItem selectAllItem = new MenuItem()
    {
        Text = "Select All"
    };
    items.Add(selectAllItem);

    return items;
}
#endregion

#region radcontextmenu-populating-with-data-binding-to-dynamic-data_4
public Sample()
{
    InitializeComponent();
    this.radContextMenu.ItemsSource = this.GetMenuItems();
}
#endregion
}
