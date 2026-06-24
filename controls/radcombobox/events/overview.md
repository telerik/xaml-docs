---
title: Overview
page_title: Events Overview
description: Learn how to handle RadComboBox events, subscribe in XAML or code-behind, and reset the drop-down scroll position in multiple-selection scenarios.
slug: radcombobox-events-overview
tags: overview
published: True
position: 0
---

# Events Overview

Use `RadComboBox` events to react when the drop-down opens, closes, or the selection changes. This article shows how to subscribe to the most common events and how to use `DropDownOpened` to reset the drop-down scroll position each time the list opens.

## Subscribing to Event

Subscribe to a `RadComboBox` event in XAML or in code-behind.

__Example 1: Subscribe to an event in XAML__

```xaml
<telerik:RadComboBox x:Name="radComboBox" DropDownOpened="RadComboBox_DropDownOpened" />
```

__Example 2: Subscribe to an event in code-behind__

```csharp
this.radComboBox.DropDownOpened += RadComboBox_DropDownOpened;
```

## Events

Start with the following events when you customize `RadComboBox` behavior:

### DropDownOpened

Use `DropDownOpened` when you need to change the drop-down state after the popup becomes visible. Typical scenarios include loading data on demand, focusing an element in the popup, or resetting the scroll position.

__Example 3: Handle the DropDownOpened event__

```csharp
private void RadComboBox_DropDownOpened(object sender, EventArgs e)
{
	var radComboBox = (RadComboBox)sender;
}
```

### DropDownClosed

Use `DropDownClosed` when you need to react after the user dismisses the drop-down. This event is useful when you want to commit UI changes or trigger cleanup logic after the popup closes.

__Example 4: Handle the DropDownClosed event__

```csharp
private void RadComboBox_DropDownClosed(object sender, EventArgs e)
{
	var radComboBox = (RadComboBox)sender;
}
```

### SelectionChanged

Use `SelectionChanged` when you need to inspect the selected and unselected items. The `SelectionChangedEventArgs` type exposes the `AddedItems` and `RemovedItems` collections.

__Example 5: Handle the SelectionChanged event__

```csharp
private void RadComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
	var radComboBox = (RadComboBox)sender;
	IList selectedItems = e.AddedItems;
	IList unselectedItems = e.RemovedItems;
}
```

>note `SelectionChanged` is inherited from the [Selector class](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.primitives.selector?view=windowsdesktop-9.0).

## Reset the Drop-Down Scroll Position on Open

By default, `RadComboBox` keeps the last scroll position when the user closes and reopens the drop-down. This behavior is the same when `AllowMultipleSelection` is `True`.

>important `RadComboBox` does not expose a built-in property that resets the drop-down list to the first item every time it opens. To enforce that behavior, handle `DropDownOpened` and scroll the popup `ScrollViewer` in code.

To reset the drop-down scroll position each time the list opens:

1. Subscribe to the `DropDownOpened` event.
2. Find the `ScrollViewer` inside the popup after the drop-down opens.
3. Call `ScrollToTop()` on that `ScrollViewer`.

__Example 6: Subscribe to DropDownOpened in a multiple-selection combo box__

```xaml
<telerik:RadComboBox x:Name="radComboBox"
					 AllowMultipleSelection="True"
					 DropDownOpened="CountriesComboBox_DropDownOpened" />
```

__Example 7: Reset the drop-down scroll position in code-behind__

```csharp
        private void CountriesComboBox_DropDownOpened(object sender, EventArgs e)
        {
            if (sender is RadComboBox comboBox && comboBox.Items.Count > 1)
            {
                // VisualTreeHelper cannot cross Popup boundaries because the Popup
                // opens in a separate PresentationSource. We find the Popup first,
                // then search within popup.Child. The Dispatcher delay ensures the
                // popup layout is complete before we try to access its visual tree.
                Dispatcher.BeginInvoke(() =>
                {
                    var popup = FindChildElement<Popup>(comboBox);
                    if (popup?.Child != null)
                    {
                        var scrollViewer = FindChildElement<ScrollViewer>(popup.Child);
                        scrollViewer?.ScrollToTop();
                    }
                }, DispatcherPriority.Loaded);
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

Add the required `using` directives (for example `System.Windows`, `System.Windows.Controls`, `System.Windows.Controls.Primitives`, `System.Windows.Media`, and `System.Windows.Threading`) if they are not already present in the code-behind file.

Because the code runs after `DropDownOpened` fires, the popup is already created and the `ScrollViewer` is available to scroll back to the top.

## See Also

* [Visual Structure]({%slug radcombobox-general-information-visual-structure%})
* [Getting Started]({%slug radcombobox-getting-started%})
* [Multiple Selection]({%slug radcombobox-features-multiple-selection%})
* [RadComboBox Virtualization]({%slug radcombobox-howto-virtualization%})
