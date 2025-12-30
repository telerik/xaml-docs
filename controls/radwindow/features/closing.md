---
title: Closing
page_title: Closing
description: This article demonstrates how a RadWindow can be closed and also how the closing can be prevented.
slug: radwindow-features-closing
tags: closing
published: True
position: 8
---

# Closing

The __RadWindow__ can be closed by either clicking on its 'Close' button at the top-right corner or by calling the __Close()__ method of the __RadWindow__ instance.

![{{ site.framework_name }} RadWindow Close Button](images/RadWindow_Features_Closing_01.png)

__Example 1: Closing a RadWindow__

```C#
	RadWindow radWindow = new RadWindow();
	radWindow.Show();
	//...
	radWindow.Close();
```
```VB.NET
	Dim radWindow As New RadWindow()
	radWindow.Show()
	'...'
	radWindow.Close()
```

>tip When the __RadWindow__ gets closed, the __Closed__ event is raised. More about events can be found [here]({%slug radwindow-events-overview%}).

## Prevent Closing

To disable the closing of the __RadWindow__ via the UI you can set the __CanClose__ property to __False__.

__Example 2: Setting the CanClose property__

```C#
	RadWindow radWindow = new RadWindow();
	radWindow.CanClose = false;
```
```VB.NET
	Dim radWindow As New RadWindow()
	radWindow.CanClose = False
```

![{{ site.framework_name }} RadWindow Hidden Close Button](images/RadWindow_Features_Closing_02.png)

Alternatively, you can also handle the __PreviewClosed__ event and set the __Cancel__ property of the event arguments to True. 

__Example 3: Canceling the PreviewClosed event__

```C#
	private void RadWindow_PreviewClosed(object sender, WindowPreviewClosedEventArgs e)
	{
		e.Cancel = true;
	}
```
```VB.NET
	Private Sub RadWindow_PreviewClosed(ByVal sender As Object, ByVal e As WindowPreviewClosedEventArgs)
		e.Cancel = True
	End Sub
```

## See Also

 * [Moving]({%slug radwindow-features-moving%})

 * [Minimizing/Maximizing]({%slug radwindow-features-minimizingmaximazing%})

 * [Resizing]({%slug radwindow-features-resizing%})