---
title: Attaching input events to the map shapes
page_title: Attaching input events to the map shapes
description: Check our &quot;Attaching input events to the map shapes&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-visualization-layer-input-events
tags: attaching,input,events,to,the,map,shapes
published: True
position: 4
---

# Attaching input events to the map shapes

The visualization engine based on the VisualizationLayer class separates geographical data and its visualization. The map shape data classes aren’t dependency objects. It means that you can’t attach input events to these classes directly. Instead you can attach events to the map shape visualization. It allows assigning of any input events supported by ContentPresenter to the map shape visual presentation.        

The VisualizationLayer class provides 2 events:        

1. __MapShapeVisualizationCreated__ – occurs when map shape visualization object is created. Can be used to attach event handlers.            

1. __MapShapeVisualizationRemoved__ – occurs when map shape visualization object is removed. Can be used to detach event handlers.            

Here it is an example which attaches MouseEnter and MouseLeave events to the map shape visualization object:        


<snippet id='radmap-features-visualization-layer-input-events-block_1-xaml' />


<snippet id='radmap-features-visualization-layer-input-events-block_2-cs' />
<snippet id='radmap-features-visualization-layer-input-events-block_2-vb' />