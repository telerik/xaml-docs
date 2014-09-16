---
title: Template and Style Selectors
page_title: Template and Style Selectors
description: Template and Style Selectors
slug: radcontextmenu-populating-with-data-template-and-style-selectors
tags: template,and,style,selectors
publish: True
position: 4
---

# Template and Style Selectors



## 

The __RadContextMenu__ and the __RadMenuItem__ controls come with a set of selector properties. Typically, you use a template or style selector when you have more than one data template or style defined for the same type of objects.

>tipTo learn how to use selectors, be sure to read the common topics about [Template Selectors](http://www.telerik.com/help/silverlight/common-data-binding-template-selectors.html) and [Style Selectors](http://www.telerik.com/help/silverlight/common-data-binding-style-selectors.html).

Here is a list of the selectors provided by the __RadContextMenu__ control:

* __ItemTemplateSelector__- used to select the __DataTemplate__ that is set to the __HeaderTemplate__ property of the child __RadMenuItems__.

* __ItemContainerStyleSelector -__ used to select the __Style__ that is applied to the child __RadMenuItems__.

And a list of the selectors provided by the __RadMenuItem__ control:{% if site.site_name == 'Silverlight' %}

>tipTo learn more about the __RadMenuItems__, please take a look at the [RadMenu help content](http://www.telerik.com/help/silverlight/radmenu-overview.html).{% endif %}{% if site.site_name == 'WPF' %}

>tipTo learn more about the __RadMenuItems__, please take a look at the [RadMenu help content](http://www.telerik.com/help/wpf/radmenu-overview.html).{% endif %}

* __HeaderTemplateSelector__ - used to select the __DataTemplate__ that is set to its __HeaderTemplate__ property.

* __ItemContainerStyleSelector -__ used to select the __Style__ that is applied to the child __RadMenuItems__.

* __ItemTemplateSelector__- used to select the __DataTemplate__ that is set to the __HeaderTemplate__ property of the child __RadMenuItems__.

>tipThese properties of the __RadMenuItem__ should be set through the __ItemContainerStyle__ of the parent item. If you set the __ItemContainerStyle__ property of the __RadContextMenu__ only (valid for [dynamic data scenarios]({%slug radcontextmenu-populating-with-data-binding-to-dynamic-data%})), it will get inherited in the hierarchy, unless it is not explicitly set somewhere.

The __HierarchicalDataTemplate__ used with the __RadContextMenu__ also exposes __ItemContainerStyleSelector__ and __ItemTemplateSelector__ properties.

# See Also

 * [Populating with Data - Overview]({%slug radcontextmenu-populating-with-data-overview%})

 * [Data Binding Support Overview]({%slug radcontextmenu-populating-with-data-data-binding-support-overview%})

 * [Using Static Items]({%slug radcontextmenu-populating-with-data-using-static-items%})

 * [Binding to Dynamic Data]({%slug radcontextmenu-populating-with-data-binding-to-dynamic-data%})

 * [Styles and Templates - Overview]({%slug radcontextmenu-styles-and-templates-overview%})
