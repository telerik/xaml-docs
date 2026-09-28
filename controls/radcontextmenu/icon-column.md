---
title: Customizing Icons
page_title: Customizing the Icon Column
description: Learn how to customize the icon column of the RadContextMenu in the Telerik UI for WPF documentation.
components: ["contextmenu"]
slug: radcontextmenu-features-icon-column
tags: icon,column,appearance
published: True
position: 11
---

# Customizing the Icon Column

By default, the __RadContextMenu__ displays a column for the icons of its menu items. You can control the width of this column or hide it when the menu items do not use icons.

## Change the Icon Column Width

Use the `IconColumnWidth` property to control the width of the icon column. Set the value to `0` to hide the column.

__Set the Icon Column Width__
```XAML
<telerik:RadContextMenu xmlns:telerik="http://schemas.telerik.com/2008/xaml/presentation"
                        IconColumnWidth="0" />
```

__RadContextMenu Icon Column__
![WPF RadContextMenu Icon Column](images/RadContextMenu_KeyProperties_01.png)

__RadContextMenu with Hidden Icon Column__
![WPF RadContextMenu with Hidden Icon Column](images/RadContextMenu_KeyProperties_02.png)

## See Also  
* [Data Binding]({%slug radcontextmenu-features-data-binding%})
* [Item Template and Style Selectors]({%slug radcontextmenu-features-template-and-style-selectors%})
* [Menu Placement]({%slug radcontextmenu-features-placement%})