---
title: Prevent Dragging Off the Screen
page_title: Prevent Dragging Off the Screen
description: Prevent Dragging Off the Screen
slug: radwindow-how-to-prevent-dragging-off-the-screen
tags: prevent,dragging,off,the,screen
published: True
position: 2
---

# Prevent Dragging Off the Screen



## 

With its default settings, the __RadWindow__ can be dragged off the screen by the user. To prevent the user from dragging the __RadWindow__ off the screen you have to set the __IsRestricted__ property of the __RadWindow__ to __True__.

#### __C#__

{{region radwindow-how-to-prevent-dragging-off-the-screen_0}}
	RadWindow radWindow = new RadWindow();
	radWindow.IsRestricted = true;
	{{endregion}}



#### __VB.NET__

{{region radwindow-how-to-prevent-dragging-off-the-screen_1}}
	Dim radWindow As New RadWindow()
	radWindow.IsRestricted = True
	{{endregion}}



# See Also

 * [Moving]({%slug radwindow-features-moving%})

 * [Hide the Maximize and Minimize buttons]({%slug radwindow-how-to-hide-minimize-maximize-buttons%})

 * [Center the Header of the RadWindow]({%slug radwindow-how-to-center-the-header-of-the-content%})
