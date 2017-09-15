---
title: Tool Window
page_title: Tool Window
description: Tool Window
slug: raddocking-features-tool-window
tags: tool,window
published: True
position: 3
---

# Tool Window

__ToolWindow__ is the container control that hosts all panes that are in a floating state. Every time you drag a pane and undock it, a new instance of the class __Telerik.Windows.Controls.Docking.ToolWindow__ is created to host that pane for you.

>The implementation of the __RadDocking__ never requires you to work with __ToolWindows__ directly, but with the Pane hosted inside it. For example, to make a __ToolWindow__ not closable, just set the property __CanUserClose__ of the hosted RadPane to __False__.

In the figure below you can see two ToolWindows with a floating pane inside of each one.

![](images/RadDocking_Features_ToolWindow_010.png)

You can learn how to declare such a floating structure in the [Floating Panes](#Floating_Panes) help article.

## Setting FloatingSize and FloatingLocation

__RadDocking__ provides the ability to easily set the initial floating size and location of the __ToolWindows__. To do that, use the __RadDocking.FloatingSize__ and __RadDocking.FloatingLocation__ attached properties, as shown in Example 1:

#### __[XAML] Example 1: Setting RadDocking.FloatingSize and RadDocking.FloatingLocation__

{{region xaml-raddocking-features-tool-window_0}}
	<telerik:RadDocking>
	    <telerik:RadSplitContainer InitialPosition="FloatingOnly">
	        <telerik:RadPaneGroup>
	            <telerik:RadPane telerik:RadDocking.FloatingSize="500, 500" telerik:RadDocking.FloatingLocation="400, 400"/>
	        </telerik:RadPaneGroup>
	    </telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

## Styling ToolWindow

To learn how to style the tool windows of your applications, read the [Styling the ToolWindow]({%slug raddocking-styling-the-toolwindow%}) topic.

## See Also

 * [Docked/Floating Panes]({%slug raddocking-features-panes-docked-floating-panes%})

 * [Pane Groups]({%slug raddocking-features-pane-groups%})

 * [Split Container]({%slug raddocking-features-split-container%})

 * [Compass]({%slug raddocking-features-compass%})

 * [Drag and Drop]({%slug raddocking-features-drag-and-drop%})

 * [Document Host]({%slug raddocking-features-document-host%})

 * [Styling the ToolWindow]({%slug raddocking-styling-the-toolwindow%})
