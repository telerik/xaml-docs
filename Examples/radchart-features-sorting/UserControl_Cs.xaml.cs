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

#region radchart-features-sorting_2
ChartSortDescriptor descriptor = new ChartSortDescriptor();
descriptor.Member = "Title";
descriptor.SortDirection = ListSortDirection.Ascending;
this.radChart.SortDescriptors.Add( descriptor ) );
#endregion
}
