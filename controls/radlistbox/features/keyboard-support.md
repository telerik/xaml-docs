---
title: Keyboard Support
page_title: Keyboard Support
description: Using the keyboard you can easily navigate through RadListbox's items. This article describes the available key shortucts as well as some specific use cases.
slug: radlistbox-features-keyboard-support
tags: keyboard,support
published: True
position: 2
---

# Keyboard Support

Using the keyboard you can easily navigate through RadListbox's items. Here's a list of the currently supported keys.

## Keyboard Shortcuts

* __Up/Down, Left/Right__: Navigates to the previous/next item based on the current **orientation** of the control's **ItemsPanel**.

>Prior to **R1 2018**, only up/down navigation is supported which does not take into account the orientation of the panel - always navigates to the next/previous index.

>RadListBox currently supports navigation in the following panels: **StackPanel**, **VirtualizingStackPanel**, **WrapPanel**, **VirtualizingWrapPanel**.

* __PageUp/PageDown__: Navigates to the first/last item in the viewport or selects the previous/next item if all items are in the viewport.

* __Home/End__: Navigates to the first/last item.

* __Space__: Selects the currently focused item when in **Multiple** selection mode.

* __Ctrl__: When in **Extended** selection mode, moves the focus to the next/previous item when used in combination with the arrow keys.

* __Shift__: When in **Extended** selection mode, selects all items from the current one to the next/previous item when used in combination with the arrow keys.

## Notes

> All other keys trigger the control's [autocomplete]({%slug radlistbox-features-autocomplete%}) mechanism if **IsTextSearchEnabled** is set to **True**.

<!-- -->

> Disabled items are not be included in navigation - they are skipped and the next/previous item is navigated to.

<!-- -->

>important Currently, the attached **KeyBoardNavigation.DirectionalNavigation** property is not respected. The control behaves as in **Contained** directional navigation.

<!-- -->

> Navigation always starts from the currently selected item. If there is no selection, navigation will start from the first item.

<!-- -->

> By default RadListBox has its **IsScrollIntoViewEnabled** property set to **True**. This means that when an item is selected with the keyboard it will be scrolled into the viewport and made visible.

## See Also

* [AutoComplete]({%slug radlistbox-features-autocomplete%})
* [Selection]({%slug radlistbox-features-selection%})