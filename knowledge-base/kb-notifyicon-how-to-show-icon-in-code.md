---
title: How to show a RadNotifyIcon without opening any WPF windows
description: This article shows how to create a system tray application with the RadNotifyIcon.
type: how-to
page_title: Showing an icon in the system tray area without opening a window
slug: kb-notifyicon-how-to-show-icon-in-code
tags: show, notify, icon, without, window, tray, system, application
ticketid: 1471469
res_type: kb
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product</td>
			<td>RadNotifyIcon for WPF</td>
		</tr>
	</tbody>
</table>

## Description

Display the RadNotifyIcon without opening a WPF Window.

## Solution

Instantiate the RadNotifyIcon in code and invoke its __AddIcon__ method.


```C#
     
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        var uri = new Uri("/YourProjectName;component/YourIconName.ico", UriKind.RelativeOrAbsolute);
        StreamResourceInfo streamInfo = Application.GetResourceStream(uri);
        var iconImage = new System.Drawing.Icon(streamInfo.Stream);
        var icon = new RadNotifyIcon() { TrayIcon = iconImage, GuidItem = new Guid("12345678-9123-4567-8901-234567890123") };
        icon.AddIcon();
    }
```

## See Also

* [Getting Started]({%slug radnotifyicon-getting-started%})