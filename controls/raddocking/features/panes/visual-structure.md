---
title: Visual Structure
page_title: Visual Structure
description: Visual Structure
slug: raddocking-panes-visual-structure
tags: visual,structure
published: True
position: 2
---

# Visual Structure

The major control elements of a the standard __RadPane__ are:

* __Content Area__: This is the area inside of a __RadPane__ where your content will be hosted. To set it or get it just use the __RadPane__'s property __Content__.

	![RadPane Content Area](images/RadDocking_Features_Panes_RadPane_020.png)

* __Header__: This is the header control of a RadPane. In most cases it displays textual information. To learn how to customize the header, take a look at the [Styling the Pane Header]({%slug raddocking-styling-the-pane-header%}) and [How to Add Buttons to the Pane Header]({%slug raddocking-how-to-add-buttons-to-the-pane-headers%}) articles.

	![RadPane Header](images/RadDocking_Features_Panes_RadPane_030.png)

* __Menu__: This menu is created automatically for you and contains the __RadPane__'s most common commands. It allows you to make it floating, docked, part of a tabbed document or just hide it. The menu commands are programmatically accessible via the __RadPane__'s property __MenuCommands__. To learn how to customize this menu, take a look at the [How to Customize or Remove the RadPane's Menu]({%slug raddocking-how-to-add-menu-items-to-the-radpanes-menu%}) and [RadDocking Localization]({%slug raddocking-localization%}) articles.

	![RadPane Menu](images/RadDocking_Features_Panes_RadPane_040.png)

* __Pin/Unpin Button__: This button allows you to pin and unpin the RadPane in case it is docked inside of the __RadSplitContainer__. It is visible by default but if you want to hide it, and prevent the user from changing the pin state of your pane, just set the pane's __CanUserPin__ property to __False__ and the button will be hidden.

	![](images/RadDocking_Features_Panes_RadPane_050.png)

* __Close button__: This button allows you to close the __RadPane__. It is visible by default but if you want to hide it, and prevent the user from closing your pane, just set the __RadPane__'s property __CanUserClose__ to __False__ and the button will be hidden. You can also have a look at the [How to Disable the Close Button]({%slug raddocking-how-to-disable-the-close-button%}) topic.

	![](images/RadDocking_Features_Panes_RadPane_060.png)

* __Tab__: The tab is visible only when a __RadPane__ is docked inside of a container that hosts more than one pane. In that case each RadPane is placed as a separate tab item. To learn more, take a look at the [Pane Groups]({%slug raddocking-features-pane-groups%}) article.

	![](images/RadDocking_Features_Panes_RadPane_070.png)
          
## See Also

 * [How to Add Buttons to the Pane Header]({%slug raddocking-how-to-add-buttons-to-the-pane-headers%})
 * [How to Customize or Remove the RadPane's Menu]({%slug raddocking-how-to-add-menu-items-to-the-radpanes-menu%})
 * [Styling the RadPane]({%slug raddocking-styling-the-radpane%})
 * [Styling the Pane Header]({%slug raddocking-styling-the-pane-header%})