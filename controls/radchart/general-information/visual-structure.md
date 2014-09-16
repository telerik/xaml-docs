---
title: Visual Structure
page_title: Visual Structure
description: Visual Structure
slug: radchart-general-information-visual-structure
tags: visual,structure
publish: True
position: 1
---

# Visual Structure



This section defines terms and concepts used in the scope of __RadChart__ you have to get familiar with prior to continue reading this help.

## Default layout

The structure of the __RadChart__ control is based on three major elements: [ChartTitle]({%slug radchart-features-chart-title%}), [ChartArea]({%slug radchart-features-chart-area%}) and [ChartLegend]({%slug radchart-features-chart-legend%}). These elements are common for all chart types. The illustration below shows the default chart layout and the positions of the chart’s elements:




         
      ![](images/RadChart_GeneralInformation_VisualStructure_01.png)

## Chart Title

Usually the __ChartTitle__ is used to display a simple text about the chart displayed. However, as a __ContentControl__, you are able to customize the title and add whatever controls you need. [Read more]({%slug radchart-features-chart-title%})

## Chart Area

The __ChartArea__ is where your graphics is drawn. Unlike the __ChartTitle__, __ChartArea__ consists of other elements:




         
      ![](images/RadChart_GeneralInformation_VisualStructure_02.png)




         
      ![](images/RadChart_GeneralInformation_VisualStructure_03.png)

In most cases a chart area has the following structure:

* [X-Axis]({%slug radchart-features-axes-x-axis%}) and [Y-Axis]({%slug radchart-features-axes-y-axis%}) - except the Pie and Doughnut charts.

* __Axes titles__ - axes description text.

* [Horizontal and vertical strip lines]({%slug radchart-features-axes-striplines-and-gridlines%}) - for better readability.

* [Major grid lines]({%slug radchart-features-axes-striplines-and-gridlines%}) - grid lines for the major ticks.

* [Minor grid lines]({%slug radchart-features-axes-striplines-and-gridlines%}) - grid lines for the minor ticks. Valid for X-axis only.

## Chart Legend




         
      ![](images/RadChart_GeneralInformation_VisualStructure_04.png)

The __ChartLegend__ element contains a header, where explanation text is shown and a list of legend items - one for each data series displayed on a __ChartArea__ associated with the __ChartLegend__. [Read more]({%slug radchart-features-chart-legend%})

# See Also

 * [Key Features]({%slug radchart-overview-key-features%})

 * [Create Data Bound Chart]({%slug radchart-getting-started-create-data-bound-chart%})

 * [Create a Line Chart with Static Data]({%slug radchart-getting-started-create-a-line-chart-with-static-data%})
