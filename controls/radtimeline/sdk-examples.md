---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radtimeline-sdk-examples
tags: sdk,examples
publish: True
position: 1
---

# SDK Examples



The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadTimeline__.

## List of all RadTimeline SDK examples:{% if site.site_name == 'WPF' %}

* __Annotations margin__ - The default top margin of a timeline annotation instance equals the height of the period items, positioned on top of the timeline line. You can change the default top margin value of an annotation instance using the Margin property.

* __Annotations source__ - The AnnotationsSource property specifies a collection, used to generate the annotations of the RadTimeline instance. When AnnotationsSource property is set, the Annotations collection is read-only.   - AnnotationStartPath property - The path to the StartDate source property.   - AnnotationDurationPath property - The path to the Duration source property.   - AnnotationZIndexPath property property - The path to the ZIndex source property.   - AnnotationContentPath property - The path to the Content source property.   - AnnotationContentTemplate property - A DataTemplate that defines the visualization of the content of the generated timeline annotations. The default is null. 

* __Annotations zIndex__ - The default top margin of a timeline annotation instance equals the height of the period items, positioned on top of the timeline line. You can change the default top margin value of an annotation instance using the Margin property.

* __Customizing items__ - There are two ways you can change the template for the RadTimeline items. You can either customize them with the use of ItemTemplateSelector, or with a TimelineItemTemplate / TimelineInstantItemTemplate property. This example will walk you through these two approaches:   - TimelineItemTemplate / TimelineInstantItemTemplate property   - ItemTemplateSelector

* __Data binding__ - This example aims to show you how easy and intuitive is to bind the RadTimeline control. 

* __Grouping__ - The timeline items in a RadTimeline control can be displayed in groups. Additionally, groups of timeline items can be made expandable/collapsible. This example demonstrates the following:   - Properties   - Group Expand Modes   - Changing the default collapsed state of expandable groups

* __Interval specific items__ - This example demonstrates how you can present interval specific items by changing the ItemsSource on the ItemIntervalChanged event.

* __MVVM Support__ - The RadTimeline control can be used with great success with the Model-View-ViewModel (MVVM) pattern. This example will demonstrate how to bind the control with the pattern. 

* __Scroll mode__ - The ScrollMode property of RadTimeline configures the horizontal scrolling and zooming behavior of control. 

* __Selection__ - This example will demonstrate how you can make the timeline more interactive by enabling and configuring the selection feature. 

* __Special slots__ - The purpose of this topic is to demonstrate how you may use the special slots feature of RadTimeBar. It provides the following four samples: 	 	-WeekDaysGenerator - It demonstrates a customizable slot, where the first day and the duration of the period can be set. 	-WorkDaysGenerator - It is a specific case of the WeekDaysGenerator, where the period Monday to Friday is marked for every week. 	-WeekendGenerator - Similarly to the WeekDaysGenerator, Saturday and Sunday are marked. 	-MonthDayGenerator - It is a customizable slot, where you have a reccuring day once in the month. For instance, every 15th day of the month.

* __Tooltips__ - RadTimeline supports tooltips for its items. You can specify a tooltip template and display the details of the item itself. The purpose of this example is to show you how this can be achieved. {% endif %}{% if site.site_name == 'Silverlight' %}

* __Annotations margin__ - The default top margin of a timeline annotation instance equals the height of the period items, positioned on top of the timeline line. You can change the default top margin value of an annotation instance using the Margin property.

* __Annotations source__ - The AnnotationsSource property specifies a collection, used to generate the annotations of the RadTimeline instance. When AnnotationsSource property is set, the Annotations collection is read-only.   - AnnotationStartPath property - The path to the StartDate source property.   - AnnotationDurationPath property - The path to the Duration source property.   - AnnotationZIndexPath property property - The path to the ZIndex source property.   - AnnotationContentPath property - The path to the Content source property.   - AnnotationContentTemplate property - A DataTemplate that defines the visualization of the content of the generated timeline annotations. The default is null. 

* __Annotations zIndex__ - The default top margin of a timeline annotation instance equals the height of the period items, positioned on top of the timeline line. You can change the default top margin value of an annotation instance using the Margin property.

* __Customizing items__ - There are two ways you can change the template for the RadTimeline items. You can either customize them with the use of ItemTemplateSelector, or with a TimelineItemTemplate / TimelineInstantItemTemplate property. This example will walk you through these two approaches:   - TimelineItemTemplate / TimelineInstantItemTemplate property   - ItemTemplateSelector

* __Data binding__ - This example aims to show you how easy and intuitive is to bind the RadTimeline control. 

* __Grouping__ - The timeline items in a RadTimeline control can be displayed in groups. Additionally, groups of timeline items can be made expandable/collapsible. This example demonstrates the following:   - Properties   - Group Expand Modes   - Changing the default collapsed state of expandable groups

* __Interval specific items__ - This example demonstrates how you can present interval specific items by changing the ItemsSource on the ItemIntervalChanged event.

* __MVVM Support__ - The RadTimeline control can be used with great success with the Model-View-ViewModel (MVVM) pattern. This example will demonstrate how to bind the control with the pattern. 

* __Scroll mode__ - The ScrollMode property of RadTimeline configures the horizontal scrolling and zooming behavior of control. 

* __Selection__ - This example will demonstrate how you can make the timeline more interactive by enabling and configuring the selection feature. 

* __Special slots__ - The purpose of this topic is to demonstrate how you may use the special slots feature of RadTimeBar. It provides the following four samples: 	 	-WeekDaysGenerator - It demonstrates a customizable slot, where the first day and the duration of the period can be set. 	-WorkDaysGenerator - It is a specific case of the WeekDaysGenerator, where the period Monday to Friday is marked for every week. 	-WeekendGenerator - Similarly to the WeekDaysGenerator, Saturday and Sunday are marked. 	-MonthDayGenerator - It is a customizable slot, where you have a reccuring day once in the month. For instance, every 15th day of the month.

* __Tooltips__ - RadTimeline supports tooltips for its items. You can specify a tooltip template and display the details of the item itself. The purpose of this example is to show you how this can be achieved. {% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).

# See Also
