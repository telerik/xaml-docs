---
title: DragReorder of Tabs
page_title: DragReorder of Tabs
description: Check our &quot;DragReorder of Tabs&quot; documentation article for the RadDocking {{ site.framework_name }} control.
slug: raddocking-features-dragreorder
tags: dragreorder,of,tabs
published: True
position: 7
---

# DragReorder of Tabs

With the official Q3 2012 release of UI for {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %} we introduced the __DragReorder__ feature of __RadDocking__ control. This feature will help end users to easily reorder existing __RadPanes__ in a specific __RadPaneGroup__.

## Enabling and Disabling DragReorder

By default the __DragReorder__ feature is disabled. In order to enable it you will need to set the AllowDragReorder property of the control to true.

The next code snippet shows how to enable the DragReorder feature:

#### __XAML__

```XAML
	<telerik:RadDocking AllowDragReorder="True">
	    ...
	</telerik:RadDocking>
```

The following screenshots demonstrate the behavior of RadDocking when DragReorder feature is enabled:

* When RadPaneGroup is in DocumentHost:

![raddocking-features-dragreorder-1](images/raddocking-features-dragreorder-1.png)

![raddocking-features-dragreorder-2](images/raddocking-features-dragreorder-2.png)

* When RadPaneGroup is not in DocumentHost:

![raddocking-features-dragreorder-3](images/raddocking-features-dragreorder-3.png)

![raddocking-features-dragreorder-4](images/raddocking-features-dragreorder-4.png)