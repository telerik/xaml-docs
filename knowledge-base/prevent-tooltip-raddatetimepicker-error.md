---
title: Preventing Tooltip Display for Error Content in RadDateTimePicker
description: Learn how to prevent the tooltip of the RadDateTimePicker control in WPF from showing when its content equals "Error".
type: how-to
page_title: Avoid Tooltip Display for RadDateTimePicker Error Content
meta_title: Avoid Tooltip Display for RadDateTimePicker Error Content
slug: prevent-tooltip-raddatetimepicker-error
tags: raddatetimepicker, wpf, tooltip, error, isparsingsuccessful, istooltipopen
res_type: kb
ticketid: 1691793
---

## Environment

<table>
<tbody>
<tr>
<td> Product </td>
<td> RadDateTimePicker for WPF </td>
</tr>
<tr>
<td> Version </td>
<td> 2025.2.521 </td>
</tr>
</tbody>
</table>

## Description

I want to prevent the tooltip of the [RadDateTimePicker](https://docs.telerik.com/devtools/wpf/controls/raddatetimepicker/overview) control from showing when its content is set to Error.

## Solution

To achieve this behavior, subscribe to the `ParseDateTimeValue` event of the RadDateTimePicker control. Check the `IsParsingSuccessful` property of the event arguments, and if it is false, set the `IsTooltipOpen` property of the control to false. Use the `Dispatcher.BeginInvoke` method to delay this logic.

Follow these steps:

1. Subscribe to the `ParseDateTimeValue` event of RadDateTimePicker.
2. Implement the logic to check `IsParsingSuccessful` in the event handler.
3. If `IsParsingSuccessful` is false, use `Dispatcher.BeginInvoke` to set `IsTooltipOpen` to false.

Example implementation:

```csharp
private void RadDateTimePicker_ParseDateTimeValue(object sender, ParseDateTimeEventArgs args)
{
    if (!args.IsParsingSuccessful)
    {
        Dispatcher.BeginInvoke(new Action(() =>
        {
            this.dateTimePicker.IsTooltipOpen = false;
        }));
    }
}
```

Attach the event handler to your RadDateTimePicker instance:

```csharp
this.dateTimePicker.ParseDateTimeValue += RadDateTimePicker_ParseDateTimeValue;
```

This approach prevents the tooltip from displaying when parsing the input fails.
