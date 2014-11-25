---
title: Fields
page_title: Fields
description: Fields
slug: radrichtextbox-features-fields
tags: fields
published: True
position: 0
---

# Fields



Fields are a convenient way to show non-static data in the document. In this way, you could present different data to the end-user without actually changing the document content.
      

This topic contains the following sections:

* [Field Types](#field-types)

* [Display Modes](#display-modes)

* [Inserting a Field](#inserting-a-field)

* [Fields Update Priority](#fields-update-priority)

## Field Types

In RadDocument the base class for all fields is __CodeBasedField__. It is an abstract class that can be inherited from. Some of the implemented and ready-to-use field types are:

* __DateField__: Inserts the current date in one of the specified formats.
            

* __PageField__: Shows the current page number.
            

* __NumPagesField__: Shows the number of pages in the document.
            

* __MergeField__: Used in mail-merge scenarios. You can read more here: [Mail Merge]({%slug radrichtextbox-features-mail-merge%}).
            

* __IncludePictureField__: Specifies the URI from which an image must be retrieved.
            

* __DocumentVariableField__ А field which uses DocumentVariables. More information can be found here: [Document Variables]({%slug radrichtextbox-features-document-variables%}).
            

* __SequentialField__: Tracks the number of tables and figures inserted in the document before a place in the document, so that the __InsertCaption()__ method would use the correct number. Find more here: [Captions for Tables and Figures]({%slug radrichtextbox-features-captions-for-tables-and-figures%}).
            

* __StyleReferenceField__: The type of field that a reference field refers to when a cross-reference to a Heading style is inserted.
            

* __ReferenceField__: Used to refer to a bookmark or other type of field. It is inserted when a cross-reference to a table or figure caption is added to the document. Find more here: [Cross-Reference]({%slug radrichtextbox-features-cross-reference%}).
            

* __PageReferenceField__: Used in table of contents in order to be able to navigate to the respective page on Ctrl+Click.
            

* __HyperlinkField__: Inserted in hyperlinks to store information about the navigation URI.
            

* __TCField__: Used in table of contents to describe one entry. They include the text of the entry and the page reference field.
            

* __AuthorField__: The type of field is related to track changes, specifies the name of the user that has modified the document part. Read more here: [Track Changes]({%slug radrichtextbox-features-track-changes%}).
            

* __CitationField__: Inserted when you add a citation to the document.
            

* __BibliographyField__: Inserted in the document when you want to add information about the bibliographic sources used in the document. Read more here: [Bibliographic References]({%slug radrichtextbox-features-bibliographic-references%}).
            

## Display Modes

Fields normally have two modes – __Code__ and __Result__. When in code mode, they appear as {<FieldTypeName> [<field parameter>] [<switch> <switch parameter>]*}.
        

For instance, Page Fields appear as { PAGE }, Merge Fields as { MERGEFIELD FirstName } or { MERGEFIELD FirstName \b "text that will appear before the merge field if it is not empty" }.
        

In result mode, all fields get evaluated depending on some conditions – the place in the document where they appear in the case of page fields, the current mail merge record for merge fields, etc.

__MergeFields__ have one additional mode – __DisplayName__ that shows the property path they use in brackets of the type <<[PropertyPathHere]>>. Furthermore, there are specific methods and commands of the editor that change the display mode of merge fields or even remove them from the document altogether, replacing them with the ResultFragment. More information on this topic can be found in the [Mail Merge]({%slug radrichtextbox-features-mail-merge%}) article.
        

## Inserting a Field

Inserting any type of field in the document of an editor can be done with the __InsertField()__ method.
        

Insert a page field:

#### __C#__

{{region radrichtextbox-features-fields_0}}
    this.radRichTextBox.InsertField(new PageField());
{{endregion}}



Update of a field can be triggered from the context menu or using the __UpdateField()__ method of RadRichTextBox by passing the FieldRangeStart of the field as a parameter.
        

Update a field:

#### __C#__

{{region radrichtextbox-features-fields_1}}
    this.radRichTextBox.UpdateField(fieldStart);
{{endregion}}


You can also update all fields in the current document with the __UpdateAllFields()__ method of RadRichTextBox.
        

## Fields Update Priority

All field types in the context of RadDocument have update priority which determines when they should be updated when the __UpdateAllFields()__ method is invoked. Most fields have the default value 0. Changing it is needed in case a field depends on the evaluated value of another field to be properly evaluated.
        

Priority can specified through the __FieldsUpdateManager__ static class. The following code snippet shows how to set higher priority for a specific field type, causing all fields of this type to be updated before the rest of the field when calling UpdateAllField():
        

#### __C#__

{{region radrichtextbox-features-fields_2}}
    FieldsUpdateManager.RegisterFieldUpdatePriority(typeof(ReferenceField), 1000);
{{endregion}}

>tipHaving many different values for field priory is not recommended and may lead to performance degradation of the UpdateAllFields() method. The reason for this is that all fields with the same priority are updated in a batch update. Having more priority groups leads to execution of more batch updates.


# See Also

 * [Custom Fields]({%slug radrichtextbox-features-custom-fields%})

 * [Mail Merge]({%slug radrichtextbox-features-mail-merge%})
 
 * [CustomField SDK example](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/CustomField)
