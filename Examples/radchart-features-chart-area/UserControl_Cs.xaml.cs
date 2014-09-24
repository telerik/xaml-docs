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

#region radchart-features-chart-area_1
Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
radChart.DefaultView.ChartArea.LabelFormatBehavior = LabelFormatBehavior.HumanReadable;
radChart.DefaultView.ChartArea.AxisX.IsDateTime = true;
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "MMM";
radChart.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Between;
...
#endregion
}
