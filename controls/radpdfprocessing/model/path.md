---
title: Path
page_title: Path
description: Path
slug: radpdfprocessing-model-path
tags: path
published: True
position: 4
---

# Path



__Path__ is a content element that represents series of connected lines and curves. The shape in the path is specified by its [Geometry]({%slug radpdfprocessing-concepts-geometry%}) property.
      

* [Inserting a Path](#inserting-a-path)

* [Modifying a Path](#modifying-a-path)

## Inserting a Path

__Path__ is a content element that is designed to be added in the __Content__ collection of an __IContainerElement__ such [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%}). There are several approaches which you can be adopt to achieve that.
        

__Example 1__ shows how you can create a Path, assign a predefined Geometry to it and add it in a container.
        

#### __[C#] Example 1: Create Path and add it to container.__

{{region radpdfprocessing-model-path_0}}
	            Path path = new Path();
	            path.Geometry = geometry;
	            container.Content.Add(path); 
	{{endregion}}



__Example 2__ demonstrates how to use one of the factory methods of the __ContentElementCollection__ that creates a new path and inserts it into the document.
        

#### __[C#] Example 2: Add Path to container.__

{{region radpdfprocessing-model-path_1}}
	            Path path = container.Content.AddPath();
	            path.Geometry = geometry;
	{{endregion}}



>There are other methods that allow adding a path to a document. They can be taken advantage of when using [FixedContentEditor]({%slug radpdfprocessing-editing-fixedcontenteditor%}).
          

## Modifying a Path

You can modify a __Path__ element using the properties the class exposes. The properties are listed below.
        

* __Fill__: The color that is used to fill the path. The default value is Black.
            

* __Stroke__: The color that is used to stroke the path. The default value is Black.
            

* __IsFilled__: Specifies whether the path should be filled.
            

* __IsStroked__: Specified whether the path should be stroked.
            

* __StrokeThickness__: The width of the stroke outline.
            

* __StrokeLineCap__: Specifies the shape which is used at the ends of open paths when they are stroked.
            

* __Flat__: Flat line cap.
                

* __Round__: Round line cap.
                

* __Square__: Square line cap.
                

* __StrokeLineJoin__: Specifies the shape to be used at the corners of paths that are stroked. Join styles are significant only at the points where consecutive segments of a path connect at an angle.
            

* __Bevel__: Produces a diagonal corner.
                

* __Miter__: Produces a sharp corner. If the segments meet at too sharp angle, a bevel join is used instead.
                

* __Bevel__: Produces a smooth, circular arc between the lines.
                

* __StrokeDashArray__: The pattern of dashes and gaps used to stroke paths.
            

* __StrokeDashOffset__: The distance from the start of a line to the beginning of a dash pattern.
            

* __MiterLimit__: The limit of the thickness of the join on a mitered corner.
            

* __Geometry__: The shape to be drawn. More information about geometries is available [here]({%slug radpdfprocessing-concepts-geometry%}).
            

# See Also

 * [Geometry]({%slug radpdfprocessing-concepts-geometry%})

 * [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%})

 * [FixedContentEditor]({%slug radpdfprocessing-editing-fixedcontenteditor%})
