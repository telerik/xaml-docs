---
title: Drawing
page_title: Drawing
description: Drawing
slug: radimageeditor-howto-drawing
tags: drawing
published: True
position: 2
---

# Drawing


The __DrawTool__ is one of the tools that come out-of-the-box with the __RadImageEditor__ and enables you to draw over the image. You can choose different brush color and size. The tool provides some customization options that are explained in detail in this topic.


As like the other __RadImageEditor__’s tools, the __DrawTool__ is located under the Telerik.Windows.Media.Imaging.Tools namespace, inherits the [ToolBase]({%slug radimageeditor-howto-implement-toolbase%}) class and can be defined in XAML as follows:

#### __[XAML] Example 1: Define DrawTool__

{{region radimageeditor-howto-drawing_0}}
	<tools:DrawTool />
{{endregion}}


## Modifying

The __DrawTool__ introduces the following two properties which can be set by declaring them in XAML as well:

* __DefaultBrushSize__: Specifies the default size of the brush. The property is of type __double__.

* __DefaultBrushColor__: Specifies the default brush color. The property is of type __Color__.

#### __[XAML] Example 2: Customize DrawTool__

{{region radimageeditor-howto-drawing_1}}
	<tools:DrawTool DefaultBrushColor="Blue" DefaultBrushSize="5"/>
{{endregion}}

#### __[C#] Example 2: Customize DrawTool__

{{region radimageeditor-howto-drawing_2}}
	DrawTool drawTool = new DrawTool();
	drawTool.DefaultBrushColor = Colors.Blue;
	drawTool.DefaultBrushSize = 5;
{{endregion}}

#### __[VB.NET] Example 2: Customize DrawTool__

{{region radimageeditor-howto-drawing_3}}
    Dim drawTool = New DrawTool()
    drawTool.DefaultBrushColor = Colors.Blue
    drawTool.DefaultBrushSize = 5
{{endregion}}


## Inheritance and Customizing

The __DrawTool__ introduces the following virtual methods which can be overridden in order to achieve different than the default behavior:

* __SetPathProperties(Path path)__: Passes as a parameter the [Path](https://msdn.microsoft.com/en-us/library/system.windows.shapes.path%28v=vs.110%29.aspx) object which shall get the drawn geometry data later. You can set [properties](https://msdn.microsoft.com/en-us/library/system.windows.shapes.path_properties(v=vs.110).aspx) like _Stroke, Fill, StrokeThickness, StrokeLineJoin_ and etc. The method is invoked at the beginning of the drawing.

* __CreatePathFigure(Point currentPosition)__: Returns a [PathFigure](https://msdn.microsoft.com/en-us/library/system.windows.media.pathfigure%28v=vs.110%29.aspx) object which is added to the path’s geometry figures collection. The method is invoked at the beginning of the drawing right after the __Path__’s initialization.

* __CreatePathSegment(Point currentPosition)__: Returns a [PathSegment](https://msdn.microsoft.com/en-us/library/system.windows.media.pathsegment(v=vs.110).aspx) object which is added to the drawn path’s figure during the drawing. A [LineSegment](https://msdn.microsoft.com/en-us/library/system.windows.media.linesegment%28v=vs.110%29.aspx) is inserted by default.

# See Also

* [Cropping]({%slug radimageeditor-howto-use-crop%})

* [Commands and Tools]({%slug radimageeditor-features-commands-and-tools%})
