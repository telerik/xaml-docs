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

#region gridview-filtering-howto-remove-some-of-the-available-filter-operators_0
private void OnRadGridViewFilterOperatorsLoading(object sender, Telerik.Windows.Controls.GridView.FilterOperatorsLoadingEventArgs e)
{
	if (e.Column.UniqueName == "HireDate")
	{
		e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsEqualTo);
		e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNotEqualTo);
				
		e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsGreaterThanOrEqualTo);
		e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsLessThanOrEqualTo);
				
		e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNull);
		e.AvailableOperators.Remove(Telerik.Windows.Data.FilterOperator.IsNotNull);

		e.DefaultOperator1 = Telerik.Windows.Data.FilterOperator.IsGreaterThan;
		e.DefaultOperator2 = Telerik.Windows.Data.FilterOperator.IsLessThan;
	}
}
#endregion

}
