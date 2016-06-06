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

__ToolWindow__ is the container control that hosts all panes when in floating state. Every time you drag a pane and undock it, a new instance of the class __Telerik.Windows.Controls.Docking.ToolWindow__ is created to host that pane for you.

>The implementation of the __RadDocking__ never requires you to work with __ToolWindows__ directly, rather than with the pane hosted inside. For example, to make a __ToolWindow__ not closable just set the property __CanUserClose__ of the hosted pane to __False__.

On the snapshot below you can see two ToolWindows with pane inside of each one.

![](images/RadDocking_Features_ToolWindow_010.png)

If you need to find out how to declare such a floating structure take a look at the [Floating Panes](#Floating_Panes) topic.

## Setting FloatingSize and FloatingLocation

RadDocking provides the ability to set easily the initial floating size and location of the __ToolWindows__. For that purpose the __RadDocking.FloatingSize__ and __RadDocking.FloatingLocation__ attached properties need to be used as shown in Example 1:

#### __[XAML] Example 1: Setting RadDocking.FloatingSize and RadDocking.FloatingLocation__

{{region raddocking-features-tool-window_0}}
	<telerik:RadDocking>
		<telerik:RadSplitContainer InitialPosition="FloatingOnly">
			<telerik:RadPaneGroup>
				<telerik:RadPane telerik:RadDocking.FloatingSize="500, 500" telerik:RadDocking.FloatingLocation="400, 400"/>
			</telerik:RadPaneGroup>
		</telerik:RadSplitContainer>
	</telerik:RadDocking>
{{endregion}}

## Styling ToolWindow

To learn how to style the tool windows of your applications take a look at the [Styling the ToolWindow]({%slug raddocking-styling-the-toolwindow%}) topic.

# See Also

 * [Docked/Floating Panes]({%slug raddocking-features-panes-docked-floating-panes%})

 * [Pane Groups]({%slug raddocking-features-pane-groups%})

 * [Split Container]({%slug raddocking-features-split-container%})

 * [Compass]({%slug raddocking-features-compass%})

 * [Drag and Drop]({%slug raddocking-features-drag-and-drop%})

 * [Document Host]({%slug raddocking-features-document-host%})

 * [Styling the ToolWindow]({%slug raddocking-styling-the-toolwindow%})
