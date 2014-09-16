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

#region radchart-features-axes-ticks_1
this.radChart.DefaultView.ChartArea.AxisX.MajorTicksVisibility = System.Windows.Visibility.Collapsed;
this.radChart.DefaultView.ChartArea.AxisX.MinorTickPointMultiplier = 3;
this.radChart.DefaultView.ChartArea.AxisX.MinorTicksVisibility = System.Windows.Visibility.Visible;
#endregion
}
