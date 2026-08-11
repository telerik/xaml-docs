---
title: Getting Started
page_title: Getting Started
description: Check our &quot;Getting Started&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-annotations-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

Both RadCartesianChart and RadPolarChart contain an __Annotations__ collection which holds all the annotations plotted against the chart.

>The RadChartView will visualize annotations only if it populated with data.        

## Adding Cartesian Annotations

When adding GridLine or PlotBand annotations to RadCartesianChart, you have to explicitly set their __Axis__ property to either the vertical or the horizontal axis. That way the annotation knows what its orientation is, and also, the exact coordinates on which it has to be rendered.

<snippet id='radchartview-features-annotations-getting-started-block_1-xaml' />


<snippet id='radchartview-features-annotations-getting-started-block_2-cs' />

<snippet id='radchartview-features-annotations-getting-started-block_2-vb' />


## Adding Polar Annotations

When adding GridLine or PlotBand annotations to RadPolarChart, you do not need to set their axis association as it is implicitly resolved by their respective type. For example, PolarAxisGridLineAnnotation is implicitly associated with the polar axis, while RadialAxisPlotBandAnnotation is implicitly associated with the radial axis.

<snippet id='radchartview-features-annotations-getting-started-block_3-xaml' />


<snippet id='radchartview-features-annotations-getting-started-block_4-cs' />

<snippet id='radchartview-features-annotations-getting-started-block_4-vb' />
