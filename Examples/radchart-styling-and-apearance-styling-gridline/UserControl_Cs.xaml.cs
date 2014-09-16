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

#region radchart-styling-and-apearance-styling-gridline_1
this.radChart.DefaultView.ChartArea.AxisX.AxisStyles.GridLineStyle = this.Resources[ "GridLineStyle" ] as Style;
this.radChart.DefaultView.ChartArea.AxisY.AxisStyles.GridLineStyle = this.Resources[ "GridLineStyle" ] as Style;
#endregion
}
