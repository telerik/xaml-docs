---
title: Required Parts
page_title: Required Parts
description: Required Parts
slug: radtoolbar-template-parts
tags: required,parts
published: True
position: 1
---

# Required Parts



## 

#### __C#__

{{region radtoolbar-template-parts_0}}
	[DefaultProperty("Items")]
	[TemplatePart(Name = "PART_DropdownButton", Type = typeof(ToggleButton))]
	[TemplatePart(Name = "PART_StripPanel", Type = typeof(StackPanel))]
	[TemplatePart(Name = "PART_OverflowPanel", Type = typeof(StackPanel))]
	[TemplatePart(Name = "PART_Overflow", Type = typeof(Popup))]
	public partial class RadToolBar : ItemsControl
	{{endregion}}



The default control template of the __RadToolBar__ consists the following parts:


* __PART_DropdownButton__: this element is responsible to open/close the __Overflow__ area.

* __PART_StripPanel__: this element serves as a place holder for all visible items.

* __PART_OverflowPanel__: this element serves as a place holder for all items not fitted in 
            __Strip__ panel.

* __PART_Overflow__: this element holds the __Overflow__ panel and is responsible for 
            all the pop-up management.

