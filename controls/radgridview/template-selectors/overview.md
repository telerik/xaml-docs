---
title: Overview
page_title: Template Selectors Overview
description: Learn how to apply grid data templates based on custom logic with the help of the template selector within RadGridView - Telerik's {{ site.framework_name }} DataGrid.
slug: gridview-template-selectors-overview
tags: overview
published: True
position: 0
---

# Template Selectors Overview

## What is a Template Selector?

The __DataTemplateSelector__ provides a way to apply data templates based on custom logic.

Typically, you use a template selector when you have more than one data template defined for the same type of objects. For example, use it if your binding source is a list of student objects and you want to apply a particular template to the part-time students. You can do this by creating a class that inherits from __DataTemplateSelector__ and by overriding the __SelectTemplate()__ method. Once your class is defined you can assign an instance of the class to the template selector property of your element.

>tip For more information, you can check the [DataTemplateSelector Class msdn article](http://msdn.microsoft.com/en-us/library/system.windows.controls.datatemplateselector(v=vs.110).aspx).

## See Also

 * [CellTemplateSelector]({%slug gridview-cell-template-selector%})
 
 * [Row Details TemplateSelector]({%slug radgridview-row-details-templateselector%})
