---
title: Checkable Items
page_title: Checkable Items
description: Check our &quot;Checkable Items&quot; documentation article for the RadMenu {{ site.framework_name }} control.
slug: radmenu-features-checkable-items
tags: checkable,items
published: True
position: 8
---

# Checkable Items

In order to enhance the functionality of the __RadMenu__ control, the __RadMenuItem__ can behave like a checkable item. This means that it can be checked and unchecked like a simple __CheckBox__. In order to toggle this behavior you have to set the __IsCheckable__ property of the __RadMenuItem__ to either __True__ or __False__. The default value is __False__.

>tip To learn how to group the checkable items into radio groups read [here]({%slug radmenu-how-to-group-checkable-menu-items-into-radio-group%}).

>tip Upon checking and unchecking the respective events are raised - __Checked__ and __Unchecked__. You can subscribe to them in order to implement your custom logic against the respective action. To learn more about them read here.

Here is an example of a definition of a checkable __RadMenuItem__:

__Example 1: Define a checkable menu item__

<snippet id='radmenu-features-checkable-items-block_1-xaml' />

Upon clicking on the item it will get checked and the tick will appear as an icon for the item.

>tip Note that after clicking on the item the menu will collapse. In order to keep the menu open you can set the __StaysOpenOnClick__ property of the __RadMenuItem__ to __True__. This will keep the menu open when this item is clicked.

![Checkable Menu Item](images/RadMenu_Features_Checkable_Items_01.png)

>If you want to programmatically mark an item as checked, you have to set the __IsChecked__ property to __True__.

## Checked Icon

As of **R1 2022**, the menu items also expose **CheckedIcon** and **CheckedIconTemplate** properties which you can use to replace the default checkmark glyph with your custom icon which is used when the item is checked.

__Example 2: Using a custom check icon__

<snippet id='radmenu-features-checkable-items-block_2-xaml' />

>important Note that you also need to set the **CheckedIconTemplate** to **null** to override the default icon.

If you're generating the items [dynamically]({%slug radmenu-populating-with-data-binding-to-dynamic-data%}), you can define the **CheckedIconTemplate** as shown in **Example 3**.

__Example 3: Setting the checked icon for dynamically generated items__

<snippet id='radmenu-features-checkable-items-block_3-xaml' />

![Custom Checked Icon](images/RadMenu_Features_Checkable_Items_02.png)

## See Also

 * [Icons]({%slug radmenu-features-icons%})

 * [Separator Items]({%slug radmenu-features-separator-items%})

 * [Group Checkable Menu Items into Radio Group]({%slug radmenu-how-to-group-checkable-menu-items-into-radio-group%})