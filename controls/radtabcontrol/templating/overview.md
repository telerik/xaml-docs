---
title: Overview
page_title: Overview
description: Overview
slug: radtabcontrol-templating-overview
tags: overview
published: True
position: 0
---

# Overview



__RadTabControl__ takes full advantage of the templates by providing a set of __Template__ properties that allows you to control the appearance of the control. The __DataTemplateSelector__ and the __StyleSelector__ also come with the __RadControls__ and allow you to choose the appropriate template on a custom logic basis.

>tipThere are two types of templates – __ControlTemplate__ and __DataTemplate__. The __ControlTemplate__ is used to define the default look of a control and allows the using of __TemplateBinding__. The __DataTemplate__ is used when defining a template that should bind its controls to an object.

## RadTabControl Templates and Template Selectors

* Template property is of type __ControlTemplate__ and is used to set the template of the control.

* __ItemTemplate__ property is of type __DataTemplate__ and is used to set the template for the tab content.

* __ItemTemplateSelector__ property’s value must inherit from __Telerik.Windows.Controls.DataTemplatesSelector__ and allows you to use custom logic to determine which template to apply to the content of the tab.

* __Top__-, __Right__-, __Bottom__- and __LeftTemplate__ are of type __ControlTemplate__. They set the default template of the __RadTabControl__ and are used in combination with the __TabStripPlacement__ property.
            

## RadTabItem Templates and Template Selectors

* __Template__ property is of type __ControlTemplate__ and is used to set the default template of the control.

* __ContentTemplate__ property is of type __DataTemplate__ and is used to define a template for the content of the tab.

* __HeaderTemplate__ property is of type __DataTemplate__ and is used to define a template for the header of the tab.

* __HeaderTemplateSelector__ property’s value must inherit from __Telerik.Windows.Controls.DataTemplatesSelector__ and allows you to use custom logic to determine which template to apply to the header of the tab.

# See Also

 * [Tab Item Templates]({%slug radtabcontrol-templating-tabs-templates%})

 * [Item Template and Template Selectors]({%slug radtabcontrol-item-templates-and-selectors%})

 * [Choose Header Template by Custom Logic]({%slug radtabcontrol-templating-custom-header-template%})

 * [Left/Top/Right/Bottom Templates]({%slug radtabcontrol-left-top-right-bottom-templates%})
