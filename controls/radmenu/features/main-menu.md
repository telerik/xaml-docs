---
title: Main Menu
page_title: Main Menu
description: This article describes the IsMainMenu property which controls whether RadMenu receives a main menu activation notification.
slug: radmenu-features-main-menu
tags: main,menu
published: True
position: 14
---

# Main Menu

As of **R3 2018**, RadMenu exposes a boolean **IsMainMenu** property which indicates whether RadMenu receives a main menu activation notification. When set to **True** and the user presses the **F10** or the **Alt** key, the menu grabs the focus and its first item gets highlighted. The default value is **False**.

#### __Figure 1: RadMenu with IsMainMenu set to True once Alt/F10 is pressed__

![RadMenu with IsMainMenu set to True once Alt/F10 is pressed](images/activated-menu.png)

>If there are multiple RadMenu instances with IsMainMenu set to **True**, only one of them will get highlighted.

<!-- -->

>If the mouse is captured at the moment when the activation takes place, the RadMenu will not receive the focus.

## See Also

 * [Orientation and DropDownPlacement]({%slug radmenu-features-orientation%})
 * [Opening Modes]({%slug radmenu-features-opening-modes%})
 * [Click Modes]({%slug radmenu-features-click-modes%})