---
title: Pinned/Unpinned Panes
page_title: Pinned/Unpinned Panes
description: Pinned/Unpinned Panes
slug: raddocking-panes-pinned-unpinned-panes
tags: pinned/unpinned,panes
publish: True
position: 3
---

# Pinned/Unpinned Panes



Each __RadPane__ provides built-in pin/unpin functionality that allows you to control the behavior and the visualization of the docked __RadPanes__ during run-time.

By default this functionality is enabled and when a __RadPane__ is docked, pin/unpin toggle button is created and placed at its upper right corner. To toggle the pinned state of a certain __RadPane__ just click the button, highlighted on the snapshot below.




         
      ![](images/RadDocking_Features_Panes_Pinn_Unpinn_010.png)

You can also change the pin state of a __RadPane__ programmatically using the __RadPane__'s boolean property __IsPinned__.

#### __XAML__

{{region raddocking-panes-pinned-unpinned-panes_0}}
	<telerik:RadPane x:Name="radPane" IsPinned="True"/>
	{{endregion}}



#### __C#__

{{region raddocking-panes-pinned-unpinned-panes_1}}
	radPane.IsPinned = true;
	{{endregion}}



#### __VB.NET__

{{region raddocking-panes-pinned-unpinned-panes_2}}
	radPane.IsPinned = True
	{{endregion}}



You can also [pin](#Pinning_All_Panes)/[unpin](#Unpining_All_Panes) all of the panes inside of a [RadPaneGroup]({%slug raddocking-features-pane-groups%}) using the methods __group.PinAllPanes()__/__group.UnpinAllPanes()__.

## Pinned Panes

You can recognize that a docked __RadPane__is pinned if it is visible all the time, even if your mouse cursor is not over it. On the snapshot below you can see two pinned __RadPanes__docked to the left and to the right side of the docking container. __Note that the pin icon of the toggle button is pointing downwards.__




         
      ![](images/RadDocking_Features_Panes_Pinn_Unpinn_020.png)

## Unpinned Panes

The unpinned __RadPane__is shown only when the mouse cursor is over it and is hidden when the cursor leaves its area. When it is hidden you can only see its tab header placed in the auto hide area, while when shown, it is slided on the top of all the other controls without affecting the overall layout.

On the snapshot below you can see two unpinned __RadPanes__; the first is a "Toolbox" docked to the left, the second is a "Solution Explorer" docked respectively to the right. You can see that all their content is hidden, except their tab headers placed in the auto hide area.




         
      ![](images/RadDocking_Features_Panes_Pinn_Unpinn_030.png)

If you hover your mouse over the tab of the "Toolbox" pane, it will slide automatically overlapping the other content. __Note that the pin icon of the toggle button is pointing sideways.__




         
      ![](images/RadDocking_Features_Panes_Pinn_Unpinn_040.png)

>tipIf you want to control the auto hide width and the auto hide hight of your unpinned panes use the respective __RadPane__'s properties __AutoHideHeight__ and __AutoHideWidth__.

## Disabling Pin

If you don't want your __RadPanes__to be pinnable just set the __CanUserPin__ property to __False__. Once disabled the user will not be able to change the pin state of the __RadPane__run-time because the toggle button will be hidden.




         
      ![](images/RadDocking_Features_Panes_Pinn_Unpinn_050.png)

#### __XAML__

{{region raddocking-panes-pinned-unpinned-panes_3}}
	<telerik:RadPane x:Name="radPane" CanUserPin="False"/>
	{{endregion}}



#### __C#__

{{region raddocking-panes-pinned-unpinned-panes_4}}
	radPane.CanUserPin = false;
	{{endregion}}



#### __VB.NET__

{{region raddocking-panes-pinned-unpinned-panes_5}}
	radPane.CanUserPin = False
	{{endregion}}



# See Also

 * [RadPane]({%slug raddocking-panes-radpane%})

 * [RadDocumentPane]({%slug raddocking-panes-raddocumentpane%})

 * [Docked/Floating Panes]({%slug raddocking-features-panes-docked-floating-panes%})
