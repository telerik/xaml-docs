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

#region radtimeline-databinding_0
	public class Product
	{
		public IEnumerable<Item> Data { get; set; }

		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}

	public class Item
	{
		public TimeSpan Duration { get; set; }
		public DateTime Date { get; set; }
	}
#endregion

#region radtimeline-databinding_1
public MainPage() //MainWindow in WPF
{
	InitializeComponent();
	
	var startDate = new DateTime(2010, 1, 1);
	var endDate = new DateTime(2012, 2, 1);

	var items = new List<Item>();
	Random r = new Random();
	for (DateTime i = startDate; i < endDate; i = i.AddMonths(1))
	{
		items.Add(new Item() { Date = i, Duration = TimeSpan.FromDays(r.Next(50, 100))} );
	}

	for (int i = 0; i < 15; i++)
	{
		items.Add(new Item()
		{
			Date = startDate.AddMonths(r.Next(0, 25)).AddDays(15)
		});
	}
	
	this.DataContext = new Product() { Data = items, StartDate = startDate, EndDate = endDate, };
}	
#endregion
	}
}
