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

#region radchart-tempalting-bar-series_0
BarSeriesDefinition barSeries = new BarSeriesDefinition();
barSeries.ItemStyle = this.Resources[ "BarStyle" ] as Style;
this.radChart.DefaultSeriesDefinition = barSeries;
#endregion
}
