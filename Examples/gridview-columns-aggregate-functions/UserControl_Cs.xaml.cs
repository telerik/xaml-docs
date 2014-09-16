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

#region gridview-columns-aggregate-functions_2
CountFunction f = new CountFunction();
( ( GridViewDataColumn )this.radGridView.Columns[ "ID" ] ).AggregateFunctions.Add( f );
#endregion

#region gridview-columns-aggregate-functions_4
private void Button1_Click(object sender, RoutedEventArgs e)
{
   this.radGridView.CalculateAggregates();
}
#endregion
}
