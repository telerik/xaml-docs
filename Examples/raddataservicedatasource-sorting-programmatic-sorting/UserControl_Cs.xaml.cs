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

#region raddataservicedatasource-sorting-programmatic-sorting_0
SortDescriptor sd = new SortDescriptor();
sd.Member = "ContactTitle";
sd.SortDirection = ListSortDirection.Descending;
this.customersDataSource.SortDescriptors.Add(sd);
#endregion
}
