---
title: Moving
page_title: Moving
description: Moving
slug: radwindow-features-moving
tags: moving
published: True
position: 9
---

# Moving

The user can move the window by clicking on the __RadWindow__'s header and then drag it around the screen.

![](images/RadWindow_Features_Moving_01.png)

>tipWhen the __RadWindow__ gets moved, the __LayoutChangeStarted__ and the __LayoutChangeEnded__ events are raised. More about the events can be found [here]({%slug radwindow-events-overview%}).

To disable the moving of the __RadWindow__ via the UI you have to set the __CanMove__ property to __False__.

#### __C#__

{{region radwindow-features-moving_0}}
	RadWindow radWindow = new RadWindow();
	radWindow.CanMove = false;
{{endregion}}

#### __VB.NET__

{{region radwindow-features-moving_1}}
	Dim radWindow As New RadWindow()
	radWindow.CanMove = False
{{endregion}}

# See Also

 * [Closing]({%slug radwindow-features-closing%})

 * [Resizing]({%slug radwindow-features-resizing%})

 * [Minimizing/Maximizing]({%slug radwindow-features-minimizingmaximazing%})

 * [Prevent Dragging Off the Screen]({%slug radwindow-how-to-prevent-dragging-off-the-screen%})
