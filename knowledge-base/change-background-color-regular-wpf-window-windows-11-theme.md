---
title: Changing Background Color of Regular WPF Window with Windows 11 Theme
description: This article explains how to change the background color of a regular WPF window according to the system setting in the Windows 11 theme.
type: how-to
page_title: Change Background Color of Regular WPF Window with Windows 11 Theme
slug: change-background-color-regular-wpf-window-windows-11-theme
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

Please refer to the attached file for an updated version of your project that implements this solution.

Note: If you have any further questions, please don't hesitate to contact us.

## See Also
- [Telerik UI for WPF Documentation](https://docs.telerik.com/devtools/wpf/introduction)
- [Windows 11 Theme Documentation](https://docs.microsoft.com/en-us/windows/apps/desktop/modernize/apply-acrylic-material)
- [Change Background Color of RadWindow](https://docs.telerik.com/devtools/wpf/controls/radwindow/overview#styling-the-radwindow)
