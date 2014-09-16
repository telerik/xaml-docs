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

#region radmenu-how-to-group-checkable-menu-items-into-radio-group_2
private void radMenu_ItemClick( object sender, RadRoutedEventArgs e )
{
    var currentItem = e.OriginalSource as RadMenuItem;
    if ( currentItem.IsCheckable && currentItem.Tag != null )
    {
        //the place for the radio items logic
    }
}
#endregion

#region radmenu-how-to-group-checkable-menu-items-into-radio-group_4
private List<RadMenuItem> GetSiblingGroupItems( RadMenuItem currentItem )
{
    var parentItem = currentItem.ParentOfType<RadMenuItem>();
    if ( parentItem == null )
    {
        return null;
    }
    List<RadMenuItem> items = new List<RadMenuItem>();
    foreach ( var item in parentItem.Items )
    {
        RadMenuItem container = parentItem.ItemContainerGenerator.ContainerFromItem( item ) as RadMenuItem;
        if ( container == null || container.Tag == null )
        {
            continue;
        }
        if ( container.Tag.Equals( currentItem.Tag ) )
        {
            items.Add( container );
        }
    }
    return items;
}
#endregion

#region radmenu-how-to-group-checkable-menu-items-into-radio-group_6
private void radMenu_ItemClick(object sender, Telerik.Windows.RadRoutedEventArgs e)
{
    var currentItem = e.OriginalSource as RadMenuItem;
    if (currentItem.IsCheckable && currentItem.Tag != null)
    {
        var siblingItems = this.GetSiblingGroupItems(currentItem);
        if (siblingItems != null)
        {
            foreach (var item in siblingItems)
            {
                if (item != currentItem)
                {
                    item.IsChecked = false;
                }
            }
        }                
    }
}
#endregion

#region radmenu-how-to-group-checkable-menu-items-into-radio-group_8
public class MenuItem
{       
    public string Header { get; set; }
    public bool IsCheckable { get; set; }
    public string RadioGroup { get; set; }
    public bool IsSeparator { get; set; }
    public ObservableCollection<MenuItem> SubMenuItems { get; set; }
}
#endregion

#region radmenu-how-to-group-checkable-menu-items-into-radio-group_9
public class ViewModel
{
    public ObservableCollection<MenuItem> MenuItems { get; set; }

    public ViewModel()
    {
        this.MenuItems = new ObservableCollection<MenuItem>
        {
            new MenuItem { Header = "File", SubMenuItems = new ObservableCollection<MenuItem>
            {
                new MenuItem { Header = "Exit", IsCheckable = true, RadioGroup = "1" },
            }},
            new MenuItem { Header = "Options", SubMenuItems = new ObservableCollection<MenuItem>
            {
                new MenuItem { Header = "Radio Button 1.1", IsCheckable = true, RadioGroup = "1" },
                new MenuItem { Header = "Radio Button 1.2", IsCheckable = true, RadioGroup = "1" },
                new MenuItem { Header = "Radio Button 1.3", IsCheckable = true, RadioGroup = "1" },
                new MenuItem { IsSeparator = true },
                new MenuItem { Header = "Radio Button 2.1", IsCheckable = true, RadioGroup = "2" },
                new MenuItem { Header = "Radio Button 2.2", IsCheckable = true, RadioGroup = "2" },
                new MenuItem { Header = "Radio Button 2.3", IsCheckable = true, RadioGroup = "2" },
            }},
        };
    }
}
#endregion
}
