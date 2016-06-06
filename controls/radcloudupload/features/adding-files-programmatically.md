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

__RadCloudUpload__ allows you to prepare files for upload in code using the __AddFile__ method of the control. The method will create a new __CloudUploadFile__ object and add it in the __Items__ collection of the RadCloudUpload component, after a validation is performed. <Comment: The code examples do not show a CloudUploadFile object; it looks like they show a __cloudUpload__ file object.>

> The file object will also be included in the __InvalidItems__ or __ValidItems__ collection, depending on the validation result.

The AddFile method expects a __fileStream__ with the file that will be uploaded, along with a __filename__ to indicate the name of the file to be saved. <Comment: The words fileStream and filename are each one word, I think.> In addition, you can control whether the stream should be automatically closed after the upload finishes or not by passing __true__ as the last parameter of the method (__autoCloseStream__). <Comment: Please check that my change to the end of the previous sentence did not create an error.>

#### __[C#] Example 1: Add a file using the RadCloudUpload AddFile method__	
{{region radcloudupload-features-adding-files-01}}
	this.cloudUpload.AddFile(theNameOfTheFileToBeAdded, fileStream, true);
{{endregion}}
	
#### __[VB.NET] Example 1: Add a file using the RadCloudUpload AddFile method__	
{{region radcloudupload-features-adding-files-02}}
	Me.cloudUpload.AddFile(theNameOfTheFileToBeAdded, fileStream, True);
{{endregion}}

## See Also
* [Providers]({%slug radcloudupload-features-providers%})
* [CloudUploadFile]({%slug radcloudupload-cloud-upload-file%})
* [Validation]({%slug radcloudupload-features-validation%})
