---
title: What happens when you have more than 200 items?
page_title: What happens when you have more than 200 items?
description: What happens when you have more than 200 items?
slug: radchart-tips-and-tricks-what happens when-the-datacontext-is-large-axis
tags: what,happens,when,you,have,more,than,200,items?
published: True
position: 1
---

# What happens when you have more than 200 items?

In a scenario with big number of items (UIElements) the performance of the application might get down. In this case you can use the sampling feature of the chart. In general, sampling is combining several data items into a single object with a value based on a specific function - as sum, average, minimum, etc. You can learn more about the feature in the [Sampling]({%slug radchart-features-sampling%}) help article.

By default the sampling feature uses a function that calculates an average value for the XValue and YValue. You can chose another aggregate function instead -  First, Last, Min, Max and others, and of course implement custom logic with your own function (as explained in the Sampling topic).

The main side effect is that the series items will no longer represent a single value. The same goes for their corresponding their labels. 

For the XCategory an average value can not be calculated correctly (by definition) as XCategory can be any type of object (like string, and it is not clear what is the average of two strings). That's why it is necessary to implement a custom sampling function for the XCategory. If no such function is provided, the result will be the following, depending on the type of the proprty mapped to the XCategory:

* Numeric (int, double, ...): The average value is calculated.
* String: The XCategory is filled with the numbers from 1 to the value of SamplingTreshold
* DateTime: The first date in the calendar (30 December 1899)
* Other types: Same as string

## See Also

* [Getting Started]({%slug radchart-getting-started-create-a-line-chart-with-static-data%})
* [Sampling]({%slug radchart-features-sampling%})
* [Performance tips and tricks]({%slug radchart-performance-tips-and-tricks%})


