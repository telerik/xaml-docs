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

#region gridview-filtering-cascading-distinct-values_0
private void radGridView_DistinctValuesLoading(object sender, Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs e)
{
    e.ItemsSource = ((RadGridView)sender).GetDistinctValues(e.Column, false);
}
#endregion
}
