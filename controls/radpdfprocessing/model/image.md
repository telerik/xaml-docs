---
title: Image
page_title: Image
description: Image
slug: radpdfprocessing-model-image
tags: image
published: True
position: 4
---

# Image



__Image__ is a content element which contains an image source and represents an image.
      

* [Inserting an Image](#Inserting_an_Image)

* [Modifying an Image](#Modifying_an_Image)

## Inserting an Image

__Image__ is a content element that can be added in the __Content__ collection of a __IContainerElement__ such as [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%}). There are several approaches which you can use to achieve that.
        

__Example 1__ shows how to initialize an Image object and add it to a previously defined container.
        

#### __[C#] Example 1: Create Image__

{{region radpdfprocessing-model-image_0}}
    Image image = new Image();
    container.Content.Add(image);
{{endregion}}



__Example 2__ demonstrates how to use one of the factory methods of the __ContentElementCollection__ to create a new image and insert it into the respective container.
        

#### __[C#] Example 2: Add Image to container__

{{region radpdfprocessing-model-image_1}}
    Image image = container.Content.AddImage();
    Image imageWithSource = container.Content.AddImage(imageSource);
{{endregion}}



>tipThere are other methods that allow adding an image to a document by passing image size, format and source. They can be taken advantage of when using [FixedContentEditor]({%slug radpdfprocessing-editing-fixedcontenteditor%}).
          

## Modifying an Image

You can modify an __Image__ element using the properties the class exposes. The properties are listed below.
        

* __ImageSource__: Specifies the image source that will be visualized in the Image object.
            

* __Width__: The width of the image.
            

* __Height__: The height of the image.
            

* __Position__: The [Position]({%slug radpdfprocessing-concepts-position%}) of the image inside the __IContainerElement__.
            

# See Also

 * [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%})

 * [FixedContentEditor]({%slug radpdfprocessing-editing-fixedcontenteditor%})

 * [Position]({%slug radpdfprocessing-concepts-position%})
