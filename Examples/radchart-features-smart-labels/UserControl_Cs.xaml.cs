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

#region radchart-features-smart-labels_1
this.radChart.DefaultView.ChartArea.SmartLabelsEnabled = true;
#endregion

#region radchart-features-smart-labels_4
LabelSettings settings = new LabelSettings();
settings.Distance = 10;
settings.ShowConnectors = true;
LineSeriesDefinition lineSeries = new LineSeriesDefinition();
lineSeries.LabelSettings = settings;
this.radChart.DefaultSeriesDefinition = new LineSeriesDefinition();
this.radChart.DefaultView.ChartArea.SmartLabelsEnabled = true;
#endregion

#region radchart-features-smart-labels_7
BarLabelSettings barSettings = new BarLabelSettings();
barSettings.Distance = 10;
barSettings.LabelDisplayMode = LabelDisplayMode.Outside;
barSettings.ShowConnectors = false;
BarSeriesDefinition barSeries = new BarSeriesDefinition();
barSeries.LabelSettings = barSettings;
this.radChart.DefaultSeriesDefinition = barSeries;
this.radChart.DefaultView.ChartArea.SmartLabelsEnabled = true;
#endregion

#region radchart-features-smart-labels_10
RadialLabelSettings radialSettings = new RadialLabelSettings();
radialSettings.SpiderModeEnabled = true;
radialSettings.ShowConnectors = true;
PieSeriesDefinition pieSeries = new PieSeriesDefinition();
pieSeries.LabelSettings = radialSettings;
this.radChart.DefaultSeriesDefinition = pieSeries;
this.radChart.DefaultView.ChartArea.SmartLabelsEnabled = true;
#endregion
}
