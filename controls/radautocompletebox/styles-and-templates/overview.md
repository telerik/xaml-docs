---
title: Overview
page_title: Overview
description: Overview
slug: radautocompletebox-styles-and-templates-overview
tags: styles,templates
published: True
position: 1
---

# Overview

__RadAutoCompleteBox__ provides the following properties for styling and templating the items placed inside the boxes part of the control:

* __BoxesItemTemplate__ - when __RadAutoCompleteBox__ is bound to a collection of items, using the __BoxesItemTemplate__ you are able to easily configure the visualization and appearance of the items placed inside the boxes part of the control. Please, check {% if site.site_name == 'WPF' %}[this](http://docs.telerik.com/devtools/wpf/controls/radautocompletebox/styles-and-templates/customizing-boxes-itemtemplate.html){% endif %}{% if site.site_name == 'Silverlight' %}[this](http://docs.telerik.com/devtools/silverlight/controls/radautocompletebox/styles-and-templates/customizing-boxes-itemtemplate.html){% endif %} article for some more detailed information concerning __BoxesItemTemplate__ and how to apply it.

* __BoxesItemTemplateSelector__ - introduced with the Q1 2016 release version of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} is used when you have more than one __BoxesItemTemplate__ defined for the same type of objects. Using __BoxesItemTemplateSelector__ you could easily provide a way to apply the data template based on some custom logic. You could easily achieve this by creating a class that inherits __DataTemplateSelector__ and by overriding the __SelectTemplate__ method that should return the desired template based on a custom logic.

* __BoxesItemStyle__ - introduced with the Q1 2016 release version of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %}. Using the __BoxesItemStyle__ you could easily customize the items that are placed inside the boxes part of the control. Please, check {% if site.site_name == 'WPF' %}[this](http://docs.telerik.com/devtools/wpf/controls/radautocompletebox/styles-and-templates/boxesitemstyle.html){% endif %}{% if site.site_name == 'Silverlight' %}[this](http://docs.telerik.com/devtools/silverlight/controls/radautocompletebox/styles-and-templates/boxesitemstyle.html){% endif %} article for some more detailed information concerning __BoxesItemStyle__ and how to apply it.

* __BoxesItemStyleSelector__ - introduced with the Q1 2016 release version of UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} provides a way to easily apply styles based on some custom logic and thus to customize the items that are inside the boxes part of the control. You could use style selector when you have more that one style defined for the same type of objects. In order to create a style selector you need to create a class that inherits the __StyleSelector__ and override the __SelectStyle__ method - it should return the desired style based on the implemented custom logic.

# See Also

 * [Binding To Object]({%slug radautocompletebox-populating-with-data-binding-to-object%})
 
 * [DropDownItemTemplate]({%slug radautocompletebox-customizing-drop-down-itemtemplate%})
 
 * [BoxesItemTemplate]({%slug radautocompletebox-customizing-boxes-itemtemplate%})
 
 * [BoxesItemStyle]({%slug radautocompletebox-boxesitemstyle%})
