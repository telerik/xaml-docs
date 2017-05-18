---
title: Series and Axes
page_title: Series and Axes
description: Series and Axes
slug: radchartview-series-and-axes
tags: series,and,axes
publish: True
position: 3
---

# Series and Axes

The RadChartView series works with different combinations of axes. The purpose of this topic is to make you familiar with the axes supported by each series. To learn more about series, refer to the [Chart Series]({%slug radchartview-series-chartseries%}) topic. 

If you use a combination of axes that is not supported by the specific series, the series data won't be displayed properly.

### RadCartesianChart Series

| Series | Horizontal Axis | Vertical Axis |
|---------|---------|---------|
| Area Series | CategoricalAxis, DateTimeCategoricalAxis, DateTimeContinuousAxis | LinearAxis, LogarithmicAxis |
| Bar Series | CategoricalAxis, DateTimeCategoricalAxis, DateTimeContinuousAxis | LinearAxis, LogarithmicAxis |
| Bubble Series | CategoricalAxis, DateTimeCategoricalAxis, DateTimeContinuousAxis | LinearAxis, LogarithmicAxis |
| CandleStick Series | CategoricalAxis, DateTimeCategoricalAxis, DateTimeContinuousAxis | LinearAxis, LogarithmicAxis |
| Line Series | CategoricalAxis, DateTimeCategoricalAxis, DateTimeContinuousAxis | LinearAxis, LogarithmicAxis |
| OHLC Series  | CategoricalAxis, DateTimeCategoricalAxis, DateTimeContinuousAxis | LinearAxis, LogarithmicAxis |
| Point Series  | CategoricalAxis, DateTimeCategoricalAxis, DateTimeContinuousAxis | LinearAxis, LogarithmicAxis |
| Range Bar Series  | CategoricalAxis, DateTimeCategoricalAxis, DateTimeContinuousAxis | LinearAxis, LogarithmicAxis |
| Range Series  | CategoricalAxis, DateTimeCategoricalAxis, DateTimeContinuousAxis | LinearAxis, LogarithmicAxis |
| Range Spline Series  | CategoricalAxis, DateTimeCategoricalAxis, DateTimeContinuousAxis | LinearAxis, LogarithmicAxis |
| Scatter Area Series | LinearAxis, LogarithmicAxis | LinearAxis, LogarithmicAxis |
| Scatter Bubble Series | LinearAxis, LogarithmicAxis | LinearAxis, LogarithmicAxis |
| Scatter Line Series | LinearAxis, LogarithmicAxis | LinearAxis, LogarithmicAxis |
| Scatter Point Series | LinearAxis, LogarithmicAxis | LinearAxis, LogarithmicAxis |
| Scatter Spline Area Series | LinearAxis, LogarithmicAxis | LinearAxis, LogarithmicAxis |
| Scatter Spline Series | LinearAxis, LogarithmicAxis | LinearAxis, LogarithmicAxis |
| Spline Area Series | CategoricalAxis, DateTimeCategorical Axis, DateTimeContinuousAxis | LinearAxis, LogarithmicAxis |
| Spline Series | CategoricalAxis, DateTimeCategoricalAxis, DateTimeContinuousAxis | LinearAxis, LogarithmicAxis |
| Step Area Series | CategoricalAxis, DateTimeCategoricalAxis, DateTimeContinuousAxis | LinearAxis, LogarithmicAxis |
| Step Line Series | CategoricalAxis, DateTimeCategoricalAxis, DateTimeContinuousAxis | LinearAxis, LogarithmicAxis |

> The axes used as Horizontal Axis and Vertical Axis could be switched. For example the AreaSeries works with two axes - one CategoricalAxis (or date time axes) and one LinearAxis (or logarithmic). In this case you can set the CategoricalAxis as a Horizontal Axis and the LinearAxis as Vertical Axis. Or you can switch them and set the Categorical Axis as a Vertical Axis and the LinearAxis as a Horizontal Axis.

### RadPolarChart Series

| Series | Radial Axis | Polar Axis |
|---------|---------|---------|
| Polar Area Series | Numeric Radial Axis | Polar Axis |
| Polar Line Series | Numeric Radial Axis | Polar Axis |
| Polar Point Series | Numeric Radial Axis | Polar Axis |
| Radar Area Series | Categorical Radial Axis | Polar Axis |
| Radar Line Series | Categorical Radial Axis | Polar Axis |
| Radar Point Series | Categorical Radial Axis | Polar Axis |

## See Also
* [Getting Started]({%slug radchartview-introduction%})
* [Chart Types]({%slug radchartview-chart-types%})
