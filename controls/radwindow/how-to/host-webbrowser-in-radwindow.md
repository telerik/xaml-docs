---
title: Host WebBrowser in RadWindow
page_title: Host WebBrowser in RadWindow
description: Check our &quot;Host WebBrowser in RadWindow&quot; documentation article for the RadWindow {{ site.framework_name }} control.
slug: radwindow-how-to-host-webbrowser-in-radwindow
tags: host, webbrowser
published: True
position: 8
---

# Host WebBrowser in RadWindow

A common scenario that you might want to achieve is hosting a [WebBrowser](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.webbrowser?redirectedfrom=MSDN&view=netframework-4.7.2) control in a RadWindow. However, by default the RadWindow does not support this, because it is displayed into a transparent WPF Window and the WPF Window doesn't support hosting a WebBrowser control when it is in transparent mode.

## Setting the Transparancy of the RadWindow

In order to achieve the requirement described above, you can utilize the __RadWindowInteropHelper__ class in order to set the __AllowTransparency__ attached property on the RadWindow. __Example 1__ demonstrates this approach.

__Example 1: Hosting a WebBrowser in RadWindow__
```C#
	var window = new RadWindow
    {
        Content = new WebBrowser { Source = new Uri("http://www.telerik.com/") },
        Width = 700,
        Height = 500
    };
    RadWindowInteropHelper.SetAllowTransparency(window, false);
    window.Show();
```
```VB.NET
	Dim window = New RadWindow With {
        .Content = New WebBrowser With {.Source = New Uri("http://www.telerik.com/")},
        .Width = 700,
        .Height = 500
    }
	RadWindowInteropHelper.SetAllowTransparency(window, False)
	window.Show()
```

#### __Figure 1: Result from Example 1 in the Office2016 theme__
![WebBrowser in RadWindow](images/RadWindow_Host_WebBrowser.png)

## See Also

 * [Use RadWindow as User Control]({%slug radwindow-how-to-use-radwindow-as-user-control%})

 * [RadWindowInteropHelper]({%slug radwindow-features-radwindowinterophelper%})

 * [Working with RadWindow]({%slug radwindow-features-working-with-radwindow%})