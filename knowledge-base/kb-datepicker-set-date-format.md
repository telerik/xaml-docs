---
title: Setting the Display Format of RadDatePicker's TextBox
description: How to change the date format used for the RadDatePicker's selected date.
components: ["datepicker"]
type: how-to
page_title: Customize the DateTime Format of the Selected Date in RadDatePicker 
slug: kb-datepicker-set-date-format
tags: raddatetimepicker, raddatepicker, wpf, date format, cultureinfo, datetimeformat
res_type: kb
ticketid: 1672177
---

## Environment

<table>
<tbody>
<tr>
<th scope="row">Product</th>
<td>RadDatePicker for WPF</td>
</tr>
<tr>
<th scope="row">Version</th>
<td>2024.3.821</td>
</tr>
</tbody>
</table>

## Description

How to change the default date-time format for the selected date in RadDatePicker.

## Solution

You can assign the `Culture` property of the RadDatePicker. This way you can use the `DateTimeFormat` of the `CultureInfo` object.


```C#
    var culture = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
    culture.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";
    this.radDatePicker.Culture = culture;
```

