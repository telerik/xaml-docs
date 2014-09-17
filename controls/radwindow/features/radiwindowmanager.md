---
title: RadWindowManager
page_title: RadWindowManager
description: RadWindowManager
slug: radwindow-features-radiwindowmanager
tags: radwindowmanager
published: True
position: 10
---

# RadWindowManager



## 

__RadWindowManager__ is a singleton class that exposes several methods that act on all active __RadWindows__ in the current application.

Here is a brief list of all static methods exposed by __RadWindowManager__:

* __CloseAllWindows__ - Closes all __RadWindows__ that are currently opened.

* __MinimizeAllWindows__ - Sets the __WindowState__ of all __RadWindows__ that are currently opened to __Minimized__.

* __MaximizeAllWindows__ - Sets the __WindowState__ of all __RadWindows__ that are currently opened to __Maximized__.

* __NormalizeAllWindows__ - Sets the __WindowState__ of all __RadWindows__ that are currently opened to __Normal__.

* __GetWindows__ - returns a __IList__ of __RadWindow__ objects that contain all currently opened __RadWindows__.

Here is an example of how to use __RadWindowManager__ to close all active __RadWindows__:

#### __C#__

{{region radwindow-features-radiwindowmanager_0}}
	RadWindowManager.Current.CloseAllWindows();
	{{endregion}}



#### __VB.NET__

{{region radwindow-features-radiwindowmanager_1}}
	RadWindowManager.Current.CloseAllWindows()
	{{endregion}}



# See Also

 * [Working with RadWindow]({%slug radwindow-features-working-with-radwindow%})

 * [Predefined Dialogs]({%slug radwindow-features-predefined-dialogs%})

 * [States]({%slug radwindow-features-states%})
