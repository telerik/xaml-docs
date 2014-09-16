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

#region raddataservicedatasource-getting-started-creating-the-client-application_0
public class MyNorthwindContext : NorthwindEntities
{
 public MyNorthwindContext() : base(new Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute)){}
}
#endregion

#region raddataservicedatasource-getting-started-creating-the-client-application_2
public class MyNorthwindContext : NorthwindEntities
{
 public MyNorthwindContext() : base(new Uri("http://services.odata.org/Northwind/Northwind.svc", UriKind.Absolute)){}
}
#endregion
}
