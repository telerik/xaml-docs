---
title: Not Supported Properties
page_title: Not Supported Properties
description: Check our &quot;Not Supported Properties&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: not-supported-properties
tags: not,supported,properties
published: True
position: 2
---

# Not Supported Properties

There are several properties that are not supported by the `RadDocking` control. Below is a list of these properties and the reason why they are not working. However, we are working on improving their behavior. 

## General

Placing the RadDocking control inside a panel that measures its children with infinity (like `StackPanel`, `ScrollViewer`, etc.) is __not supported__. You can disable the exception by setting the `AllowUnsafeMode` property of the control to __true__, however, this can lead to an __unexpected__ behavior of the control.

__Description__&mdash;The RadDocking control will check if it is placed in such a panel and will throw a `NotSupportedException` if this is the case.

## RadDocking

Properties that are __not supported__:

* `ItemsSource`
* `ItemTemplate`
* `ItemTemplateSelector`
* `ItemContainerStyle`
* `ItemContainerStyleSelector`
* `DisplayMemberPath`

__Description__&mdash;These properties are directly inherited from `ItemsControl` property and the use of ItemsSource property is __not supported__.

Properties that should __not be changed__:

* `ItemsPanel`

__Description__&mdash;The RadDocking control allows its ItemsPanel property to be used and customized, but this could lead to an __unexpected__ behavior of the control.

Problematical Properties:

* `FlowDirection`

__Description__&mdash;Not implemented yet. This problem will be targeted soon.

> If you want to bind a collection of objects to RadDocking you could use the [__PanesSource__]({%slug raddocking-features-panes-panesource%}) property. It is very similar to the not supported ItemsSource property - it can even be bound to RadPane instances.

## RadSplitContainer

Properties that are __not supported__:

* `ItemsSource`
* `ItemTemplate`
* `ItemTemplateSelector`
* `ItemContainerStyle`
* `ItemContainerStyleSelector`
* `DisplayMemberPath`

__Description__&mdash;These properties are directly inherited from ItemsControl property and the use of ItemsSource property is __not supported__.

Properties that should __not be changed__:

* `ItemsPanel`

__Description__&mdash;The RadDocking control allows its ItemsPanel property to be used and customized, but this could lead to an __unexpected__ behavior of the control.

Problematical Properties:

* `FlowDirection`

__Description__&mdash;Not implemented yet. This problem will be targeted soon.

## RadPaneGroup

Properties that are __not supported__:

* `ItemsSource`
* `ItemTemplate`
* `ItemTemplateSelector`
* `ItemContainerStyle`
* `ItemContainerStyleSelector`
* `DisplayMemberPath`

__Description__&mdash;These properties are directly inherited from ItemsControl property and the use of ItemsSource property is __not supported__.

* __All drop-down properties__

__Description__&mdash;All drop-down properties are inherited from `RadTabControl`. Their events are limited only for the `DocumentHost` groups. They are __not implemented__ in the other control templates at this moment.

* `OverFlowMode`

__Description__&mdash;OverFlowMode property can be used and customized, but this could lead to an __unexpected__ behavior of the control.

* `ReorderTabRows`

__Description__&mdash;This property is inherited from __RadTabControl__. It works only if you change the ItemsPanel with a `TabWrapPanel`. In other cases it could lead to an __unexpected__ behavior of the control.

* `ScrollMode`

__Description__&mdash;It is __not implemented__ at this moment.

Properties that should __not be changed__:

* `ItemsPanel`

__Description__&mdash;The RadDocking control allows its ItemsPanel property to be used and customized, but this could lead to an __unexpected__ behavior of the control.

Problematical Properties:

* `FlowDirection`

__Description__&mdash;It is __not implemented__ at this moment.

## RadPane

Properties that are __not supported__:

* __All drop-down properties__

__Description__&mdash;All drop-down properties are inherited from `RadTabControl`. Their events are limited only for the `DocumentHost` groups. It’s __not implemented__ in the other control templates at this moment.