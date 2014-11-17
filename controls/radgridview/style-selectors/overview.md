---
title: Overview
page_title: Overview
description: Overview
slug: gridview-style-selectors-overview
tags: overview
published: True
position: 0
---

# Overview

## What is a Style Selector?

The __StyleSelector__ provides a way to apply styles based on custom logic.
		
Typically, you use a style selector when you have more than one styles defined for the same type of objects. For example, use it if your binding source is a list of student objects and you want to apply a particular style to the part-time students. You can do this by creating a class that inherits from __Telerik.Windows.Controls.StyleSelector__ and by overriding the __SelectStyle()__ method. Once your class is defined you can assign an instance of the class to the style selector property of your element.

>tipFor more information, you can check the [StyleSelector Class msdn article](http://msdn.microsoft.com/en-us/library/system.windows.controls.styleselector.aspx).

# See Also

 * [CellStyleSelector]({%slug gridview-cell-style-selector%})

 * [RowStyleSelector]({%slug gridview-rowstyleselector%})
