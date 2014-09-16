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

#region radchart-features-axes-overview_1
Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
radChart.DefaultView.ChartArea.AxisX.AutoRange = true;
radChart.DefaultView.ChartArea.AxisX.DefaultLabelFormat = "0.0";
radChart.DefaultView.ChartArea.AxisX.Title = "Kilovolt [kV]";
radChart.DefaultView.ChartArea.AxisY.AutoRange = false;
radChart.DefaultView.ChartArea.AxisY.MinValue = 100;
radChart.DefaultView.ChartArea.AxisY.MaxValue = 200;
radChart.DefaultView.ChartArea.AxisY.Step = 5;
radChart.DefaultView.ChartArea.AxisY.DefaultLabelFormat = "0";
radChart.DefaultView.ChartArea.AxisY.Title = "Ampere [A]";
#endregion

#region radchart-features-axes-overview_3
telerikChart.DefaultView.ChartArea.AxisX.AddRange( 100, 200, 5 );
#endregion
}
