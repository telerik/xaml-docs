---
title: UI Automation Issue with RadGridView on .NET 8
description: This article provides workaround for the issue where UI Automation doesn't work in WPF after migrating to .NET 8.
type: troubleshooting
page_title: UI Automation Not Created in WPF Under .NET 8
slug: kb-common-net8-automationpeers-issue
tags: radgridview, ui, automation, net8, peers
res_type: kb
---
## Environment

| Product | Version |
| --- | --- |
| UI for WPF | 2023.3.1114 |

## Description

Automation peers cannot be accessed by UI Automation tests in a  WPF project targeting .NET 8.

## Solution

This is a bug in .NET 8 which is described in the following two Microsoft items:
* [Fix ItemsControl Automation Again #8715](https://github.com/dotnet/wpf/pull/8715)
* [Windows Automation tree breaking change #8679](https://github.com/dotnet/wpf/issues/8679)

To work it around, set the static `_ItemsControlDoesNotSupportAutomation` internal field of the `System.Windows.AccessibilitySwitches` class.

#### __[C#]__
{{region kb-common-net8-automationpeers-issue-0}}
	public partial class App : Application
	{
		public App()
		{
			var accessibilitySwitches = Type.GetType("System.Windows.AccessibilitySwitches, WindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
			var field = accessibilitySwitches.GetField("_ItemsControlDoesNotSupportAutomation", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static | BindingFlags.DeclaredOnly);
			field.SetValue(null, 1);
		}
	}
{{endregion}}
