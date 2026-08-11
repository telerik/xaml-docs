---
title: Custom Smart Label Strategy
page_title: Custom Smart Label Strategy
description: Check our &quot;Custom Smart Label Strategy&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-labels-custom-smart-labels-strategy
tags: custom, smart,labels, strategy, chartsmartlabelsstrategy, chartsmartlabelsstrategybase
published: True
position: 3
---

# Custom Smart Label Strategy

The chart's smart labels feature tries to positions the labels of the data points in such a way that they do not overlap one another. To customize this behavior and implement custom smart labels startegy you can use create a class that derives from __ChartSmartLabelsStrategyBase__ and override its __CalculateLabelsPositions__ method.

__Example 1: Defininig custom smart label strategy class__
<snippet id='radchartview-features-labels-custom-smart-labels-strategy-example_1_defininig_custom_smart_label_strategy_class-cs' />


## Creating Custom Smart Label Strategy

This section will walk you through the creation of a custom smart label strategy. First, we will specify the following view models which are going to be used to populate the chart control.

__Example 1: Defining view models__
<snippet id='radchartview-features-labels-custom-smart-labels-strategy-example_1_defining_view_models-cs' />


Next, we can go ahead and define the chart. For the purpose of this example we will specify a __LineSeries__ and add label connectors. Then we can definea a custom label template, so it is more clear where the labels are positioned.

>important In order to visualize the connections between the labels and the corresponding data points, you can take advantage of the __LabelConnectorsSettings__ property of the chart series. 

__Example 2: Defining RadCartesianChart in XAML__
<snippet id='radchartview-features-labels-custom-smart-labels-strategy-example_2_defining_radcartesianchart_in_xaml-xaml' />


To populate the chart we need to set the DataContext of the user control that hosts it.

__Example 3: Defining RadCartesianChart in XAML__
<snippet id='radchartview-features-labels-custom-smart-labels-strategy-example_3_defining_radcartesianchart_in_xaml-xaml' />


If you run the application now, you should get a structure like in **Figure 1**. 

#### Figure 1: Labels without Custom Smart Label Strategy
![Telerik UI for WPF RadChartView Line Series with Overlapping Default Labels](images/radchartview-labels-custom-smart-labels-strategy_1.png)

Looking at the Figure 1 you can easily observe that some of the labes are overlapped and it is not clear enough which label for which data point corresponds. To change the position of the label we can create custom label strategy. To do that we will need to create a custom class which inherits ChartSmartLabelsStrategyBase. You can use this class to control the positioning of the labels. The arranging of the labels is happening in the CalculateLabelsPositions() method. 

__Example 4: Creating custom ChartSmartLabelsStrategyBase__
<snippet id='radchartview-features-labels-custom-smart-labels-strategy-example_4_creating_custom_chartsmartlabelsstrategybase-cs' />


To apply the custom smart strategy to the chart, set the SmartLabelsStrategy property.

__Example 4: Setting the CustomSmartLabelStrategy__
<snippet id='radchartview-features-labels-custom-smart-labels-strategy-example_4_setting_the_customsmartlabelstrategy-cs' />



#### Figure 1: Labels with Custom Smart Label Strategy
![Telerik UI for WPF RadChartView Line Series with Labels Repositioned by a Custom Smart Label Strategy](images/radchartview-labels-custom-smart-labels-strategy_2.png)

## See Also  
* [GettingStarted]({%slug radchartview-introduction%})
* [LineSeries]({%slug radchartview-series-lineseries%})
* [Smart Labels]({%slug radchartview-features-smart-labels%})
* [Label Definition]({%slug radchartview-features-label-definition%})
