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

#### __C#__

```C#

    IEnumerable<SdtRangeStart> content_controls = this.radRichTextBox.Document.GetAnnotationMarkersOfType<SdtRangeStart>();
    foreach (SdtRangeStart item in content_controls)
    {
        Console.WriteLine("Type: {0} ID:{1}", item.SdtProperties.Type, item.SdtProperties.ID);
    }
```

### Set Content Controls Properties

This example show how one can iterate the items and add an item to to a existing ComboBox content control. 

#### Example 2: Adding items to a ComboBox or a DropDownList

#### __C#__

```C#

    foreach (SdtRangeStart item in content_controls)
    {
        if (item.SdtProperties.Type == SdtType.ComboBox)
        {
            ComboBoxProperties properties = item.SdtProperties as ComboBoxProperties;

            ListItem newItem = new ListItem();
            newItem.DisplayText = "New Item Text";

            properties.Items.Add(newItem);
        }
    }
```

## Insert New Content Controls

New content controls can be inserted trough one of the overloads of the **InsertStructuredDocumentTag** method accessible from **RadRichTextBox** and [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}):

#### Example 3: Inserting a content control

#### __C#__

```C#

    this.radRichTextBox.InsertStructuredDocumentTag();
    // OR
    RadDocumentEditor editor = new RadDocumentEditor(this.radRichTextBox.Document);
    editor.InsertStructuredDocumentTag();
```

#### Example 4: Inserting a content control using content control type

#### __C#__

```C#

    this.radRichTextBox.InsertStructuredDocumentTag(SdtType.CheckBox);
    // OR
    RadDocumentEditor editor = new RadDocumentEditor(this.radRichTextBox.Document);
    editor.InsertStructuredDocumentTag(SdtType.CheckBox);
```

#### Example 5: Inserting a content control using content control properties

#### __C#__

```C#

    SdtProperties sdtProperties = new SdtProperties(SdtType.RichText)
    {
        Alias = "AliasName",
        Lock = Lock.SdtContentLocked,
    };
    this.radRichTextBox.InsertStructuredDocumentTag(sdtProperties);
    // OR
    RadDocumentEditor editor = new RadDocumentEditor(this.radRichTextBox.Document);
    editor.InsertStructuredDocumentTag(sdtProperties);
```

# See Also
* [Content Controls Overview]({%slug radrichtextbox-features-content-controls%})
* [Manipulating Annotations]({%slug radrichtextbox-features-document-elements-manipulating-annotations%})
* [Working with Content Controls UI]({%slug radrichtextbox-features-working-with-content-controls-ui%})
