---
title: Chart Series Overview
page_title: Chart Series Overview
description: Chart Series Overview
slug: radchartview-series-chartseries
tags: chart,series,overview
published: True
position: 0
---

# Chart Series Overview



The data visualization in __RadChartView__ is done by a hierarchy of classes that inherit from the __ChartSeries__ class. Each series has a collection of data points, that is the view model of the data. A series may have its data populated directly through the __DataPoints__ property (unbound mode) or by data-binding to an arbitrary __IEnumerable__ instance through the __ItemsSource__ property. When a series is data-bound it will internally populate its DataPoints collection. A series may work either in bound or unbound mode, but not in both.
      

## 

Concrete series types are available for specific charts. For example, there is a set of __CartesianSeries__ applicable in the context of a __RadCartesianChart__. Here are all series available in the __RadChartView__ suite:
        
|CartesianCart|PolarChart|PieChart|
|-------------|----------|--------|
|**Line Series**<br/>[LineSeries]({%slug radchartview-series-lineseries%})<br/>[SplineSeries]({%slug radchartview-series-splineseries%})<br/>[StepLineSeries]({%slug radchartview-series-steplineseries%})<br/>[ScatterLineSeries]({%slug radchartview-series-scatterlineseries%})<br/>[ScatterSplineSeries]({%slug radchartview-series-scattersplineseries%})|**Line Series**<br/>[PolarLineSeries]({%slug radchartview-series-polarlineseries%})<br/>[RadarLineSeries]({%slug radchartview-series-radarlineseries%})|**Pie Series**<br/>[PieSeries]({%slug radchartview-series-pieseries%})|
|**Area Series**<br/>[AreaSeries]({%slug radchartview-series-areaseries%})<br/>[StepAreaSeries]({%slug radchartview-series-stepareaseries%})<br/>[SplineAreaSeries]({%slug radchartview-series-splineareaseries%})<br/>[ScatterAreaSeries]({%slug radchartview-series-scatterareaseries%})<br/>[ScatterSplineAreaSeries]({%slug radchartview-series-scattersplineareaseries%})|**Area Series**<br/>[PolarAreaSeries]({%slug radchartview-series-polarareaseries%})<br/>[RadarAreaSeries]({%slug radchartview-series-radarareaseries%})|**Doughnut Series**<br/>[DoughtnutSeries]({%slug radchartview-series-doughnutseries%})|
|**Point Series**<br/>[PointSeries]({%slug radchartview-series-point%})<br/>[ScatterPointSeries]({%slug radchartview-series-scatterpointseries%})|**Point Series**<br/>[PolarPointSeries]({%slug radchartview-series-polarpointseries%})<br/>[RadarPointSeries]({%slug radchartview-series-radarpointseries%})|
|**Financial Series**<br/>[OhlcSeries]({%slug radchartview-series-ohlcseries%})<br/>[CandlesticSeries]({%slug radchartview-series-candlestickseries%})|
|**Bar Series**<br/>[BarSeries]({%slug radchartview-series-barseries%})<br/>[RangeBarSeries]({%slug radchartview-series-rangebarseries%})|
