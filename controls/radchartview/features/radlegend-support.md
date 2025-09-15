---
title: RadLegend Support
page_title: RadLegend Support
description: This topic will give you an overview of the RadLegend support that RadChartView provides.
slug: radchartview-features-radlegend-support
tags: radlegend,support
published: True
position: 5
---

# RadLegend Support

This topic will give you an overview of the RadLegend support that RadChartView provides.

> Read more about the RadLegend control in its [documentation section]({%slug radlegend-overview%}).

The chart exposes a __LegendItems__ property which is to be passed to the RadLegend's Items property. The LegendItems collection is empty by default and no legend items will be generated for a series unless the __LegendSettings__ property of the series is set. This will generate and add [LegendItem]({%slug radlegend-getting-started%}#defining-radlegend-and-adding-items) objects in the LegendItems collection of the chart. The chart will automatically set the Title, MarkerStroke, MarkerFill and MarkerGeometry properties of the LegendItem object, based on the LegendSettings and the default visuals of the chart series.

## LegendSetting

Each [chart series]({%slug radchartview-series-chartseries%}) expose a __LegendSettings__ property that allows you to determine the legend items appearance. There are two types of legend settings supported by the chart series.

* __SeriesLegendSettings__: This is supported by all chart series. A single LegendItem will be generated  for the series that uses the settings.

	The settings object allows you to set the title of the LegendItem via its __Title__ property (see Example 2).

* __DataPointLegendSettings__: This is supported only by the [BarSeries]({%slug radchartview-series-barseries%}) and [BubbleSeries]({%slug radchartview-series-bubbleseries%}). A LegendItem will be generated for each data point in the series that uses the settings.

	The settings allow you to bind the title to a property from the data point model. You can do that via the __TitleBinding__ property. The property expects a string value that corresponds to the name of a property in the [DataPoint]({%slug radchartview-getting-started-data-point%}) object.
	
	__Example 1: Binding legend items title to the Category property of the CategoricalDataPoint object__
	```XAML
		<Grid>
			<telerik:RadCartesianChart x:Name="chart" Palette="Windows8">
				<telerik:RadCartesianChart.HorizontalAxis>
					<telerik:CategoricalAxis />
				</telerik:RadCartesianChart.HorizontalAxis>
				<telerik:RadCartesianChart.VerticalAxis>
					<telerik:LinearAxis />
				</telerik:RadCartesianChart.VerticalAxis>
				<telerik:RadCartesianChart.Series>
					<telerik:BarSeries PaletteMode="DataPoint">
						<telerik:BarSeries.DataPoints>
							<telerik:CategoricalDataPoint Category="X1" Value="11" />
							<telerik:CategoricalDataPoint Category="X2" Value="7" />
							<telerik:CategoricalDataPoint Category="X3" Value="3" />
						</telerik:BarSeries.DataPoints>
						<telerik:BarSeries.LegendSettings>
							<telerik:DataPointLegendSettings TitleBinding="Category" />
						</telerik:BarSeries.LegendSettings>
					</telerik:BarSeries>             
				</telerik:RadCartesianChart.Series>
			</telerik:RadCartesianChart>

			<telerik:RadLegend Items="{Binding LegendItems, ElementName=chart}" 
							   BorderBrush="Black" 
							   BorderThickness="1"
							   HorizontalAlignment="Right" 
							   VerticalAlignment="Top" />
		</Grid>
	```
	
	![Rad Chart View-features-radlegend-support-0](images/radchartview-features-radlegend-support-0.png)

Both legend settings allow you to set the geometry of the legend item's marker. You can do that via the __MarkerGeometry__ property of the settings.

## Code Example

The example below demonstrates the cooperation between the RadLegend and RadCartesianChart. In this example the chart uses a palette to color its series and it uses the same palette to color the legend items. Note that no legend item is present for the last series as the LegendSettings property has not been set. The BarSeries is set up to use DataPointLegendSettings and this is why a legend item is created for each DataPoint.If a SeriesLegendSettings was used instead - only a single item would have been generated for the BarSeries.

