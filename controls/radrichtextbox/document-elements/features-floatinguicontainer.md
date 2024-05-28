---
title: FloatingUIContainer
page_title: FloatingUIContainer
description: Check our &quot;FloatingUIContainer&quot; documentation article for the RadRichTextBox control.
slug: radrichtextbox-features-document-elements-floatinguicontainer
tags: floatinguicontainer
published: True
position: 9
---

# FloatingUIContainer

`RadRichTextBox` provides you with the functionality of enclosing custom UI elements in its document that you can display over its content. To do so, you can use the `FloatingUIContainer` element, which can wrap any object of type `UIElement`, e.g. a button, an image or even a media element or media player. It is inserted as an [inline]({%slug radrichtextbox-features-document-elements-hierarchy%})

The following example showcases how to add a `RadButton` element inside a FloatingUIContainer instance and display it in the RadDocument:

#### __[C#] Adding a UIElement to a FloatingUIContainer__
{{region radrichtextbox-features-document-elements-floatinguicontainer-0}}
    RadButton radButton = new RadButton()
    {
        Content = "Hello",
        Width = 200,
        Height = 40
    };

    FloatingUIContainer floatingContainer = new FloatingUIContainer(radButton, new Size(radButton.Width,    radButton.Height));

    radRichTextBox.InsertInline(floatingContainer);
{{endregion}}

__RadRichTextBox with a FloatingUIContainer containing a RadButton element__

![RadRichTextBox with a FloatingUIContainer containing a RadButton element](images/radrichtextbox-features-document-elements-floatinguicontainer-0.png)

## Not Supported Scenarios

* There isn't UI for resizing/ deleting the FloatingUIContainer element. Changing the properties of the FloatingUIContainer is not possible through the UI.
* The FloatingUIContainer is not copyable. 
* The FloatingUIContainer cannot be dragged and dropped.
* The FloatingUIContainer element can only be imported/exported from/to a XAML format via the `XamlFormatProvider` class. To perform additional logic when importing/exporting the FloatingUIContainer and its layout, subscribe to the the `ExportSettings.InlineUIContainerExporting` and `ImportSettings.InlineUIContainerImported` events of the XamlFormatProvider instance.

>tip To learn more about XamlFormatProvider class, check this [article](%slug radrichtextbox-import-export-using-xamlformatprovider%).