---
title: Lights
page_title: Lights
description: Check our &quot;Lights&quot; documentation article for the RadChartView3D {{ site.framework_name }} control.
slug: radchartview3d-lights
tags: lights, chartview, 3d, scene, illuminate
published: True
position: 4
---

# Lights

The lights in the 3D world are making the scene visible. The 3D chart allows you define different light sources to illuminate the scene. This can be done through the __Lights__ collection of the chart. The collection holds objects of type __System.Media.Media3D.Light__. The WPF framework provides several built-in lights which you can use – __AmbientLight__, __DirectionalLight__, __PointLight__ and  __SpotLight__. You can read more about them in the [3-D Graphics Overview](https://msdn.microsoft.com/en-us/library/ms747437(v=vs.110).aspx) MSDN article.

__Example 1: Adding lights in the chart using XAML__
<snippet id='radchartview3d-lights-example_1_adding_lights_in_the_chart_using_xaml-xaml' />


__Example 2: Adding lights in the chart in code__
<snippet id='radchartview3d-lights-example_2_adding_lights_in_the_chart_in_code-cs' />


>The chart uses default lights to illuminate the scene. Adding items in the Lights collection will override the default lighting.

>important When using the chart's __CameraBehavior3D__ the direction of the lights is determined by the camera position. You can find more information about this in the [Camera Behavior]({%slug radchartview3d-behaviors-camera%}) article.

## See Also

* [Getting Started]({%slug radchartview3d-getting-started%})
* [Camera Behavior]({%slug radchartview3d-behaviors-camera%})
* [Axes]({%slug radchartview3d-axes%})
