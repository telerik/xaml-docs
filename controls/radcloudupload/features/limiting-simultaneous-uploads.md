---
title: Limiting the Simultaneous Uploads
page_title: Limiting the Simultaneous Uploads
description: Check our &quot;Limiting the Simultaneous Uploads&quot; documentation article for the RadCloudUpload {{ site.framework_name }} control.
slug: radcloudupload-features-limiting-simultaneous-uploads
tags: limiting, limit, simultaneous, upload, uploads, count, maximum, max, maximumsimultaneousuploadscount
published: True
position: 9
---

# {{ site.framework_name }} RadCloudUpload Limiting the Simultaneous Uploads

__RadCloudUpload__ allows you to control the maximum number of uploads that can be running simultaneously. You can do that using the __MaximumSimultaneousUploadsCount__ property. 

>The default value of the __MaximumSimultaneousUploadsCount__ property is __3__.

#### __[XAML] Example 1: Setting the MaximumSimultaneousUploadsCount property in XAML__
{{region radcloudupload-features-limiting-simultaneous-uploads-01}}
	<telerik:RadCloudUpload MaximumSimultaneousUploadsCount="5" />
{{endregion}}	

#### __[C#] Example 2: Setting the MaximumSimultaneousUploadsCount property in code__
{{region radcloudupload-features-limiting-simultaneous-uploads-02}}
	this.cloudUpload.MaximumSimultaneousUploadsCount = 5;
{{endregion}}	

#### __[VB.NET] Example 2: Setting the MaximumSimultaneousUploadsCount property in code__
{{region radcloudupload-features-limiting-simultaneous-uploads-03}}
	Me.cloudUpload.MaximumSimultaneousUploadsCount = 5;
{{endregion}}

## See Also
* [Providers]({%slug radcloudupload-features-providers%})
* [CloudUploadFile]({%slug radcloudupload-cloud-upload-file%})
* [Validation]({%slug radcloudupload-features-validation%})
