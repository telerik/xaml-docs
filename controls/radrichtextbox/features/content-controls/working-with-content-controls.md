---
title: Working with Content Controls
page_title:  Working with Content Controls
description: This article show you you can access the content controls in code.
slug: radrichtextbox-features-working-with-content-controls
tags: content controls, richtextbox
published: True
---

# Working with Content Controls Programmatically

This article shows some examples of how you can insert content controls or access existing and modify their properties from the code. In RadRichTextBox, the content controls are marked with annotations and you can manipulate them as such. Detailed information is available in the [Manipulating Annotations]({%slug radrichtextbox-features-document-elements-manipulating-annotations%}) topic.

## Manipulate Existing Content Controls

### Get the Content Controls 

The content controls can be retrieved by using the __GetAnnotationMarkersOfType__ method.

#### Example 1: Get all content controls



<snippet id='radrichtextbox-features-content-controls-working-with-content-controls-block_1-cs' />

### Set Content Controls Properties

This example show how one can iterate the items and add an item to to a existing ComboBox content control. 

#### Example 2: Adding items to a ComboBox or a DropDownList



<snippet id='radrichtextbox-features-content-controls-working-with-content-controls-block_2-cs' />

## Insert New Content Controls

New content controls can be inserted trough one of the overloads of the **InsertStructuredDocumentTag** method accessible from **RadRichTextBox** and [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}):

#### Example 3: Inserting a content control



<snippet id='radrichtextbox-features-content-controls-working-with-content-controls-block_3-cs' />

#### Example 4: Inserting a content control using content control type



<snippet id='radrichtextbox-features-content-controls-working-with-content-controls-block_4-cs' />

#### Example 5: Inserting a content control using content control properties



<snippet id='radrichtextbox-features-content-controls-working-with-content-controls-block_5-cs' />

# See Also
* [Content Controls Overview]({%slug radrichtextbox-features-content-controls%})
* [Manipulating Annotations]({%slug radrichtextbox-features-document-elements-manipulating-annotations%})
* [Working with Content Controls UI]({%slug radrichtextbox-features-working-with-content-controls-ui%})