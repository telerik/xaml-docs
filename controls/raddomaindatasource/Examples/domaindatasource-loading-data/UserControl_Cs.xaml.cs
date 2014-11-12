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

#region domaindatasource-loading-data_0
public QueryableDomainServiceCollectionView(DomainContext domainContext, EntityQuery<TEntity> entityQuery)
     : base(domainContext, new DomainServiceCollection<TEntity>(domainContext))
#endregion

#region domaindatasource-loading-data_1
public EntityQuery<Customer> GetCustomersQuery()
{
     this.ValidateMethod("GetCustomersQuery", null);
     return base.CreateQuery<Customer>("GetCustomers", null, false, true);
}
#endregion

#region domaindatasource-loading-data_2
NorthwindDomainContext context = new NorthwindDomainContext();
EntityQuery<Customer> query = context.GetCustomersQuery();
QueryableDomainServiceCollectionView<Customer> view = new QueryableDomainServiceCollectionView<Customer>(context, query);
#endregion

#region domaindatasource-loading-data_5
public IQueryable<Customer> GetCustomers()
{
   // Fake server slow-down.
   Thread.Sleep(500);
   return this.ObjectContext.Customers.OrderBy(c=>c.CustomerID);
}
#endregion
}
