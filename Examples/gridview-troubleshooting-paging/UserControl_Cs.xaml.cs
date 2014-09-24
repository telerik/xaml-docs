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

#region gridview-troubleshooting-paging_0
public IQueryable<Order_Details_Extended> GetOrder_Details_Extendeds()
{
    return this.ObjectContext.Order_Details_Extendeds.OrderBy(o => o.OrderID);
}
#endregion

#region gridview-troubleshooting-paging_2
order_Details_ExtendedDomainDataSource.SortDescriptors.Add(new 
SortDescriptor("OrderID", SortDirection.Ascending));
#endregion
}
