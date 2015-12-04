---
title: Events
page_title: Events
description: Events
slug: radmap-events
tags: events
published: True
position: 7
---

# Events

This topic covers the specific events exposed by the __RadMap__ control.

The __RadMap__ control raises the following specific events:

* __CenterChanged__ - occurs when the __Center__ property of the __RadMap__ control is changed. You can use this event, for example, to prevent user from changing a center of the map or to get the new value of the center location. The event handler receives two arguments: 
	* The sender argument contains the __RadMap__. This argument is of type object, but can be cast to the __RadMap__ type.
	* An __EventArgs__ object.

* __InitializeCompleted__ - occurs when the map provider has been initialized and the map images are ready to be displayed. You can use this event to display the __InformationLayer__, as it guarantees that the elements inside of it will be displayed correctly. The event handler receives two arguments: 
	* The sender argument contains the __RadMap__. This argument is of type object, but can be cast to the __RadMap__ type.
	* An __EventArgs__ object.

* __MapMouseClick__ - occurs when the left mouse button is clicked a single time. You can use the __MouseClickMode__ property to choose one of the predefined single click behaviors or you can implement your own using the event. The event handler receives two arguments:
	* The sender argument contains the __RadMap__. This argument is of type object, but can be cast to the __RadMap__ type.
	* {% if site.site_name == 'WPF' %} A [MapMouseRoutedEventArgs](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Controls_Map_MapMouseRoutedEventArgs.htm).{% endif %}{% if site.site_name == 'Silverlight' %} A [MapMouseRoutedEventArgs](http://docs.telerik.com/devtools/silverlight/api/html/T_Telerik_Windows_Controls_Map_MapMouseRoutedEventArgs.htm).{% endif %}

* __MapMouseDoubleClick__ - occurs when the left mouse button is double clicked. You can use the __MouseDoubleClickMode__ property to choose one of the predefined double click behaviors  or you can implement your own using the event. The event handler receives two arguments:
	* The sender argument contains the __RadMap__. This argument is of type object, but can be cast to the __RadMap__ type.
	* * {% if site.site_name == 'WPF' %} A [MapMouseRoutedEventArgs](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Controls_Map_MapMouseRoutedEventArgs.htm).{% endif %}{% if site.site_name == 'Silverlight' %} A [MapMouseRoutedEventArgs](http://docs.telerik.com/devtools/silverlight/api/html/T_Telerik_Windows_Controls_Map_MapMouseRoutedEventArgs.htm).{% endif %}
	
* __PanningFinished__ - occurs when the panning executed by the user finishes. The event handler receives two arguments:
	* The sender argument contains the __RadMap__. This argument is of type object, but can be cast to the __RadMap__ type.
	* A __RoutedEventArgs__ object.

* __ZoomChanged__ - occurs when the __ZoomLevel__ changes its value. The event handler receives two arguments:
	* The sender argument contains the __RadMap__. This argument is of type object, but can be cast to the __RadMap__ type.
	* An __EventArgs__ object.

* __ZoomFinished__ - occurs when the zooming action executed by the user finishes. The event handler receives two arguments:
	* The sender argument contains the __RadMap__. This argument is of type object, but can be cast to the __RadMap__type.
	* A __RoutedEventArgs__ object.

# See Also
 * [Visual Structure]({%slug radmap-visual-structure%})
 * [Getting Started]({%slug radmap-getting-started%})
 * [Localization]({%slug radmap-localization%})
 * [Events]({%slug radmap-events%})