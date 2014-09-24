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

#region binding-to-collections_1
List<string> items = new List<string>();
items.Add("one");
items.Add("two");
items.Add("three");
combo.DataContext = items;
#endregion

#region binding-to-collections_3
public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
}
List<Product> products = new List<Product>();
products.Add(new Product() { Name = "Banana", Description = "A soft, tasty fruit" });
products.Add(new Product() { Name = "Lemon", Description = "A juicy, sour fruit" });
combo.DataContext = products;
#endregion

#region binding-to-collections_5
combo.DataContext = products;
#endregion
}
