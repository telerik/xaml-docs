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

* [Updating a Field](#updating-a-field)

* [Updating all Fields](#updating-all-fields)

## Field Types

In the RadDocument's model, the base class for all fields is __CodeBasedField__. It is an abstract class that can be inherited from. Some of the implemented and ready-to-use field types are:

* __DateField__: Inserts the current date in one of the specified formats.
            

* __PageField__: Shows the current page number.
            

* __NumPagesField__: Shows the number of pages in the document.
            

* __MergeField__: Used in mail-merge scenarios. You can read more here: [Mail Merge]({%slug radrichtextbox-features-mail-merge%}).
            

* __IncludePictureField__: Specifies the URI from which an image must be retrieved.
            

* __DocumentVariableField__ А field which uses DocumentVariables. More information can be found here: [Document Variables]({%slug radrichtextbox-features-document-variables%}).
            

* __SequentialField__: Tracks the number of tables and figures inserted in the document before a place in the document, so that the __InsertCaption()__ method would use the correct number. Find more here: [Captions for Tables and Figures]({%slug radrichtextbox-features-captions-for-tables-and-figures%}).
            

* __StyleReferenceField__: The type of field that a reference field refers to when a cross-reference to a Heading style is inserted.
            

* __ReferenceField__: Used to refer to a bookmark or other type of field. It is inserted when a cross-reference to a table or figure caption is added to the document. Find more here: [Cross-Reference]({%slug radrichtextbox-features-cross-reference%}).
            

* __PageReferenceField__: Inserts the page number of a referenced bookmark.
            

* __HyperlinkField__: Inserted in hyperlinks to store information about the navigation URI.
            

* __TableOfContentsField__: Shows a table of contents including headings and other specially marked parts of the document. Also can be configured to show table of figures or table of tables.
            

* __TCField__: Used to mark text that should be included as entry in TableOfContentsField. 
            

* __AuthorField__: The type of field is related to track changes, specifies the name of the user that has modified the document part. Read more here: [Track Changes]({%slug radrichtextbox-features-track-changes%}).
            

* __CitationField__: Inserted when you add a citation to the document.
            

* __BibliographyField__: Inserted in the document when you want to add information about the bibliographic sources used in the document. Read more here: [Bibliographic References]({%slug radrichtextbox-features-bibliographic-references%}).
            

## Display Modes

Fields normally have two modes – __Code__ and __Result__. When in code mode, they appear as {&lt;FieldTypeName&gt; [&lt;field parameter&gt;] [&lt;switch&gt; &lt;switch parameter&gt;]}.
        

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

## Updating a Field

Update of a field can be triggered from the context menu or using the __UpdateField()__ method by passing the corresponding FieldRangeStart of the field as a parameter.
        

Update a field:

#### __C#__

{{region radrichtextbox-features-fields_1}}
    this.radRichTextBox.UpdateField(fieldRangeStart);
{{endregion}}

## Updating all Fields

You can update all fields in the document with the __UpdateAllFields()__ method of __RadRichTextBox__. The method is optimized to perform better than updating fields one by one using the __Update__ method.
        
>tip Correctly updating all fields in a document works in almost all cases, but it’s not always possible as there are multiple dependencies between the fields. You can influence the way UpdateAllFields is executed by registering additional [update information for specific field types]({%slug radrichtextbox-features-custom-fields%}#integrating-with-updateallfields-operation).


## See Also

 * [Custom Fields]({%slug radrichtextbox-features-custom-fields%})

 * [Mail Merge]({%slug radrichtextbox-features-mail-merge%})
 
 * [CustomField SDK example](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/CustomField)
