---
title: Implement DrawToolBase Class
page_title: Implement DrawToolBase Class
description: Implement DrawToolBase Class
slug: radimageeditor-howto-implement-drawtoolbase
tags: draw, tool
published: True
position: 1
---

# Implement DrawToolBase Class

The __DrawToolBase__ class represents an abstraction of a tool, which is responsible for drawing geometries over an image. This is the base class of the __Shape and Drawing tools__. This article will describe the members of this class.

* __StartDraw (Point currentPoint)__: Starts the drawing of a geometry

* __Draw (Point currentPoint)__: Draws a geometry

* __EndDraw (Point currentPoint)__: Ends the drawing of a geometry

* __SetPathProperties (Path path)__: Passes as a parameter the [Path](https://msdn.microsoft.com/en-us/library/system.windows.shapes.path%28v=vs.110%29.aspx) object which shall get the drawn geometry data later. You can set [properties](https://msdn.microsoft.com/en-us/library/system.windows.shapes.path_properties(v=vs.110).aspx) like _Stroke, Fill, StrokeThickness, StrokeLineJoin_ and etc. The method is invoked at the beginning of the drawing.


## See also

* [Create a Custom Tool]({%slug radimageeditor-howto-custom-tool%})
* [Implement ToolBase Class]({%slug radimageeditor-howto-implement-toolbase%})