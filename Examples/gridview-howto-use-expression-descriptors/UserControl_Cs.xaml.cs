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

#region gridview-howto-use-expression-descriptors_0
var descriptor = new SortDescriptor<Employee, double>
{
    SortingExpression = e => e.Orders.SelectMany(o => o.Details).Sum(d => d.UnitPrice * d.Quantity),
    SortDirection = ListSortDirection.Descending
};
#endregion

#region gridview-howto-use-expression-descriptors_1
var descriptor = new GroupDescriptor<Employee, int, int>
{
    GroupingExpression = e => e.Orders.Where(o => o.Details.Any(d => d.Product.ProductName.Contains("Syrup"))).Count(),
    SortDirection = ListSortDirection.Ascending
};
#endregion

#region gridview-howto-use-expression-descriptors_2
var descriptor = new FilterDescriptor<Employee> { FilteringExpression = e => prospects.Contains(e) };
#endregion

}
