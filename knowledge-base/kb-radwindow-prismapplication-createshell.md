---
title: CreateShell Method Can't Return RadWindow in Prism 7
description: The return value of the CreateShell method is of type Shell. This breaks the application if the return type is not a sub class of WPF Window.
type: troubleshooting
page_title: Using RadWindow with Prism 7
slug: kb-radwindow-prismapplication-createshell
position: 0
tags: radwindow, telerik, prism 7, prismapplication, createshell, telerikwindow
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

Returning object of type RadWindow in the Prism 7 application CreateShell method causes an error.

## Solution

Return null in CreateShell() method, and override OnInitialized() method to show the RadWindow.


```C#
	public partial class App
	{
		protected override Window CreateShell()
		{
		    return null;
		}
		protected override void OnInitialized()
		{
		    // TelerikShell derives from RadWindow
		    TelerikShell shellWindow = Container.Resolve<TelerikShell>();
		    shellWindow.Show();
		    MainWindow = shellWindow.ParentOfType<Window>();
	
		    RegionManager.SetRegionManager(MainWindow, Container.Resolve<IRegionManager>());
		    RegionManager.UpdateRegions();
		    InitializeModules();
		    base.OnInitialized();
		}
		protected override void RegisterTypes(IContainerRegistry containerRegistry)
		{

		}
	}
```

