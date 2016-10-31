---
title: Separator Items
page_title: Separator Items
description: Separator Items
slug: radmenu-features-separator-items
tags: separator,items
published: True
position: 9
---

# Separator Items

In order to enhance the functionality of the __RadMenu__ control, the __RadMenuItem__ can behave like a separator. In order to make it a separator you have to set its __IsSeparator__ property to either __True__ or __False__. The default value is __False__.

Here is a sample definition of __RadMenuItem__, used as separator:

#### __XAML__

{{region xaml-radmenu-features-separator-items_0}}
	<telerik:RadMenuItem IsSeparator="True" />
{{endregion}}

![](images/RadMenu_Features_Separator_Items_01.png)

>tipIn order to customize the appearance of the separator you have to set the __SeparatorTemplateKey__ to an appropriate __ControlTemplate__. To learn more about the __RadMenuItem's__ templates read [this topic]({%slug radmenu-styles-and-templates-templates-structure%}).

# See Also

 * [Checkable Items]({%slug radmenu-features-checkable-items%})

 * [Icons]({%slug radmenu-features-icons%})

 * [Group Checkable Menu Items into Radio Group]({%slug radmenu-how-to-group-checkable-menu-items-into-radio-group%})
