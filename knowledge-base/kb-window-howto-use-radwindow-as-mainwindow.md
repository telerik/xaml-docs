---
title: How to Use RadWindow as MainWindow
description: Change the main window with RadWindow.
type: how-to
page_title: Replace the Default Application Window with a RadWindow
slug: kb-window-howto-use-radwindow-as-mainwindow
position: 0
tags: radwindow,as,mainwindow
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
		<td>RadWindow for WPF and Silverlight</td>
	</tr>
</table>

 ## Description

 How to Use RadWindow as MainWindow.

 ## Solution

 **1.** First open the **MainWindow.xaml** file and replace the Window declaration with a RadWindow declaration:
	
```XAML
	  <telerik:RadWindow x:Class="RadWindowAsMainWindow.MainWindow"
		  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
		  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
		  xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
		  Header="MainWindow" Height="350" Width="525">
	  ...
	  </telerik:RadWindow>
```

and in code-behind:
	
```C#
	public partial class MainWindow : RadWindow
	{
	}
```

**2.** Remove **StartupUri** from the Application definition inside App.xaml:
	
```XAML
  <Application x:Class="RadWindowAsMainWindow.App"
	  xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
	  xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
  ...
```

**3.** Then override the **OnStartup** method of the Application class to show the RadWindow:
	
```C#
  public partial class App : Application
  {
	  protected override void OnStartup(StartupEventArgs e)
	  {
	  new MainWindow().Show();
	  base.OnStartup(e);
	  }
  }
```

 ## See Also

 * [RadWindowInteropHelper]({%slug radwindow-features-radwindowinterophelper%})
* [Host WebBrowser in RadWindow]({%slug radwindow-how-to-host-webbrowser-in-radwindow%})
* [Use RadWindow as User Control]({%slug radwindow-how-to-use-radwindow-as-user-control%})
