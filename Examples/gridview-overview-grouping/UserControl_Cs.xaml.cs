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

#region gridview-overview-grouping_2
GroupDescriptor descriptor = new GroupDescriptor();
descriptor.Member = "Country";
descriptor.SortDirection = ListSortDirection.Ascending;
descriptor.DisplayContent = "Country Group";
this.radGridView.GroupDescriptors.Add( descriptor );
//You can create and add more descriptors here
#endregion
}
