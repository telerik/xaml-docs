---
title: ImageSource
page_title: ImageSource
description: ImageSource
slug: radpdfprocessing-model-imagesource
tags: imagesource
published: True
position: 5
---

# ImageSource



__ImageSource__ represents a single, constant set of pixels at a certain size. It can be used by multiple [Image]({%slug radpdfprocessing-model-image%}) objects in order to be drawn in a PDF file.
      

## Creating ImageSource

The ImageSource class has two contrustor overloads and can be created from a [Stream](http://msdn.microsoft.com/en-us/library/system.io.stream(v=vs.110).aspx) that contains image or from a [BitmapSource](http://msdn.microsoft.com/en-us/library/system.windows.media.imaging.bitmapsource(v=vs.110).aspx) object.
        

__Example 1__ illustrates how you can create an ImageSource using a __FileStream__.
        

#### __[C#] Example 1: Create ImageSource from Stream__

{{region radpdfprocessing-model-imagesource_0}}
    using (FileStream source = File.Open(filename, FileMode.Open))
    {
        ImageSource imageSource = new ImageSource(source);
    }
{{endregion}}



## Extensions

__RadPdfProcessing__ exposes an extension method allowing to convert every BitmapSource to an ImageSource that can be used for the creation of [Image]({%slug radpdfprocessing-model-image%}) elements. __Example 2__ shows how you can use the ToImageSource() extension method over a previously created bitmap.
        

#### __[C#] Example 2: Create ImageSource with Extension Method__

{{region radpdfprocessing-model-imagesource_1}}
    BitmapImage bitmap = new BitmapImage();
    bitmap.BeginInit();
    bitmap.UriSource = new Uri(filename, UriKind.RelativeOrAbsolute);
    bitmap.EndInit();

    return bitmap.ToImageSource();
{{endregion}}



# See Also

 * [Image]({%slug radpdfprocessing-model-image%})
