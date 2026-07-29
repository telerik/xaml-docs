---
title: Hide Zero Values Labels in PieChart
page_title: Remove Zero Values Labels in PieChart
description: This article described how to hide zero segments labels in PieChart.
slug: radchartview-troubleshooting-hide-zero-segments-labels
tags: troubleshooting,howto,zero,piechart,label,pieseries,slice,hide,remove,segments
published: True
position: 0
---

# Hide Zero Segments Labels in PieChart 

There are different ways to hide/remove the labels of the zero segments inside __PieChart__. This article will describe how to hide them by setting the __Opacity__ property of the TextBlock which holds the label. __Example 1__ demonstrate a basic scenario where the label of the zero segments will appear. 

__Example 1: Declaring PieSeries in XAML__
<snippet id='radchartview-howto-hide-zerro-values-pieseries-example_1_declaring_pieseries_in_xaml-xaml' />


![{{ site.framework_name }} RadChartView Pie Chart Default Zero Label](images/chartview-howto-pieseries-hide-zero-labels.png)

The next step is to bind the __Opacity__ property to the slice value and apply custom __IValueConverter__ class. In the __Convert()__ method you can get the current value. If the value is zero you can return 0 to hide the label.

__Example 2: Custom IValueConverter__
<snippet id='radchartview-howto-hide-zerro-values-pieseries-example_2_custom_ivalueconverter-xaml' />


__Example 3: Apply the IValueConverter to the Opacity property binding__
<snippet id='radchartview-howto-hide-zerro-values-pieseries-example_3_apply_the_ivalueconverter_to_the_opacity_property_binding-cs' />


![{{ site.framework_name }} RadChartView Pie Chart No Zero Label](images/chartview-howto-pieseries-hide-zero-no-labels.png)

The label is now hidden but the label connector is still visible. To remove the connector you can create a custom class which derives from PieSeries and override the GetLabelConnector() method (as demonstrated in [this article]({%slug radchartview-features-label-connectors%}))

__Example 4: Override the GetLabelConnector method of PieSeries__
<snippet id='radchartview-howto-hide-zerro-values-pieseries-example_4_override_the_getlabelconnector_method_of_pieseries-cs' />


Now you can just replace the PieSeries in __Example 3__  with your custom class.

__Example 5: Replace the PieSeries with the custom class__
<snippet id='radchartview-howto-hide-zerro-values-pieseries-example_5_replace_the_pieseries_with_the_custom_class-xaml' />


![{{ site.framework_name }} RadChartView Pie Chart No Zero Label or Connector](images/chartview-howto-pieseries-hide-zero-no-labels-no-connectors.png)

### See Also

* [Label Connectors]({%slug radchartview-features-label-connectors%})
* [PieSeries]({%slug radchartview-series-pieseries%})
* [DoughnutSeries]({%slug radchartview-series-doughnutseries%})