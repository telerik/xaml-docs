---
title: Combine Mode
page_title: Combine Mode
description: Check our &quot;Combine Mode&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-features-combinemode
tags: series, combinemode, barseries
published: True
position: 9
---

# Combine Mode

Categorical series in RadChartView have a mechanism which can be used for combining data points that reside in different series but have the same category. This mechanism can be triggered by setting the __CombineMode__ property of the series. It is an enumeration and it allows the following values: __None, Cluster, Stack, Stack100__.

>tip Categorical series which supports this mechanism are: __AreaSeries, BarSeries, LineSeries, PointSeries, RangeBarSeries, BoxPlotSeries__. RangeBarSeries and BoxPlotSeries support only None and Cluster modes.

__Example 1: Setting the CombineMode property__
<snippet id='radchartview-features-combinemode-example_1_setting_the_combinemode_property-xaml' />


<!-- -->

 * __None__: In this mode each series will be plotted on top of each other. The series that is defined last will be rendered on top. You can change that by setting the **ZIndex** property of the series.

	#### __Figure 1: CombineMode None__  	 
	![Telerik UI for WPF RadChartView Series with CombineMode None Overlapping in One Plot Area](images/radchartview-features-combinemode-none.PNG)

 * __Cluster__: In this mode each series will be plotted independently of each other, so that they are not overlapping.

	#### __Figure 2: CombineMode Cluster__  
	![Telerik UI for WPF RadChartView Series with CombineMode Cluster Displayed Side by Side](images/radchartview-features-combinemode-cluster.PNG)
	
 * __Stack__: In this mode all series form stacks. The points of all series are placed on top of each other. The drawing of the next point will start from the value of the previous one. 

	#### __Figure 3: CombineMode Stack__  
	![Telerik UI for WPF RadChartView Series with CombineMode Stack](images/radchartview-features-combinemode-stack.png)
	
 * __Stack100__: When this mode is set all series form stacks that occupy 100% of the plot area. It shows the combined contribution of values as percentages where the combined total for each category is 100 percent. It's good to use it when the relationship between values in a category is more significant than the amounts.

	#### __Figure 4: CombineMode Stack100__  
	![Telerik UI for WPF RadChartView Series with CombineMode Stack100 Showing Percentage Contributions](images/radchartview-features-combinemode-stack100.png)

## Utilizing the StackGroupKey Property

If the **CombineMode** property of the series is either **Stack** or **Stack100**, the **StackGroupKey** property of the series can be set in order to define in which stack group it will be included. **Example 2** demonstrates this property.

__Example 2: Setting the StackGroupKey property__
<snippet id='radchartview-features-combinemode-example_2_setting_the_stackgroupkey_property-xaml' />


#### __Figure 5: Result from Example 2__
![Telerik UI for WPF RadChartView Series Grouped into Separate Stacks with StackGroupKey](images/radchartview-combinemode-stackgroupkey.png)

## Stacking Mixed Values in the Same Stack

By default when you have mixed values (negative and positive) in the same category, those will be added in separate value stacks. This means that all positive values will be combined into one stack and all negative values into another stack.

To change this behavior and use a single stack for all values, set the __ChartViewExtensions.StackNegativeValuesSeparately__ attached property to __False__. The property is applied to the RadCartesianChart control.

__Example 3: Setting the ChartViewExtensions.StackNegativeValuesSeparately property__
<snippet id='radchartview-features-combinemode-example_3_setting_the_chartviewextensions_stacknegativevaluesseparately_property-xaml' />


> The "chartView" namespace refers to the following - `xmlns:chartView="clr-namespace:Telerik.Windows.Controls.ChartView;assembly=Telerik.Windows.Controls.Chart"`

#### __Figure 5: Comparison between the stack modes__
![Telerik UI for WPF RadChartView Comparing Separate and Combined Stacks for Positive and Negative Values](images/radchartview-features-combinemode-stacknegativevaluesseparately.png)

## See Also

 * [Getting Started]({%slug radchartview-introduction%})
 * [Data Binding]({%slug radchartview-series-databinding%}) 
