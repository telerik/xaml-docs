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

Categorical series in RadChartView have a mechanism which can be used for combining data points that reside in different series but have the same category. This mechanism can be triggered by setting the __CombineMode__ property of the series. It is an enumeration and it allows the following values: __None, Cluster, Stack, Stack100__.

>tip Categorical series which supports this mechanism are: __AreaSeries, BarSeries, LineSeries, PointSeries, RangeBarSeries__.

#### __[XAML] Example 1: Setting the CombineMode property__
	{{region xaml-radchartview-features-combinemode_0}}
		<telerik:RadCartesianChart Palette="Windows8">
            <telerik:RadCartesianChart.HorizontalAxis>
                <telerik:CategoricalAxis />
            </telerik:RadCartesianChart.HorizontalAxis>
            <telerik:RadCartesianChart.VerticalAxis>
                <telerik:LinearAxis />
            </telerik:RadCartesianChart.VerticalAxis>
            <telerik:RadCartesianChart.Series>
                <telerik:BarSeries CombineMode="None">
                    <telerik:BarSeries.DataPoints>
                        <telerik:CategoricalDataPoint Category="January" Value="14" />
                        <telerik:CategoricalDataPoint Category="February" Value="10" />
                        <telerik:CategoricalDataPoint Category="March" Value="7" />
                        <telerik:CategoricalDataPoint Category="April" Value="15" />
                    </telerik:BarSeries.DataPoints>
                </telerik:BarSeries>
                <telerik:BarSeries CombineMode="None">
                    <telerik:BarSeries.DataPoints>
                        <telerik:CategoricalDataPoint Category="January" Value="11" />
                        <telerik:CategoricalDataPoint Category="February" Value="15" />
                        <telerik:CategoricalDataPoint Category="March" Value="3" />
                        <telerik:CategoricalDataPoint Category="April" Value="10" />
                    </telerik:BarSeries.DataPoints>
                </telerik:BarSeries>
                <telerik:BarSeries CombineMode="None">
                    <telerik:BarSeries.DataPoints>
                        <telerik:CategoricalDataPoint Category="January" Value="8" />
                        <telerik:CategoricalDataPoint Category="February" Value="12" />
                        <telerik:CategoricalDataPoint Category="March" Value="19" />
                        <telerik:CategoricalDataPoint Category="April" Value="11" />
                    </telerik:BarSeries.DataPoints>
                </telerik:BarSeries>
            </telerik:RadCartesianChart.Series>
        </telerik:RadCartesianChart>
	{{endregion}}

<!--- --->

 * __None__: In this mode each series will be plotted on top of each other. The series that is defined last will be rendered on top. You can change that by setting the **ZIndex** property of the series.

 #### __Figure 1: CombineMode None__
 ![RadChartView series with CombineMode Cluster](images/radchartview-features-combinemode-none.PNG)

 * __Cluster__: In this mode each series will be plotted independently of each other, so that they are not overlapping.

 #### __Figure 2: CombineMode Cluster__
 ![RadChartView series with CombineMode Cluster](images/radchartview-features-combinemode-cluster.PNG)
	
 * __Stack__: In this mode all series form stacks. The points of all series are placed on top of each other. The drawing of the next point will start from the value of the previous one. 

 #### __Figure 3: CombineMode Stack__
 ![RadChartView series with CombineMode Stack](images/radchartview-features-combinemode-stack.png)
	
 * __Stack100__: When this mode is set all series form stacks that occupy 100% of the plot area. It shows the combined contribution of values as percentages where the combined total for each category is 100 percent. It's good to use it when the relationship between values in a category is more significant than the amounts.

 #### __Figure 4: CombineMode Stack100__
 ![RadChartView series with CombineMode Stack100](images/radchartview-features-combinemode-stack100.png)

## Utilizing the StackGroupKey property

If the **CombineMode** property of the series is either **Stack** or **Stack100**, the **StackGroupKey** property of the series can be set in order to define in which stack group it will be included. **Example 2** demonstrates this property.

#### __[XAML] Example 2: Setting the StackGroupKey property__
	{{region xaml-radchartview-features-combinemode_1}}
		 <telerik:RadCartesianChart Palette="Windows8">
            <telerik:RadCartesianChart.HorizontalAxis>
                <telerik:CategoricalAxis />
            </telerik:RadCartesianChart.HorizontalAxis>
            <telerik:RadCartesianChart.VerticalAxis>
                <telerik:LinearAxis />
            </telerik:RadCartesianChart.VerticalAxis>
            <telerik:RadCartesianChart.Series>
                <telerik:BarSeries CombineMode="Stack"  StackGroupKey="FirstStackGroup">
                    <telerik:BarSeries.DataPoints>
                        <telerik:CategoricalDataPoint Category="January" Value="14" />
                        <telerik:CategoricalDataPoint Category="February" Value="10" />
                        <telerik:CategoricalDataPoint Category="March" Value="7" />
                        <telerik:CategoricalDataPoint Category="April" Value="15" />
                    </telerik:BarSeries.DataPoints>
                </telerik:BarSeries>
                <telerik:BarSeries CombineMode="Stack" StackGroupKey="FirstStackGroup">
                    <telerik:BarSeries.DataPoints>
                        <telerik:CategoricalDataPoint Category="January" Value="11" />
                        <telerik:CategoricalDataPoint Category="February" Value="15" />
                        <telerik:CategoricalDataPoint Category="March" Value="3" />
                        <telerik:CategoricalDataPoint Category="April" Value="10" />
                    </telerik:BarSeries.DataPoints>
                </telerik:BarSeries>
                <telerik:BarSeries CombineMode="Stack" StackGroupKey="SecondStackGroup" >
                    <telerik:BarSeries.DataPoints>
                        <telerik:CategoricalDataPoint Category="January" Value="8" />
                        <telerik:CategoricalDataPoint Category="February" Value="12" />
                        <telerik:CategoricalDataPoint Category="March" Value="19" />
                        <telerik:CategoricalDataPoint Category="April" Value="11" />
                    </telerik:BarSeries.DataPoints>
                </telerik:BarSeries>
            </telerik:RadCartesianChart.Series>
        </telerik:RadCartesianChart>
	{{endregion}}

#### __Figure 5: Result from Example 2__
![RadChartView series with CombineMode and StackGroupKey](images/radchartview-combinemode-stackgroupkey.png)

## See Also

 * [Getting Started]({%slug radchartview-introduction%})
 * [Data Binding]({%slug radchartview-series-databinding%}) 
