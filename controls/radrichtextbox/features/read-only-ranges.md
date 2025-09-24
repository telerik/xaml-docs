---
title: Read Only Ranges
page_title: Read Only Ranges
description: Check our &quot;Read Only Ranges&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
slug: radrichtextbox-features-read-only-ranges
tags: read,only,ranges
published: True
---

# Read Only Ranges



The following article explains how to use read only ranges in RadRichTextBox
      

## What is a Read Only range?

Read only ranges are a convenient way to restrict some of the content of a particular document from editing. When content is in a read only range, users are unable to edit, format or delete it. What is more, manipulating the document from code with __RadRichTextBox__'s API or commands is also not possible. Additionally, the predefined UI - __RadRichTextBoxRibbonUI__ corresponds to the state of the document when the caret is located in a read only region by fading out the parts which operate with the document content in order to notify users they cannot edit this content.
        

>tip__RadRichTextBox__ also provides another, more advanced option for restricting content which allows particular users or groups of users to edit different parts of a document. For more information on this check the documentation of the [Document Protection]({%slug radrichtextbox-features-document-protection%}) feature.
          

A read only annotation range is represented in __RadDocument__'s structure by two paired annotation markers – a __ReadOnlyRangeStart__ instance and a __ReadOnlyRangeEnd__ instance. Both are inline elements, thus users are able to edit the document prior and after the annotation markers. More on Annotations you can find [here]({%slug radrichtextbox-features-document-elements-annotations%}).
        

>As read only ranges do not have a proper equivalent in most of the supported export formats (like DOCX or HTML), they are only exported to __RadDocument__'s native format – XAML.
          

## Insert Read Only Range

__RadDocument__ has two states - measured and non-measured. Depending on the state of the document you can insert a read only range in one of the following ways. 

### Insert in Measured Document

When the document is measured (for example, shown in a __RadRichTextBox__), you can select the part of the document which you want to make read-only and use the __InsertReadOnly()__ method of __RadRichTextBox__ or [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%}) respectively:
            



```C#
    this.radRichTextBox.InsertReadOnlyRange();
```
```VB.NET
    Me.radRichTextBox.InsertReadOnlyRange()
```


>tipGenerally, editing the content of a read only range is not possible through the UI and through __RadRichtextBox__'s API. However, when manipulating a document using __RadDocumentEditor__ you can set the __RespectReadOnlyRanges__ property of __RadDocumentEditor__ to *false* and read only ranges will be ignored.
      
### Insert in Non-measured Document

As opposed to when inserting with one of the methods of __RadRichTextBox__, when building a document from code you have to make sure that the annotations in it are explicitly paired. This can be achieved with the __PairWithStart()__ method of __AnnotationRangeEnd__. Here is an example which builds a __RadDocument__ with a read only range in it.
            



```C#
    RadDocument document = new RadDocument();
    Section section = new Section();
    Paragraph paragraph = new Paragraph();
    Span span = new Span("Content prior range[");
    Span span2 = new Span("]Content after range");
    Span readOnlyContent = new Span("READ ONLY");

    ReadOnlyRangeStart rangeStart = new ReadOnlyRangeStart();
    ReadOnlyRangeEnd rangeEnd = new ReadOnlyRangeEnd();
    rangeEnd.PairWithStart(rangeStart);

    paragraph.Inlines.Add(span);
    paragraph.Inlines.Add(rangeStart);
    paragraph.Inlines.Add(readOnlyContent);
    paragraph.Inlines.Add(rangeEnd);
    paragraph.Inlines.Add(span2);

    section.Blocks.Add(paragraph);
    document.Sections.Add(section);
```
```VB.NET
    Dim document As New RadDocument()
    Dim section As New Section()
    Dim paragraph As New Paragraph()
    Dim span As New Span("Content prior range[")
    Dim span2 As New Span("]Content after range")
    Dim readOnlyContent As New Span("READ ONLY")

    Dim rangeStart As New ReadOnlyRangeStart()
    Dim rangeEnd As New ReadOnlyRangeEnd()
    rangeEnd.PairWithStart(rangeStart)

    paragraph.Inlines.Add(span)
    paragraph.Inlines.Add(rangeStart)
    paragraph.Inlines.Add(readOnlyContent)
    paragraph.Inlines.Add(rangeEnd)
    paragraph.Inlines.Add(span2)

    section.Blocks.Add(paragraph)
    document.Sections.Add(section)
```



## Delete Read Only Range

In order to remove a read only range, you should simply call the __DeleteReadOnlyRange()__ method of __RadRichTextBox__ or __RadDocumentEditor__:
        



```C#
    this.radRichTextBox.DeleteReadOnlyRange();
```
```VB.NET
    Me.radRichTextBox.DeleteReadOnlyRange()
```



The above-demonstrated method will delete the read only range the caret is currently located in and make the content which was in it editable again.
        

Additionally, if you can obtain a reference to a particular __ReadOnlyRangeStart__ element in the document, you can delete it with the __DeleteReadOnlyRange(ReadOnlyRangeStart start)__ method. For example, if you want to delete a particular range based on its __Tag__, you can do it as follows:
        



```C#
    ReadOnlyRangeStart start = this.radRichTextBox.Document.EnumerateChildrenOfType<ReadOnlyRangeStart>().Where(x => x.Tag == "ReadOnly").FirstOrDefault();
    if (start != null)
    {
        this.radRichTextBox.DeleteReadOnlyRange(start);
    }
```
```VB.NET
    Dim start As ReadOnlyRangeStart = Me.radRichTextBox.Document.EnumerateChildrenOfType(Of ReadOnlyRangeStart)().Where(Function(x) x.Tag = "ReadOnly").FirstOrDefault()
    If start IsNot Nothing Then
	    Me.radRichTextBox.DeleteReadOnlyRange(start)
    End If
```



## See Also

 * [Annotations Overview]({%slug radrichtextbox-features-document-elements-annotations%})

 * [Manipulating Annotations]({%slug radrichtextbox-features-document-elements-manipulating-annotations%})

 * [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%})

 * [Document Protection]({%slug radrichtextbox-features-document-protection%})
