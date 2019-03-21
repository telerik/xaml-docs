---
title: CreateShell() method can't return RadWindow in Prism 7
description: 
type: troubleshooting
page_title: 
slug: kb-radwindow-prismapplication-createshell
position: 
tags: 
ticketid: 1400280
res_type: kb
---

## Environment
<table>
	<tr>
		<td>Product Version</td>
		<td>2019.1.220</td>
	</tr>
	<tr>
		<td>Product</td>
		<td>RadWindow for WPF</td>
	</tr>
</table>


## Description

In Prism 7 for WPF, the return value of CreateShell() method from class PrismApplication expects to be a subclass of a Window. With this in hand, returning an object of type RadWindow won't be possible as the control does not derive from a Window.

## Solution

Return null in CreateShell() method, and override OnInitialized() metho to show the RadWindow.

#### __[C#]__
	protected override Window CreateShell()
	{
		return null;
	}

	protected override void OnInitialized()
	{
		TelerikShellRadWindow shellWindow = Container.Resolve<TelerikShellRadWindow>();
		TelerikShellRadWindow.Show();
		MainWindow = TelerikShellRadWindow.ParentOfType<Window>();

		RegionManager.SetRegionManager(MainWindow, Container.Resolve<IRegionManager>());
		RegionManager.UpdateRegions();
		InitializeModules();
		base.OnInitialized();
	}
{{endregion}}

