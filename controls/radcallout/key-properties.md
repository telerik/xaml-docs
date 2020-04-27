---
title: Key Properties
page_title: Key Properties
description: This article lists and explains the events exposed by the RadCallout control.
slug: radcallout-key-properties
tags: radcallout, key, property, properties
published: True
position: 3
---

# Key Properties

This article will list the key properties provided by the RadCallout control.

* __ArrowAnchorPoint__: A property of type __Point__ that gets or sets the anchor point of the arrow geometry. 

* __ArrowBasePoint1__: A property of type __Point__ that gets or sets the first base point of the arrow geometry.

* __ArrowBasePoint2__: A property of type __Point__ that gets or sets the second base point of the arrow geometry.

* __MeasurePathWithInfinity__: A __boolean__ property that gets or sets a value indicating whether the path in the control template is measured with infinity or not.

* __Stretch__: A property of type __Strech__ that gets or sets the stretch of the path from the control template.

* __CornerRadius__: A property of type __double__ that gets or sets the corner radius used for the __Telerik.Windows.Controls.CalloutType.RoundedRectangle__ geometry.

* __TextTrimming__: A property of type __TextTrimming__ that gets or sets the text trimming mode of the underlying __TextBlock__.

* __TextAlignment__: A property of type __TextAlignment__ that gets or sets the text alignment of the underlying __TextBlock__.

* __TextWrapping__: A property of type __TextWrapping__ that gets or sets the text wrapping mode of the underlying __TextBlock__.

* __StrokeThickness__: A property of type __double__ that gets or sets the stroke thickness of the underlying path.

* __GeometryResult__: A property of type __Geometry__ that gets the combined __(body and arrow)__ geometry of the callout control.

* __Geometry__: A property of type __Geometry__ that gets or sets the desired (body) geometry of the callout control.

* __StrokeDashArray__: A __DoubleCollection__ property that gets or sets the stroke dash array of the underlying path.

* __CalloutType__: A property of type __CalloutType__ that gets or sets the callout type of the callout control. The __CalloutType__ is an enumeration and it allows the following values:
	* __Rectangle__:  Rectangle geometry.
	* __RoundedRectangle__: Rounded rectangle geometry.
	* __Ellipse__: Ellipse geometry.
	* __Cloud__: Cloud geometry.
	* __Kaboom__: Kaboom geometry.
	* __Custom__: Set custom geometry.	
	
	#### Figure 1: RadCallout types
	![Telerik Callout Map Integration 0](images/radcallout-key-properties_1.png)

* __ArrowType__: A property of type __CalloutArrowType__ that gets or sets gets or sets the arrow type of the callout control. The __ArrowType__ is an enumeration and it allows the following values:
	* __None__: No arrow.
	* __Triangle__: Triangle or line arrow consisted of 3 pivot points.
	* __Circles__: Series of circles.
	* __Ellipses__: Series of circles.
	
	#### Figure 1: RadCallout arrow types
	![Telerik Callout Map Integration 0](images/radcallout-key-properties_2.png)

## See Also

* [Getting Started]({%slug radcallout-getting-started%})
