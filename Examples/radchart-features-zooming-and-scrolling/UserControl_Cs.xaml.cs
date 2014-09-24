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

#region radchart-features-zooming-and-scrolling_0
this.radChart.DefaultView.ChartArea.ZoomScrollSettingsX.MinZoomRange = 0.1;
this.radChart.DefaultView.ChartArea.ZoomScrollSettingsX.RangeEnd = 0.3;
this.radChart.DefaultView.ChartArea.ZoomScrollSettingsX.RangeStart = 0.2;
this.radChart.DefaultView.ChartArea.ZoomScrollSettingsX.ScrollMode = ScrollMode.ScrollAndZoom;
#endregion
}
