---
title: Clipping
page_title: Clipping
description: Clipping
slug: radpdfprocessing-concepts-clipping
tags: clipping
published: True
position: 1
---

# Clipping



__Clipping__ is a content element that can be used to define the outline of other content elements like [Image]({%slug radpdfprocessing-model-image%}) and [Path]({%slug radpdfprocessing-model-path%}).
      

## Creating a Clipping

The __Clipping__ element exposes a single property.
        

* __Clip__: Property of type __GeometryBase__ representing the [Geometry]({%slug radpdfprocessing-concepts-geometry%}) that is used to clip the content element.
            

__Example 1__ demonstrates how you can create a Clipping element and assign a __RectangeGeometry__ to its Clip property.
        

#### __[C#] Example 1: Create Clipping__

{{region radpdfprocessing-concepts-clipping_0}}
    Clipping clipping = new Clipping();
    clipping.Clip = new RectangleGeometry(new Rect(5, 5, 50, 50));
{{endregion}}



## Using Clipping

All inheritors of the __ContentElementBase__ class expose a __Clipping__ property. Setting it clips the respective content element with the specified clipping. 
        

__Example 2__ demonstrates how to clip an image using the Clipping created in __Example 1__.
        

#### __[C#] Example 2: Use Clipping__

{{region radpdfprocessing-concepts-clipping_1}}
    Image image = container.Content.AddImage(imageSource);
    image.Clipping = clipping;
{{endregion}}



# See Also

 * [Geometry]({%slug radpdfprocessing-concepts-geometry%})
