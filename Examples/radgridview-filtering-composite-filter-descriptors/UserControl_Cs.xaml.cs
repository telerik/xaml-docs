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

#region radgridview-filtering-composite-filter-descriptors_1
CompositeFilterDescriptor compositeDescriptor = new CompositeFilterDescriptor();
compositeDescriptor.LogicalOperator = FilterCompositionLogicalOperator.Or;
compositeDescriptor.FilterDescriptors.Add( new FilterDescriptor( "City", FilterOperator.IsEqualTo, "Berlin", false ) );
compositeDescriptor.FilterDescriptors.Add( new FilterDescriptor( "City", FilterOperator.IsEqualTo, "Aachen", false ) );
this.radGridView.FilterDescriptors.Add( compositeDescriptor );
#endregion

#region radgridview-filtering-composite-filter-descriptors_4
CompositeFilterDescriptor compositeDescriptor = new CompositeFilterDescriptor();
compositeDescriptor.LogicalOperator = FilterCompositionLogicalOperator.And;
CompositeFilterDescriptor citiesDescriptor = new CompositeFilterDescriptor();
citiesDescriptor.LogicalOperator = FilterCompositionLogicalOperator.Or;
citiesDescriptor.FilterDescriptors.Add(new FilterDescriptor("City", FilterOperator.IsEqualTo, "Berlin", false));
citiesDescriptor.FilterDescriptors.Add(new FilterDescriptor("City", FilterOperator.IsEqualTo, "Aachen", false));
FilterDescriptor descriptor = new FilterDescriptor();
descriptor.Member = "Country";
descriptor.Operator = FilterOperator.IsEqualTo;
descriptor.Value = "Germany";
compositeDescriptor.FilterDescriptors.Add(citiesDescriptor);
compositeDescriptor.FilterDescriptors.Add(descriptor);
this.radGridView.FilterDescriptors.Add(compositeDescriptor);
#endregion
}
