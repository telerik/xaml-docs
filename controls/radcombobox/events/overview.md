---
title: Overview
page_title: Events Overview
description: Learn how to handle RadComboBox events, subscribe in XAML or code-behind, and reset the drop-down scroll position in multiple-selection scenarios.
components: ["combobox"]
slug: radcombobox-events-overview
tags: overview
published: True
position: 0
---

# Events Overview

Use `RadComboBox` events in Progress® Telerik® UI for WPF to react when the drop-down opens, closes, or the selection changes. This article shows how to subscribe to common events and use `DropDownOpened` to request a scroll reset when the list opens.

## Subscribing to Events

Subscribe to a `RadComboBox` event in XAML or in code-behind.

**Example 1: Subscribe to an event in XAML**

<snippet id='radcombobox-events-overview-example_1_subscribing_to_an_event_in_xaml-xaml' />

**Example 2: Subscribe to an event in code-behind**

<snippet id='radcombobox-events-overview-example_2_subscribing_to_an_event_in_code-cs' />

## Events

Start with the following events when you customize `RadComboBox` behavior:

### DropDownOpened

Use `DropDownOpened` when you need to change the drop-down state after the popup becomes visible. Typical scenarios include loading data on demand, focusing an element in the popup, or resetting the scroll position.

**Example 3: Handle the `DropDownOpened` event**

<snippet id='radcombobox-events-overview-example_3_dropdownopened_event_handler-cs' />

### DropDownClosed

Use `DropDownClosed` when you need to react after the user dismisses the drop-down. This event is useful when you want to commit UI changes or trigger cleanup logic after the popup closes.

**Example 4: Handle the `DropDownClosed` event**

<snippet id='radcombobox-events-overview-example_4_dropdownclosed_event_handler-cs' />

### SelectionChanged

Use `SelectionChanged` when you need to inspect the selected and unselected items. The `SelectionChangedEventArgs` type exposes the `AddedItems` and `RemovedItems` collections.

**Example 5: Handle the `SelectionChanged` event**

<snippet id='radcombobox-events-overview-example_5_selectionchanged_event_handler-cs' />

>note `SelectionChanged` is inherited from the [`Selector` class](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.primitives.selector?view=windowsdesktop-9.0).

## Resetting the Drop-Down Scroll Position on Open

To request that the drop-down scroll to the top when it opens, handle `DropDownOpened` and call `ScrollToTop()` on its `ScrollViewer`. The following example uses `AllowMultipleSelection="True"`.

>important This example depends on the control template. The lookup assumes a `Popup` is a visual descendant of `RadComboBox` and contains a `ScrollViewer` under `Popup.Child`. If your template differs, adapt the lookup to its structure.

To request a scroll reset when the list opens:

1. Subscribe to the `DropDownOpened` event.
2. Find the `ScrollViewer` inside the popup after the drop-down opens.
3. Call `ScrollToTop()` on that `ScrollViewer`.

These fragments assume a populated `RadComboBox` in a WPF window configured as described in [Getting Started]({%slug radcombobox-getting-started%}). Declare `xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"` on the window and place the control in its layout.

**Example 6: Subscribe to `DropDownOpened` in a multiple-selection combo box**

```xaml
<telerik:RadComboBox x:Name="radComboBox"
                     AllowMultipleSelection="True"
                     DropDownOpened="CountriesComboBox_DropDownOpened" />
```

Add the handler and helper method to the window's code-behind class. Include the `System`, `System.Windows`, `System.Windows.Controls`, and `System.Windows.Controls.Primitives` namespaces. Also include `System.Windows.Media`, `System.Windows.Threading`, and `Telerik.Windows.Controls`.

**Example 7: Reset the drop-down scroll position in code-behind**

```csharp
private void CountriesComboBox_DropDownOpened(object sender, EventArgs e)
{
    if (sender is RadComboBox comboBox && comboBox.Items.Count > 1)
    {
        comboBox.Dispatcher.BeginInvoke(new Action(() =>
        {
            var popup = FindChildElement<Popup>(comboBox);
            if (popup?.Child != null)
            {
                var scrollViewer = FindChildElement<ScrollViewer>(popup.Child);
                scrollViewer?.ScrollToTop();
            }
        }), DispatcherPriority.Loaded);
    }
}

private static T FindChildElement<T>(DependencyObject parent) where T : DependencyObject
{
    for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
    {
        var child = VisualTreeHelper.GetChild(parent, i);
        if (child is T match)
            return match;

        var result = FindChildElement<T>(child);
        if (result != null)
            return result;
    }
    return null;
}
```

The callback runs at `DispatcherPriority.Loaded` and requests a scroll to the top only if it finds the popup and scroll viewer. If either lookup fails, it makes no scroll request. Verify the result with your template, selection state, and virtualization settings rather than assuming this timing guarantees the final scroll position.

## See Also

* [Visual Structure]({%slug radcombobox-general-information-visual-structure%})
* [Getting Started]({%slug radcombobox-getting-started%})
* [Multiple Selection]({%slug radcombobox-features-multiple-selection%})
* [RadComboBox Virtualization]({%slug radcombobox-howto-virtualization%})
