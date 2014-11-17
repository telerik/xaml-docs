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

#region radlistbox-populating-with-data-binding-to-object_1
public class Customer
{
	public string Name { get; set; }
	public string City { get; set; }		
	public string Phone { get; set; }

	public Customer(string name, string city, string phone)
	{
		this.Name = name;
		this.City = city;
		this.Phone = phone;
	}
}
#endregion

#region radlistbox-populating-with-data-binding-to-object_2
public class CustomerViewModel
{
	public ObservableCollection<Customer> Customers { get; set; }

	public CustomerViewModel()
	{
		this.Customers = new ObservableCollection<Customer>()
		{
			new Customer("Maria Anders", "Berlin", "030-0074321"),
			new Customer("Lino Rodriguez", "Lisbon", "(1) 354-2534"),
			new Customer("Yoshi Tannamuri", "Vancouver","(604) 555-3392"),
			new Customer("Renate Messner","Frankfurt a.M.","069-0245984"),
			new Customer("Paolo Accorti","Torino","011-4988260"),
			new Customer("Philip Cramer","Brandenburg","0555-09876")
		};
	}
}
#endregion
}
