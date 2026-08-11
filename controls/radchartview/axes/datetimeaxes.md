---
title: Date Time Axes
page_title: Date Time Axes
description: Check our &quot;Date Time Axes&quot; documentation article for the RadChartView {{ site.framework_name }} control.
slug: radchartview-axes-datetimeaxes
tags: date,time,axes
published: True
position: 2
---

# Date Time Axes

__RadChartView__ has two DateTime dedicated axes. The first one is __DateTimeCategoricalAxis__, the other is __DateTimeContinuousAxis__. These axes are different in nature as one is categorical (discrete), and the other is continuous. This topic will cover the specific properties of these two axes.

## Date Time Continuous Axis

The __DateTimeContinuousAxis__ is like a numerical axis but the axis value range consists of DateTime values which are always sorted chronologically. This axis expects each data point to provide a System.DateTime structure as its value for this axis. It does not work with categories, it works with ranges. The base unit (or the timeline step) of the axis is calculated depending on the smallest difference between any two dates.

### Specific Properties

* __ActualRange__: A property of type __ValueRange<DateTime>__ that gets the actual range used by the axis to plot data points.
* __ActualVisibleRange__: A property of type __ValueRange<DateTime>__ that gets the range that is actually visible on the plot area when the chart is zoomed in.
* __GapLength__: A property of type __double__  that gets or sets the gap (in the range [0, 1]) to be applied when calculating each plotted Telerik.Windows.Controls.ChartView.ChartSeries position. More information regarding this property can be found in the [Gap Length]({%slug radchartview-axes-gap-length%}) help article.
* __MajorStep__: A property of type __double__  that gets or sets  the user-defined step between two adjacent ticks on the axis. Specify TimeSpan.Zero to clear the value. If not specified, the step will be automatically determined, depending on the smallest difference between any two dates.
* __MajorStepUnit__: A property of type __TimeInterval__ that gets or sets the unit that defines the custom major step of the axis. If no explicit step is defined, the axis will automatically calculate one, depending on the smallest difference between any two dates.
* __Maximum__: A property of type __DateTime__ that gets or sets the maximum date of the axis
* __MaximumTicks__: An __Integer__ property that gets or sets the maximum ticks that might be displayed on the axis.
* __Minimum__: A property of type __DateTime__ that gets or sets the minimum date of the axis.
* __PlotMode__: A property of type __AxisPlotMode__ that gets or sets the mode which determines how points are plotted by this axis. The plot mode is an enumeration and it allows the following values: __BetweenTicks__, __OnTicks__, and __OnTicksPadded__.
* __TickOrigin__: A nullable property of type __DateTime__ that gets or sets from which point the ticks will start drawing. The position of the ticks is determined based on the combination of the __MajorStep__ and __TickOrigin__ values. 


Here is an example XAML snippet that demonstrates how to create chart with horizontal date time continuous axis:
        
__Example 1: Setting DateTimeContinuousAxis__

<snippet id='radchartview-axes-datetimeaxes-example_1_setting_datetimecontinuousaxis-xaml' />


Below is the binding logic:        

__Example 2: Setting the binding in code behind__

<snippet id='radchartview-axes-datetimeaxes-example_2_setting_the_binding_in_code_behind-cs' />

<snippet id='radchartview-axes-datetimeaxes-example_2_setting_the_binding_in_code_behind-vb' />


And finally the definition of the ChartDataObject class:

__Example 3: Creating the businesses object__

<snippet id='radchartview-axes-datetimeaxes-example_3_creating_the_businesses_object-cs' />

<snippet id='radchartview-axes-datetimeaxes-example_3_creating_the_businesses_object-vb' />


![Telerik UI for WPF RadChartView with a Horizontal DateTime Continuous Axis](images/radchartview-chart_datetime_continuous_axis.png)

## Date Time Categorical Axis

The DateTime categorical axis is a categorical axis with Date-Time values which are sorted chronologically and is represented by the DateTimeCategoricalAxis class. It also allows definition of categories based on specific date time components. For example if such an axis displays a range of one year, the data points can be plotted in categories for each month. If the range is one month, the values may be categorized by day and so on. 
 
### Specific Properties

* __DateTimeComponent__: A property of type __DateTimeComponent__ that gets or sets how data points will be grouped. The DateTime component property is an enumeration and it allows the following values: __Ticks, Year, Quarter, Month, Week, Hour, Minute, Second, Millisecond, Date, TimeOfDay, Day, DayOfWeek, DayOfYear.__

__Example 4: Setting the DateTimeCategoricalAxis axes__

<snippet id='radchartview-axes-datetimeaxes-example_4_setting_the_datetimecategoricalaxis_axes-xaml' />


![Telerik UI for WPF RadChartView with a Horizontal DateTime Categorical Axis](images/radchartview-chart_datetime_categorical_axis.png)

### See also

* [Axis]({%slug radchartview-axes-axis%})
* [Categorical Axis]({%slug radchartview-axes-categoricalaxis%})
