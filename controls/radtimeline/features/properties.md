---
title: Properties
page_title: Properties
description: Check our &quot;Properties&quot; documentation article for the RadTimeline {{ site.framework_name }} control.
slug: radtimeline-properties
tags: properties
published: True
position: 0
---

# Properties

This help topic will make you familiar with the most important properties, settings and elements of the RadTimeline control.


* __AnnotationContentTemplate__: A property of type __DataTemplate__ that gets or sets the annotation content template.
* __AnnotationContentPath__: A property of type __string__ that gets or sets the annotation content path.
* __AnnotationDurationPath__: A property of type __string__ that gets or sets the duration of the annotation.
* __AnnotationZIndexPath__: A property of type __string__ that gets or sets the annotation z-index path.
* __AnnotationStartPath__: A property of type __string__ that gets or sets the annotation start path.
* __Annotations__: A property of type __string__ that gets or sets the annotations path.
* __AnnotationsSource__: A property of type __IEnumerable__ that gets or sets the annotation source.
* __TimelineInstantItemTemplate__: A property of type __DataTemplate__ that gets or sets the instant event template.
* __TimelineItemTemplate__: A property of type __DataTemplate__ that gets or sets the event template.
* __ToolTipTemplate__: A property of type __DataTemplate__ that gets or sets the template of the __ToolTip__.
* __ToolTipFormat__: A property of type __string__ that gets or sets the ToolTip format.
* __ToolTipPath__: A property of type __string__ that gets or sets the ToolTip path.
* __SelectedItems__: A property of type __IList__ that gets the selected items.
* __SelectedItem__: A property of type __object__ that gets or sets the selected item.
* __SelectionMode__: An enumeration property of type __SelectionMode__ that gets or sets the selection mode of the control: __(Single, Multiple, and Extended)__
* __IsSelectionEnabled__: A property of type __bool__ that disables or enables the selection functionality of the control.
* __GroupExpandMode__: A enumeration property of type __GroupExpandMode__ that gets or sets the group expand mode of the groups: __(None, Single, and Multiple)__
* __GroupPath__: A property of type __string__ that gets or sets the group path.
* __MinimumItemGap__: A property of type __TimeSpan__ that gets or sets the minimum gap between two items on the same row.
* __AutoSort__: A property of type __bool__ that indicates if the timeline items will be ordered automatically by Start and Duration or not.
* __VerticalScrollBarVisibility__: An enumeration property of type __ScrollBarVisibility__ that shows or hides the vertical ScrollBar.
* __DataItems__: A property of type __IEnumerable\<TimelineDataItem\>__ that returns a collection of Timeline items.
* __GroupedDataItems__: A property of type __IEnumerable\<TimelineDataItemGroup\>__ that returns a collection of the grouped items.
* __DataGroups__: A property of type __List\<TimelineGroupData\>__ that returns a collection of a group of none intersecting items.
* __ItemRowIndexGenerator__: A property of type __IItemRowIndexGenerator__ that gets or sets IItemRowIndexGenerator instance that generates row indexes for the items based on custom logic.
* __StartPath__: A property of type __string__ that gets or sets the name of the property from the underlying datasource, which will determine the start time for the data.
* __DurationPath__: A property of type __string__ that gets or sets the name of the property from the underlying datasource, which will determine the end time for the data.
* __PeriodStart and PeriodEnd__: These properties are of type __DateTime__ and determine the start and end time period in the Timeline control.
* __Intervals__: Currently the supported intervals are:
	* Century
	* Decade
	* Year
	* Quarter
	* Month
	* Week
	* Day
	* Hour
	* Minute
	* Second
	* Millisecond
	
__Example 1: Setting the RadTimeline Intervals__

```XAML
	 <telerik:RadTimeline.Intervals>
	       <telerik:CenturyInterval />
	       <telerik:DecadeInterval />
	       <telerik:YearInterval />
	       <telerik:MonthInterval/>
	  </telerik:RadTimeline.Intervals>
```

* __IntervalSpans__:  It is used to group the given interval items together. __Example 2__ shows how you can group the seconds in groups of 10. __Example 3__ demonstrates that you can also set more than one *IntervalSpan* simultaneously by separating them with comma.
        
__Example 2: Setting the IntervalSpans__

```XAML
	<telerik:RadTimeline.Intervals>
	   <telerik:YearInterval IntervalSpans="10"/>
	</telerik:RadTimeline.Intervals>
```   

__Example 3: Setting multiple IntervalSpans__

```XAML
	<telerik:RadTimeline.Intervals>
	   <telerik:YearInterval IntervalSpans="1,5" />
	   <telerik:MonthInterval IntervalSpans="1,6" />
	</telerik:RadTimeline.Intervals>
```

* __MinZoomRange__ and __MaxZoomRange__: These properties set the minimum and maximum range that the TimeLine can be zoomed.

{% if site.framework_name == 'Silverlight' %}
> The MinZoomRange cannot be set to lower than 30000 pixels. 
{% endif %}

## See Also

* [Getting Started]({%slug radtimeline-getting-started%})