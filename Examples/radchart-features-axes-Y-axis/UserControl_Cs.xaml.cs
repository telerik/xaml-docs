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

#region radchart-features-axes-Y-axis_1
Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
....
radChart.DefaultView.ChartArea.AxisY.MinorTicksVisibility = Visibility.Visible;
radChart.DefaultView.ChartArea.AxisY.MinorTickPointMultiplier = 5;
radChart.DefaultView.ChartArea.AxisY.ExtendDirection = AxisExtendDirection.Down;
radChart.DefaultView.ChartArea.AxisY.DefaultLabelFormat = "0";
radChart.DefaultView.ChartArea.AxisY.Title="Ampere [A]";
....
#endregion
}
