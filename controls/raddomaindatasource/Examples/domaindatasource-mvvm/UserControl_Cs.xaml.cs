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

#region domaindatasource-mvvm_1
private readonly QueryableDomainServiceCollectionView<Customer> view;
public CustomersViewModel()
{
    NorthwindDomainContext context = new NorthwindDomainContext();
    EntityQuery<Customer> getCustomersQuery = context.GetCustomersQuery();
    this.view = new QueryableDomainServiceCollectionView<Customer>(context, getCustomersQuery);
    //...
}
#endregion

#region domaindatasource-mvvm_3
public int PageSize
{
     get
     {
         return this.view.PageSize;
     }
     set
     {
         if (this.view.PageSize != value)
         {
              this.view.PageSize = value;
              this.OnPropertyChanged("PageSize");
         }
     }
}
#endregion

#region domaindatasource-mvvm_4
radDomainDataSource.PageSize = 10;
radDomainDataSource.DataView.PageSize = 10;
#endregion
}
