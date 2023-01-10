---
title: Performance Tips
page_title: Performance Tips
description: This article lists several settings that can be applied in order to improve the RadMap's performance.
slug: radmap-performance-tips
tags: performance,tips,many,items,huge,shapes
published: True
position: 8
---

# {{ site.framework_name }} RadMap Performance Tips

This article lists several settings that can be applied in order to improve the RadMap's performance.

* Use [VisualizationLayer]({%slug radmap-visualization-layer-introduction%}), instead of InformationLayer. VisualizationLayer brings improvements compared to the other layers and it loads the shapes asynchronous.

* Disable the automation peers. All Telerik controls support extended [UI automation]({%slug common-ui-automation%}) that can be disabled in order to improve the performance. To do so, set the __AutomationManager.AutomationMode__ to __Disabled__.

	#### __[C#] Example 1: Disabling automation peers__
	{{region radmap-performance-tips-0}}
		public MainWindow()
        {
            AutomationManager.AutomationMode = AutomationMode.Disabled;
            InitializeComponent();         
        }
	{{endregion}}

* Use the [items virtualization]({%slug radmap-features-visualization-layer-shapes-virtualization%}) feature and restrict the viewport, so that a smaller number of shapes is displayed.

* Use the [clustering]({%slug radmap-heatures-visualization-layer-clustering%}) feature. This will allow you to combine several shapes into a single one when they start overlapping.

* If using a [provider]({%slug radmap-features-providers%}), disable the tiles caching by setting the __IsCachingTilesEnabled__ property of the provider to __False__. 

	#### __[XAML] Example 2: Disabling the tiles caching__
	{{region radmap-performance-tips-1}}
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider IsTileCachingEnabled="False" />
		</telerik:RadMap.Provider>
	{{endregion}}

* Disable the zooming animations by setting the __UseSpringAnimations__ property of RadMap to __False__.

	#### __[XAML] Example 3: Disabling zoom animations__
	{{region radmap-performance-tips-2}}
		<telerik:RadMap UseSpringAnimations="False" />
	{{endregion}}

* Disable the bitmap cache of the VisualizationLayer by setting its __UseBitmapCache__ property to __False__. This caching is used to accelerate the panning operation. Note when this is enabled the memory increases significantly when there are many map shapes on the layer.

	#### __[XAML] Example 4: Disabling the bitmap cache__
	{{region radmap-performance-tips-3}}
		<telerik:VisualizationLayer UseBitmapCache="False" />	
	{{endregion}}

* Avoid using __MapShapeBindableWrapper__ elements, like MapEllipseView, MapRectangleView, MapPolylineView, etc. The wrappers implement additional logic that syncs the business objects with the automatically created map shape data objects which takes processing time. Instead, use [map shape data]({%slug radmap-visualization-layer-map-shape-data%}) objects directly.

* If the loaded shape file contains many and complex geometries, try to simplify the geometries in the shape file.

## See Also  
 * [Getting Started]({%slug radmap-getting-started%}) 
 * [Events]({%slug radmap-events%})
