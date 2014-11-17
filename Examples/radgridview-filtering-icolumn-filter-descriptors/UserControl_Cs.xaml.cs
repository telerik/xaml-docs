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

#region radgridview-filtering-icolumn-filter-descriptors_0
    GridViewColumn cityColumn = this.playersGrid.Columns["City"];
    // Getting it from the property will create it and associate it with its column automatically.
    IColumnFilterDescriptor columnDescriptor = cityColumn.ColumnFilterDescriptor;
    columnDescriptor.SuspendNotifications();
    columnDescriptor.DistinctFilter.AddDistinctValue("Berlin");
    columnDescriptor.DistinctFilter.AddDistinctValue("Aachen");
    columnDescriptor.ResumeNotifications();
    // There is no need to manually add the column filter to this.radGridView.FilterDescriptors
    // When the column filter is activated/deactivated it is automatically added/removed to this collection.
#endregion

#region radgridview-filtering-icolumn-filter-descriptors_2
    GridViewColumn cityColumn = this.playersGrid.Columns["City"];
    // Getting it from the property will create it and associate it with its column automatically.
    IColumnFilterDescriptor columnDescriptor = cityColumn.ColumnFilterDescriptor;
    columnDescriptor.SuspendNotifications();
    columnDescriptor.FieldFilter.Filter1.Operator = FilterOperator.IsEqualTo;
    columnDescriptor.FieldFilter.Filter1.Value = "Berlin";
    columnDescriptor.FieldFilter.LogicalOperator = FilterCompositionLogicalOperator.Or;
    columnDescriptor.FieldFilter.Filter2.Operator = FilterOperator.IsEqualTo;
    columnDescriptor.FieldFilter.Filter2.Value = "Aachen";
    columnDescriptor.ResumeNotifications();
    // There is no need to manually add the column filter to this.radGridView.FilterDescriptors
    // When the column filter is activated/deactivated it is automatically added/removed to this collection.
#endregion

#region radgridview-filtering-icolumn-filter-descriptors_4
    GridViewColumn cityColumn = this.playersGrid.Columns["City"];
    // Getting it from the property will create it and associate it with its column automatically
    IColumnFilterDescriptor cityDescriptor = cityColumn.ColumnFilterDescriptor;
    cityDescriptor.SuspendNotifications();
    cityDescriptor.DistinctFilter.AddDistinctValue("Berlin");
    cityDescriptor.DistinctFilter.AddDistinctValue("Aachen");
    cityDescriptor.ResumeNotifications();

    GridViewColumn countryColumn = this.playersGrid.Columns["Country"];
    IColumnFilterDescriptor columnDescriptor = countryColumn.ColumnFilterDescriptor;
    columnDescriptor.SuspendNotifications();
    columnDescriptor.DistinctFilter.AddDistinctValue("Germany");
    columnDescriptor.ResumeNotifications();  

    // There is no need to manually add the column filter to this.radGridView.FilterDescriptors
    // When the column filter is activated/deactivated it is automatically added/removed to this collection.
#endregion
}
