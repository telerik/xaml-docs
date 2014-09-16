---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radtimebar-sdk-examples
tags: sdk,examples
published: True
position: 1
---

# SDK Examples



The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadTimeBar__.

## List of all RadTimeBar SDK examples:{% if site.site_name == 'WPF' %}

* __Create time bar code behind__ - RadTimeBar supports lightweight batch initialization through the ISupportInitialize interface. You can use the methods of this interface in code behind to create and initialize a time bar before adding it in the visual tree. 

* __Events__ - You can handle the following events when using the RadTimeBar for a very rich user experience with the control: · GroupIntervalChanged - Fires when interval groups drill level changed. · HoveredPeriodChanged - Fires when the time period hovered changes. · ItemIntervalChanged - Fires when the interval items drill level changed. · VisiblePeriodChanged - Fires when the period that is currently visible has changed as we scroll and zoom within the control. · SelectionChanged - Fires when the time period selected has changed.

* __Hide selection range title__ - The purpose of this topic is to demonstrate how you may hide the range title that is visible with selection range. This will be achieved with completely implicit styles instead of the old way of styling which was used in Styling Items and Groups example.

* __Localization__ - The built-in localization mechanism in Silverlight and WPF (which is available since Q2 2011) allows you to localize any string resource used by the standard RadTimeBar control. Once translated you might use your resources in both Silverlight and WPF projects without changing anything.

* __MVVM support__ - The Telerik RadTimeBar control can be used with great success with the Model-View-ViewModel (MVVM) pattern. This help topic will demonstrate how to use the control with the pattern.

* __RadTimeBar overview__ - The RadTimeBar is a time bound DataVisualization control. Its chief purpose is to allow lightweight scrolling and navigation through large periods of time. Additionally, the control exposes intuitive API which allows for both declarative and programmatic manipulation of the control.

* __RadTimeBar properties__ - There is a required precedence of the TimeBar's properties. This means that the Start Time should always be set before the End Time. A required precedence of Properties is given in this example.

* __Scroll modes__ - The ScrollMode property of RadTimeBar configures the horizontal scrolling and zooming behavior of the control. 

* __Special slots__ - The purpose of this topic is to demonstrate how you may use the special slots feature of RadTimeBar. It provides the following four samples: 	 	-WeekDaysGenerator - It demonstrates a customizable slot, where the first day and the duration of the period can be set. 	-WorkDaysGenerator - It is a specific case of the WeekDaysGenerator, where the period Monday to Friday is marked for every week. 	-WeekendGenerator - Similarly to the WeekDaysGenerator, Saturday and Sunday are marked. 	-MonthDayGenerator - It is a customizable slot, where you have a reccuring day once in the month. For instance, every 15th day of the month.

* __Styling items and groups__ - This section is intended to give you a broad understanding of the possible way in which you can customize the visual appearance of the RadTimeBar. 

* __Timeline inside TimeBar__ - The example demonstrates how a RadTimeline control can be added as content of a RadTimebar control.{% endif %}{% if site.site_name == 'Silverlight' %}

* __Create time bar code behind__ - RadTimeBar supports lightweight batch initialization through the ISupportInitialize interface. You can use the methods of this interface in code behind to create and initialize a time bar before adding it in the visual tree. 

* __Events__ - You can handle the following events when using the RadTimeBar for a very rich user experience with the control: · GroupIntervalChanged - Fires when interval groups drill level changed. · HoveredPeriodChanged - Fires when the time period hovered changes. · ItemIntervalChanged - Fires when the interval items drill level changed. · VisiblePeriodChanged - Fires when the period that is currently visible has changed as we scroll and zoom within the control. · SelectionChanged - Fires when the time period selected has changed.

* __Hide selection range title__ - The purpose of this topic is to demonstrate how you may hide the range title that is visible with selection range. This will be achieved with completely implicit styles instead of the old way of styling which was used in Styling Items and Groups example.

* __Localization__ - The built-in localization mechanism in Silverlight and WPF (which is available since Q2 2011) allows you to localize any string resource used by the standard RadTimeBar control. Once translated you might use your resources in both Silverlight and WPF projects without changing anything.

* __MVVM support__ - The Telerik RadTimeBar control can be used with great success with the Model-View-ViewModel (MVVM) pattern. This help topic will demonstrate how to use the control with the pattern.

* __RadTimeBar overview__ - The RadTimeBar is a time bound DataVisualization control. Its chief purpose is to allow lightweight scrolling and navigation through large periods of time. Additionally, the control exposes intuitive API which allows for both declarative and programmatic manipulation of the control.

* __RadTimeBar properties__ - There is a required precedence of the TimeBar's properties. This means that the Start Time should always be set before the End Time. A required precedence of Properties is given in this example.

* __Scroll modes__ - The ScrollMode property of RadTimeBar configures the horizontal scrolling and zooming behavior of the control. 

* __Special slots__ - The purpose of this topic is to demonstrate how you may use the special slots feature of RadTimeBar. It provides the following four samples: 	 	-WeekDaysGenerator - It demonstrates a customizable slot, where the first day and the duration of the period can be set. 	-WorkDaysGenerator - It is a specific case of the WeekDaysGenerator, where the period Monday to Friday is marked for every week. 	-WeekendGenerator - Similarly to the WeekDaysGenerator, Saturday and Sunday are marked. 	-MonthDayGenerator - It is a customizable slot, where you have a reccuring day once in the month. For instance, every 15th day of the month.

* __Styling items and groups__ - This section is intended to give you a broad understanding of the possible way in which you can customize the visual appearance of the RadTimeBar. 

* __Timeline inside TimeBar__ - The example demonstrates how a RadTimeline control can be added as content of a RadTimebar control.{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).

# See Also
