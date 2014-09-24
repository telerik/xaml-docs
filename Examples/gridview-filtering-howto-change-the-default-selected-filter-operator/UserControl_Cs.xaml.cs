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

#region gridview-filtering-howto-change-the-default-selected-filter-operator_0
private void OnRadGridViewFilterOperatorsLoading(object sender, Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs e)
{
	if (e.Column.UniqueName == "HireDate")
	{
		e.DefaultOperator1 = Telerik.Windows.Data.FilterOperator.IsGreaterThan;
		e.DefaultOperator2 = Telerik.Windows.Data.FilterOperator.IsLessThan;
	}
}
#endregion

}
