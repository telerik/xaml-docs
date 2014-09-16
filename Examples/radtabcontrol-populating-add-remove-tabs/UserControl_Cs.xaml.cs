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

#region radtabcontrol-populating-add-remove-tabs_0
private void AddTab()
{
    RadTabItem itemToAdd = new RadTabItem()
    {
        Header = "New Tab"
    };
    radTabControl.Items.Add(itemToAdd);
}
#endregion

#region radtabcontrol-populating-add-remove-tabs_2
private void RemoveTab( RadTabItem tabItemToRemove )
{
    radTabControl.Items.Remove( tabItemToRemove );
}
#endregion
}
