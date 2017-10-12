---
title: Overview
page_title: Overview
description: Overview
slug: touchmanager-overview
tags: overview,touch,manager,touchmanager
published: True
position: 0
---

# TouchManager Overview

{% if site.site_name == 'Silverlight' %}
![Touch Manager](images/touchmanager_overview_01_SL.png)
{% endif %}
{% if site.site_name == 'WPF' %}
![Touch Manger](images/touchmanager_overview_01_WPF.png)
{% endif %}

__TouchManager__ is a framework that provides an intuitive API for handling the interaction on touch devices. The framework allows you to subscribe to touch events and control the touch hit test visibility of the elements in the visual tree. 

> __TouchManager__ is used for implementing the touch support of the controls in the UI for WPF suite.

## Features

__TouchManager__ has the following key features:

* __Rich event handling__: TouchManager provides a set of events that can be used to handle the touch interaction within your application. Using the framework you can associate a UIElement to different touch interactions as touch down, touch move, touch enter, swipe, tap, pinch, etc. You can find a complete list with the events exposed by the manager in the [Events]({%slug touchmanager-events%}) help article.

* __Hit test visibility control__: Touchmanager allows you to define the hit test visibility of the elements involved in the touch interaction. You can take a look at the [Touch Modes]({%slug touchmanager-touch-modes%}) help article for more information.

* __Gestures__: TouchManager gives you several built-in gestures (tap, pinch, swipe, etc.) and also the ability to create custom gestures.

* __Creating custom gestures__: TouchManager allows you to create custom gestures to trace specific patterns or movements. You can find more information about creating custom gestures in the [Custom Gestures]({%slug touchmanager-custom-gestures-overview%}) section of the TouchManager documentation.

> You can find an example that demonstrates TouchManager in our {% if site.site_name == 'Silverlight' %}[demo application](https://demos.telerik.com/silverlight/){% endif %}{% if site.site_name == 'WPF' %}[demo application](https://demos.telerik.com/wpf/){% endif %}. 

> See the [Touch Support]({%slug touch-support%}) help article for more information about the touch support in {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}

## See Also
* [Getting Started]({%slug touchmanager-getting-started%})
* [Events]({%slug touchmanager-events%})
* [Features]({%slug touchmanager-features%})
* [Touch Modes]({%slug touchmanager-touch-modes%})
