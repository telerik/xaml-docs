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

#region gridview-overview-sorting_2
SortDescriptor descriptor = new SortDescriptor();
descriptor.Member = "EmployeeID";
descriptor.SortDirection = ListSortDirection.Ascending;
this.radGridView.SortDescriptors.Add( descriptor );
#endregion
}
