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

#region hierarchical-data_1
public class Category
{
  public string Name { get; set; }
  public List<Product> Products { get; set; }
}
public class Product
{
  public string Name { get; set; }
  public string Description { get; set; }
}
List<Category> categories = new List<Category>();
categories.Add(new Category() { Name = "Cars" });
categories.Add(new Category() { Name = "Fruits" });
categories[0].Products = new List<Product>() {
  new Product() { Name = "BMW", Description = "A german luxury car." },
  new Product() { Name = "Porsche", Description = "A german sports car." }
};
categories[1].Products = new List<Product>() {
  new Product() { Name = "Banana", Description = "A soft, tasty fruit." },
  new Product() { Name = "Lemon", Description = "A juicy, sour fruit." }
};
tree.DataContext = categories;
#endregion
}
