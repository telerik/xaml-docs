---
title: Localization
page_title: Localization
description: Localization
slug: chart-localization
tags: localization
publish: True
position: 6
site_name: Silverlight
---

# Localization



The built-in localization mechanism in Silverlight and WPF allows you to localize any string resource exposed by the standard __RadChart__ control. Once translated, you might use your resources in both Silverlight and WPF projects without changing anything.

>tip__To learn more about the ways in which to localize the RadControls please read the common topic about__[Localization](http://www.telerik.com/help/silverlight/common-localization.html)__.__

## Resource Keys

__RadChart__ is a complex user interface control and its strings for localization are numerous. In order to be able to distinguish these resources, an unique identifier, called __resource key__, is assigned to each localizable string.

>

Note that the resource keys exposed by the __RadChart__ control are used with values, that can be specified via the control and its properties. For example, the __ChartChartTitle__ value is applied to the title of the __RadChart__, which can be set through the __DefaultView__ of the __RadChart__. 

These resources are created for your facilitation and you can use them when you have a single __RadChart__ in your application.

When you have two controls of this type they will get localized using the one and the same resource file, as the __LocalizationManager__ localizes all of the __RadControls__ in an application. In this case you are unable to specify a specific resource file for each of the charts, so you have to do the localization manually, without the __LocalizationManager__.

Here is a list of all of the __Resources__ available and their default values:

>

For the empty fields there are no default values.


<table> <tr>KeyValue</tr><tr><td>ChartAxisLabelDateTimeFormat</td><td>dddd, dd MMMM yyyy</td></tr><tr><td>ChartAxisLabelFromat</td><td></td></tr><tr><td>ChartChartLegendHeader</td><td>Legend</td></tr><tr><td>ChartChartLegendLinearSeriesFormat</td><td>Series {0}</td></tr><tr><td>ChartChartLegendRadialSeriesFormat</td><td>Item {0}</td></tr><tr><td>ChartChartTitle</td><td></td></tr><tr><td>ChartHorizontalAxisTitle</td><td></td></tr><tr><td>ChartItemLabelFormat</td><td></td></tr><tr><td>ChartItemToolTipFormat</td><td></td></tr><tr><td>ChartNoDataMessage</td><td>No Data Series.</td></tr><tr><td>ChartRangeItemToolTipFormat</td><td>High: {0}{2}Low: {1}</td></tr><tr><td>ChartStickItemToolTipFormat</td><td>High: {0}{4}Low: {1}{4}Open: {2}{4}Close: {3}</td></tr><tr><td>ChartVerticalAxisTitle</td><td></td></tr></table>
