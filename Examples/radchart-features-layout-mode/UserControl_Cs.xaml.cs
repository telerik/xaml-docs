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

#region radchart-features-layout-mode_1
this.radChart.DefaultView.ChartArea.AxisX.LayoutMode = AxisLayoutMode.Normal;
#endregion
}
