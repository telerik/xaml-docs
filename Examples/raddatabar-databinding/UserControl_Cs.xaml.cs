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
	
	#region raddatabar-databinding_0
public class Product
{
	public int Value1 { get; set; }
	public int Value2 { get; set; }

	public IEnumerable<int> Ints { get; set; }
	public IEnumerable<Item> Items { get; set; }
}

public class Item
{
	public double Val { get; set; }
	public string Name { get; set; }
}
	#endregion
	
	#region raddatabar-databinding_1
 var items = new List<Item>() 
	{
		new Item{ Val = 9, Name = "nine", },
		new Item{ Val = 10, Name = "ten", },
		new Item{ Val = 11, Name = "eleven", },
		new Item{ Val = 20, Name = "twenty", }, 
		new Item{ Val = 22, Name = "twenty two", }, 
		new Item{ Val = 90, Name = "ninety", }, 

		new Item{ Val = -9, Name = "-nine", },
		new Item{ Val = -10, Name = "-ten", },
		new Item{ Val = -11, Name = "-eleven", },
		new Item{ Val = -20, Name = "-twenty", }, 
		new Item{ Val = -100, Name = "-hundred", }, 
	};

	this.DataContext = new Product() { Value1 = 20, Value2 = 30, Ints = new List<int>() {5, 6, 7, 8, 9, }, Items = items };
	#endregion	
		
	}
	
}
