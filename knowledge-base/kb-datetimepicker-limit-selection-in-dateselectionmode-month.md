---
title: Limit selection when DateSelectionMode="Month"
description: Disable selection in Month DateSelectionMode.
type: how-to
page_title: Prevent certain months from being selected
slug: kb-datetimepicker-limit-selection-in-dateselectionmode-month
position: 0
tags: limit, selection, dateselectionmode, month
ticketid: 1425924
res_type: kb
---

## Environment
<table>
    <tbody>
	    <tr>
	    	<td>Product</td>
	    	<td>RadDateTimePicker for WPF</td>
	    </tr>
    </tbody>
</table>


## Description

How to limit selection when the DateSelectionMode property is Month.

## Solution

Create a custom StyleSelector and disable the months by setting the __IsEnabled__ property of the __CalendarButtonContent__. After that, set the StyleSelector to the __MonthButtonStyleSelector__ property of the RadDateTimePicker.


```C#

    public class MonthSelector : StyleSelector
    {
        public override Style SelectStyle(object item, DependencyObject container)
        {
            CalendarButtonContent content = item as CalendarButtonContent;
            if (content != null)
            {
                var monthsToEnable = new List<string>() { "Mar", "Jun", "Sep", "Dec" };
                if (!monthsToEnable.Contains(content.Text))
                {
                    content.IsEnabled = false;
                }
            }
            return base.SelectStyle(item, container);
        }       
    }
```


```XAML

    <Grid>
        <Grid.Resources>
            <local:MonthSelector x:Key="monthSelector"/>
        </Grid.Resources>
        <telerik:RadCalendar DateSelectionMode="Month"
                             MonthButtonStyle="{x:Null}"
                             MonthButtonStyleSelector="{StaticResource monthSelector}"/>
    </Grid>
```