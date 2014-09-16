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

#region radchart-features-axes-multiple-y-axes_1
Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
....
radChart.DefaultView.ChartArea.AxisY.Title = "Megawatt [MW]";
AxisY axisY = new AxisY();
axisY.AxisName = "AxisY_South";
axisY.Title = "Kilowatt [kW]";
radChart.DefaultView.ChartArea.AdditionalYAxes.Add( axisY );
....
//Series mapping for the collection with index 0
SeriesMapping seriesMapping = new SeriesMapping();
seriesMapping.CollectionIndex = 0;
seriesMapping.LegendLabel = "North [MW]";
seriesMapping.SeriesDefinition = new BarSeriesDefinition();
seriesMapping.SeriesDefinition.ShowItemLabels = false;
seriesMapping.ItemMappings.Add( new ItemMapping( "Value", DataPointMember.YValue ) );
radChart.SeriesMappings.Add( seriesMapping );
//Series mapping for the collection with index 1
seriesMapping = new SeriesMapping();
seriesMapping.CollectionIndex = 1;
seriesMapping.LegendLabel = "South [kW]";
seriesMapping.SeriesDefinition = new BarSeriesDefinition();
seriesMapping.SeriesDefinition.AxisName = "AxisY_South";
seriesMapping.SeriesDefinition.ShowItemLabels = false;
seriesMapping.ItemMappings.Add( new ItemMapping( "Value", DataPointMember.YValue ) );
radChart.SeriesMappings.Add( seriesMapping );
radChart.ItemsSource = this.DataContext;
#endregion
}
