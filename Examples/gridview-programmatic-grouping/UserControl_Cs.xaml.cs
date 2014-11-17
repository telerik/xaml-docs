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

#region gridview-programmatic-grouping_0
GroupDescriptor descriptor = new GroupDescriptor();
descriptor.Member = "Country";
descriptor.SortDirection = ListSortDirection.Ascending;
#endregion

#region gridview-programmatic-grouping_4
this.radGridView.GroupDescriptors.Add( descriptor );
#endregion

#region gridview-programmatic-grouping_7
GroupDescriptor descriptor = new GroupDescriptor();
descriptor.Member = "Country";
descriptor.SortDirection = ListSortDirection.Ascending;
descriptor.DisplayContent = "Country Group";
#endregion

#region gridview-programmatic-grouping_9
this.clubsGrid.GroupDescriptors.Add(new ColumnGroupDescriptor() 
{ 
 Column = this.clubsGrid.Columns["Name"],
 SortDirection = ListSortDirection.Descending
});
#endregion
}
