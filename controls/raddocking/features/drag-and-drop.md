---
title: Drag and Drop
page_title: Drag and Drop
description: Drag and Drop
slug: raddocking-features-drag-and-drop
tags: drag,and,drop
published: True
position: 6
---

# Drag and Drop

The __Drag and Drop__ compatibilities of the __RadDocking__ control allow you to re-arange the panes in a complete __WYSIWYG__ manner. When the process of dragging starts, the [Compass]({%slug raddocking-features-compass%}) menu appears to help you dock/undock your panes. 

Below you can find several step-by-step tutorials for the most common operations that can be accomplished via drag and drop.

>tipFind out how to implement [conditional docking]({%slug raddocking-how-to-implement-conditional-docking%}) using __PreviewShowCompass__ event exposed by __RadDocking__.

## Docking Panes to a Container

1. Click on the pane's header and start dragging it to the container you wish to dock your pane to. 

1. As soon as your mouse enters a container, the __Compass__ appears right in its middle. 

1. While keeping the mouse button down, position your mouse cursor over the __compass indicator__ that points to the area you wish to dock your pane to. Notice how the possible Dropping Area is highlighted. 

1. Drop the pane and see how it is docked in the highlighted area.

	![](images/RadDocking_Features_Drag_and_Drop_010.png)

As you can see you have dragged your pane over the Compass' right indicator which leads to highlighting the respective dropping area inside the underlying container.

>Note that the [Compass](#Compass) menu always marks the possible [docking](#Docking_Panes) positions within the container your mouse cursor is currently over.

## Docking Panes to the Root Container

1. Click on the pane's header and start dragging it. 

1. The __Root Compass__ appears. 

1. While keeping the mouse button down, position your mouse cursor over the __root compass indicator__ that points to the area you wish to dock your pane to. Notice how the possible Dropping Area is highlighted. 

1. Drop the pane and see how it is docked in the highlighted area.

	![](images/RadDocking_Features_Drag_and_Drop_020.png)

>Note that the [Root Compass](#Root_Compass) always marks the possible docking positions only for the root container.

## Adding Panes to Tabbed Documents

1. Click on the pane's header and start dragging it to the container you wish to dock your pane to. 

1. As soon as your mouse enters a container, the __Compass__ appears right in its middle. 

1. While keeping the mouse button down, position your mouse cursor over the __compass' center indicator__. Notice how the whole container is highlighted as Dropping Area. 

1. Drop the pane and see how it is docked as a new tab.

	![](images/RadDocking_Features_Drag_and_Drop_030.png)

>tipTo dock a pane to a [Tabbed Document]({%slug raddocking-features-pane-groups%}), drag and drop it over the center indicator of the [Compass](#Compass).

## Undocking Panes

1. Click on the docked pane's header and start dragging it. 

1. While keeping the mouse button down, position your mouse cursor outside any __Compass__ elements. 

1. Drop the pane and notice that it is undocked and placed as a separate window ([ToolWindow]({%slug raddocking-features-tool-window%})).

	![](images/RadDocking_Features_Drag_and_Drop_040.png)

>tipTo undock a pane and make it floatable, just drag it out of its current place and drop it outside any compass indicator.

## See Also

 * [Tool Window]({%slug raddocking-features-tool-window%})

 * [Compass]({%slug raddocking-features-compass%})

 * [Save/Load Layout]({%slug raddocking-features-save-load-layout-overview%})
