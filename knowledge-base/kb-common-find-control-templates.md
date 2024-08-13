---
title: Cannot Edit the ControlTemplate of a Telerik WPF Control 
description: Steps to access and modify the control template of Telerik UI for WPF control (like RadNumericUpDown).
type: troubleshooting
page_title: The Edit Template Edit a Copy Option is Disabled on Some Telerik Controls
slug: kb-common-find-control-templates
tags: radnumericupdown, wpf, control template, themes.implicit, customization
res_type: kb
ticketid: 1632159
---

## Environment

| Product | Telerik UI for WPF |
| --- | --- |
| Version | 2024.3.806 |

## Description

The __Edit Template --> Edit a Copy__ option in the Visual Studio designer is disabled for some Telerik controls. 

In rare cases, even if the option is enabled, the extracted template may be missing some parts or property settings.

## Solution

To get the needed ControlTemplate and ensure that everything is properly extract, you can manually [copy the template from the corresponding Telerik .xaml file]({%slug styling-apperance-editing-control-templates%}).

In case you have installed Telerik UI for WPF via the .msi installer, you can go to the __\installation folder\Themes.Implicit\<.net framework name>\<theme name>\<.xaml file name>__

For example: `C:\Program Files (x86)\Progress\Telerik UI for WPF 2024 Q3\Themes.Implicit\NET\Windows11\Themes\Telerik.Windows.Controls.Input.xaml`

If you don't have the product installed, you can go to the [download page](https://www.telerik.com/account/downloads/product-download?product=RCWPF) and get the .zip file with the Telerik dlls (e.g.: Telerik_UI_for_WPF_2024_3_806_Dev_Dlls.zip). In the archive, you can find the Themes.Implicit folder, where you can search for the needed .xaml file.

When you open the .xaml file, you can search for the control name + Style posting at the end. For example: "RadNumericUpDownStyle" or "RadGridViewStyle".
