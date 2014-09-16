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

#region radchart-styling-and-appearance-styling-axis-title_0
this.radChart.DefaultView.ChartArea.AxisX.AxisStyles.TitleStyle = this.Resources[ "AxisTitleStyle" ] as Style;
this.radChart.DefaultView.ChartArea.AxisY.AxisStyles.TitleStyle = this.Resources[ "AxisTitleStyle" ] as Style;
#endregion
}
