---
title: Content Controls (Structured Document Tags) 
page_title: Content Controls
description: This article describes which content controls are supported in RadRichTextBox
slug: radrichtextbox-features-content-controls
tags: content controls, richtextbox
published: True
---

# Content Controls (Structured Document Tags)

Structured Document Tags (sdt) enable users to add specific semantics to part of the document: restricting input, binding to data source, modifying editing behavior etc. 

>note Currently, RadRichTextBox only visualize the value of the content controls and there is no UI that allow you to interact with them. The import and export operations will work with Office Open XML (docx) and XAML formats. When exporting to other formats the content controls will be lost.

## Content controls inside the document

The contented controls can be defined on __Block__, __Inline__, __Row__ or __Cell__ level. The content controls can contain other content controls as well. 

Currently the supported content controls are: 

* __Bibliography__
* __CheckBox__
* __Citation__
* __ComboBox__
* __Date__
* __DocumentPart__
* __DocumentPartGallery__
* __DropDownList__
* __Equation__
* __Group__
* __Picture__
* __RichText__
* __Text__
* __PlaceHolder__
* __RepeatingSection__
* __RepeatingSectionItem__

The following content controls are not supported by __Microsoft Word__:  
* __Bibliography__
* __Equation__


The above content controls share the following properties: 

* __Type:__ the type of the current content control. 
* __ID:__ each content control must have a an unique ID.
* __DataBinding:__ Gets or sets an XML mapping (DataBinding) that relates the content of associated SDT to a specific XML node.
* __Lock:__ This property controls if the entire content control or its contents can be edited or deleted. The possible values are:
    - __Unlocked:__ the content control can be edited and deleted. 
    - __SdtLocked:__ the content control can be edited but cannot be deleted.
    - __ContentLocked:__ the content control cannot be edited, the entire content control can be deleted.
    - __SdtContentLocked:__ the content control cannot be edited or deleted. 
* __Alias:__ Gets or sets the name for the associated content control.
* __OutlineColor:__ Gets or sets the color that is used for visualizing the outline.
* __OutlineAppearance__ Represents the different options for visualizing the outline of a content control.The possible values are:
    - __BoundingBoxes:__ The content is wrapped in a bounding box that may also contain a specific editor.
    - __Tags:__ The content is wrapped in design view tag.
    - __None:__ The content does not have outline visualization.



## Content controls that have specific properties. 

### CheckBox

The __CheckBox__ content control exposes two properties __CheckedState__ and __UnCheckedState__, both properties are of type __SdtCheckBoxState__ which allows you to set the respective character and its font. The __Checked__ property specifies whether the checkbox is checked.

### ComboBox and DropDownList

The __ComboBox__ and __DropDownList__ provider the user with options to choose from.The only difference is that the when using ComboBox you can add a value that is not in the data source.
* __Items:__ This property allows you to specify the predefined items. 
* __LastValue:__ This property return the currently selected value. 

### Date

The __Date__ content control allows you to enter a date by using a calendar. The dataContent control has the following properties:
* __DateFormat:__ Allows you to get/set the format string of the date. If it is omitted the default date format for the language is used.
* __LanguageId:__ Allows you to get/set the CultureInfo object for the date format.
* __DateTime:__ The current selected data, stored as string. 
* __Calendar:__ Allows you to select the calendar type.     


# See Also
* [Working with Content Controls]({%slug radrichtextbox-features-working-with-content-controls%})