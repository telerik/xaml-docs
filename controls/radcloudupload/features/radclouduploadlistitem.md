---
title: RadCloudUploadListItem
page_title: RadCloudUploadListItem
description: RadCloudUploadListItem
slug: radcloudupload-radclouduploadlistitem
tags: radclouduploadlistitem
published: True
position: 8
---

# RadCloudUploadListItem





## 

The __RadCloudUploadListItem__ is part of the __RadCloudUpload__ control. It visualizes the progress and the state of the uploaded file. It has some built-in buttons in its template, such as __Upload__, __Cancel__ and __Close__. They control the uploading process.
        

>While a file is uploading the __Upload__ button will be collapsed or replaced by the __Cancel__ button.

This is a visual control presenting a file upload and it contains no cloud-upload logic. All upload-related tasks like progress-tracking and cancellation are handled by a [Provider]({%slug radcloudupload-features-providers%}). 
        

## Buttons

The __RadCloudUploadListItem__ control has several buttons in its template. By default the only button that is visible is the __Close__ button. You can use the __Buttons__ property to specify which of the available ones to be shown. This property is a flags enum of type __CloudUploadListItemCommandButtons__. In XAML you can use the property like this:
        

#### __XAML__
    <Style TargetType="telerik:RadCloudUploadListItem">
       <Setter Property="Buttons" Value="Upload,Cancel,Close" />
    </Style>



>This property only toggles the buttons' visibility. It does not control the order of appearance. If you want to reorder the buttons, or add a custom ones you need to retemplate the control.

# See Also

 * [CloudUploadFile]({%slug radcloudupload-cloud-upload-file%})

 * [Template Structure]({%slug radcloudupload-templates-template-structure%})
