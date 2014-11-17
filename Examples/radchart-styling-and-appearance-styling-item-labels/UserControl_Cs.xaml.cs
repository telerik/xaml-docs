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

#region radchart-styling-and-appearance-styling-item-labels_0
this.radChart.DefaultSeriesDefinition.SeriesItemLabelStyle = this.Resources[ "SeriesItemLabelStyle" ] as Style;
#endregion
}
