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

#region gridview-basic-filtering2_3
private void radGridView_Filtering(object sender, GridViewFilteringEventArgs e)
{
    e.Cancel = true;
}
#endregion

#region gridview-basic-filtering2_5
private void radGridView_Filtered(object sender, GridViewFilteredEventArgs e)
{
    foreach( FilterDescriptor descriptor in e.Added )
    {
        GridViewColumn column = FilteringGrid.Columns[ descriptor.Member ];
        column.Background = new SolidColorBrush( Colors.Green );
    }
    foreach( FilterDescriptor descriptor in e.Removed )
    {
        GridViewColumn column = FilteringGrid.Columns[ descriptor.Member ];
        column.Background = new SolidColorBrush( Colors.Transparent );
    }
}
#endregion

#region gridview-basic-filtering2_7
private void clubsGrid_FilterOperatorsLoading(object sender, Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs e)
{
    if (e.AvailableOperators.Contains(FilterOperator.Contains))
    {
        e.DefaultOperator = FilterOperator.Contains;
    }
}
#endregion
}
