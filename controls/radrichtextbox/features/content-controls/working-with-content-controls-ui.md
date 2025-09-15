---
title: Working with Content Controls UI
page_title: Working with Content Controls UI
description: This article describes how to work with the Content Controls UI.
slug: radrichtextbox-features-working-with-content-controls-ui
tags: content controls, richtextbox
published: True
---

# Content Controls UI
The easiest way to create a content control is through the user interface. You can also create them programmatically following the [Working with Content Controls Programmatically]({%slug radrichtextbox-features-working-with-content-controls%}) article. 

## User Interface
You can specify which type of content control you wish to insert from the predefined UI of RadRichTextBox. You can select it from the Developer Tab which is part of the [RadRichTextBoxRibbonUI]({%slug radrichtextbox-features-radrichtextboxribbonui%}) by default:

![RadRichTextBox Features Content Controls 00](images/RadRichTextBox_Features_Content_controls_00.jpg)

You can choose between the following content controls:
* **Rich Text** content control
* **Plain Text** content control
* **Picture** content control
* **Repeating Section** content control
* **Check Box** content control
* **Combo Box** content control
* **Drop-Down List**  content control
* **Date Picker** content control

### Content Controls Commands
The following commands related to the content controls functionality are available in the Commands property of the RadRichTextBox:

* **InsertStructuredDocumentTagCommand**

    In order to successfully execute the InsertStructuredDocumentTagCommand you have to pass the wanted content control type (**SdtType**) as a CommandParameter:

    #### [XAML] Example 1: Binding the command
    ```XAML

        <telerik:RadRibbonButton 
                        telerik:ScreenTip.Description="Insert a picture content control."
                        SmallImage="{telerik:IconResource IconRelativePath=16/contentControl-picture.png,IconSources={StaticResource IconSources}}" 
                        telerik:RadRichTextBoxRibbonUI.RichTextCommand="{Binding InsertStructuredDocumentTagCommand}"
                        CommandParameter="Picture"
                        Size="Small" telerik:ScreenTip.Title="Picture Content Control">
        </telerik:RadRibbonButton>
    ```

* **ShowContentControlPropertiesDialogCommand**

    #### [XAML] Example 2: Binding the command

    ```XAML

        <telerik:RadRibbonButton x:Name="propertiesDialogButton"
                        telerik:ScreenTip.Description="View or modify properties for the selected control."
                        SmallImage="{telerik:IconResource IconRelativePath=16/contentControl-properties.png,IconSources={StaticResource IconSources}}"
                        telerik:RadRichTextBoxRibbonUI.RichTextCommand="{Binding ShowContentControlPropertiesDialogCommand}"
                        CommandParameter="Sdt"
                        Size="Medium" telerik:ScreenTip.Title="Control Properties"
                        Text="Properties">
        </telerik:RadRibbonButton>
    ```

    >tip In order to learn more about commands and how to use them refer to [Commands]({%slug radrichtextbox-features-commands%}) help article.

### Dialogs
You can manipulate the properties for every specific content control using the assigned Properties Dialog which you can open from the Properties button.

![RadRichTextBox Features Content Controls 01](images/RadRichTextBox_Features_Content_controls_01.jpg)

These are the predefined Properties Dialogs:
* **RichTextPropertiesDialog**
* **PlainTextPropertiesDialog**
* **PicturePropertiesDialog**
* **RepeatingSectionPropertiesDialog**
* **CheckBoxPropertiesDialog**
* **DropDownListPropertiesDialog**
* **DatePickerPropertiesDialog**

![RadRichTextBox Features Content Controls 02](images/RadRichTextBox_Features_Content_controls_02.png)

# See also
* [Content Controls Overview]({%slug radrichtextbox-features-content-controls%})
* [Manipulating Annotations]({%slug radrichtextbox-features-document-elements-manipulating-annotations%}) 
* [Working with Content Controls]({%slug radrichtextbox-features-working-with-content-controls%})
