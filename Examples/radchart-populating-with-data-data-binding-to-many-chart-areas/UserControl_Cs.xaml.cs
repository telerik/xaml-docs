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

#region radchart-populating-with-data-data-binding-to-many-chart-areas_1
//Creating new instance of RadChart control
Telerik.Windows.Controls.RadChart radChart = new Telerik.Windows.Controls.RadChart();
radChart.UseDefaultLayout = false;
....
//Creating Grid with two rows and two columns to host two ChartTitles and two ChartAreas
Grid chartLayout = new Grid();
chartLayout.Margin = new Thickness( 10, 10, 0, 20 );
chartLayout.RowDefinitions.Add( new RowDefinition() );
chartLayout.RowDefinitions[ 0 ].Height = new GridLength( 0, GridUnitType.Auto );
chartLayout.RowDefinitions.Add( new RowDefinition() );
radChart.Content = chartLayout;
chartLayout.ColumnDefinitions.Add( new ColumnDefinition() );
chartLayout.ColumnDefinitions.Add( new ColumnDefinition() );
//Creating ChartTitle for the left chart
Telerik.Windows.Controls.Charting.ChartTitle chartTitle = new Telerik.Windows.Controls.Charting.ChartTitle();
chartTitle.Margin = new Thickness( 0, 0, 0, 10 );
chartTitle.HorizontalAlignment = HorizontalAlignment.Center;
chartTitle.Content = "Year 2008";
chartLayout.Children.Add( chartTitle );
//Creating ChartArea of for the left chart
Telerik.Windows.Controls.Charting.ChartArea chartArea1 = new Telerik.Windows.Controls.Charting.ChartArea();
chartArea1.Name = "webBrowsersShare2008Chart";
chartLayout.Children.Add( chartArea1 );
Grid.SetRow( chartArea1, 1 );
//Creating ChartTitle for the right chart
chartTitle = new Telerik.Windows.Controls.Charting.ChartTitle();
chartTitle.Margin = new Thickness( 0, 0, 0, 10 );
chartTitle.HorizontalAlignment = HorizontalAlignment.Center;
chartTitle.Content = "Year 2009";
chartLayout.Children.Add( chartTitle );
Grid.SetColumn( chartTitle, 1 );
//Creating ChartArea of for the right chart
Telerik.Windows.Controls.Charting.ChartArea chartArea2 = new Telerik.Windows.Controls.Charting.ChartArea();
chartArea2 = new Telerik.Windows.Controls.Charting.ChartArea();
chartArea2.Name = "webBrowsersShare2009Chart";
chartLayout.Children.Add( chartArea2 );
Grid.SetRow( chartArea2, 1 );
Grid.SetColumn( chartArea2, 1 );
//Creating series mapping for the first chart and link it to the left ChartArea
SeriesMapping seriesMapping = new SeriesMapping();
seriesMapping.CollectionIndex = 0;
seriesMapping.ChartAreaName = "webBrowsersShare2008Chart";
seriesMapping.SeriesDefinition = new DoughnutSeriesDefinition();
seriesMapping.ItemMappings.Add( new ItemMapping( "Value", DataPointMember.YValue ) );
seriesMapping.ItemMappings.Add( new ItemMapping( "Description", DataPointMember.Label ) );
radChart.SeriesMappings.Add( seriesMapping );
//Creating series mapping for the first chart and link it to the right ChartArea
seriesMapping = new SeriesMapping();
seriesMapping.CollectionIndex = 1;
seriesMapping.ChartAreaName = "webBrowsersShare2009Chart";
seriesMapping.SeriesDefinition = new DoughnutSeriesDefinition();
seriesMapping.ItemMappings.Add( new ItemMapping( "Value", DataPointMember.YValue ) );
seriesMapping.ItemMappings.Add( new ItemMapping( "Description", DataPointMember.Label ) );
radChart.SeriesMappings.Add( seriesMapping );
....
#endregion
}
