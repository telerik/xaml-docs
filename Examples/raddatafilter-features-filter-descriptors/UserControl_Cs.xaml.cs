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

#region raddatafilter-features-filter-descriptors_1
this.radDataFilter.Source = SampleData.GetEmployees();
this.radDataFilter.FilterDescriptors.Add( new FilterDescriptor( "Name", FilterOperator.Contains, "m" ) );
#endregion
}
