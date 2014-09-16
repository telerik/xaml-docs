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

#region radchart-styling-and-appearance-styling-chart-series_0
BarSeriesDefinition barDefinition = new BarSeriesDefinition();
barDefinition.Appearance.Fill = new SolidColorBrush( Colors.Orange );
this.radChart.DefaultSeriesDefinition = barDefinition;
#endregion

#region radchart-styling-and-appearance-styling-chart-series_4
this.radChart.DefaultView.ChartArea.SeriesStyles.SplineAreaSeriesStyle = this.Resources[ "SplineAreaStyle" ] as Style;
#endregion

#region radchart-styling-and-appearance-styling-chart-series_7
this.radChart.DefaultView.ChartArea.SeriesStyles.BarSeriesStyle = this.Resources[ "BarStyle" ] as Style;
#endregion

#region radchart-styling-and-appearance-styling-chart-series_14
RadChart1.DefaultSeriesDefinition = line;
line.Appearance.Stroke = new SolidColorBrush(System.Windows.Media.Colors.Blue);
line.Appearance.Fill = new SolidColorBrush(System.Windows.Media.Colors.Blue);
line.Appearance.StrokeThickness = 1;
line.ItemStyle = this.Resources["MyDoubleLineStyle"] as Style;
#endregion
}
