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

#region radtabcontrol-addcontent_2
public partial class Example : Telerik.Windows.QuickStart.Example
{
public Example()
{
InitializeComponent();
this.orders.ItemsSource = OrdersDataSource.GetOrders();
this.company.ItemsSource = CompaniesDataSource.GetCompanies();
this.Category1.ItemsSource = ProductsDataSource.GetProductsByCategory("1");
}
void Products_SelectionChanged(object sender, System.Windows.RoutedEventArgs e)
{
RadTabItem item = Products.SelectedItem as RadTabItem;
if (item == null)
{
return;
}
if (item.Tag.Equals("0"))
{
this.Category1.ItemsSource = ProductsDataSource.GetProductsByCategory("1");
}
else if (item.Tag.Equals("1"))
{
this.Category2.ItemsSource = ProductsDataSource.GetProductsByCategory("2");
}
else if (item.Tag.Equals("2"))
{
this.Category3.ItemsSource = ProductsDataSource.GetProductsByCategory("3");
}
}
}
#endregion
}
