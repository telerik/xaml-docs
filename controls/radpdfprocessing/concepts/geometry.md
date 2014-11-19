---
title: Geometry
page_title: Geometry
description: Geometry
slug: radpdfprocessing-concepts-geometry
tags: geometry
published: True
position: 2
---

# Geometry



The __GeometryBase__ class and the classes which derive from it enable you to describe the geometry of a 2D shape. These geometric descriptions can be used for clipping and drawing.
      

This article covers the supported geometry types.
      

* [RectangleGeometry](#rectanglegeometry)

* [PathGeometry](#pathgeometry)

* [PathFigure](#pathfigure)

* [PathSegment](#pathsegment)

* [LineSegment](#linesegment)

* [BezierSegment](#beziersegment)

* [QuadraticBezierSegment](#quadraticbeziersegment)

* [ArcSegment](#arcsegment)

## RectangleGeometry

__RectangleGeometry__ represents a two-dimensional rectangle. The class exposes the following properties:
        

* __Rect__: The dimensions of the rectangle.
            

__Example 1__ shows hot to create a RectangleGeometry.
        

#### __[C#] Example 1: Create RectangleGeometry__

{{region radpdfprocessing-concepts-geometry_0}}
    RectangleGeometry rectangleGeometry = new RectangleGeometry();
    rectangleGeometry.Rect = new Rect(10, 5, 400, 300);
{{endregion}}



## PathGeometry

PathGeometry represents a complex shape that may be composed of curves and lines. The class exposes the following properties:
        

* __Figures__: A collection of __PathFigure__ objects which describe the contents of the PathGeometry.
            

* __FillRule__: Specifies how the intersecting areas contained in the PathGeometry are combined.
            

 * __EvenOdd__: Determines whether a point is inside a path by drawing a ray from that point in any direction and simply counting the number of path segments that cross the ray. If the number is odd, the point is inside. If even, the point is outside.
                

 * __Nonzero__: Determines whether a given point is inside a path by conceptually drawing a ray from that point to infinity in any direction and then examining the places where a segment of the path crosses the ray. Starting with a count of zero, the rule adds one each time a path segment crosses the ray from left to right and subtracts one each time a segment crosses from right to left. After counting all the crossings, if the result is zero, the point is outside the path. Otherwise, it is inside.
                

__Example 2__ shows how to create a PathGeometry which consists of line segments and bezier segments.
        

#### __[C#] Example 2: Create PathGeometry __

{{region radpdfprocessing-concepts-geometry_1}}
    PathGeometry pathGeometry = new PathGeometry();
    PathFigure pathFigure = pathGeometry.Figures.AddPathFigure();
    pathFigure.StartPoint = new Point(5, 5);
    LineSegment lineSegment = pathFigure.Segments.AddLineSegment();
    lineSegment.Point = new Point(205, 5);
    BezierSegment bezierSegment = pathFigure.Segments.AddBezierSegment();
    bezierSegment.Point1 = new Point(105, 50);
    bezierSegment.Point2 = new Point(130, 105);
    bezierSegment.Point3 = new Point(100, 200);
    pathFigure.IsClosed = true;
{{endregion}}



## PathFigure

__PathFigure__ represents a subsection of a __PathGeometry__.The class exposes the following properties:
        

* __Segments__: A collection of __PathSegment__ objects that define the shape of this PathFigure.
            

* __StartPoint__: The point where the PathFigure begins.
            

* __IsClosed__: Specifies whether the first and the last segments are connected.
            

## PathSegment

__PathSegment__ represents a segment of a __PathFigure__ object. This abstract class is inherited from:
        

* __LineSegment__

* __BezierSegment__

* __QuadraticBezierSegment__

## LineSegment

Represents a segment which creates a line between two points.The __LineSegment__ class exposes the following properties:
        

* __Point__: The end point of the line segment.
            

## BezierSegment

Represents a cubic Bezier curve drawn between two points.
        

* __Point1__: The first control point of the curve.
            

* __Point2__: The second control point of the curve.
            

* __Point3__: The end point of the curve.
            

## QuadraticBezierSegment

Represents a quadratic Bezier curve between two points. The __QuadraticBezierSegment__ exposes the following properties:
        

* __Point1__: The control point of the curve.
            

* __Point2__: The end point of the QuadraticBezierSegment.
            

## ArcSegment

Represents an elliptical arc between two points. The __ArcSegment__ exposes the following properties:
        

* __Point__: The endpoint of the elliptical arc.
            

* __RadiusX__: The X radius of the arc.
            

* __RadiusY__: The Y radius of the arc.
            

* __IsLargeArc__: Specifies whether the arc should be greater than 180 degrees.
            

* __SweepDirection__: Specifies whether the arc is drawn in the Clockwise or Counterclockwise direction.
            

* __RotationAngle__: Specifies the amount (in degrees) by which the ellipse is rotated about the x-axis.
            
