---
title: Performance Tips
page_title: Performance Tips
description: This article lists several settings that can be applied in order to improve the RadMap's performance.
slug: radmap-performance-tips
tags: performance,tips,many,items,huge,shapes
published: True
position: 8
---

# Performance Tips

This article lists several settings that can be applied in order to improve the RadMap's performance.

* Use [VisualizationLayer]({%slug radmap-visualization-layer-introduction%}), instead of InformationLayer. VisualizationLayer brings improvements compared to the other layers and it loads the shapes asynchronous.

* Disable the automation peers. All Telerik controls support extended [UI automation]({%slug common-ui-automation%}) that can be disabled in order to improve the performance. To do so, set the __AutomationManager.AutomationMode__ to __Disabled__.

	__Example 1: Disabling automation peers__
	```C#
		public MainWindow()
        {
            AutomationManager.AutomationMode = AutomationMode.Disabled;
            InitializeComponent();         
        }
	```

* Use the [items virtualization]({%slug radmap-features-visualization-layer-shapes-virtualization%}) feature and restrict the viewport, so that a smaller number of shapes is displayed.

* Use the [clustering]({%slug radmap-heatures-visualization-layer-clustering%}) feature. This will allow you to combine several shapes into a single one when they start overlapping.

* If using a [provider]({%slug radmap-features-providers%}), disable the tiles caching by setting the __IsTileCachingEnabled__ property of the provider to __False__. 

	__Example 2: Disabling the tiles caching__
	```XAML
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider IsTileCachingEnabled="False" />
		</telerik:RadMap.Provider>
	```

* Disable the zooming animations by setting the __UseSpringAnimations__ property of RadMap to __False__.

	__Example 3: Disabling zoom animations__
	```XAML
		<telerik:RadMap UseSpringAnimations="False" />
	```

* Disable the bitmap cache of the VisualizationLayer by setting its __UseBitmapCache__ property to __False__. This caching is used to accelerate the panning operation. Note when this is enabled the memory increases significantly when there are many map shapes on the layer.

	__Example 4: Disabling the bitmap cache__
	```XAML
		<telerik:VisualizationLayer UseBitmapCache="False" />	
	```

* Avoid using __MapShapeBindableWrapper__ elements, like MapEllipseView, MapRectangleView, MapPolylineView, etc. The wrappers implement additional logic that syncs the business objects with the automatically created map shape data objects which takes processing time. Instead, use [map shape data]({%slug radmap-visualization-layer-map-shape-data%}) objects directly.

* If the loaded shape file contains many and complex geometries, try to simplify the geometries in the shape file.

## See Also  
 * [Getting Started]({%slug radmap-getting-started%}) 
 * [Events]({%slug radmap-events%})
