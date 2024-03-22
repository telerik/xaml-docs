---
title: Resolving Error when Calling InitializeComponent() on a User Control
description: Learn how to resolve an error that occurs when calling InitializeComponent on a user control in RadComboBox for WPF.
type: troubleshooting
page_title: Error when Calling InitializeComponent() on a UserControl With RadComboBox
slug: kb-combobox-initialize-component-error
tags: radcombobox, wpf, error, initializecomponent, user control
res_type: kb
---

## Environment

| Property | Value |
| --- | --- |
| Product | RadComboBox for WPF |
| Version | 2023.1.117 |

## Description

The following error is raised when calling the InitializeComponent() method:

```plaintext
[A]Telerik.Windows.Controls.RadComboBox cannot be cast to [B]Telerik.Windows.Controls.RadComboBox. Type A originates from 'Telerik.Windows.Controls.Input, Version=2023.1.117.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7' in the context 'LoadNeither' in a byte array. Type B originates from 'Telerik.Windows.Controls.Input, Version=2023.1.117.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7' in the context 'LoadNeither' in a byte array.
```

## Solution

This error typically occurs when there is a mix-up of DLLs or it can be caused by the Visual Studio's assemblies caching mechanisms. 

You can try the following steps from the [Resolving Design Time Errors]({%slug troubleshooting-design-time-errors%}) article. The steps in it target design-time errors but they are quite valid for some runtime errors as well.

Additionally, check if your project references the assembly twice, from which the error originates. This can happen if you have both a NuGet package with this DLL and an assembly reference added to the project.

