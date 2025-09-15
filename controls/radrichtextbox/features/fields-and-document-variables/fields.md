---
title: Fields
page_title: Fields
description: Check our &quot;Fields&quot; documentation article for the RadRichTextBox {{ site.framework_name }} control.
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

In the model of RadDocument, the base class for all fields is __CodeBasedField__. It is an abstract class that can be inherited from. 

>All the supported field codes and switches for them are listed in the [Supported Fields]({%slug radrichtextbox-features-fields-supported-fields%}) topic.

## Display Modes

Fields normally have two modes – __Code__ and __Result__. When in code mode, they appear as {&lt;FieldTypeName&gt; [&lt;field parameter&gt;] [&lt;switch&gt; &lt;switch parameter&gt;]}.
        

For instance, Page Fields appear as { PAGE }, Merge Fields as { MERGEFIELD FirstName } or { MERGEFIELD FirstName \b "text that will appear before the merge field if it is not empty" }.
        

In result mode, all fields get evaluated depending on some conditions – the place in the document where they appear in the case of page fields, the current mail merge record for merge fields, etc.

__MergeFields__ have one additional mode – __DisplayName__ that shows the property path they use in brackets of the type <<[PropertyPathHere]>>. Furthermore, there are specific methods and commands of the editor that change the display mode of merge fields or even remove them from the document altogether, replacing them with the ResultFragment. More information on this topic can be found in the [Mail Merge]({%slug radrichtextbox-features-mail-merge%}) article.
        

## Inserting a Field

Inserting any type of field in the document of an editor can be done with the __InsertField()__ method.
        

Insert a page field:

#### __C#__

```C#
    this.radRichTextBox.InsertField(new PageField());
```

## Updating a Field

Update of a field can be triggered from the context menu or using the __UpdateField()__ method by passing the corresponding FieldRangeStart of the field as a parameter.
        

Update a field:

#### __C#__

```C#
    this.radRichTextBox.UpdateField(fieldRangeStart);
```

## Updating all Fields

You can update all fields in the document with the __UpdateAllFields()__ method of __RadRichTextBox__. The method is optimized to perform better than updating fields one by one using the __Update__ method.
        
>tip Correctly updating all fields in a document works in almost all cases, but it’s not always possible as there are multiple dependencies between the fields. You can influence the way UpdateAllFields is executed by registering additional [update information for specific field types]({%slug radrichtextbox-features-custom-fields%}#integrating-with-updateallfields-operation).


## See Also

 * [Supported Field Codes]({%slug radrichtextbox-features-fields-supported-fields%})
 * [Custom Fields]({%slug radrichtextbox-features-custom-fields%})
 * [Mail Merge]({%slug radrichtextbox-features-mail-merge%}) 
 * [CustomField SDK example](https://github.com/telerik/xaml-sdk/tree/master/RichTextBox/CustomField)