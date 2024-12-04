---
title: Setting the Display Format of RadDatePicker's TextBox
description: How to change the date format used for the RadDatePicker's selected date.
type: how-to
page_title: Customize the DateTime Format of the Selected Date in RadDatePicker 
slug: kb-datepicker-set-date-format
tags: raddatepicker, wpf, date format, cultureinfo, datetimeformat
res_type: kb
ticketid: 1672177
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>RadDatePicker for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2024.3.821</td>
</tr>
</tbody>
</table>

## Description

How to change the default date-time format for the selected date in RadDatePicker.

## Solution

You can assign the `Culture` property of the RadDatePicker. This way you can use the `DateTimeFormat` of the `CultureInfo` object.

#### __[C#]__
{{region kb-datepicker-set-date-format-0}}
    var culture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
    culture.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";
    this.radDatePicker.Culture = culture;
{{endregion}}

