---
title: SDK Examples
page_title: SDK Examples
description: SDK Examples
slug: radtimeline-sdk-examples
tags: sdk,examples
published: True
position: 1
---

# SDK Examples

The [Telerik XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/) provides additional demos for most of the Telerik UI for {% if site.site_name == 'WPF' %}WPF{% endif %}{% if site.site_name == 'Silverlight' %}Silverlight{% endif %} controls. The examples demonstrate many specific user case scenarios, that might be really helpful. In this article you can find the complete list of all SDK examples for __RadTimeline__.

## List of all RadTimeline SDK examples:

{% if site.site_name == 'WPF' %}

* __[Annotations margin](https://github.com/telerik/xaml-sdk/tree/master/Timeline/WPF/AnnotationsMargin)__ - The default top margin of a timeline annotation instance equals the height of the period items, positioned on top of the timeline line. You can change the default top margin value of an annotation instance using the Margin property.
* __[Annotations source](https://github.com/telerik/xaml-sdk/tree/master/Timeline/WPF/AnnotationsSource)__ - The AnnotationsSource property specifies a collection, used to generate the annotations of the RadTimeline instance. When AnnotationsSource property is set, the Annotations collection is read-only.   - AnnotationStartPath property - The path to the StartDate source property.   - AnnotationDurationPath property - The path to the Duration source property.   - AnnotationZIndexPath property property - The path to the ZIndex source property.   - AnnotationContentPath property - The path to the Content source property.   - AnnotationContentTemplate property - A DataTemplate that defines the visualization of the content of the generated timeline annotations. The default is null. 
* __[Annotations zIndex](https://github.com/telerik/xaml-sdk/tree/master/Timeline/WPF/AnnotationsZIndex)__ - The default top margin of a timeline annotation instance equals the height of the period items, positioned on top of the timeline line. You can change the default top margin value of an annotation instance using the Margin property.
* __[Custom interval types](https://github.com/telerik/xaml-sdk/tree/master/Timeline/WPF/CustomIntervalTypes)__ - The purpose of this example is to demonstrate how you can create a custom interval type and use it in a RadTimeline control. The demo demonstrates a custom interval type with duration of 6 months and the following format strings:

1. My custom interval {0}, {1}
2. Custom interval {0}
3. C{0} {1}
* __[Customizing items](https://github.com/telerik/xaml-sdk/tree/master/Timeline/WPF/CustomizingItems)__ - There are two ways you can change the template for the RadTimeline items. You can either customize them with the use of ItemTemplateSelector, or with a TimelineItemTemplate / TimelineInstantItemTemplate property. This example will walk you through these two approaches:   - TimelineItemTemplate / TimelineInstantItemTemplate property   - ItemTemplateSelector
* __[Data binding](https://github.com/telerik/xaml-sdk/tree/master/Timeline/WPF/DataBinding)__ - This example aims to show you how easy and intuitive is to bind the RadTimeline control. 
* __[Grouping](https://github.com/telerik/xaml-sdk/tree/master/Timeline/WPF/Grouping)__ - The timeline items in a RadTimeline control can be displayed in groups. Additionally, groups of timeline items can be made expandable/collapsible. This example demonstrates the following:   - Properties   - Group Expand Modes   - Changing the default collapsed state of expandable groups
* __[Interval specific items](https://github.com/telerik/xaml-sdk/tree/master/Timeline/WPF/IntervalSpecificItems)__ - This example demonstrates how you can present interval specific items by changing the ItemsSource on the ItemIntervalChanged event.
* __[MVVM Support](https://github.com/telerik/xaml-sdk/tree/master/Timeline/WPF/MvvmSupport)__ - 
The RadTimeline control can be used with great success with the Model-View-ViewModel (MVVM) pattern. This example will demonstrate how to bind the control with the pattern. 
* __[Scroll mode](https://github.com/telerik/xaml-sdk/tree/master/Timeline/WPF/ScrollMode)__ - The ScrollMode property of RadTimeline configures the horizontal scrolling and zooming behavior of control. 
* __[Selection](https://github.com/telerik/xaml-sdk/tree/master/Timeline/WPF/Selection)__ - This example will demonstrate how you can make the timeline more interactive by enabling and configuring the selection feature. 
* __[Special slots](https://github.com/telerik/xaml-sdk/tree/master/Timeline/WPF/SpecialSlots)__ - The purpose of this topic is to demonstrate how you may use the special slots feature of RadTimeline. It provides the following four samples:
	
	-WeekDaysGenerator - It demonstrates a customizable slot, where the first day and the duration of the period can be set.
	-WorkDaysGenerator - It is a specific case of the WeekDaysGenerator, where the period Monday to Friday is marked for every week.
	-WeekendGenerator - Similarly to the WeekDaysGenerator, Saturday and Sunday are marked.
	-MonthDayGenerator - It is a customizable slot, where you have a reccuring day once in the month. For instance, every 15th day of the month.
* __[Timeline item row index](https://github.com/telerik/xaml-sdk/tree/master/Timeline/WPF/TimelineItemRowIndex)__ - The purpose of this example is to demonstrate how you can customize the default vertical positioning logic of RadTimeline. There are three approaches:

1. The first approach is to specify a larger minimum gap between items using the MinimumItemGap property. This value is taken into account when calculating whether the span of an item overlaps the span of an already positioned item.
2. The second approach is to simply turn off the ordering by StartDate and Duration using the AutoSort property.
3. The third approach includes specifying your own custom vertical positioning logic using the ItemRowIndexGenerator property.
* __[Tooltips](https://github.com/telerik/xaml-sdk/tree/master/Timeline/WPF/Tooltips)__ - RadTimeline supports tooltips for its items. You can specify a tooltip template and display the details of the item itself. The purpose of this example is to show you how this can be achieved. 
{% endif %}
{% if site.site_name == 'Silverlight' %}
* __[Annotations margin](https://github.com/telerik/xaml-sdk/tree/master/Timeline/SL/AnnotationsMargin)__ - The default top margin of a timeline annotation instance equals the height of the period items, positioned on top of the timeline line. You can change the default top margin value of an annotation instance using the Margin property.
* __[Annotations source](https://github.com/telerik/xaml-sdk/tree/master/Timeline/SL/AnnotationsSource)__ - The AnnotationsSource property specifies a collection, used to generate the annotations of the RadTimeline instance. When AnnotationsSource property is set, the Annotations collection is read-only.   - AnnotationStartPath property - The path to the StartDate source property.   - AnnotationDurationPath property - The path to the Duration source property.   - AnnotationZIndexPath property property - The path to the ZIndex source property.   - AnnotationContentPath property - The path to the Content source property.   - AnnotationContentTemplate property - A DataTemplate that defines the visualization of the content of the generated timeline annotations. The default is null. 
* __[Annotations zIndex](https://github.com/telerik/xaml-sdk/tree/master/Timeline/SL/AnnotationsZIndex)__ - The default top margin of a timeline annotation instance equals the height of the period items, positioned on top of the timeline line. You can change the default top margin value of an annotation instance using the Margin property.
* __[Custom interval types](https://github.com/telerik/xaml-sdk/tree/master/Timeline/SL/CustomIntervalTypes)__ - The purpose of this example is to demonstrate how you can create a custom interval type and use it in a RadTimeline control. The demo demonstrates a custom interval type with duration of 6 months and the following format strings:

1. My custom interval {0}, {1}
2. Custom interval {0}
3. C{0} {1}
* __[Customizing items](https://github.com/telerik/xaml-sdk/tree/master/Timeline/SL/CustomizingItems)__ - There are two ways you can change the template for the RadTimeline items. You can either customize them with the use of ItemTemplateSelector, or with a TimelineItemTemplate / TimelineInstantItemTemplate property. This example will walk you through these two approaches:   - TimelineItemTemplate / TimelineInstantItemTemplate property   - ItemTemplateSelector
* __[Data binding](https://github.com/telerik/xaml-sdk/tree/master/Timeline/SL/DataBinding)__ - This example aims to show you how easy and intuitive is to bind the RadTimeline control. 
* __[Grouping](https://github.com/telerik/xaml-sdk/tree/master/Timeline/SL/Grouping)__ - The timeline items in a RadTimeline control can be displayed in groups. Additionally, groups of timeline items can be made expandable/collapsible. This example demonstrates the following:   - Properties   - Group Expand Modes   - Changing the default collapsed state of expandable groups
* __[Interval specific items](https://github.com/telerik/xaml-sdk/tree/master/Timeline/SL/IntervalSpecificItems)__ - This example demonstrates how you can present interval specific items by changing the ItemsSource on the ItemIntervalChanged event.
* __[MVVM Support](https://github.com/telerik/xaml-sdk/tree/master/Timeline/SL/MvvmSupport)__ - 
The RadTimeline control can be used with great success with the Model-View-ViewModel (MVVM) pattern. This example will demonstrate how to bind the control with the pattern. 
* __[Scroll mode](https://github.com/telerik/xaml-sdk/tree/master/Timeline/SL/ScrollMode)__ - The ScrollMode property of RadTimeline configures the horizontal scrolling and zooming behavior of control. 
* __[Selection](https://github.com/telerik/xaml-sdk/tree/master/Timeline/SL/Selection)__ - This example will demonstrate how you can make the timeline more interactive by enabling and configuring the selection feature. 
* __[Special slots](https://github.com/telerik/xaml-sdk/tree/master/Timeline/SL/SpecialSlots)__ - The purpose of this topic is to demonstrate how you may use the special slots feature of RadTimeBar. It provides the following four samples:
	
	-WeekDaysGenerator - It demonstrates a customizable slot, where the first day and the duration of the period can be set.
	-WorkDaysGenerator - It is a specific case of the WeekDaysGenerator, where the period Monday to Friday is marked for every week.
	-WeekendGenerator - Similarly to the WeekDaysGenerator, Saturday and Sunday are marked.
	-MonthDayGenerator - It is a customizable slot, where you have a reccuring day once in the month. For instance, every 15th day of the month.
* __[Timeline item row index](https://github.com/telerik/xaml-sdk/tree/master/Timeline/SL/TimelineItemRowIndex)__ - The purpose of this example is to demonstrate how you can customize the default vertical positioning logic of RadTimeline. There are three approaches:

1. The first approach is to specify a larger minimum gap between items using the MinimumItemGap property. This value is taken into account when calculating whether the span of an item overlaps the span of an already positioned item.
2. The second approach is to simply turn off the ordering by StartDate and Duration using the AutoSort property.
3. The third approach includes specifying your own custom vertical positioning logic using the ItemRowIndexGenerator property.
* __[Tooltips](https://github.com/telerik/xaml-sdk/tree/master/Timeline/SL/Tooltips)__ - RadTimeline supports tooltips for its items. You can specify a tooltip template and display the details of the item itself. The purpose of this example is to show you how this can be achieved. 
{% endif %}

>You can also check the [SDK Samples Browser]({%slug sdk-samples-browser%}) that provides a more convenient approach in exploring and executing the examples in the Telerik XAML SDK repository. The SDK Samples Browser application is available for download from [this link](http://demos.telerik.com/xaml-sdkbrowser/).