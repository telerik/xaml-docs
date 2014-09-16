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

#region raddataservicedatasource-loading-the-DataServiceContext_0
public partial class NorthwindEntities : global::System.Data.Services.Client.DataServiceContext
#endregion

#region raddataservicedatasource-loading-the-DataServiceContext_2
Uri serviceUri = new Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute);
NorthwindEntities northwindContext = new NorthwindEntities(serviceUri);
this.radDataServiceDataSource.DataServiceContext = northwindContext;
#endregion

#region raddataservicedatasource-loading-the-DataServiceContext_4
public class MyNorthwindContext : NorthwindEntities
{
    public MyNorthwindContext() : base(new Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute)){}
}
#endregion
}
