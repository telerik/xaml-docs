---
title: Cannot access Freezable System.Windows.Media.SolidColorBrush across threads because it cannot be frozen
description: InvalidOperationException occurs with the Windows8 Telerik theme
type: troubleshooting
page_title: InvalidOperationException Cannot access Freezable SolidColorBrush across threads because it cannot be frozen
slug: kb-common-windows8-brushes
tags: windows8,theming,brushes,exception
res_type: kb
---

## Environment

| Product | Version |
|---------|---------|
| Telerik UI for WPF | 2023.3.1114 |

## Description

InvalidOperationException occurs in some cases when using the Telerik Windows8 theme in a scenario with multiple UI threads.

`InvalidOperationException was unhandled by user code Message=Cannot access Freezable 'System.Windows.Media.SolidColorBrush' across threads because it cannot be frozen.`

## Solution

To fix the issue, call the `Freeze` method on the `Windows8Palette` object. 


```C#
	Telerik.Windows.Controls.Windows8Palette.Palette.Freeze();
```