__Example 2: Legend Settings Code Example__  
```XAML
	<Grid>
	    <telerik:RadCartesianChart x:Name="chart1" Palette="Summer">
	        <telerik:RadCartesianChart.HorizontalAxis>
	            <telerik:CategoricalAxis />
	        </telerik:RadCartesianChart.HorizontalAxis>
	        <telerik:RadCartesianChart.VerticalAxis>
	            <telerik:LinearAxis />
	        </telerik:RadCartesianChart.VerticalAxis>
	        <telerik:RadCartesianChart.Series>
	            <telerik:BarSeries x:Name="series1">
	                <telerik:BarSeries.DataPoints>
	                    <telerik:CategoricalDataPoint Category="X1" Value="11" />
	                    <telerik:CategoricalDataPoint Category="X2" Value="7" />
	                    <telerik:CategoricalDataPoint Category="X3" Value="3" />
	                </telerik:BarSeries.DataPoints>
	                <telerik:BarSeries.LegendSettings>
	                    <telerik:DataPointLegendSettings />
	                </telerik:BarSeries.LegendSettings>
	            </telerik:BarSeries>
	            <telerik:LineSeries x:Name="series2">
	                <telerik:LineSeries.DataPoints>
	                    <telerik:CategoricalDataPoint Category="X1" Value="15" />
	                    <telerik:CategoricalDataPoint Category="X2" Value="14" />
	                    <telerik:CategoricalDataPoint Category="X3" Value="13" />
	                </telerik:LineSeries.DataPoints>
	                <telerik:LineSeries.LegendSettings>
	                    <telerik:SeriesLegendSettings Title="Line Series" />
	                </telerik:LineSeries.LegendSettings>
	            </telerik:LineSeries>
	            <telerik:LineSeries x:Name="series3">
	                <telerik:LineSeries.DataPoints>
	                    <telerik:CategoricalDataPoint Category="X1" Value="14" />
	                    <telerik:CategoricalDataPoint Category="X2" Value="13" />
	                    <telerik:CategoricalDataPoint Category="X3" Value="10" />
	                </telerik:LineSeries.DataPoints>
	            </telerik:LineSeries>
	        </telerik:RadCartesianChart.Series>
	    </telerik:RadCartesianChart>
		
	    <telerik:RadLegend Background="White" 
	                       BorderBrush="Black" 
	                       BorderThickness="1" 
	                       Items="{Binding LegendItems, ElementName=chart1}" 
	                       HorizontalAlignment="Right" 
	                       VerticalAlignment="Top" />
	</Grid>
```

![Rad Chart View-features-radlegend-support-0](images/radchartview-features-radlegend-support-1.png)

> If the default LegendItem objects created by the chart doesn't work for your scenario, you can manually populate the legend instead of using the __LegendItems__ collection. Read the [Getting Started]({%slug radlegend-getting-started%}) article of RadLegend to see how to populate the control with LegendItem objects manually.

## Using RadLegend with SeriesProvider

When using SeriesProvider, you can define the legend settings object via the Style of the series or the [SeriesCreated]({%slug radchartview-features-chartseriesprovider%}#events) event. The following example shows how to set up a SeriesProvider and add SeriesLegendSettings for each series.

__Example 3: Defining the view__  
```XAML
	<Grid>
		<Grid.ColumnDefinitions>
			<ColumnDefinition />
			<ColumnDefinition Width="Auto" />
		</Grid.ColumnDefinitions>
		
		<telerik:RadCartesianChart x:Name="chart" Palette="Windows8">
			<telerik:RadCartesianChart.VerticalAxis>
				<telerik:LinearAxis />
			</telerik:RadCartesianChart.VerticalAxis>
			<telerik:RadCartesianChart.HorizontalAxis>
				<telerik:CategoricalAxis />
			</telerik:RadCartesianChart.HorizontalAxis>
			<telerik:RadCartesianChart.SeriesProvider>
				<telerik:ChartSeriesProvider x:Name="seriesProvider">
					<telerik:CategoricalSeriesDescriptor CategoryPath="Category" ValuePath="Value" ItemsSourcePath="Items">
						<telerik:CategoricalSeriesDescriptor.Style>
							<!-- If you use NoXaml, please set the following property on the Style - BasedOn="{StaticResource PointSeriesStyle}" -->
							<Style TargetType="telerik:PointSeries">
								<Setter Property="LegendSettings">
									<Setter.Value>
										<telerik:SeriesLegendSettings Title="{Binding SeriesName}" />
									</Setter.Value>
								</Setter>
							</Style>
						</telerik:CategoricalSeriesDescriptor.Style>
					</telerik:CategoricalSeriesDescriptor>
				</telerik:ChartSeriesProvider>
			</telerik:RadCartesianChart.SeriesProvider>
		</telerik:RadCartesianChart>

		<telerik:RadLegend Items="{Binding ElementName=chart, Path=LegendItems}" Grid.Column="1"/>
	</Grid>
```

__Example 4: Defining the models__  
```C#
	public class SeriesInfo
    {
        public string SeriesName { get; set; }
        public ObservableCollection<PlotInfo> Items { get; set; }
    }

    public class PlotInfo
    {
        public double Value { get; set; }
        public string Category { get; set; }
    }
```

__Example 5: Populating with data__  
```C#
	private static Random r = new Random();
	private ObservableCollection<SeriesInfo> GetData()
	{
		var source = new ObservableCollection<SeriesInfo>();
		for (int i = 0; i < 5; i++)
		{
			var seriesInfo = new SeriesInfo() { SeriesName = "Series " + i,  Items = new ObservableCollection<PlotInfo>() };
			for (int k = 0; k < 10; k++)
			{
				seriesInfo.Items.Add(new PlotInfo() { Category = "C" + k, Value = r.Next(100, 300) });
			}
			source.Add(seriesInfo);
		}

		return source;
	}
```

__Example 6: Setting the SeriesProvider Source__  
```C#
	this.seriesProvider.Source = GetData();
```

![Rad Chart View-features-radlegend-support-0](images/radchartview-features-radlegend-support-2.png)
