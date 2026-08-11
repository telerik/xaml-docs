---
title: Axis Title
page_title: Axis Title
description: This article outlines the axis title customization abilities in the RadChartView suite.
slug: radchartview-axes-title
tags: axis,title
published: True
position: 4
---

# Axis Title

The chart axes allows you to display a title aligned next to the axis line.

To show the title, set the `Title` property of the axis element (`LinearAxis`, `CategoricalAxis`, etc.).

__Setting the axis title to a string value__
<snippet id='radchartview-axes-title-setting_the_axis_title_to_a_string_value-xaml' />


![RadCartesianChart with axis Title assigned to a string value](images/radchartview-axes-title-0.png)

__Setting the axis title to a visual element__
<snippet id='radchartview-axes-title-setting_the_axis_title_to_a_visual_element-xaml' />


![RadCartesianChart with axis Title assigned to visual elements](images/radchartview-axes-title-1.png)

The axis can be customized also through the `TitleTemplate` property. 

__Setting Axis TitleTemplate__
<snippet id='radchartview-axes-title-setting_axis_titletemplate-xaml' />


The data context in the `DataTemplate` will be the value of the `Title` property.

![RadCartesianChart with set TitleTemplate for its axes](images/radchartview-axes-title-1.png)

## See Also
* [Getting Started]({%slug radchartview-introduction%})
* [Events]({%slug radchartview-events%})
* [Create Data-Bound Chart]({%slug radchartview-series-databinding%})
