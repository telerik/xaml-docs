---
title: Displaying Underscores in Named Ranges in WPF Spreadsheet
description: Avoid the removal of underscores from named ranges in the WPF Spreadsheet control.
type: how-to
page_title: How to Display Underscores in Named Ranges in WPF Spreadsheet
meta_title: Display Underscores in Named Ranges in WPF Spreadsheet
slug: kb-spreadsheet-display-underscores-named-ranges
tags: wpf, spreadsheet, named-ranges, underscore, radmenuitem, accesstext
res_type: kb
ticketid: 1713569
---

## Environment

<table>
<tbody>
<tr>
<td>Product</td>
<td>Spreadsheet for UI for WPF</td>
</tr>
<tr>
<td>Version</td>
<td>2026.1.415</td>
</tr>
</tbody>
</table>

## Description

When using named ranges containing underscores `_` in the [Spreadsheet](https://docs.telerik.com/devtools/wpf/controls/radspreadsheet/overview) control in UI for WPF, the underscores are removed. 

This happens because the `RadMenuItem` element displaying the named ranges automatically enables the WPF access text feature, which interprets underscores as access keys.

## Solution

To display the underscores properly, override the `Header` property of the `RadMenuItem` elements using a global `Loaded` event handler. This disables the access text feature by replacing the text content with a `TextBlock` element. 

```csharp
static MainWindow()
{
    EventManager.RegisterClassHandler(typeof(RadMenuItem), RadMenuItem.LoadedEvent, new RoutedEventHandler(OnMenuItemLoaded));
}

private static void OnMenuItemLoaded(object sender, RoutedEventArgs e)
{
    var menuItem = (RadMenuItem)sender;
    if (menuItem.DataContext is DefinedName context)
    {
        // Use TextBlock to properly display underscores
        menuItem.Header = new TextBlock() { Text = context.Name };
    }
}
```

## See Also

- [Spreadsheet Overview](https://docs.telerik.com/devtools/wpf/controls/radspreadsheet/overview)
- [RadMenuItem Documentation](https://docs.telerik.com/devtools/wpf/controls/radmenu/overview)
- [AccessText Class](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.accesstext?view=windowsdesktop-10.0)
