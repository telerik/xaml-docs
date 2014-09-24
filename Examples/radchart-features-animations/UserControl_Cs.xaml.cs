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

#region radchart-features-animations_1
Telerik.Windows.Controls.RadChart radChart= new Telerik.Windows.Controls.RadChart();
....
radChart.DefaultView.ChartArea.AnimationSettings = new AnimationSettings();
radChart.DefaultView.ChartArea.AnimationSettings.ItemDelay = new TimeSpan( 0 );
radChart.DefaultView.ChartArea.AnimationSettings.ItemAnimationDuration = new TimeSpan( 0, 0, 3 );
DataSeries barSeries = new DataSeries();
barSeries.Definition = new BarSeriesDefinition();
barSeries.Add( new DataPoint(){ YValue = 154 } );
barSeries.Add( new DataPoint(){ YValue = 138 } );
barSeries.Add( new DataPoint(){ YValue = 143 } );
barSeries.Add( new DataPoint(){ YValue = 120 } );
barSeries.Add( new DataPoint(){ YValue = 135 } );
barSeries.Add( new DataPoint(){ YValue = 125 } );
barSeries.Add( new DataPoint(){ YValue = 179 } );
barSeries.Add( new DataPoint(){ YValue = 170 } );
barSeries.Add( new DataPoint(){ YValue = 198 } );
barSeries.Add( new DataPoint(){ YValue = 187 } );
barSeries.Add( new DataPoint(){ YValue = 193 } );
barSeries.Add( new DataPoint(){ YValue = 176 } );
radChart.DefaultView.ChartArea.DataSeries.Add( barSeries );
barSeries = new DataSeries();
barSeries.Definition = new BarSeriesDefinition();
barSeries.Definition.AnimationSettings = new AnimationSettings();
barSeries.Definition.AnimationSettings.ItemAnimationDuration = new TimeSpan( 0, 0, 0, 0, 500 );
barSeries.Definition.AnimationSettings.TotalSeriesAnimationDuration = new TimeSpan( 0, 0, 3 );
barSeries.Add( new DataPoint(){ YValue = 45 } );
barSeries.Add( new DataPoint(){ YValue = 48 } );
barSeries.Add( new DataPoint(){ YValue = 53 } );
barSeries.Add( new DataPoint(){ YValue = 41 } );
barSeries.Add( new DataPoint(){ YValue = 32 } );
barSeries.Add( new DataPoint(){ YValue = 28 } );
barSeries.Add( new DataPoint(){ YValue = 63 } );
barSeries.Add( new DataPoint(){ YValue = 74 } );
barSeries.Add( new DataPoint(){ YValue = 77 } );
barSeries.Add( new DataPoint(){ YValue = 85 } );
barSeries.Add( new DataPoint(){ YValue = 89 } );
barSeries.Add( new DataPoint(){ YValue = 80 } );
radChart.DefaultView.ChartArea.DataSeries.Add( barSeries );
#endregion

#region radchart-features-animations_4
....
radChart.DefaultView.ChartArea.EnableAnimations = false;
radChart.DefaultView.ChartArea.EnableStripLinesAnimation = false;
....
#endregion
}
