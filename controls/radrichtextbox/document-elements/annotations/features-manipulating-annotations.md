---
title: Manipulating Annotations
page_title: Manipulating Annotations
description: Check our &quot;Manipulating Annotations&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-document-elements-manipulating-annotations
tags: manipulating,annotations
published: True
position: 1
---

# Manipulating Annotations

This article outlines the most commonly used manipulations with regard to Annotations.

The types of manipulations that can be performed on annotations include:

* Presentation in the document;

* Retrieving annotations;

* Inserting an annotation;

* Deleting an annotation;

* Splitting an annotation at a given position.

## Presentation

By default all annotations are markup-only in the sense that they do not have any appearance. If you want to display a highlight, range brackets or anything else, you can use the UI layers feature of RadRichTextBox. You can read more about them in [this article]({%slug radrichtextbox-features-custom-ui-layers%}).        

## Methods for Retrieving Annotations

* RadDocument and DocumentSelection expose the following general methods for retrieving annotation markers or checking if such exist in the document/selection at all:



<snippet id='radrichtextbox-document-elements-annotations-features-manipulating-annotations-block_1-cs' />

* Methods for retrieving the containing annotations around a particular inline. This is particularly convenient if you would like to perform checks against the caret position. First, you can obtain the current inline like this:



<snippet id='radrichtextbox-document-elements-annotations-features-manipulating-annotations-block_2-cs' />

and then, check if this inline is contained in a range using one of the methods below:



<snippet id='radrichtextbox-document-elements-annotations-features-manipulating-annotations-block_3-cs' />

* More finely tuned methods that filter the annotation ranges at the time of their retrieval include:



<snippet id='radrichtextbox-document-elements-annotations-features-manipulating-annotations-block_4-cs' />

## Inserting Annotations

Annotations can be inserted in the document using the following method of [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}).        



<snippet id='radrichtextbox-document-elements-annotations-features-manipulating-annotations-block_5-cs' />

There are also some methods that insert specific types of annotations for the commonly used types, such as Hyperlinks, Comments, etc. For more information, check the respective article.

## Deleting Annotations

In order to delete an annotation, you need to obtain a reference to its range start first. After that, you can use the following method of [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}) to remove it.



<snippet id='radrichtextbox-document-elements-annotations-features-manipulating-annotations-block_6-cs' />

Note that this method will remove the annotation, but will keep its contents. In order to delete the contents as well, you can select it and use the Delete method of the editor:



<snippet id='radrichtextbox-document-elements-annotations-features-manipulating-annotations-block_7-cs' />

There are also some methods that that remove specific types of annotations for the commonly used types, such as Hyperlinks, Comments, etc. For more information, check the respective article.

## Splitting Annotations

Some user scenarios require that there would be an easy way to split annotation ranges. In such cases, one can use the following methods:        



<snippet id='radrichtextbox-document-elements-annotations-features-manipulating-annotations-block_8-cs' />

## See Also  
 * [Annotations Overview]({%slug radrichtextbox-features-document-elements-annotations%})
 * [Custom Annotations]({%slug radrichtextbox-features-document-elements-custom-annotations%})