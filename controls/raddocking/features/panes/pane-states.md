---
title: Pane States
page_title: Pane States
description: Pane States
slug: raddocking-panes-pane-states
tags: pane,states
published: True
position: 3
---

# Pane States

The standard RadPane can be [docked/floating]({%slug raddocking-features-panes-docked-floating-panes%}), [pinned/unpinned]({%slug raddocking-panes-pinned-unpinned-panes%}) or [grouped]({%slug raddocking-features-pane-groups%}). **Figure 1** shows the appearance of the RadPane in each one of these states.

#### Figure 1: RadPane states

![RadPane states](images/RadDocking_Features_Panes_RadPane_010.png)

* __Docked__: A __RadPane__ which is [docked]({%slug raddocking-features-panes-docked-floating-panes%}#docking-panes) to a __RadDocking__ container.
* __Floating__: All __RadPane__ instances which are not docked are [floating]({%slug raddocking-features-panes-docked-floating-panes%}#floating-panes) and are hosted inside of a floatable [ToolWindow]({%slug raddocking-features-tool-window%}) that appears on top of other controls.
* __Pinned__: A [pinned]({%slug raddocking-panes-pinned-unpinned-panes%}#pinned-panes) __RadPane__ is always visible and does not hide automatically.
* __Unpinned__: An [unpinned]({%slug raddocking-panes-pinned-unpinned-panes%}#unpinned-panes) __RadPane__ is shown only when the mouse cursor is over it and is hidden when the cursor leaves its area.
* __Grouped Panes__: When multiple __RadPane__ instances are docked inside one and the same container, a separate tab is created for each one of them. To learn more take a look at the [Pane Groups]({%slug raddocking-features-pane-groups%}) topic.

>tip RadDocking's __PaneStateChanged__ event is fired when a pane changes its state. You can find more information in the [RadDocking events]({%slug raddocking-events-overview%}) article.
          
## See Also

 * [Docked/Floating Panes]({%slug raddocking-features-panes-docked-floating-panes%})
 * [Pinned/Unpinned Panes]({%slug raddocking-panes-pinned-unpinned-panes%})
 * [Pane Groups]({%slug raddocking-features-pane-groups%})
 * [RadDocking Events]({%slug raddocking-events-overview%})