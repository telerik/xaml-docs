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

#region gridview-sorting-programmatic_0
SortDescriptor descriptor = new SortDescriptor();
descriptor.Member = "Title";
descriptor.SortDirection = ListSortDirection.Ascending;
#endregion

#region gridview-sorting-programmatic_2
ColumnSortDescriptor csd = new ColumnSortDescriptor()
{
 Column = this.clubsGrid.Columns["Name"],
 SortDirection = ListSortDirection.Descending
};
this.clubsGrid.SortDescriptors.Add(csd);
#endregion

#region gridview-sorting-programmatic_5
this.radGridView.SortDescriptors.Add( descriptor );
#endregion
}
