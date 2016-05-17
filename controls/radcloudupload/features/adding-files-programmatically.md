---
title: Adding Files Programmatically
page_title: Adding Files Programmatically
description: Adding Files Programmatically
slug: radcloudupload-features-adding-files-programmatically
tags: adding, items, files, manually, programmatically, code, code-behind
published: True
position: 0
---

# Adding Files Programmatically

__RadCloudUpload__ allows you to prepare files for upload in code. This can be done through the __AddFile__ method of the control. The method will create a new __CloudUploadFile__ object and add it in the __Items__ collection of the RadCloudUpload component, after a validation is performed.

> The file object will be included also in the __InvalidItems__ or __ValidItems__ collection, depending on the validation result.

The AddFile method expects a __file stream__ with the file that will be uploaded, along with a __file name__ under which the file will be saved. In addition you can control whether the stream should be automatically closed after the upload finishes or not, through the last parameter of the method (__autoCloseStream__).

#### __[C#] Example 1: Using the AddFile method__	
{{region radcloudupload-features-adding-files-01}}
	this.cloudUpload.AddFile(theNameOfTheFileToBeAdded, fileStream, true);
{{endregion}}
	
#### __[VB.NET] Example 1: Using the AddFile method__	
{{region radcloudupload-features-adding-files-02}}
	Me.cloudUpload.AddFile(theNameOfTheFileToBeAdded, fileStream, True);
{{endregion}}

## See Also
* [Providers]({%slug radcloudupload-features-providers%})
* [CloudUploadFile]({%slug radcloudupload-cloud-upload-file%})
* [Validation]({%slug radcloudupload-features-validation%})
