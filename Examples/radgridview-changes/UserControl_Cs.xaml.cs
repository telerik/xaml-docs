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

    #region radgridview-changes_0
    GridViewColumn ageColumn = this.radGridView.Columns["Age"];
    ColumnFilterDescriptor ageColumnFilter = new ColumnFilterDescriptor(ageColumn);
    // ...
    ageColumnFilter.DistinctFilter.DistinctValues.Add(5);
    ageColumnFilter.FieldFilter.Filter1.Operator = FilterOperator.IsLessThan;
    ageColumnFilter.FieldFilter.Filter1.Value = 10;
    // ...
    this.radGridView.FilterDescriptors.Add(ageColumnFilter);
    #endregion

    #region radgridview-changes_2
    GridViewColumn ageColumn = this.radGridView.Columns["Age"];
    // Getting it from the property will create it and associate it with its column automatically.
    IColumnFilterDescriptor ageColumnFilter = ageColumn.ColumnFilterDescriptor;
    ageColumnFilter.SuspendNotifications();
    // ...
    ageColumnFilter.DistinctFilter.AddDistinctValue(5);
    ageColumnFilter.FieldFilter.Filter1.Operator = FilterOperator.IsLessThan;
    ageColumnFilter.FieldFilter.Filter1.Value = 10;
    // ...
    // There is no need to manually add the column filter to this.radGridView.FilterDescriptors
    // When the column filter is activated/deactivated it is automatically added/removed to this collection.
    ageColumnFilter.ResumeNotifications();
    #endregion

    #region radgridview-changes_4
    this.radGridView.FilterDescriptors.Remove(columnFilterDescriptor);
    #endregion

    #region radgridview-changes_6
    // Calling ClearFilter will automatically remove filter descriptor from the grid.
    myColumn.ClearFilters();
    #endregion

    #region radgridview-changes_8
    this.radGridView.FilterDescriptors.Clear();
    #endregion
    #region radgridview-changes_10
    this.radGridView.FilterDescriptors.SuspendNotifications();
    foreach (var column in this.radGridView.Columns)
    {
	    column.ClearFilters();
    }
    this.radGridView.FilterDescriptors.ResumeNotifications();
    #endregion
}
