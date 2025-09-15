---
title: Prepare New Custom Window
page_title: Create New Custom Window
description: Prepare a custom instance of RadTabbedWindow for WPF to be used as a host when you drag out a tab item from its original window.
slug: radtabbedwindow-howto-prepare-custom-window
tags: preparenewwindow,inherit,derive
published: True
position: 0
---

# Prepare New Custom Window

This article shows how to prepare a custom instance of RadTabbedWindow to be used as a host when you drag out a tab item from its original window.

By default, when you drag a RadTabItem out of its parent tabbed window, a new RadTabbedWindow instance is created as the tab's host. You can use the __PrepareNewWindow__ virtual method to customize the default instance or replace it with a custom implementation of RadTabbedWindow.

The following example shows how to create a class that derives from RadTabbedWindow and overrides the PrepareNewWindow, where it returns an instance of itself. This is useful when you need the newly created window to be the same type as the custom implementation.

__Example 1: Override the PrepareNewWindow method__  
```C#
	public partial class CustomTabbedWindow : RadTabbedWindow
	{
		protected override RadTabbedWindow PrepareNewWindow()
		{
			var window = new CustomTabbedWindow();
			return window;
		}
	}
```

> Read more about RadTabbedWindow configuration in its [Getting Started]({%slug radtabbedwindow-getting-started%}) article.

## See Also  
* [Key Properties]({%slug radtabbedwindow-key-properties%})
* [Data Binding]({%slug radtabbedwindow-data-binding%})
