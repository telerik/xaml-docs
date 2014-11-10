---
title: Events Overview
page_title: Events Overview
description: Events Overview
slug: radslider-events-overview
tags: events,overview
published: True
position: 0
---

# Events Overview



This topic covers the specific events exposed by the __RadSlider__ control.
	  

## Drag Events

* __DragStarted__ - occurs when a user starts dragging a __Thumb__ control with the mouse. The event handler receives two arguments:
			

* The __sender__ argument contains the __RadSlider__. This argument is of type object, but can be cast to the __RadSlider__ type.
				

* A {% if site.site_name == 'Silverlight' %}[RadDragStartedEventArgs](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_raddragstartedeventargs.html){% endif %}{% if site.site_name == 'WPF' %}[RadDragStartedEventArgs](http://www.telerik.com/help/wpf/t_telerik_windows_controls_raddragstartedeventargs.html){% endif %} object.
				

* __DragDelta__ - occurs one or multiple times while a user drags a __Thumb__ control with the mouse. The event handler receives two arguments:
			

* The __sender__ argument contains the __RadSlider__. This argument is of type object, but can be cast to the __RadSlider__ type.
				

* A {% if site.site_name == 'Silverlight' %}[RadDragDeltaEventArgs](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_raddragdeltaeventargs.html){% endif %}{% if site.site_name == 'WPF' %}[RadDragDeltaEventArgs](	http://www.telerik.com/help/wpf/t_telerik_windows_controls_raddragdeltaeventargs.html){% endif %} object.
				

* __DragCompleted__ - occurs when a user completes a drag operation of a __Thumb__ control with the mouse.  The event handler receives two arguments:
			

* The __sender__ argument contains the __RadSlider__. This argument is of type object, but can be cast to the __RadSlider__ type.
				

* A {% if site.site_name == 'Silverlight' %}[RadDragCompletedEventArgs](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_raddragcompletedeventargs.html){% endif %}{% if site.site_name == 'WPF' %}[RadDragCompletedEventArgs](http://www.telerik.com/help/wpf/t_telerik_windows_controls_raddragcompletedeventargs.html){% endif %} object.
				

## Selection Events

* __SelectionStartChanged__ - occurs when the value of the __RadSlider.SelectionStart__ property is changed. The event handler receives two arguments:
			

* The __sender__ argument contains the __RadSlider__. This argument is of type object, but can be cast to the __RadSlider__ type.
				

* A __RoutedPropertyChangedEventArgs<double>__ object.
				

* __SelectionEndChanged__ - occurs when the value of the __RadSlider.SelectionEnd__ property is changed. The event handler receives two arguments:
			

* The __sender__ argument contains the __RadSlider__. This argument is of type object, but can be cast to the __RadSlider__ type.
				

* A __RoutedPropertyChangedEventArgs<double>__ object.
				

* __SelectionChanged__ - occurs when the value of the __RadSlider.Selection__ property is changed.  The event handler receives two arguments:
			

* The __sender__ argument contains the __RadSlider__. This argument is of type object, but can be cast to the __RadSlider__ type.
				

* A __RadRoutedEventArgs__ object.
				

# See Also

 * [Getting Started]({%slug radslider-declaration%})

 * [Selection Range]({%slug radslider-selection-range%})

 * [Keyboard and Mouse support]({%slug radslider-keyboard-mouse-support%})
