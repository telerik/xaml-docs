---
title: InlineUIContainer
page_title: InlineUIContainer
description: Check our &quot;InlineUIContainer&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-document-elements-inlineuicontainer
tags: inlineuicontainer
published: True
position: 7
---

# InlineUIContainer

__RadRichTextBox__ provides you with the functionality of enclosing custom UI elements in its document. This is achieved with the help of a special type of inline document element called __InlineUIContainer__, which can wrap any object of type System.Windows.__UIElement__, e.g. a button, an image or even a media element or media player.
      
The __InlineUIContainer__ is an inline element, so it should be placed in a __Block__ that can contain inline elements (e.g. __Paragraph__).      

## Add UI Element to an InlineUIContainer

You can add any element that derives from the UIElement class inside the __InlineUIContainer__. To do that, simply wrap the desired element inside the tag of the __InlineUIContainer__ in case you are defining it in XAML. If you are using code, use the __UIElement__ property of the container. Here is a simple example with a __Button__.        

>In order to utilize the __InlineUIContainer__, you have to set its __Height__ and __Width__ explicitly (or use the constructor that takes a __Size__ as a parameter). Otherwise, they will not be shown in the document.          

__Example 1: Add UI Element to an InlineUIContainer__  
<snippet id='radrichtextbox-document-elements-features-inlineuicontainer-block_1-xaml' />

__Example 1: Add UI Element to an InlineUIContainer__  
<snippet id='radrichtextbox-document-elements-features-inlineuicontainer-block_2-cs' />
<snippet id='radrichtextbox-document-elements-features-inlineuicontainer-block_3-vb' />

__Example 2__ is a more complex example, which demonstrates how to implement a Button that inserts a MediaElement inside the __RadRichTextBox__'s document.

__Example 2: Add MediaElement on Button Click__ 
<snippet id='radrichtextbox-document-elements-features-inlineuicontainer-block_4-cs' />
<snippet id='radrichtextbox-document-elements-features-inlineuicontainer-block_5-vb' />

## Specifics

>important InlineUIContainer elements are not copyable. 

The following scenarios are affected:

* Drag-and-drop operation	
* Copy/paste operation	
* Update of the layout when the InlineUIContainer is in the header/footer
* Print operation 

The reason is that copying InlineUIContainer involves cloning of the internal UIElement, which cannot be handled in a generic way. 

To enable copying of InlineUIContainers in your application, you can create a custom object, which can copy the UIElement inside the container. What you need to do is to inherit the InlineUIContainer class and override IsCopyable, CreateNewElementInstance(), CopyPropertiesFromOverride(). The container and its parts are copied in the CopyPropertiesFromOverride() method, so you should ensure that the override copies the UIElement inside the container as well.

__Example 3: Implement CopyableInlineUIContainer for a Button as underlying UIElement__
<snippet id='radrichtextbox-document-elements-features-inlineuicontainer-block_6-cs' />
<snippet id='radrichtextbox-document-elements-features-inlineuicontainer-block_7-vb' />

There is a very generic option for copying UIElement objects, which might help in most of the cases. However, have in mind that depending on the UI elements on which it will be invoked, **the implementation might differ**.

__Example 4: Copy UI Element__
<snippet id='radrichtextbox-document-elements-features-inlineuicontainer-block_8-cs' />
<snippet id='radrichtextbox-document-elements-features-inlineuicontainer-block_9-vb' />

## Import/Export InlineUIContainers

Most features that __RadRichTextBox__ provides are also supported in the format providers that it uses for export and import.        

>tip For more information on Import/Export, please refer to [this topic]({%slug radrichtextbox-features-import-export%}).          

However, as the UIElement class is a WPF specific concept, some format providers support them in a non-standard way and others do not support them at all.

### Exporting InlineUIContainers:

Different approaches have been adopted when it comes to exporting inline UI containers via the format providers:

* __XamlFormatProvider__: Inline UI containers are serialized as expected, thus ensuring lossless export in simple cases, e.g. when a button is in the container. Custom attached properties may not be exported.            

* __HtmlFormatProvider__: The inline UI containers are serialized as XAML and are included in the HTML as comments. If the user handles the __InlineUIContainerExporting__ event, they can provide their own implementation for the export of the UI elements by accessing the properties of the __InlineUIContainerExportingEventArgs__ and setting the ones they need. The __CommentContent__ contains the XAML serialization and the __HtmlContent__ string property can be set to the desired user-defined HTML equivalent of the UI element. It will appear when the page is rendered outside __RadRichTextBox__. The UI element can also be omitted from the document altogether.

![{{ site.framework_name }} RadRichTextBox Inline UI Container](images/RadRichTextBox_Features_LayoutElements_InlineUIContainer_01.png)

* __DocxFormatProvider__: All __InlineUIContainers__ are ignored as the Microsoft Word concept of controls is quite different.
            

* __RtfFormatProvider__: All __InlineUIContainers__ are ignored as the RTF standard does not have a concept for similar elements.


* __PdfFormatProvider__: The __InlineUIContainers__ are taken a snapshot of and included in the export. If you like, you can prevent that by setting the __InlineUIContainersExportMode__ property of the provider to __None__.
	![{{ site.framework_name }} RadRichTextBox Inline UI Containers Export Mode None](images/RadRichTextBox_Features_LayoutElements_InlineUIContainer_02.png)

### Importing InlineUIContainers

There are some differences between the format providers when it comes to importing __InlineUIContainers__, too.

* __XamlFormatProvider__: All inline UI containers are deserialized and imported.

* __DocxFormatProvider__: There cannot be any inline UI containers in DOCX, as they are not exported in the first place.

* __RtfFormatProvider__: There cannot be any inline UI containers in RTF, as they are not exported in the first place.            

* __PdfFormatProvider__: PDF import is currently not supported.

## See Also  
* [Paragraph]({%slug radrichtextbox-features-document-elements-paragraph%})
* [Section]({%slug radrichtextbox-features-document-elements-section%})
* [RadDocument]({%slug radrichtextbox-features-document-elements-raddocument%})