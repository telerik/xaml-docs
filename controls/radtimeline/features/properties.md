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

## Supported Data Sources

The control can be bound to data from a variety of data sources in the form of common language runtime (CLR) objects and XML - see the list of the supported data sources bellow.         

* [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) - supports simple iteration of a collection. See the MSDN article for more on [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx).         
* [ICollection](http://msdn.microsoft.com/en-us/library/system.collections.icollection.aspx) - extends [IEnumerable](http://msdn.microsoft.com/en-us/library/system.collections.ienumerable.aspx) and supports size, enumerator, and synchronization methods for collections.          
* [IList](http://msdn.microsoft.com/en-us/library/system.collections.ilist.aspx) - extends [ICollection](http://msdn.microsoft.com/en-us/library/system.collections.icollection.aspx) and is the base class for lists.          

## Change Notification Support

__RadTimeline__ also provides full support for change notifications - changes in data sources that implement the [INotifyCollectionChanged](http://msdn.microsoft.com/en-us/library/system.collections.specialized.inotifycollectionchanged.aspx), as well as [INotifyPropertyChanged](http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged(VS.95).aspx%20),  are properly tracked and reflected by the UI.        
## Key Properties

* __StartPath__: Sets the name of the property from the underlying datasource, which will determine the start time for the data.
* __DurationPath__: Sets the name of the property from the underlying datasource, which will determine the end time for the data.
* __VisiblePeriodStart and VisiblePeriodEnd__: Set the names of the properties from the underlying datasource, which will determine the visible start and end time for the data.
* __PeriodStart and PeriodEnd__: These properties determine the start and end time period in the Timeline control.
* __Intervals__: Determines the displayed time intervals. The supported intevals are: __Century__, __Decade__, __Year__, __Quarter__, __Month__, __Week__, __Day__, __Hour__, __Minute__, __Second__, __Millisecond__.

#### __[XAML] Example 1: Setting the RadTimeline Intervals__

{{region xaml-radtimeline-properties_0}}
	 <telerik:RadTimeline.Intervals>
	       <telerik:CenturyInterval />
	       <telerik:DecadeInterval />
	       <telerik:YearInterval />
	       <telerik:MonthInterval/>
	  </telerik:RadTimeline.Intervals>
{{endregion}}

* __IntervalSpans__:  It is used to group the given interval items together. __Example 2__ shows how you can group the seconds in groups of 10. __Example 3__ demonstrates that you can also set more than one *IntervalSpan* simultaneously by separating them with comma.
        
#### __[XAML] Example 2: Setting the IntervalSpans__

{{region radtimeline-properties_1}}
	<telerik:RadTimeline.Intervals>
	   <telerik:YearInterval IntervalSpans="10"/>
	</telerik:RadTimeline.Intervals>
{{endregion}}   

#### __[XAML] Example 3: Setting multiple IntervalSpans__

{{region radtimeline-properties_2}}
	<telerik:RadTimeline.Intervals>
	   <telerik:YearInterval IntervalSpans="1,5" />
	   <telerik:MonthInterval IntervalSpans="1,6" />
	</telerik:RadTimeline.Intervals>
{{endregion}}

* __MinZoomRange__ and __MaxZoomRange__: These properties set the minimum and maximum range that the TimeLine can be zoomed.

{% if site.framework_name == 'Silverlight' %}
> The MinZoomRange cannot be set to lower than 30000 pixels. 
{% endif %}

## See Also

* [Getting Started]({%slug radtimeline-getting-started%})