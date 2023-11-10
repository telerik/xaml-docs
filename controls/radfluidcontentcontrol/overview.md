---
title: Overview
page_title: Overview
description: RadFluidContentControl is a flexible content control used to built responsive layouts.
slug: fluidcontentcontrol-overview
tags: overview
published: True
position: 0
CTAControlName: RadFluidContentControl
---

# {{ site.framework_name }} FluidContentControl Overview

__RadFluidContentControl__ is a flexible content control used to build responsive layouts. In its nature the control is a ContentControl, but instead of a single content it can define three that can be switched under specific conditions. By default the condition is the size of the control. So, you can show different content based on the size of the application.

{% if site.has_cta_panels == true %}
{% include cta-panel-overview.html %}
{% endif %}

![radfluidcontentcontrol-overview-01](images/radfluidcontentcontrol-overview-0.png)

## Key Features

* __Flexible content switching__: The control allows you to easily switch between the three content views (small, normal and large). The switching happens if the control reaches a specific resolution or if you manually set up the current state.

* __Customizable transition animation__: RadFluidContentControl comes with a transition animation support. Additionally, you can define a custom transition to enrich the user experience. Read more about this in the [Transitions]({%slug fluidcontentcontrol-transitions%}) article.

* __Data binding support__: The control provides several bindable properties for the different contents along with corresponding ContentTemplate properties. Read more about this in the [Data Binding]({%slug fluidcontentcontrol-data-binding%}) article.

>tip Get started with the control with its [Getting Started]({%slug fluidcontentcontrol-getting-started%}) help article that shows how to use it in a basic scenario.

{% if site.site_name == 'WPF' %}
## Telerik UI for WPF Support and Learning Resources

* [Telerik UI for WPF FluidContentControl Homepage](empty)
* [Get Started with the Telerik UI for WPF FluidContentControl]({%slug fluidcontentcontrol-getting-started%})
* [Telerik UI for WPF API Reference](https://docs.telerik.com/devtools/wpf/api/)
* [Getting Started with Telerik UI for WPF Components]({%slug getting-started-first-steps%})
* [Telerik UI for WPF Virtual Classroom (Training Courses for Registered Users)](https://learn.telerik.com/learn/course/external/view/elearning/16/telerik-ui-for-wpf) 
* [Telerik UI for WPF FluidContentControl Forums](https://www.telerik.com/forums/wpf)
* [Telerik UI for WPF Knowledge Base](https://docs.telerik.com/devtools/wpf/knowledge-base)
{% endif %}

## See Also
 * [Integration Examples]({%slug radfluidcontentcontrol-integration-examples%})
 * [Events]({%slug fluidcontentcontrol-events%})
