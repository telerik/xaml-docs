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

#region gridview-overview-filtering_2
FilterDescriptor descriptor = new FilterDescriptor();
descriptor.Member = "Country";
descriptor.Operator = FilterOperator.IsEqualTo;
descriptor.Value = "Germany";
this.radGridView.FilterDescriptors.Add( descriptor );
#endregion
}
