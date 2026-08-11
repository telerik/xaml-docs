---
title: Alternating Rows
page_title: Alternating Rows
description: Get started with Telerik's {{ site.framework_name }} DataGrid and learn how to improve the readability by having alternating rows.
slug: radgridview-rows-alternating-rows
tags: alternating,rows
published: True
position: 3
---

# Alternating Rows

__RadGridView__ allows you to have alternating rows should you need to improve readability. 

In order to define the pattern of alternation, you have to set the __AlternationCount__ property. For example, if you want to alternate each second row, you have to set its value to __2__. Setting the __AlternationCount__ property to __3__ shows an alternating color for each third row.

__Example 1: Setting the AlternationCount Property__

<snippet id='radgridview-rows-alternating-rows-example_1_setting_the_alternationcount_property-xaml' />


![Telerik UI for {{ site.framework_name }} RadGridView with AlternationCount set to display alternating row styling every second row](images/RadGridView_Rows_Alternating_Rows_02.png)

In order to style the alternating rows, you can specify the __AlternateRowStyle__ and/or the __AlternateRowBackground__ properties. If you do not specify an AlternateRowBackground a default color will be picked, based on the current theme.

>tip To learn more about styling the rows and the alternating rows you can read [the following article]({%slug gridview-styling-a-row%}).

__Example 2__ shows __RadGridView__ with __AlternationCount__ set to __2__ and __AlternateRowBackground__ color set to __Coral__.

__Example 2: Setting the AlternateRowBackground Property__
<snippet id='radgridview-rows-alternating-rows-example_2_setting_the_alternaterowbackground_property-xaml' />


![Telerik UI for {{ site.framework_name }} RadGridView with AlternateRowBackground set to Coral for alternating rows](images/RadGridView_Rows_Alternating_Rows_01.png)

## See Also

* [Grid Rows - Overview]({%slug gridview-rows-overview%})
* [Customizing Rows]({%slug gridview-customizing-rows%})
{% if site.framework_name == 'WPF' %}* [Selected Row Background]({%slug radgridview-rows-selected-background%}){% endif %}
