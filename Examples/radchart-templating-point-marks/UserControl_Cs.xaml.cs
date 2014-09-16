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

#region radchart-templating-point-marks_2
this.radChart.DefaultSeriesDefinition = new LineSeriesDefinition();
this.radChart.DefaultSeriesDefinition.PointMarkItemStyle = this.Resources["PointMarkStyle"] as Style;
#endregion
}
