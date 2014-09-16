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

#region consuming-data-in-memory-data_0
public List<Categories> categories = new List<Categories>();
public void CreateCategories()
{
    Categories c = new Categories();
    c.CategoryID = 1;
    c.CategoryName = "Beverages";
    c.Description = "Soft drinks, coffees, teas, beers, and ales";
    categories.Add( c );
    c = new Categories();
    c.CategoryID = 2;
    c.CategoryName = "Condiments";
    c.Description = "Sweet and savory sauces, relishes, spreads, and seasonings";
    categories.Add( c );
    c = new Categories();
    c.CategoryID = 3;
    c.CategoryName = "Confections";
    c.Description = "Desserts, candies, and sweet breads";
    categories.Add( c );
}
#endregion

#region consuming-data-in-memory-data_3
radTreeView.ItemsSource = categories;
// Or
radTreeView.DataContext = categories;
#endregion
}
