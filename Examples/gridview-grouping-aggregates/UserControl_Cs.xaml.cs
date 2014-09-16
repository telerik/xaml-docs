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

#region gridview-grouping-aggregates_1
CountFunction f = new CountFunction();
f.Caption = "Entries Count: ";
GroupDescriptor countryDescriptor = new GroupDescriptor();
countryDescriptor.Member = "Country";
countryDescriptor.SortDirection = ListSortDirection.Ascending;
countryDescriptor.AggregateFunctions.Add( f );
this.radGridView.GroupDescriptors.Add( countryDescriptor );
#endregion

#region gridview-grouping-aggregates_4
CountFunction f = new CountFunction();
f.Caption = "Entries Count: ";
FirstFunction f1 = new FirstFunction();
f.Caption = "FirstEntry: ";
GroupDescriptor countryDescriptor = new GroupDescriptor();
countryDescriptor.Member = "Country";
countryDescriptor.SortDirection = ListSortDirection.Ascending;
countryDescriptor.AggregateFunctions.Add( f );
countryDescriptor.AggregateFunctions.Add( f1 );
this.radGridView.GroupDescriptors.Add( countryDescriptor );
#endregion
}
