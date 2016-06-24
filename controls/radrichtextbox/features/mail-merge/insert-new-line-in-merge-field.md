---
title: Insert a New Line in Merge Field
page_title: Insert a New Line in Merge Field
description: Insert a New Line in Merge Field
slug: radrichtextbox-features-mail-merge-insert-new-line-in-merge-field
tags: mail,merge,vertical,tab,line
published: True
position: 1
---

# Insert a New Line in Merge Field

In RadRichtextBox, you can insert a line break using the [Break element]({%slug radrichtextbox-features-document-elements-break%}). However, when working with mail merge fields, inserting a similar document element is not possible. This is why we introduced support for the vertical tab symbol. This article will explain how you could use this symbol in order to insert a new line in the document content and in a merge field. 

* [What is the Vertical Tab Symbol?](#what-is-the-vertical-tab-symbol)

* [How to Insert a Vertical Tab in RadDocument?](#how-to-insert-a-vertical-tab-in-raddocument)

* [Insert a Line Break Before/After a Merge Field If the Field Result Isn't Empty](#insert-a-line-break-beforeafter-a-merge-field-if-the-field-result-isnt-empty)

* [Using Vertical Tab in a DocumentVariableField](#using-vertical-tab-in-a-documentvariablefield)


## What is the Vertical Tab Symbol?

The vertical tab character is __*"\v"*__. It can be inserted directly into a document as a string or through the merge field switches. The vertical tab character itself won’t be preserved, but it is evaluated to a [Break element]({%slug radrichtextbox-features-document-elements-break%}) of type LineBreak.

## How to Insert a Vertical Tab in RadDocument?


The [RadDocumentEditor class]({%slug radrichtextbox-features-raddocumenteditor%}) exposes the Insert() method that allows you add text to the document. **Example 1** shows how to insert a vertical tab with this method.

#### __[C#] Example 1: Insert vertical tab through RadDocumentEditor__

{{region radrichtextbox-features-mail-merge-Insert-new-line-in-merge-field_0}}

	radDocumentEditor.Insert("\v");
{{endregion}}

#### __[VB.NET] Example 1: Insert vertical tab through RadDocumentEditor__

{{region radrichtextbox-features-mail-merge-Insert-new-line-in-merge-field_1}}

	radDocumentEditor.Insert("\v")
{{endregion}}


Another option is to create a [Span]({%slug radrichtextbox-features-document-elements-span%}) and assign the vertical tab character to it. 

#### __[C#] Example 2: Create vertical tab through document model__

{{region radrichtextbox-features-mail-merge-Insert-new-line-in-merge-field_2}}

	Span span = new Span("\v");
{{endregion}}


#### __[VB.NET] Example 2: Create vertical tab through document model__

{{region radrichtextbox-features-mail-merge-Insert-new-line-in-merge-field_3}}

	Dim span As New Span("\v")
{{endregion}}
When inserted in the document, the vertical tab symbol will be replaced with a Break element of type LineBreak.

## Insert a Line Break Before/After a Merge Field If the Field Result Isn't Empty

You can use the vertical tab symbol when you need to insert a line break before or after the result of a merge field only if it is not empty.

#### __[C#] Example 3: Insert vertical tab in the switch of a merge field__

{{region radrichtextbox-features-mail-merge-Insert-new-line-in-merge-field_4}}

	MergeField mergeField = new MergeField() { PropertyPath = "FirstName", TextAfterIfNotEmpty="\v" };
{{endregion}}


#### __[VB.NET] Example 3: Insert vertical tab in the switch of a merge field__

{{region radrichtextbox-features-mail-merge-Insert-new-line-in-merge-field_5}}

	Dim mergeField As New MergeField() With {.PropertyPath = "FirstName", .TextAfterIfNotEmpty = "\v"}
{{endregion}}


### Using End of Paragraph "\r\n" Instead of Vertical Tab

You could use the *“\r\n”* in the TextBeforeIfNotEmpty or TextAfterIfNotEmpty switches to create a line break as well. 

#### __[C#] Example 4: Insert \r\n in the switch of a merge field__

{{region radrichtextbox-features-mail-merge-Insert-new-line-in-merge-field_6}}

	MergeField mergeField = new MergeField() { PropertyPath = "FirstName", TextAfterIfNotEmpty="\r\n" };
{{endregion}}


#### __[VB.NET] Example 4: Insert \r\n in the switch of a merge field__

{{region radrichtextbox-features-mail-merge-Insert-new-line-in-merge-field_7}}

	Dim mergeField As New MergeField() With {.PropertyPath = "FirstName", .TextAfterIfNotEmpty = "\r\n"}
{{endregion}}


>important The vertical tab is serialized only when it is used as a value for a document variable. In all other cases, it  will be stripped from the document content on export.


## Using Vertical Tab in a DocumentVariableField

The suggested approach in scenarios that include export is to use a [document variable]({%slug radrichtextbox-features-document-variables%}) as a nested field. Using this approach, the field will be persisted when importing or exporting XAML and DOCX documents.

#### __[C#] Example 5: Insert vertical in the switch of a merge field__

{{region radrichtextbox-features-mail-merge-Insert-new-line-in-merge-field_8}}

	string verticalTabSymbol = "\v";
	string verticalTabKey = "verticalTab";
	this.radRichTextBox.Document.DocumentVariables.Add(verticalTabKey, verticalTabSymbol);
	
	DocumentVariableField documentVariableField = new DocumentVariableField();
	documentVariableField.VariableName = verticalTabKey;
	
	var mergeField = new MergeField() { PropertyPath = "FirstName" };
	mergeField.SetPropertyValue(MergeField.TextAfterIfNotEmptyProperty, documentVariableField);
	
	this.radRichTextBox.InsertField(mergeField, FieldDisplayMode.Result);

{{endregion}}


#### __[VB.NET] Example 5: Insert vertical in the switch of a merge field__

{{region radrichtextbox-features-mail-merge-Insert-new-line-in-merge-field_9}}

    Dim verticalTabSymbol As String = "\v"
    Dim verticalTabKey As String = "verticalTab"
    Me.radRichTextBox.Document.DocumentVariables.Add(verticalTabKey, verticalTabSymbol)

    Dim documentVariableField As New DocumentVariableField()
    documentVariableField.VariableName = verticalTabKey

    Dim mergeField = New MergeField() With {.PropertyPath = "FirstName"}
    mergeField.SetPropertyValue(MergeField.TextAfterIfNotEmptyProperty, documentVariableField)

    Me.radRichTextBox.InsertField(mergeField, FieldDisplayMode.Result)

{{endregion}}

As a value of the document variable you could insert the "\r\n" as well. Have in mind that this value could be exported to DOCX only.

# See Also

* [Mail Merge]({%slug radrichtextbox-features-mail-merge%})
* [Break]({%slug radrichtextbox-features-document-elements-break%})
* [Document Variables]({%slug radrichtextbox-features-document-variables%})
* [RadDocumentEditor]({%slug radrichtextbox-features-raddocumenteditor%})
 