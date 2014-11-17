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

#region raddataservicedatasource-filtering-programmatic-filtering_0
FilterDescriptor fd = new FilterDescriptor("PostalCode", FilterOperator.IsEqualTo, 1010);
this.radDataServiceDataSource.FilterDescriptors.Add(fd);
#endregion

#region raddataservicedatasource-filtering-programmatic-filtering_2
CompositeFilterDescriptor cfd = new CompositeFilterDescriptor();
cfd.LogicalOperator = FilterCompositionLogicalOperator.Or;
FilterDescriptor f1 = new FilterDescriptor("City", FilterOperator.IsEqualTo, "Berlin");
cfd.FilterDescriptors.Add(f1);
FilterDescriptor f2 = new FilterDescriptor("City", FilterOperator.IsEqualTo, "Madrid);
cfd.FilterDescriptors.Add(f2);
this.radDataServiceDataSource.FilterDescriptors.Add(cfd);
#endregion
}
