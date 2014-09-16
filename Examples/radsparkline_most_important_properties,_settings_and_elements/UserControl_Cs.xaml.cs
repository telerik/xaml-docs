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

#region radsparkline_most_important_properties,_settings_and_elements_0
RadSparklineBase line = new RadLinearSparkline();
line.ShowMarkers = true;
#endregion

#region radsparkline_most_important_properties,_settings_and_elements_1
RadLinearSparkline  line = new RadLinearSparkline();
line.ShowHighPointIndicators = true;
#endregion

#region radsparkline_most_important_properties,_settings_and_elements_2
RadLinearSparkline  line = new RadLinearSparkline();
line. ShowLowPointIndicators = true;
#endregion

#region radsparkline_most_important_properties,_settings_and_elements_3
RadLinearSparkline  line = new RadLinearSparkline();
line.ShowNegativePointIndicators = true;
#endregion

#region radsparkline_most_important_properties,_settings_and_elements_4
RadLinearSparkline  line = new RadLinearSparkline();
line. ShowFirstPointIndicator = true;
#endregion

#region radsparkline_most_important_properties,_settings_and_elements_5
RadLinearSparkline  line = new RadLinearSparkline();
line. ShowLastPointIndicator = true;
#endregion

#region radsparkline_most_important_properties,_settings_and_elements_6
RadScatterSparkline chart = new RadScatterSparkline(); 
chart.EmptyPointBehavior = EmptyPointBehavior.DropPoint;
#endregion
}
