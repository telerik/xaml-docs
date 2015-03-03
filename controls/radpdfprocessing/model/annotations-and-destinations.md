---
title: Annotations and Destinations
page_title: Annotations and Destinations
description: Annotations and Destinations
slug: radpdfprocessing-model-annotations-and-destinations
tags: annotations,and,destinations
published: True
position: 7
---

# Annotations and Destinations



The abstract __Annotation__ element associates an object with a location on a [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%}). Annotation exposes the following properties:
      

* __Rect__: The rectangle which defines the location of the annotation on the page.
          

* __Type__: Property of type [AnnotationType](http://www.telerik.com/help/wpf/t_telerik_windows_Documents_fixed_model_annotations_annotationtype.html) which determines the type of the annotation. The only supported type is __Link__.
          

This article will get you familiar with the following concepts:
      

* [Link](#link)

* [Destination](#destination)

* [Action](#action)

## Link

The __Link__ class inherits the abstract __Annotation__ class and is the only supported type of annotation in the document model. Link annotations represents either a hypertext link to a destination elsewhere in the document or an action to be performed. For this reason there are two separate constructors in the [Link class](http://www.telerik.com/help/wpf/t_telerik_windows_documents_fixed_model_annotations_link.html) - one requiring a __Destination__ object and one requiring an __Action__ object.
        

__Link__ exposes the following properties:
        

* __Destination__: A destination to be displayed when the annotation is activated. __Example 1__ demonstrates how you can create a Link using a previously created __Destination__ and add the Link in RadFixedPage's Annotations collection.
            

#### __[C#] Example 1: Add Link to Destination__

{{region radpdfprocessing-model-annotations-and-destinations_0}}
    Link linkWithDestination = new Link(destination);
    page.Annotations.Add(linkWithDestination);
{{endregion}}



* __Action__: An action to be performed when the annotation is activated. __Example 2__ demonstrates how you can create a Link using a previously created __Action__ and add the Link in RadFixedPage's Annotations collection.
            

#### __[C#] Example 2: Add Link with Action__

{{region radpdfprocessing-model-annotations-and-destinations_1}}
    Link linkWithAction = new Link(action);
    page.Annotations.Add(linkWithAction);
{{endregion}}



>importantIn __Example 1__ the *action* object should be from the Telerik.Windows.Documents.Fixed.Model.Actions.Action type.
              

## Destination

The abstract __Destination__ class defines a particular view of a document, consisting of the following items:
        

* The page which needs to be displayed.
            

* The location on that page.
            

* The magnification (zoom) factor which should be uses when displaying the page.
            

The __Destination__ class itself only exposes a __Page__ property specifying the page of the destination. The other properties of the view are determined by the classes that inherit __Destination__.
        

* __Location__: Exposes __Left__, __Top__ and __Zoom__ properties. Displays the specified page, positioned with the (Left, Top) position at the upper-left corner of the window and the contents of the page magnified by the factor Zoom.
            

* __PageFit__: Displays the specified page with its contents magnified just enough to fit the entire page within the window both horizontally and vertically.
            

* __PageHorizontalFit__: Exposes __Top__ property. Displays the specified page with the vertical coordinate Top positioned at the top edge of the window and the contents of the page magnified just enough to fit the entire width of the page within the window.
            

* __PageVerticalFit__: Exposes __Left__ property. Displays the specified page with the horizontal coordinate Left positioned at the left edge of the window and the contents of the page magnified just enough to fit the entire height of the page within the window.
            

* __RectangleFit__: Exposes __Left__, __Top__, __Right__ and __Bottom__ properties. Displays the specified page with its contents magnified just enough to fit the rectangle specified by the coordinates Left, Bottom, Right and Top entirely within the window both horizontally and vertically.
            

* __BoundingRectangleFit__: Displays the specified page with its contents magnified just enough to fit its bounding box entirely within the window both horizontally and vertically.
            

* __BoundingRectangleHorizontalFit__: Exposes __Top__ property. Displays the specified page with the vertical coordinate Top positioned at the top edge of the window and the contents of the page magnified just enough to fit the entire width of its bounding box within the window.
            

* __BoundingRectangleVerticalFit__: Exposes __Left__ property. Displays the specified page with the horizontal coordinate Left positioned at the left edge of the window and the contents of the page magnified just enough the fit the entire height of its bounding box within the window.
            

__Example 3__ shows how you can create a Location object, associate it with a Link and add it to a RadFixedPage.
        

#### __[C#] Example 3: Add Link with Location__

{{region radpdfprocessing-model-annotations-and-destinations_2}}
    Location location = new Location();
    location.Left = 225;
    location.Top = 500;
    location.Zoom = 4;
    location.Page = secondPage;

    var link = firstPage.Annotations.AddLink(location);
    link.Rect = new Rect(10, 10, 50, 50);
{{endregion}}



## Action

The abstract __Action__ class defines a behavior for an annotation. Action is inherited from the following classes:
        

* __GoToAction__: Associates the action with a __Destination__. The GoToAction class exposes the following properties:
            

 * __Destination__: The associated destination.
                

* __UriAction__: Associates the action with an Uri. The UriAction class exposes the following properties:
            

 * __Uri__: The associated Uri.
                

 * __IncludeMouseCoordinates__: Specifies weather to include the mouse coordinates as query parameters in the Uri.
                

__Example 4__ demonstrates how to create an action of type __GoToAction__, associate it with a Link and add it to a RadFixedPage. The *location* object can be of type Location like the one in __Example 3__.
        

#### __[C#] Example 4: Add Link with Action__

{{region radpdfprocessing-model-annotations-and-destinations_3}}
    GoToAction goToAction = new GoToAction();
    goToAction.Destination = location;

    var goToLink = firstPage.Annotations.AddLink(goToAction);
    goToLink.Rect = new Rect(10, 10, 50, 50);

    UriAction uriAction = new UriAction();
    uriAction.Uri = new Uri(@"http://www.telerik.com");

    var uriLink = firstPage.Annotations.AddLink(uriAction);
    uriLink.Rect = new Rect(70, 10, 50, 50);
{{endregion}}



# See Also

 * [RadFixedPage]({%slug radpdfprocessing-model-radfixedpage%})
 * [AnnotationType API Reference](http://www.telerik.com/help/wpf/t_telerik_windows_Documents_fixed_model_annotations_annotationtype.html)
 * [Link API Reference](http://www.telerik.com/help/wpf/t_telerik_windows_documents_fixed_model_annotations_link.html)
