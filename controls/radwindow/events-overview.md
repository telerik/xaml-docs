---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadWindow {{ site.framework_name }} control.
slug: radwindow-events-overview
tags: events
published: True
position: 7
---

# {{ site.framework_name }} RadWindow Events

The __RadWindow__ is a __HeaderedContentControl__. Almost all of the exposed events are inherited by the __HeaderedContentControl__ class. The __RadWindow__ adds several additional events for the developers.

The __RadWindow__ raises the following specific events:

* __Activated__ - occurs each time the __RadWindow__ gets active. The event handler receives two arguments:

	* The sender argument contains the __RadWindow__. This argument is of type object, but can be cast to the __RadWindow__ type.

	* An __EventArgs__ object.

* __Closed__ - occurs after the __RadWindow__ gets closed. The event handler receives two arguments:

	* The sender argument contains the __RadWindow__. This argument is of type object, but can be cast to the __RadWindow__ type.

	* A {% if site.site_name == 'Silverlight' %}[WindowClosedEventArgs](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_windowclosedeventargs.html){% endif %}{% if site.site_name == 'WPF' %}[WindowClosedEventArgs](http://www.telerik.com/help/wpf/t_telerik_windows_controls_windowclosedeventargs.html){% endif %} object
	
{% if site.site_name == 'WPF' %}
* __HostCreated__ - occurs when the Host instance of __RadWindow__ gets created and right before __RadWindow__ is visualized. The event handler receives two arguments:

	* The sender argument contains __RadWindow__. This argument is of type object, but can be cast to __RadWindow__.

	* A __HostWindowCreatedEventArgs__.
{% endif %}

* __LayoutChangeStarted__ - occurs when a layout change operation begins (drag, resize). The event handler receives two arguments:

	* The sender argument contains the __RadWindow__. This argument is of type object, but can be cast to the __RadWindow__ type.

	* An __EventArgs__ object.

* __LayoutChangeEnded__ - occurs when a layout change operation ends (drag, resize). The event handler receives two arguments:

	* The sender argument contains the __RadWindow__. This argument is of type object, but can be cast to the __RadWindow__ type.

	* An __EventArgs__ object.

* __LocationChanged__ - occurs when the value of the __Left__ or the __Top__ properties changes. The event handler receives two arguments:

	* The sender argument contains the __RadWindow__. This argument is of type object, but can be cast to the __RadWindow__ type.

	* An __RoutedEventArgs__ object.

* __PreviewClosed__ - occurs right before the __RadWindow__ gets closed. The event handler receives two arguments:

	* The sender argument contains the __RadWindow__. This argument is of type object, but can be cast to the __RadWindow__ type.

	* A {% if site.site_name == 'Silverlight' %}[WindowPreviewClosedEventArgs](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_windowpreviewclosedeventargs.html){% endif %}{% if site.site_name == 'WPF' %}[WindowPreviewClosedEventArgs](http://www.telerik.com/help/wpf/t_telerik_windows_controls_windowpreviewclosedeventargs.html){% endif %} object.

* __WindowStateChanged__ - occurs when the value of the __WindowState__ property changes. The event handler receives two arguments:

	* The sender argument contains the __RadWindow__. This argument is of type object, but can be cast to the __RadWindow__ type.

	* An __EventArgs__ object.

## See Also

 * [Visual Structure]({%slug radwindow-visual-structure%})

 * [Working with RadWindow]({%slug radwindow-features-working-with-radwindow%})

 * [End-User Capabilities]({%slug radwindow-end-user-capabilities%})
