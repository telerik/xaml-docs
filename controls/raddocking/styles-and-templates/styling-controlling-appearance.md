---
title: Controlling Appearance
page_title: Controlling Appearance
description: This article lists some ways in which the RadDocking appearance can be customized.
slug: raddocking-styling-controlling-appearance
tags: controlling,appearance
published: True
position: 2
---

# {{ site.framework_name }} RadDocking Controlling Appearance

There are a number of ways to customize the look and feel of your __RadDocking__ control. This topic covers some of the most useful of these properties.

* Use [RadPaneGroup]({%slug raddocking-features-pane-groups%}) to organize your panes. You can group them both [run-time](#Grouping_Panes_Run-time) or [programmatically](#Grouping_Panes_Programmatically). 

* [Pin](#Pinning_All_Panes)/[Unpin](#Unpining_All_Panes) or [Hide](#Hiding_All_Panes)/[Show](#Showing_All_Panes) all panes via the appropriate __RadPaneGroup__ methods. 

* [Set relative size of nested RadPaneGroups](#Set_Relative_Size_to_the_RadPaneGroup) using the attached property __ProportionalStackPanel.RelativeSize__. 

* Use [RadSplitContainer]({%slug raddocking-features-split-container%}) to split your panes according to your needs. 

* Change the orientation of your __RadSplitContainer__ to __Horizontal__ or __Vertical__ using its __Orientation__ property as shown [here](#Setting_the_Orientation_Property_in_XAML). 

* Control the initial docking positions of your panes via the __InitialPosition__ property of the __RadSplitContainer__ class. Choose between __DockedLeft__, __DockedRight__, __DockedTop__, __DockedBottom__, __FloatingDockable__ and __FloatingOnly__. To learn more read [this](#Setting_the_InitialPosition_of_the_RadSplitContainer_in_XAML). 

* Specify the [size](#Setting_the_Initial_FloatingSize_of_the_RadSplitContainer) and [location](#Setting_the_Initial_FloatingLocation_of_the_RadSplitContainer) of your [floating panes](#Floating_Panes) using the attached properties __RadDocking.FloatingSize__ and __RadDocking.FloatingPosition__. 

* Moreover you can change the look and feel of your __RadDocking__ controls completely using [styles]({%slug raddocking-styling-overview%}). 

## See Also
 * [Styles and Templates - Overview]({%slug raddocking-styling-overview%})
