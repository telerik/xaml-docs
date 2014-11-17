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

#region radchart-styling-and-appearance-styling-point-marks_0
LineSeriesDefinition l = new LineSeriesDefinition();
l.Appearance.PointMark.Stroke = new SolidColorBrush( Colors.Blue );
l.Appearance.PointMark.StrokeThickness = 1;
l.Appearance.PointMark.Fill = new SolidColorBrush( Colors.Transparent );
l.Appearance.PointMark.Shape = MarkerShape.Diamond;
this.radChart.DefaultSeriesDefinition = l;
#endregion
}
