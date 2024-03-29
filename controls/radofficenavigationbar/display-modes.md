---
title: Display Modes
page_title: Display Modes
description: Check our &quot;Display Modes&quot; documentation article for the RadOfficeNavigationBar control.
slug: radofficenavigationbar-display-modes
tags: display modes, radofficenavigationbar
published: True
position: 3
---

# Display Modes

RadOfficeNavigationBar offers different item display modes that indicate whether the items are visualized in a compact or default mode. This is controlled by the `IsInCompactMode` property. You can also change the IsInCompactMode property's value through the UI via the [navigation options window]({%slug radofficenavigationbar-navigation-options%}).

## Compact

When this mode is active, RadOfficeNavigationBar will use the values set to the `CompactContent`, `CompactContentTemplate`, and `CompactContentTemplateSelector` properties of each `RadOfficeNavigationBarItem` element. You can learn more about these properties in the [Custom Content]({%slug radofficenavigationbar-custom-content%}) article.

#### __[XAML] Setting the display mode to compact__
{{region radofficenavigationbar-display-modes-0}}
    <telerik:RadOfficeNavigationBar x:Name="radOfficeNavigationBar" IsInCompactMode="True"/>
{{endregion}}

#### __[C#] Setting the display mode to compact in code__
{{region radofficenavigationbar-display-modes-1}}
    this.radOfficeNavigationBar.IsInCompactMode = true;
{{endregion}}

#### __[VB.NET] Setting the display mode to compact in code__
{{region radofficenavigationbar-display-modes-2}}
    Me.radOfficeNavigationBar.IsInCompactMode = True
{{endregion}}

## Default

This items' display mode is the default one. RadOfficeNavigationBar will use the values set to the `Content`, `ContentTemplate`, and `ContentTemplateSelector` properties of each RadOfficeNavigationBarItem element. You can learn more about these properties in the [Custom Content]({%slug radofficenavigationbar-custom-content%}) article.

>tip To use this display mode, set the IsInCompactMode property of RadOfficeNavigationBar to __False__.

## See Also
* [Custom Content]({%slug radofficenavigationbar-custom-content%})
* [Navigation Options]({%slug radofficenavigationbar-navigation-options%})
* [Peek Popup]({%slug radofficenavigationbar-peek-popup%})