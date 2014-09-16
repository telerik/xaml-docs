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

#region gridview-filtering-programmatic_0
Telerik.Windows.Controls.GridViewColumn countryColumn = this.radGridView.Columns["Country"];
Telerik.Windows.Controls.GridView.IColumnFilterDescriptor countryFilter = countryColumn.ColumnFilterDescriptor;

// Suspend the notifications to avoid multiple data engine updates
countryFilter.SuspendNotifications();

// This is the same as the end user selecting a distinct value through the UI.
countryFilter.DistinctFilter.AddDistinctValue("Poland");
countryFilter.DistinctFilter.AddDistinctValue("Spain");
countryFilter.DistinctFilter.AddDistinctValue("Uzbekistan");
countryFilter.DistinctFilter.AddDistinctValue("Netherlands");
countryFilter.DistinctFilter.AddDistinctValue("Austria");
countryFilter.DistinctFilter.AddDistinctValue("Finland");
countryFilter.DistinctFilter.AddDistinctValue("Pakistan");

// This is the same as the end user configuring the upper field filter.
countryFilter.FieldFilter.Filter1.Operator = Telerik.Windows.Data.FilterOperator.Contains;
countryFilter.FieldFilter.Filter1.Value = "land";
countryFilter.FieldFilter.Filter1.IsCaseSensitive = true;

// This is the same as the end user changing the logical operator between the two field filters.
countryFilter.FieldFilter.LogicalOperator = Telerik.Windows.Data.FilterCompositionLogicalOperator.Or;
				
// This is the same as the end user configuring the lower field filter.
countryFilter.FieldFilter.Filter2.Operator = Telerik.Windows.Data.FilterOperator.Contains;
countryFilter.FieldFilter.Filter2.Value = "stan";
countryFilter.FieldFilter.Filter2.IsCaseSensitive = true;

// Resume the notifications to force the data engine to update the filter.
countryFilter.ResumeNotifications();
#endregion

#region gridview-filtering-programmatic_1
this.radGridView.FilterDescriptors.SuspendNotifications();
// ... filter as many columns as you wish here...
this.radGridView.FilterDescriptors.ResumeNotifications();
#endregion

#region gridview-filtering-programmatic_2
this.radGridView.FilterDescriptors.SuspendNotifications();
foreach (Telerik.Windows.Controls.GridViewColumn column in this.radGridView.Columns)
{
	column.ClearFilters();
}
this.radGridView.FilterDescriptors.ResumeNotifications();
#endregion

#region gridview-filtering-programmatic_3
// Give me all people that are named John.
Telerik.Windows.Data.FilterDescriptor fd = new Telerik.Windows.Data.FilterDescriptor();
fd.Member = "FirstName";
fd.Operator = Telerik.Windows.Data.FilterOperator.IsEqualTo;
fd.Value = "John";
fd.IsCaseSensitive = true;
// In most cases the data engine will discover this automatically so you do not need to set it.
fd.MemberType = typeof(string);
#endregion

#region gridview-filtering-programmatic_4
Telerik.Windows.Data.FilterDescriptor olderThan18Filter = new Telerik.Windows.Data.FilterDescriptor("Age", Telerik.Windows.Data.FilterOperator.IsGreaterThanOrEqualTo, 18);
Telerik.Windows.Data.FilterDescriptor youngerThan60Filter = new Telerik.Windows.Data.FilterDescriptor("Age", Telerik.Windows.Data.FilterOperator.IsLessThan, 60);

Telerik.Windows.Data.CompositeFilterDescriptor ageFilter = new Telerik.Windows.Data.CompositeFilterDescriptor();
ageFilter.FilterDescriptors.Add(olderThan18Filter);
ageFilter.FilterDescriptors.Add(youngerThan60Filter);
ageFilter.LogicalOperator = Telerik.Windows.Data.FilterCompositionLogicalOperator.And;

Telerik.Windows.Data.FilterDescriptor liveInSpainFilter = new Telerik.Windows.Data.FilterDescriptor("Country", Telerik.Windows.Data.FilterOperator.IsEqualTo, "Spain");

Telerik.Windows.Data.CompositeFilterDescriptor mainFilter = new Telerik.Windows.Data.CompositeFilterDescriptor();
mainFilter.FilterDescriptors.Add(ageFilter);
mainFilter.FilterDescriptors.Add(liveInSpainFilter);
mainFilter.LogicalOperator = Telerik.Windows.Data.FilterCompositionLogicalOperator.And;

this.radGridView.FilterDescriptors.Add(mainFilter);
#endregion
}
