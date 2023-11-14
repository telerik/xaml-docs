---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the DragDropManager {{ site.framework_name }} control.
slug: dragdropmanager-overview
tags: overview
published: True
position: 0
CTAControlName: DragDropManager
---

# {{ site.framework_name }} DragDropManager Overview

__DragDropManager__ offers intuitive API similar to the WPF native drag and drop behavior. The APi allows you to enable drag-drop in multiple scenarios.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

![{{ site.framework_name }} Drag Drop Between ListBoxes](images/DragDropManager_DragBetweenListBoxes.png)

## Features:

* __Rich event handling__: The drag-drop framework provides a wide set of events that can be used to handle the actions executed upon a drag and drop operation. Using the events you can adjust the drag and drop actions to your very custom application’s logic, thus providing a great flexibility to the end user. Read more about this in the [Events]({%slug dragdropmanager-events%}) article.

* __Drag visual__: The manager uses a drag visual element to follow the mouse while the user performs drag and drop operations. The drag visual appears always on the top of the other UI elements. This feature gives visual feedback about what is dragged and where it will be dropped. It helps the users while reordering elements on the pages. The drag visual could be easily customized to meet the design of your application. Read more about this in the [Set Drag Visual]({%slug dragdrompmanager-howto-set-drag-visual%}) article.

* __Drag threshold__: You can choose the minimum vertical and horizontal distance which the user needs to move the mouse to start a drag operation. This can be used to avoid accidental and unwanted dragging.

* __Integrations between applications__: DragDropManager has built-in support for dragging from and to external programs, allowing easy interaction between applications.

>tip Get started with the control with its [Getting Started]({%slug dragdropmanager-getting-started%}) help article that shows how to use it in a basic scenario.

> Check out the control's demos at {% if site.site_name == 'Silverlight' %}[demos.telerik.com](https://demos.telerik.com/silverlight/#DragAndDrop){% endif %}{% if site.site_name == 'WPF' %}[demos.telerik.com](https://demos.telerik.com/wpf/){% endif %}. Additionally, you can download more runnable projects from our [online SDK repository](https://github.com/telerik/xaml-sdk/tree/master/DragDrop).

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Support and Learning Resources

* [Telerik UI for WPF DragAndDrop Homepage](https://www.telerik.com/products/wpf/drag-drop.aspx)
* [Get Started with the Telerik UI for WPF DragAndDrop]({%slug dragdropmanager-getting-started%})
* [Telerik UI for WPF API Reference](https://docs.telerik.com/devtools/wpf/api/)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF DragAndDrop Forums](https://www.telerik.com/forums/wpf)
* [Telerik UI for WPF Knowledge Base](https://docs.telerik.com/devtools/wpf/knowledge-base)
{% endif %}

## See Also
 * [Developer Focused Examples]({%slug dragdropmanager-sdk-examples%})
 * [DragDropPayloadManager]({%slug dragdropmanager-dragdroppayloadmanager%})
