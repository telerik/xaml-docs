---
title: Not Supported Properties
page_title: Not Supported Properties
description: Check our &quot;Not Supported Properties&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: not-supported-properties
tags: not,supported,properties
published: True
position: 2
---

# {{ site.framework_name }} RadDocking Not Supported Properties

There are several properties that are not supported by the __RadDocking__ control. Below is a list of these properties and the reason why they are not working. However, we are working on improving their behavior. 

## RadDocking

Properties that are __not supported__:

* __ItemsSource__

* __ItemTemplate__

* __ItemTemplateSelector__

* __ItemContainerStyle__

* __ItemContainerStyleSelector__

* __DisplayMemberPath__

__Description__: These properties are directly inherited from __ItemsControl__ property and the use of __ItemsSource__ property is __not supported__.

Properties that should __not be changed__:

* __ItemsPanel__

__Description__: The __RadDocking__ control allows its __ItemsPanel__ property to be used and customized, but this could lead to an __unexpected__ behavior of the control.

Problematical Properties:

* __FlowDirection__

__Description__: Not implemented yet. This problem will be targeted soon.

> If you want to bind a collection of objects to __RadDocking__ you could use the {% if site.site_name == 'Silverlight' %}[__PanesSource__]({%slug raddocking-features-panes-panesource%}){% endif %}{% if site.site_name == 'WPF' %}[__PanesSource__]({%slug raddocking-features-panes-panesource%}){% endif %} property. It is very similar to the not supported __ItemsSource__ property - it can even be bound to RadPane instances.

## RadSplitContainer

Properties that are __not supported__:

* __ItemsSource__

* __ItemTemplate__

* __ItemTemplateSelector__

* __ItemContainerStyle__

* __ItemContainerStyleSelector__

* __DisplayMemberPath__

__Description__: These properties are directly inherited from __ItemsControl__ property and the use of __ItemsSource__ property is __not supported__.

Properties that should __not be changed__:

* __ItemsPanel__

__Description__: The __RadDocking__ control allows its __ItemsPanel__ property to be used and customized, but this could lead to an __unexpected__ behavior of the control.

Problematical Properties:

* __FlowDirection__

__Description__: Not implemented yet. This problem will be targeted soon.

## RadPaneGroup

Properties that are __not supported__:

* __ItemsSource__

* __ItemTemplate__

* __ItemTemplateSelector__

* __ItemContainerStyle__

* __ItemContainerStyleSelector__

* __DisplayMemberPath__

__Description__: These properties are directly inherited from __ItemsControl__ property and the use of __ItemsSource__ property is __not supported__.

* __All drop-down properties__

__Description__: All drop-down properties are inherited from __RadTabControl__. Their events are limited only for the __DocumentHost__ groups. They are __not implemented__ in the other __ControlTemplates__ at this moment.

* __OverFlowMode__

__Description__: __OverFlowMode__ property can be used and customized, but this could lead to an __unexpected__ behavior of the control.

* __ReorderTabRows__

__Description__: This property is inherited from __RadTabControl__. It works only if you change the __ItemsPanel__ with a __TabWrapPanel__. In other cases it could lead to an __unexpected__ behavior of the control.

* __ScrollMode__

__Description__: It is __not implemented__ at this moment.

Properties that should __not be changed__:

* __ItemsPanel__

__Description__: The __RadDocking__ control allows its __ItemsPanel__ property to be used and customized, but this could lead to an __unexpected__ behavior of the control.

Problematical Properties:

* __FlowDirection__

__Description__: It is __not implemented__ at this moment.

## RadPane

Properties that are __not supported__:

* __All drop-down properties__

__Description__: All drop-down properties are inherited from __RadTabControl__. Their events are limited only for the __DocumentHost__ groups. It’s __not implemented__ in the other __ContolTemplates__ at this moment.

