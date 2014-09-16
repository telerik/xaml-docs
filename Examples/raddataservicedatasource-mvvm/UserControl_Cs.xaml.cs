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

#region raddataservicedatasource-mvvm_0
MyNorthwindEntities ordersContext = new MyNorthwindEntities();
DataServiceQuery<Order> ordersQuery = ordersContext.Orders;
QueryableDataServiceCollectionView<Order> ordersView = new QueryableDataServiceCollectionView<Order>(this.ordersContext, ordersQuery);
#endregion
}
