---
title: Adding Files Programmatically
page_title: Adding Files Programmatically
description: Check our &quot;Adding Files Programmatically&quot; documentation article for the RadCloudUpload {{ site.framework_name }} control.
slug: radcloudupload-features-adding-files-programmatically
tags: adding, items, files, manually, programmatically, code, code-behind
published: True
position: 0
---

# Adding Files Programmatically

__RadCloudUpload__ allows you to prepare files for upload in code using the __AddFile__ method of the control. The method will create a new __CloudUploadFile__ object and add it in the __Items__ collection of the RadCloudUpload component, after a validation is performed.

> The file object will also be included in the __InvalidItems__ or __ValidItems__ collection, depending on the validation result.

The AddFile method expects a __file stream__ with the file that will be uploaded, along with a __file name__ to indicate the name of the file to be saved. In addition, you can control whether the stream should be automatically closed after the upload finishes or not by passing __true__ as the last parameter of the method (__autoCloseStream__).

__Example 1: Add a file using the RadCloudUpload AddFile method__	
```C#
	this.cloudUpload.AddFile(theNameOfTheFileToBeAdded, fileStream, true);
```
```VB.NET
	Me.cloudUpload.AddFile(theNameOfTheFileToBeAdded, fileStream, True);
```

## See Also
* [Providers]({%slug radcloudupload-features-providers%})
* [CloudUploadFile]({%slug radcloudupload-cloud-upload-file%})
* [Validation]({%slug radcloudupload-features-validation%})
