---
title: Drawing
page_title: Drawing
description: Check our &quot;Drawing&quot; documentation article for the RadImageEditor {{ site.framework_name }} control.
slug: radimageeditor-tools-drawing
tags: drawing
published: True
position: 2
---

# Drawing


The __DrawTool__ is one of the tools that come out-of-the-box with the __RadImageEditor__ and enables you to draw over the image. You can choose different brush color and size. The tool provides some customization options that are explained in detail in this topic.


Similarly to the other __RadImageEditor__ tools, the __DrawTool__ is located in the __Telerik.Windows.Media.Imaging.Tools__ namespace, inherits the [DrawToolBase]({%slug radimageeditor-howto-implement-drawtoolbase%}) class and can be defined in XAML as follows:

__Example 1: Define DrawTool__

```XAML
	<tools:DrawTool />
```


## Modifying

The __DrawTool__ introduces the following two properties which can be set by declaring them in XAML as well:

* __DefaultBrushSize__: Specifies the default size of the brush. The property is of type __double__.

* __DefaultBrushColor__: Specifies the default brush color. The property is of type __Color__.

__Example 2: Customize DrawTool__

```XAML
	<tools:DrawTool DefaultBrushColor="Blue" DefaultBrushSize="5"/>
```

__Example 2: Customize DrawTool__

```C#
	DrawTool drawTool = new DrawTool();
	drawTool.DefaultBrushColor = Colors.Blue;
	drawTool.DefaultBrushSize = 5;
```
```VB.NET
	Dim drawTool = New DrawTool()
	drawTool.DefaultBrushColor = Colors.Blue
	drawTool.DefaultBrushSize = 5
```


## Inheritance and Customizing

The __DrawTool__ introduces the following virtual methods which can be overridden in order to achieve different than the default behavior:

* __CreatePathFigure(Point currentPosition)__: Returns a [PathFigure](https://msdn.microsoft.com/en-us/library/system.windows.media.pathfigure%28v=vs.110%29.aspx) object which is added to the path’s geometry figures collection. The method is invoked at the beginning of the drawing right after the __Path__’s initialization.

* __CreatePathSegment(Point currentPosition)__: Returns a [PathSegment](https://msdn.microsoft.com/en-us/library/system.windows.media.pathsegment(v=vs.110).aspx) object which is added to the drawn path’s figure during the drawing. A [LineSegment](https://msdn.microsoft.com/en-us/library/system.windows.media.linesegment%28v=vs.110%29.aspx) is inserted by default.

## See Also

* [Cropping]({%slug radimageeditor-tools-crop%})
* [Commands and Tools]({%slug radimageeditor-features-commands-and-tools%})
* [Shape Tool]({%slug radimageeditor-tools-shape-tool%})