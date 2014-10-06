---
title: Closing
page_title: Closing
description: Closing
slug: radwindow-features-closing
tags: closing
published: True
position: 8
---

# Closing

The __RadWindow__ can be closed by either clicking on its 'Close' button at the top-right corner or by calling the __Close()__ method of the __RadWindow__ instance.

![](images/RadWindow_Features_Closing_01.png)

#### __C#__

{{region radwindow-features-closing_0}}
	RadWindow radWindow = new RadWindow();
	radWindow.Show();
	...
	radWindow.Close();
{{endregion}}

#### __VB.NET__

{{region radwindow-features-closing_1}}
	Dim radWindow As New RadWindow()
	radWindow.Show()
	...
	radWindow.Close()
{{endregion}}

>tipWhen the __RadWindow__ gets closed the __Closed__ event is raised. More about events can be found [here]({%slug radwindow-events-overview%}).

To disable the closing of the __RadWindow__ via the UI you have to set the __CanClose__ property to __False__.

>The only scenario, where you can add content to the __RadWindow__ at design-time, is when the __RadWindow__ represents an entire user control. To learn more about that read [here]({%slug radwindow-how-to-use-radwindow-as-user-control%}).

#### __C#__

{{region radwindow-features-closing_2}}
	RadWindow radWindow = new RadWindow();
	radWindow.CanClose = false;
{{endregion}}

#### __VB.NET__

{{region radwindow-features-closing_3}}
	Dim radWindow As New RadWindow()
	radWindow.CanClose = False
{{endregion}}

![](images/RadWindow_Features_Closing_02.png)

# See Also

 * [Moving]({%slug radwindow-features-moving%})

 * [Minimizing/Maximizing]({%slug radwindow-features-minimizingmaximazing%})

 * [Resizing]({%slug radwindow-features-resizing%})
