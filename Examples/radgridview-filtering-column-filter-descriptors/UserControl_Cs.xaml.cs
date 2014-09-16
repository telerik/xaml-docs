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

#region radgridview-filtering-column-filter-descriptors_0
ColumnFilterDescriptor columnDescriptor = new ColumnFilterDescriptor( ( IDataFieldDescriptor )this.radGridView.Columns[ "CityColumn" ] );
columnDescriptor.DistinctFilter.DistinctValues.Add( "Berlin" );
columnDescriptor.DistinctFilter.DistinctValues.Add( "Aachen" );
this.radGridView.FilterDescriptors.Add( columnDescriptor );
#endregion

#region radgridview-filtering-column-filter-descriptors_2
ColumnFilterDescriptor columnDescriptor = new ColumnFilterDescriptor( ( IDataFieldDescriptor )this.radGridView.Columns[ "CityColumn" ] );
columnDescriptor.FieldFilter.Filter1.Operator = FilterOperator.IsEqualTo;
columnDescriptor.FieldFilter.Filter1.Value = "Berlin";
columnDescriptor.FieldFilter.LogicalOperator = FilterCompositionLogicalOperator.Or;
columnDescriptor.FieldFilter.Filter2.Operator = FilterOperator.IsEqualTo;
columnDescriptor.FieldFilter.Filter2.Value = "Aachen";
this.radGridView.FilterDescriptors.Add( columnDescriptor );
#endregion

#region radgridview-filtering-column-filter-descriptors_4
ColumnFilterDescriptor citiesDescriptor = new ColumnFilterDescriptor( ( IDataFieldDescriptor )this.radGridView.Columns[ "CityColumn" ] );
citiesDescriptor.DistinctFilter.DistinctValues.Add( "Berlin" );
citiesDescriptor.DistinctFilter.DistinctValues.Add( "Aachen" );
this.radGridView.FilterDescriptors.Add( citiesDescriptor );
ColumnFilterDescriptor countryDescriptor = new ColumnFilterDescriptor( ( IDataFieldDescriptor )this.radGridView.Columns[ "CountryColumn" ] );
countryDescriptor.DistinctFilter.DistinctValues.Add( "Germany" );
this.radGridView.FilterDescriptors.Add( countryDescriptor );
#endregion
}
