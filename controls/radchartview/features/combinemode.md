---
title: Combine Mode
page_title: Combine Mode
description: Combine Mode
slug: radchartview-features-combinemode
tags: series, combinemode, barseries
published: True
position: 9
---

# Combine Mode

Categorical series in RadChartView have mechanism which can be used for combining data points that reside in different series but have the same category. This mechanism can be triggered by setting the __CombineMode__ property of the series. It is an enumeration and it allows the following values: __None, Cluster, Stack, Stack100__.

>tip Categorical series which supports this mechanism are: __AreaSeries, BarSeries, LineSeries, PointSeries, RangeBarSeries__.

#### __[XAML] Example 1: Setting CombineMode property__
	{{region xaml-radchartview-features-combinemode_0}}
		<telerik:RadCartesianChart Palette="Windows8">
            <telerik:RadCartesianChart.HorizontalAxis>
                <telerik:CategoricalAxis />
            </telerik:RadCartesianChart.HorizontalAxis>
            <telerik:RadCartesianChart.VerticalAxis>
                <telerik:LinearAxis />
            </telerik:RadCartesianChart.VerticalAxis>
            <telerik:RadCartesianChart.Series>                
                <telerik:BarSeries CombineMode="Cluster">
                    <telerik:BarSeries.DataPoints>
                        <telerik:CategoricalDataPoint Category="January" Value="6" />
                        <telerik:CategoricalDataPoint Category="February" Value="8" />
                        <telerik:CategoricalDataPoint Category="March" Value="7" />
                        <telerik:CategoricalDataPoint Category="April" Value="15" />
                        <telerik:CategoricalDataPoint Category="May" Value="2" />
                        <telerik:CategoricalDataPoint Category="June" Value="5" />
                        <telerik:CategoricalDataPoint Category="July" Value="8" />
                    </telerik:BarSeries.DataPoints>
                </telerik:BarSeries>
                <telerik:BarSeries CombineMode="Cluster">
                    <telerik:BarSeries.DataPoints>
                        <telerik:CategoricalDataPoint Category="January" Value="2" />
                        <telerik:CategoricalDataPoint Category="February" Value="5" />
                        <telerik:CategoricalDataPoint Category="March" Value="3" />
                        <telerik:CategoricalDataPoint Category="April" Value="10" />
                        <telerik:CategoricalDataPoint Category="May" Value="9" />
                        <telerik:CategoricalDataPoint Category="June" Value="7" />
                        <telerik:CategoricalDataPoint Category="July" Value="1" />
                    </telerik:BarSeries.DataPoints>
                </telerik:BarSeries>
                <telerik:BarSeries CombineMode="Cluster">
                    <telerik:BarSeries.DataPoints>
                        <telerik:CategoricalDataPoint Category="January" Value="8" />
                        <telerik:CategoricalDataPoint Category="February" Value="12" />
                        <telerik:CategoricalDataPoint Category="March" Value="19" />
                        <telerik:CategoricalDataPoint Category="April" Value="11" />
                        <telerik:CategoricalDataPoint Category="May" Value="7" />
                        <telerik:CategoricalDataPoint Category="June" Value="14" />
                        <telerik:CategoricalDataPoint Category="July" Value="7" />
                    </telerik:BarSeries.DataPoints>
                </telerik:BarSeries>
            </telerik:RadCartesianChart.Series>
        </telerik:RadCartesianChart>
	{{endregion}}

* __None__ / __Cluster__: In this mode each series will be plotted independently of each other, so that they are no overlapping.

	![](images/radchartview-features-combinemode-none-cluster.png)
	
* __Stack__: In this mode all series form stacks. The points of all series are placed on top of each other. The drawing of the next point will start from the value of the previous one. 

	![](images/radchartview-features-combinemode-stack.png)
	
* __Stack100__: When this mode is set all series form stacks that occupy 100% of the plot area. It shows the combined contribution of values as percentages where the combined total for each category is 100 percent. It's good to use it when the relationship between values in a category is more significant than the amounts.

	![](images/radchartview-features-combinemode-stack100.png)

## See Also

 * [Getting Started]({%slug radchartview-introduction%})
 * [Data Binding]({%slug radchartview-series-databinding%}) 
