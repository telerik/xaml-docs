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

#region gridview-multiple-column-grouping_1
GroupDescriptor countryDescriptor = new GroupDescriptor();
countryDescriptor.Member = "Country";
countryDescriptor.SortDirection = ListSortDirection.Ascending;
this.radGridView.GroupDescriptors.Add( countryDescriptor );
GroupDescriptor titleDescriptor = new GroupDescriptor();
titleDescriptor.Member = "Title";
titleDescriptor.SortDirection = ListSortDirection.Ascending;
this.radGridView.GroupDescriptors.Add( titleDescriptor );
#endregion
}
