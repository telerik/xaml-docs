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

#region radtabcontrol-declaration_1
RadTabControl tabControl = new RadTabControl();
RadTabItem item1 = new RadTabItem();
item1.Header = "item1";
RadTabItem item2 = new RadTabItem();
item2.Header = "item2";
RadTabItem item3 = new RadTabItem();
item3.Header = "item3";
tabControl.Items.Add(item1);
tabControl.Items.Add(item2);
tabControl.Items.Add(item3);
this.LayoutRoot.Children.Add(tabControl);
#endregion

#region radtabcontrol-declaration_3
public Page()
{
InitializeComponent();
this.tabControl.ItemsSource = this.GetItems();
}
private ObservableCollection<string> GetItems()
{
ObservableCollection<string> items = new ObservableCollection<string>();
items.Add("item1.1");
items.Add("item1.2");
items.Add("item1.3");
return items;
}
#endregion
}
