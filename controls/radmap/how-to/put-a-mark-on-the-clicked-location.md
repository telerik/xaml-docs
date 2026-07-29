---
title: Put a Mark on the clicked Location
page_title: Put a Mark on the clicked Location
description: Check our &quot;Put a Mark on the clicked Location&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-how-to-put-a-mark-on-the-clicked-location
tags: put,a,mark,on,the,clicked,location
published: True
position: 4
---

# Put a Mark on the clicked Location

If you want to mark the position where the user has clicked, you just have to handle the __MapMouseClick__ event and add the desired mark element to the __InformationLayer__ of the __RadMap__ on the clicked location.

The following example will use a __RadMap__ with one __InformationLayer__. The __InformationLayer__ has its __ItemTemplate__ property set. The __DataTemplate__ contains a red __Ellipse__. In this example, the object that will be passed to the __InformationLayer__ will be of type Location, so the __MapLayer.Location__ property of the ellipse is bound to the __DataContext__ of the template.

>tip More detailed information regarding the data binding can be found in the [Data Binding]({%slug radmap-features-data-binding%}) topic.

>tip To learn how to define a provider for the __RadMap__, read the [Providers]({%slug radmap-features-providers%}) topic.

Here is the code for the example:


<snippet id='radmap-how-to-put-a-mark-on-the-clicked-location-block_1-xaml' />


<snippet id='radmap-how-to-put-a-mark-on-the-clicked-location-block_2-cs' />
<snippet id='radmap-how-to-put-a-mark-on-the-clicked-location-block_2-vb' />

## See Also
 * [Information Layer]({%slug radmap-features-information-layer%})
 * [Framework Elements]({%slug radmap-features-information-layer-framework-elements%})
 * [Map Shapes]({%slug radmap-features-map-shapes%})
 * [Set the Best View for the InformationLayer]({%slug radmap-how-to-set-the-best-view-for-the-informationlayer%})
 * [Bring a Location into View]({%slug radmap-how-to-bring-a-location-into-view%})