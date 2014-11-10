---
title: Controlling Appearance
page_title: Controlling Appearance
description: Controlling Appearance
slug: radtabcontrol-controlling-appearance
tags: controlling,appearance
published: True
position: 0
---

# Controlling Appearance



## 

There are a number of ways you can customize the look & feel of your __RadTabControl__ control.
				

* If you need to group your tab items in different rows, separating them by some specific criteria, just use the __Boolean__ property__IsBreak.__ This property belongs to the __RadTabItem__ class and once set, all tab items that are after this one will be placed on a new row. [Read more]({%slug radtabcontrol-features-multiline-tabs%})

* You can control the orientation of the tab items by using the property __TabOrientation.__ You can choose one of these  options: to display them horizontally (__Orientation.Horizontal__) or vertically (__Orientation.Vertical__).[Read more](5CF866DE-453C-48CF-A4EB-2A4F717AD728#Set_Tab_Orientation)

* The default placement of the tab control items is on top, but sometimes this is not what we need. Here is when the __TabStripPlacement__ property comes. It allows you to define the exact position; the tab items should appear using the __Telerik.Windows.Controls.Dock__ enumeration. The four possible choices are: - __Dock.Bottom__, __Dock.Left__, __Dock.Right__, __Dock.Top.__[Read more]({%slug radtabcontrol-how-to-change-the-position-of-the-tab-strip-of-radtabcontrol%})

* Control the size of the __RadTabControl__ using both of the properties __Width__ and__Height__. Use these properties only in case you want to set your control to some specific size, otherwise the layout manager will take care of the proper sizing.
					

* Use the __Margin__ to get or set the outer margin of the __RadTabControl__. The margin is the space between this element and the other elements that will adjacent when the layout creates the user interface.
					

* Use the __Padding__ to get or set the padding inside the __RadTabControl__. Padding is the amount of space to insert between the object and its margin or border. The default value is 0 (zero).
					

* Use the built-in [Templates]({%slug radtabcontrol-templating-overview%}) mechanism if you want to completely change the appearance of your __RadTabControl__.
					

# See Also

 * [Templating]({%slug radtabcontrol-templating-overview%})

 * [Using Themes]({%slug radtabcontrol-using-themes%})
