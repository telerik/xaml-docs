---
title: RadFixedPage
page_title: RadFixedPage
description: RadFixedPage
slug: radpdfprocessing-model-radfixedpage
tags: radfixedpage
published: True
position: 1
---

# RadFixedPage



__RadFixedPage__ conforms to the __IContentRootElement__ interface and is the root element of all fixed content elements in the document model. __Figure 1__ in the [Model]({%slug radpdfprocessing-model%}) article  demonstrates in details the structure of the document model.
      

This article covers the following topics:
      

* [What Is RadFixedPage](#what-is-radfixedpage)

* [Operating with RadFixedPage](#operating-with-radfixedpage)

## What Is RadFixedPage

The root element in the document model tree is [RadFixedDocument]({%slug radpdfprocessing-model-radfixeddocument%}). The document, on the other hand, consists of __RadFixedPages__ hosting all content elements. You an add a __RadFixedPage__ to a document in several ways.
        

__RadFixedPage__ exposes the following properties:
        

* __Content__: The content elements collection.
            

* __Annotations__: Collection that contains all [Annotations and Destinations]({%slug radpdfprocessing-model-annotations-and-destinations%}) in the RadFixedPage.
            

* __Size__: Property of type Size representing the size of the page.
            

* __Rotation__: Property of type
              [Rotation](http://www.telerik.com/help/wpf/t_telerik_windows_documents_fixed_model_data_rotation.html)
              representing the page rotation.
            

__Example 1__ demonstrates how to create a new __RadFixedPage__ instance and add it to the __Pages__ collection of __RadFixedDocument__.
        

#### __[C#] Example 1: Create RadFixedPage and add it to a document.__

{{region radpdfprocessing-model-radfixedpage_0}}
	            RadFixedDocument document = new RadFixedDocument();
	            RadFixedPage page = new RadFixedPage();
	            document.Pages.Add(page);
	{{endregion}}



## Operating with RadFixedPage

There are several operations which you can execute directly over a __RadFixedPage__ instance.
        

### Add Content

__RadFixedPage__ is designed to hold any content element in the document model. There are several ways to achieve that.
            

__Example 2__ shows how to add a previously created ContentElement in a __RadFixedPage__.
            

#### __[C#] Example 2: Add content element to RadFixedPage__

{{region radpdfprocessing-model-radfixedpage_1}}
	            RadFixedPage page = new RadFixedPage();
	            page.Content.Add(contentElement);
	{{endregion}}



You can also use the __Add[Element]()__ methods of RadFixedPages's __Content__ property. The respective methods - AddPath(), AddTextFragment(), AddImage(), create the element, add it to the page and return it for your convenience.
            

### Add Annotation

You can add different annotations in __RadFixedPage__ by using the __Annotations__ collection.
            

__Example 3__ shows how to add a previously created annotation in a __RadFixedPage__.
            

#### __[C#] Example 3: Add annotation to RadFixedPage__

{{region radpdfprocessing-model-radfixedpage_2}}
	            RadFixedPage page = new RadFixedPage();
	            page.Annotations.Add(annotation);
	{{endregion}}



The other possible approach is using the __AddLink()__ method of the __Annotations__ property. The method creates the link, adds it to the page and returns it. More information on the topic is available in the
              
              Annotation article.
            

### Modifying Properties

RadFixedPage's API provides you with the ability to modify its properties.
            

__Example 4__ shows how you can change the __Rotation__ and __Size__ properties of a __RadFixedPage__.
            

#### __[C#] Example 4: Add annotation to RadFixedPage__

{{region radpdfprocessing-model-radfixedpage_3}}
	            RadFixedPage page = new RadFixedPage();
	            page.Rotation = Rotation.Rotate270;
	            page.Size = new Size(792, 1128);
	{{endregion}}



# See Also

 * [Model]({%slug radpdfprocessing-model%})

 * [RadFixedDocument]({%slug radpdfprocessing-model-radfixeddocument%})

 * [Annotations and Destinations]({%slug radpdfprocessing-model-annotations-and-destinations%})
