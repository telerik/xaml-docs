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

#region radchart-features-annotations-marked-zone_0
InitializeComponent();
DataSeries series1 = new DataSeries()
 {
   new DataPoint(145),
   new DataPoint(132),
   new DataPoint(164),
   new DataPoint(187),
   new DataPoint(186),
   new DataPoint(131),
   new DataPoint(173),
   new DataPoint(172),
   new DataPoint(140),
   new DataPoint(129),
   new DataPoint(158),
   new DataPoint(149)
 };
series1.Definition = new LineSeriesDefinition();
series1.Definition.Appearance.Fill = new SolidColorBrush(Colors.Black);
series1.Definition.Appearance.Stroke = new SolidColorBrush(Colors.Black);
series1.Definition.Appearance.PointMark.Stroke = new SolidColorBrush(Colors.Black);
RadChart1.DefaultView.ChartArea.DataSeries.Add(series1);
#endregion

#region radchart-features-annotations-marked-zone_3
MarkedZone redZone = new MarkedZone();
redZone.StartY = 110;
redZone.EndY = 130;
redZone.Background = new SolidColorBrush( Color.FromArgb( 255, 248, 109, 90 ) );
MarkedZone yellowZone = new MarkedZone();
yellowZone .StartY = 130;
yellowZone .EndY = 170;
yellowZone .Background = new SolidColorBrush( Color.FromArgb( 255, 234, 244, 81 ) );
MarkedZone greenZone = new MarkedZone();
greenZone .StartY = 170;
greenZone one.EndY = 200;
greenZone .Background = new SolidColorBrush( Color.FromArgb( 255, 154, 216, 70 ) );
this.radChart.DefaultView.ChartArea.Annotations.Add( redZone );
this.radChart.DefaultView.ChartArea.Annotations.Add( yellowZone );
this.radChart.DefaultView.ChartArea.Annotations.Add( greenZone );
#endregion
}
