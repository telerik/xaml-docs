---
title: Lightweight Text Rendering
page_title: Lightweight Text Rendering
description: This article will provide information about the lightweight text rendering functionality of Telerik UI for WPF RadGridView.
slug: gridview-lightweight-text-rendering
tags: gridview, lightweight, render, text render, cell text
published: True
position: 24
---

# Lightweight Text Rendering

The `RadGridView` control provides the functionality to use a lightweight rendering mode for the cells' text, which will increase the performance. To enable this functionality, set the `EnableLightweightTextRendering` property to __True__. This alternative rendering mode will skip the creation of `TextBlock` elements that are used to display the cells' text. Instead, it will draw it in a separate panel.

#### __[WPF] Enabling the lightweight rendering mode__
{{region gridview-lightweight-text-rendering-0}}
    <telerik:RadGridView EnableLightweightTextRendering="True"
                         GroupRenderMode="Flat"/>
{{endregion}}

## Redraw Actions

The panel that is used for the lightweight rendering mode, will be forced to redraw when the following `GridViewCell` element's properties are changed:

* `FontSize`
* `FontFamily`
* `FontStyle`
* `FontWeight`
* `FontStretch`
* `HorizontalContentAlignment`
* `VerticalContentAlignment`

## Known Limitations

* Merged cells are not supported with this rendering mode. If the merged cells functionality is enabled, a `NotSupportedException` will be raised.
* Frozen columns are not supported with this rendering mode. Set the `CanUserFreezeColumns` property of RadGridView to __False__, in order to use the text rendering mode. Otherwise, a `NotSupportedException` will be raised.
* The `Nested` option of the `GroupRenderMode` property does not support this rendering mode. Set the group render mode to `Flat` to use the text rendering mode. Otherwise, a `NotSupportedException` will be raised.
* The `ShowTooltipOnTrimmedText` property of the columns does not support this rendering mode, as it relies on the `TextBlock` element of each the cell.
* The `CellTemplate` or `CellTemplateSelector` properties of the columns will disable this rendering mode for their cells.
* The `ContentTemplate` or `ContentTemplateSelector` properties of the `GridViewCell` element will disable this rendering mode.
* The `RightToLeft` option the `FlowDirection` property will disable this rendering mode.