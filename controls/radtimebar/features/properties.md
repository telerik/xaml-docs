---
title: Properties
page_title: Properties
description: Check our &quot;Properties&quot; documentation article for the RadTimeBar {{ site.framework_name }} control.
slug: radtimebar-properties
tags: properties
published: True
position: 0
---

# Properties

When setting up the RadTimeBar you should keep in mind that the __Start Time__ properties should always be set before the __End Time__ ones. __Example 1__ shows the required precedence of the properties.

__Example 1: RadTimeBar Properties Precedence__

<snippet id='radtimebar-features-properties-block_1-xaml' />

## Key Properties
	
* __PeriodStart__: Gets or sets the timebar's start date.
* __PeriodEnd__: Gets or sets the timebar's end date.
* __VisiblePeriodStart__: Gets or sets the currently visible start date.
* __VisiblePeriodEnd__: Gets or sets the currently visible end date.
* __Intervals__: Determines the displayed time intervals. The supported intevals are: __Century__, __Decade__, __Year__, __Quarter__, __Month__, __Week__, __Day__, __Hour__, __Minute__, __Second__, __Millisecond__.

__Example 2: Setting the RadTimeBar Intervals__

<snippet id='radtimebar-features-properties-block_2-xaml' />

Every interval has a preset collection of formatting strings that creates the string representation of a given date to match the interval. RadTimeBar automatically chooses the appropriate string formatter according to the control size and visible range. Learn more about that in the [Intervals Formatters]({%slug radtimebar-intervals-formatters%}) article.

* __SelectionStart__ and __SelectionEnd__: These properties determine the beginning of the selected range in the TimeBar control.

* __ActualSelectionStart__ and __ActualSelectionEnd__: When the user is dragging one of the selection thumbs, the SelectionStart and SelectionEnd properties are updated once the user releases the selection thumb. On the other hand, the ActualSelectionStart and ActualSelectionEnd properties are updated while the selection thumbs are moving.

* __IsSnapToIntervalEnabled__: This turns on the snapping functionality, which will restrict the moving of the selection thumb, so that it will snap to the items' lines.

* __MinSelectionRange__ and __MaxSelectionRange__: These properties define the selection range interval. You won't be able to select an interval lower than the MinSelectionRange and higher than MaxSelectionRange.

* __IntervalSpans__: This property can be set from each Interval except Decade and Quarter. It is used to group the given interval items together. __Example 3__ shows how you can group the seconds in groups of 10. __Example 4__ demonstrates that you can also set more than one *IntervalSpan* simultaneously by separating them with comma.

__Example 3: Setting the IntervalSpans__

<snippet id='radtimebar-features-properties-block_3-xaml' />

__Example 4: Setting multiple IntervalSpans__

<snippet id='radtimebar-features-properties-block_4-xaml' />

* __CurrentItemInterval__ and __CurrentGroupInterval__: These properties can be used in code-behind to take the current item respectively group interval span set.

* __MinZoomRange__ and __MaxZoomRange__: These properties set the minimum and maximum range that the TimeBar can be zoomed.

{% if site.framework_name == 'Silverlight' %}
> The MinZoomRange cannot be set to 
{% endif %}

## See Also

* [Getting Started]({%slug radtimebar-getting-started%})