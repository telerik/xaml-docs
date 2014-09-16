---
title: Chart Series Overview
page_title: Chart Series Overview
description: Chart Series Overview
slug: radchartview-series-chartseries
tags: chart,series,overview
publish: True
position: 0
---

# Chart Series Overview



The data visualization in __RadChartView__ is done by a hierarchy of classes that inherit from the __ChartSeries__ class. Each series has a collection of data points, that is the view model of the data. A series may have its data populated directly through the __DataPoints__ property (unbound mode) or by data-binding to an arbitrary __IEnumerable__ instance through the __ItemsSource__ property. When a series is data-bound it will internally populate its DataPoints collection. A series may work either in bound or unbound mode, but not in both.
      

## 

Concrete series types are available for specific charts. For example, there is a set of __CartesianSeries__ applicable in the context of a __RadCartesianChart__. Here are all series available in the __RadChartView__ suite:
        
<table><th><tr><td>

CartesianCart</td><td>

PolarChart</td><td>

PieChart</td></tr></th><tr><td>

* Line Series

* [LineSeries]({%slug radchartview-series-lineseries%})

* [SplineSeries]({%slug radchartview-series-splineseries%})

* [StepLineSeries]({%slug radchartview-series-steplineseries%})

* [ScatterLineSeries]({%slug radchartview-series-scatterlineseries%})

* [ScatterSplineSeries]({%slug radchartview-series-scattersplineseries%})</td><td>

* Line Series

* [PolarLineSeries]({%slug radchartview-series-polarlineseries%})

* [RadarLineSeries]({%slug radchartview-series-radarlineseries%})</td><td>

* Pie Series

* [PieSeries]({%slug radchartview-series-pieseries%})</td></tr><tr><td>

* Area Series

* [AreaSeries]({%slug radchartview-series-areaseries%})

* [StepAreaSeries]({%slug radchartview-series-stepareaseries%})

* [SplineAreaSeries]({%slug radchartview-series-splineareaseries%})

* [ScatterAreaSeries]({%slug radchartview-series-scatterareaseries%})

* [ScatterSplineAreaSeries]({%slug radchartview-series-scattersplineareaseries%})</td><td>

* Area Series

* [PolarAreaSeries]({%slug radchartview-series-polarareaseries%})

* [RadarAreaSeries]({%slug radchartview-series-radarareaseries%})</td><td>

* Doughnut Series

* [DoughtnutSeries]({%slug radchartview-series-doughnutseries%})</td></tr><tr><td>

* Point Series

* [PointSeries]({%slug radchartview-series-point%})

* [ScatterPointSeries]({%slug radchartview-series-scatterpointseries%})</td><td>

* Point Series

* [PolarPointSeries]({%slug radchartview-series-polarpointseries%})

* [RadarPointSeries]({%slug radchartview-series-radarpointseries%})</td><td></td></tr><tr><td>

* Financial Series

* [OhlcSeries]({%slug radchartview-series-ohlcseries%})

* [CandlesticSeries]({%slug radchartview-series-candlestickseries%})</td><td></td><td></td></tr><tr><td>

* Bar Series

* [BarSeries]({%slug radchartview-series-barseries%})

* [RangeBarSeries]({%slug radchartview-series-rangebarseries%})</td><td></td><td></td></tr></table>
