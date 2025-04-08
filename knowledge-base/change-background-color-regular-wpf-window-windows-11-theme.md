---
title: Changing Background Color of Regular WPF Window with Windows 11 OS Theme
description: This article explains how to change the background color of a WPF window according to the system setting in the Windows 11 theme.
type: how-to
page_title: Change Background Color of WPF Window with Windows 11 Theme
slug: kb-window-change-background-color-regular-window-windows-11-theme
tags: wpf, windows-11, theme, background-color
res_type: kb
---

## Environment

| Product | Version |
| --- | --- |
| RadCalculator for WPF | 2023.2.718 |

## Description

I want to change the background color of a regular WPF window according to the Light/Dark theme setting in the Windows 11 operating system. However, the color does not change when I toggle the theme between light and dark mode in the `Windows > PC Settings > Personalization`.

## Solution

To achieve this requirement, you can use the `RadWindow` control instead of the `Window` control. Additionally, you should set the `RadWindow` as the `MainWindow` of your application and use the `System` color variation of the Telerik Windows11 theme.

Here are the steps to implement the solution:

1. Replace the `Window` control with the [RadWindow]({%slug radwindow-getting-started%}) control in your project.
2. Set the [RadWindow as the MainWindow]({%slug radwindow-how-to-use-radwindow-as-user-control%}) of your application.
3. Set the Windows11 theme and apply the `System` [color variation]({%slug common-styling-appearance-windows11-theme%}#changing-theme-variation).

## See Also
- [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})
- [Windows 11 Theme]({%slug common-styling-appearance-windows11-theme%})
- [Switching Themes at Runtime]({%slug styling-apperance-themes-runtime%})
