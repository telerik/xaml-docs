---
title: Lights
page_title: Lights
description: Lights
slug: radchartview3d-lights
tags: lights, chartview, 3d, scene, illuminate
published: True
position: 4
---

# Lights

The lights in the 3D world are making the scene visible. The 3D chart allows you define different light sources to illuminate the scene. This can be done through the __Lights__ collection of the chart. The collection holds objects of type __System.Media.Media3D.Light__. The WPF framework provides several built-in lights which you can use – __AmbientLight__, __DirectionalLight__, __PointLight__ and  __SpotLight__. You can read more about them in the [3-D Graphics Overview](https://msdn.microsoft.com/en-us/library/ms747437(v=vs.110).aspx) MSDN article.

#### __[XAML] Example 1: Adding lights in the chart using XAML__
{{region xaml-radchartview-3d-lights-0}}
	<telerik:RadCartesianChart3D.Lights>
		<DirectionalLight />
	</telerik:RadCartesianChart3D.Lights>
{{endregion}}

#### __[C#] Example 2: Adding lights in the chart in code__
{{region cs-radchartview-3d-lights-1}}
	chart3D.Lights.Add(new DirectionalLight());
{{endregion}}

>The chart uses default lights to illuminate the scene. Adding items in the Lights collection will override the default lighting.

>important When using the chart's __CameraBehavior3D__ the direction of the lights is determined by the camera position. You can find more information about this in the [Camera Behavior]({%slug radchartview3d-behaviors-camera%}) article.

## See Also

* [Getting Started]({%slug radchartview3d-getting-started%})
* [Camera Behavior]({%slug radchartview3d-behaviors-camera%})
* [Axes]({%slug radchartview3d-axes%})
