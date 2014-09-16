---
title: Checkable Items
page_title: Checkable Items
description: Checkable Items
slug: radmenu-features-checkable-items
tags: checkable,items
publish: True
position: 8
---

# Checkable Items



## 

In order to enhance the functionality of the __RadMenu__ control, the __RadMenuItem__ can behave like a checkable item. This means that it can be checked and unchecked like a simple __CheckBox__. In order to toggle this behavior you have to set the __IsCheckable__ property of the __RadMenuItem__ to either __True__ or __False__. The default value is __False__.

>tipTo learn how to group the checkable items into radio groups read [here]({%slug radmenu-how-to-group-checkable-menu-items-into-radio-group%}).

>tipUpon checking and unchecking the respective events are raised - __Checked__ and __Unchecked__. You can subscribe to them in order to implement your custom logic against the respective action. To learn more about them read here.

Here is an example of a definition of a checkable __RadMenuItem__:

#### __XAML__

{{region radmenu-features-checkable-items_0}}
	<telerik:RadMenuItem Header="Status Bar" 
	                               IsCheckable="True" />
	{{endregion}}



Upon clicking on the item it will get checked and the tick will appear as an icon for the item.

>tipNote that after clicking on the item the menu will collapse. In order to keep the menu open you can set the __StaysOpenOnClick__ property of the __RadMenuItem__ to __True__. This will keep the menu open when this item is clicked.

![](images/RadMenu_Features_Checkable_Items_01.png)

>If you want to programmatically mark an item as checked, you have to set the __IsChecked__ property to __True__.

# See Also

 * [Icons]({%slug radmenu-features-icons%})

 * [Separator Items]({%slug radmenu-features-separator-items%})

 * [Group Checkable Menu Items into Radio Group]({%slug radmenu-how-to-group-checkable-menu-items-into-radio-group%})
