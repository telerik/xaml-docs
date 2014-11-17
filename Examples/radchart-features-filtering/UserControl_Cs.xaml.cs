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

#region radchart-features-filtering_2
ChartFilterDescriptor descriptor = new ChartFilterDescriptor();
descriptor.Member = "Quantity";
descriptor.Operator = FilterOperator.IsLessThanOrEqualTo;
descriptor.Value = 150;
this.radChart.FilterDescriptors.Add( descriptor );
#endregion
}
