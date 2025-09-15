---
title: Camera
page_title: Camera
description: Check our &quot;Camera&quot; documentation article for the RadChartView3D {{ site.framework_name }} control.
slug: radchartview3d-camera
tags: camera, chartview, 3d, scene
published: True
position: 2
---

# Camera

The chart camera defines and controls the point of view from where the chart is observed in 3D space. __RadCartesianChart3D__ uses the WPF __Camera__ class to project 3D objects to a 2D surface. By default the chart uses the native __PerspectiveCamera__ provided by the WPF framework.

The point of view is defined by the position of the camera in the 3D space (x, y, z positions), the look direction represented by a 3D vector and a field of view angle when the camera is perspective.

You can get the camera object using the __Camera__ property of the chart.

__Example 1: Getting/setting the chart camera__
```C#
	// Getting the camera
	Camera camera = chart.Camera;	
	
	// Setting the camera
	chart.Camera = new OrthographicCamera();	
```

> You can find more information about 3D and the WPF cameras in the [3-D Graphics Overview article](https://msdn.microsoft.com/en-us/library/ms747437(v=vs.110).aspx) in MSDN. 

>important RadCartesianChart3D allows you easier interaction with the camera via the __Chart3DCameraBehavior__ class. You can read more about it in the Telerik's [Camera Behavior]({%slug radchartview3d-behaviors-camera%}) help article.

## See Also

* [Getting Started]({%slug radchartview3d-getting-started%})
* [Camera Behavior]({%slug radchartview3d-behaviors-camera%})
* [Axes]({%slug radchartview3d-axes%})
