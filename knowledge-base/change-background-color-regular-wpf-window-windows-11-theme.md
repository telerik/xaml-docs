---
title: Changing Background Color of Regular WPF Window with Windows 11 Theme
description: This article explains how to change the background color of a regular WPF window according to the system setting in the Windows 11 theme.
type: how-to
page_title: Change Background Color of Regular WPF Window with Windows 11 Theme
slug: kb-window-change-background-color-regular-window-windows-11-theme
tags: wpf, windows-11, theme, background-color
res_type: kb
---

## Environment
| Product | Progress Telerik UI for WPF |
| ------- | ------------------------- |
| Version | 2023.2.718               |

## Description

I want to change the background color of a regular WPF window according to the system setting in the Windows 11 theme. However, the color does not change when I toggle the theme mode between light and dark in the system settings.

## Solution

To achieve this requirement, you can use the `RadWindow` control instead of the `Window` control. Additionally, you should set the `RadWindow` as the `MainWindow` of your application.

Here are the steps to implement the solution:

1. Replace the `Window` control with the `RadWindow` control in your project.
2. Set the `RadWindow` as the `MainWindow` of your application.

## See Also
- [Setting a Theme]({%slug styling-apperance-implicit-styles-overview%})
- [Windows 11 Theme]({%slug common-styling-appearance-windows11-theme%})
- [Switching Themes at Runtime]({%slug styling-apperance-themes-runtime%})
