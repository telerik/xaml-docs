---
title: Moving
page_title: Moving
description: Check our &quot;Moving&quot; documentation article for the RadDesktopAlert {{ site.framework_name }} control.
slug: raddesktopalert-moving
tags: moving
published: True
position: 8
---

# Moving

With the Q3 2015 release version of UI for WPF the ability to drag and drop __RadDesktopAlert__ to a specific location on the screen is now available.

You can easily move __RadDesktopAlert__ by clicking anywhere inside the control except its __Content__.

>When __RadDesktopAlert__ gets moved its __LayoutChanged__ event is raised.

You could easily disable the moving functionality of __RadDesktopAlert__ using the __CanMove__ property. By default it is set to __True__, so you have to set it to __False__ in order to disable it:

__Enable moving__

```C#
	RadDesktopAlert alert = new RadDesktopAlert();
	alert.CanMove = true;
```

__Enable moving__

```VB
	Dim alert As New RadDesktopAlert()
	alert.CanMove = True
```

If you prefer visualizing __RadDesktopAlert__ by passing an object of type __DesktopAlertParameters__ to the __ShowAlert__ method the __DesktopAlertParameters__ class also supports the __CanMove__ property and you could set it through it:

__Enable moving using DesktopAlertParameters__

```C#
	var manager = new RadDesktopAlertManager();
	manager.ShowAlert(new DesktopAlertParameters
	{
	    CanMove = false,
	    Header = "Message",
	    Content = "A new message has arrived!"
	});
```

__Enable moving using DesktopAlertParameters__

```VB
	Dim manager As New RadDesktopAlertManager()
	manager.ShowAlert(New DesktopAlertParameters With
	{
	    .CanMove = True,
	    .Header = "Message",
	    .Content = "A new message has arrived!"
	})
```

## See Also

 * [Overview]({%slug raddesktopalert-overview%})

 * [Getting Started]({%slug raddesktopalert-getting-started%})