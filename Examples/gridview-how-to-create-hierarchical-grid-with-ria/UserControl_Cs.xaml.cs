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

#region gridview-how-to-create-hierarchical-grid-with-ria_2
public IQueryable<Order> GetOrdersByCustomerID(string customerID)
  {
   var orders = from o in ObjectContext.Orders where o.CustomerID.StartsWith(customerID)  select o;
   return orders;
  }
#endregion
}
