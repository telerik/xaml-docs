---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radcalendar-getting-started
tags: getting,started
published: True
position: 1
---

# Getting Started

This tutorial will walk you through the creation of a sample application that contains a __RadCalendar__. 

* [Assembly References](#assembly-references)
* [Adding RadCalendar to the Project](#adding-radcalendar-to-the-project)
* [Changing the number of shown months](#changing-the-number-of-shown-months)
* [Hide Week Numbers and Weekdays](#hide-week-numbers-and-weekdays)

## Assembly References

In order to use the __RadCalendar__ control in your projects, you have to add references to the following assemblies:			

* __Telerik.Windows.Controls__
* __Telerik.Windows.Controls.Input__

## Adding RadCalendar to the Project

**Example 1** demonstrates how you can add a RadCalendar in xaml.

#### __[XAML] Example 1: RadCalendar definition__
{{region xaml-radcalendar-getting-started_0}}
	<telerik:RadCalendar VerticalAlignment="Center" HorizontalAlignment="Center"  />
{{endregion}}

#### __Figure 1: Result from Example 1 in the Office2016 Theme__
![RadCalendar Getting Started](images/RadCalendar_GettingStarted.png)

## Changing the number of shown months

You can control how many months are shown by setting the **Columns** property of the RadCalendar. Its default value is **one** and the maximum is **four**. **Example 2** demonstrates how you can achieve that.

#### __[XAML] Example 2: RadCalendar showing four months__
{{region xaml-radcalendar-getting-started_1}}
	<telerik:RadCalendar VerticalAlignment="Center" HorizontalAlignment="Center" Columns="4" ViewsHeaderVisibility="Visible"/>
{{endregion}}

#### __Figure 2: Result from Example 2 in the Office2016 Theme__
![RadCalendar with four months](images/RadCalendar_Columns.png)

## Hide Week Numbers and Weekdays

You have the option to hide the week numbers, as well as the weekdays. This can be done by setting the **AreWeekNumbersVisible** and **AreWeekNamesVisible** properties to **False**. **Example 3** demonstrates this:

#### __[XAML] Example 3: RadCalendar without week numbers and weekdays__
{{region xaml-radcalendar-getting-started_2}}
	<telerik:RadCalendar VerticalAlignment="Center" HorizontalAlignment="Center" AreWeekNumbersVisible="False" AreWeekNamesVisible="False" />
{{endregion}}

#### __Figure 3: Result from Example 3 in the Office2016 Theme__
![RadCalendar without week numbers and weekdays](images/RadCalendar_HideWeekNumbersAndDays.png)

## See Also

* [Calendar Basics]({%slug radcalendar-basics%})
* [Key Properties]({%slug radcalendar-key-properties%})
* [Globalization]({%slug radcalendar-globalization%})
* [How to Customize the Calendar Buttons]({%slug radcalendar-styling-and-appearance-daybuttonstyleselector%})