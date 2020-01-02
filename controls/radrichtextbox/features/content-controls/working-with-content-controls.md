---
title: Working with content controls
page_title:  Working with content controls
description: This article show you you can access the content controls in code
slug: radrichtextbox-features-working-with-content-controls
tags: content controls, richtextbox
published: True
---

# Working with Content Controls

This article shows some examples of how you can access a content control and modify their properties from the code. In general, the content controls are marked with annotations and you can manipulate them as such. Detailed information is available here: [Manipulating Annotations]({%slug radrichtextbox-features-document-elements-manipulating-annotations%}) 

### Get the content controls. 

The content controls can be retrieved by using the __GetAnnotationMarkersOfType__ method. This is demonstrated in the following example. 

#### Example 1: Get all Content Controls

#### __C#__

{{region radrichtextbox-features-content-controls_0}}
    var content_controls = radRichTextBox.Document.GetAnnotationMarkersOfType<SdtStart>();
    foreach (var item in content_controls)
    {
        Console.WriteLine("Type: {0} ID:{1}", item.SdtProperties.Type, item.SdtProperties.ID);
    }
{{endregion}}

### Set content controls properties.

This example show how one can iterate the items and add an item to to a existing ComboBox content control. 

#### Example 2: Adding items to a ComboBox or a DropDownList

#### __C#__

{{region radrichtextbox-features-content-controls_1}}
    foreach (var item in content_controls)
    {
        if (item.SdtProperties.Type == SdtType.ComboBox)
        {
            var properties = item.SdtProperties as ComboBoxProperties;

            var newItem = new ListItem();
            newItem.DisplayText = "New Item Text";

            properties.Items.Add(newItem);
        }
    }
{{endregion}}

# See Also
* [Content Controls Overview]({%slug radrichtextbox-features-content-controls%})