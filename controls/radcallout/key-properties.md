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

### __Geometry customization__

The RadCallout provides 3 properties for customizing the arrow of its geometry - ArrowBasePoint1 , ArrowBasePoint2 and ArrowAnchorPoint.

* __ArrowAnchorPoint__: A property of type __Point__ that gets or sets the __anchor point__ of the arrow geometry. 
* __ArrowBasePoint1__: A property of type __Point__ that gets or sets the __first base point__ of the arrow geometry.
* __ArrowBasePoint2__: A property of type __Point__ that gets or sets the __second base point__ of the arrow geometry.

The properties are of type Point and represent relative coordinates (between 0 and 1) where for example 
X = 0 and Y = 0 means the topleft point of the callout body and X= 1, Y = 1 means the 'bottom-right'
point. In the figures you can see the default values of the properties [0.25, 0.5], [0.75, 0.5] and [0.5, 1.25].

> Important to note here is that the widht and height of the callout apply only to the body of the geometry 
but not to the arrow. This way it is very easy to keep a fixed size of the main shape while making the big arrow exceeding the shape size.

#### Figure 1: 
![Telerik Callout Key Properties 1](images/radcallout-key-properties_3.png)

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
	
	#### Figure 2: RadCallout types
	![Telerik Callout Key Properties 2](images/radcallout-key-properties_1.png)

* __ArrowType__: A property of type __CalloutArrowType__ that gets or sets gets or sets the arrow type of the callout control. The __ArrowType__ is an enumeration and it allows the following values:
	* __None__: No arrow.
	* __Triangle__: Triangle or line arrow consisted of 3 pivot points.
	* __Circles__: Series of circles.
	* __Ellipses__: Series of ellipses.
	
	#### Figure 3: RadCallout arrow types
	![Telerik Callout Key Properties 3](images/radcallout-key-properties_2.png)

## See Also

* [Getting Started]({%slug radcallout-getting-started%})
