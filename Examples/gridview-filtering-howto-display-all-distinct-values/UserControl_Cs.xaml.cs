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

#region gridview-filtering-howto-display-all-distinct-values_0
private void OnRadGridViewDistinctValuesLoading(object sender, Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs e)
{
	e.ItemsSource = ((Telerik.Windows.Controls.RadGridView)sender).GetDistinctValues(e.Column, false);
}
#endregion

#region gridview-filtering-howto-display-all-distinct-values_1
private void OnRadGridViewDistinctValuesLoading(object sender, Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs e)
{
	e.ItemsSource = ((Telerik.Windows.Controls.RadGridView)sender).GetDistinctValues(e.Column, true, 15);
}
#endregion

#region gridview-filtering-howto-display-all-distinct-values_2
void OnRadGridViewFiltered(object sender, Telerik.Windows.Controls.GridView.GridViewFilteredEventArgs e)
{
    foreach (var item in e.ColumnFilterDescriptor.DistinctFilter.FilterDescriptors)
    {
        item.IsCaseSensitive = false;
    }
}

void OnRadGridViewDistinctValuesLoading(object sender, Telerik.Windows.Controls.GridView.GridViewDistinctValuesLoadingEventArgs e)
{
    e.ItemsSource = ((Telerik.Windows.Controls.RadGridView)sender).GetDistinctValues(e.Column, false).OfType<string>().Select(x => x.ToLower()).Distinct();
}
#endregion    

}
