---
title: DoughtnutSeries
page_title: DoughtnutSeries
description: DoughtnutSeries
slug: radchartview-series-doughnutseries
tags: doughtnutseries
published: True
position: 1
---

# DoughtnutSeries

This series is visualized on the screen as separate slices representing each of the data points. The only difference from the PieSeries is that each slices is drawn with an offset from the center of the control.

* [Declaratively Defined Series](#declaratively-defined-series)
* [Properties](#properties)
* [Data Binding](#data-binding)
* [Styling the Series](#styling-the-series)      

## Declaratively defined series

You can use the following definition to display a simple DoughnutSeries

#### __[XAML] Example 1: Declaring an DoughtnutSeries in XAML__
{{region  radchartview-series-doughnutseries_0}}
	<telerik:RadPieChart Palette="Windows8">
		<telerik:RadPieChart.Series>
			<telerik:DoughnutSeries>
				<telerik:DoughnutSeries.DataPoints>
					<telerik:PieDataPoint Label="43.46%" Value="43.46"/>
					<telerik:PieDataPoint Label="27.53%" Value="27.53"/>
					<telerik:PieDataPoint Label="15.11%" Value="15.11"/>
					<telerik:PieDataPoint Label="10.35%" Value="10.35"/>
					<telerik:PieDataPoint Label="3.55%" Value="3.55"/>
				</telerik:DoughnutSeries.DataPoints>
			</telerik:DoughnutSeries>
		</telerik:RadPieChart.Series>
	</telerik:RadPieChart>
{{endregion}}

#### __Figure 1: DoughtnutSeries visual appearance__	
![radchartview-series-doughnutseries](images/radchartview-series-doughnutseries.png)

## Properties

* __ValueBinding__: A property of type __DataPointBinding__ that gets or sets the property path that determines the value of the data point.
* __AngleRange__: A property of type __DataPointBinding__ that gets or sets the property path that determines the category value of the data point.
* __RadiusFactor__: A property of type __double__ that gets or sets the radius factor used to calculate the radius of the visual series.
* __SelectedPointOffset__: A property of type __double__ that gets or sets the offset applied to a __Telerik.Charting.PieDataPoint__ which is currently selected. This value is applied only if the point's OffsetFromCenter property is 0.
* __InnerRadiusFactor__: A property of type __double__ that gets or sets the inner radius factor (that is the space that remains empty) of the series. The value is in logical units, in the range of [0, 1].
* __DefaultSliceStyle__: A property of type __Style__ that gets the style applied to every segment in the series.

## Data Binding

You can use the __ValueBinding__ property of the DoughtnutSeries to bind the DataPoints’ properties to the properties from your view models.

#### __[C#] Example 2: Defining the view model__

{{region radchartview-series-doughnutseries_1}}
	public class PlotInfo
    {
        public double Value { get; set; }
    }

	//.......
	this.DataContext = new ObservableCollection<PlotInfo>
	{
		new PlotInfo() { Value = 43.46},
		//....
	};
{{endregion}}		

#### __[XAML] Example 3: Specify a DoughtnutSeries in XAML__
{{region radchartview-series-doughnutseries_2}}
	<telerik:DoughtnutSeries ItemsSource="{Binding}" ValueBinding="Value" />
{{endregion}}	

>See the [Create Data-Bound Chart]({%slug radchartview-series-databinding%}) for more information on data binding in the RadChartView suite.

## Styling the Series

You can see how to style the series using different properties in the [DoughtnutSeries section]({%slug radchartview-styles-and-templates-customizing-piechart-series%}) of the Customizing PieChart Series help article.

Additionally, you can use the Palette property of the chart to change the colors of the DoughtnutSeries on a global scale. You can find more information about this feature in the [Palettes]({%slug radchartview-features-palettes-introduction%}) section in our help documentation.

## See Also
 * [Chart Series Overview]({%slug radchartview-series-chartseries%})
 * [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
