---
title: Marker Geometry
page_title: Marker Geometry
description: Check our &quot;Marker Geometry&quot; documentation article for the RadLegend {{ site.framework_name }} control.
slug: radlegend-marker-geometry
tags: marker,geometry
published: True
position: 3
---

# Marker Geometry

You can change the default Geometry of the default Path in the legend item. This is easy to do by setting the DefaultMarkerGeometry property. If the LegendItem object that was given to the RadLegend has its MarkerGeometry property set (as is the third item in the example below) then this is the Geometry that is used. This happens because the MarkerGeometry has a higher priority than the DefaultMarkerGeometry. This is done in order to be possible for different legend items to be presented with different geometries.        


<snippet id='radlegend-marker-geometry-setting_defaultmarkergeometry-xaml' />

This is the final result:  
![radlegend-marker-geometry-0](images/radlegend-marker-geometry-0.png)