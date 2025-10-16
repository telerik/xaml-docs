---
title: Limiting the Simultaneous Uploads
page_title: Limiting the Simultaneous Uploads
description: Check our &quot;Limiting the Simultaneous Uploads&quot; documentation article for the RadCloudUpload {{ site.framework_name }} control.
slug: radcloudupload-features-limiting-simultaneous-uploads
tags: limiting, limit, simultaneous, upload, uploads, count, maximum, max, maximumsimultaneousuploadscount
published: True
position: 9
---

# Limiting the Simultaneous Uploads

__RadCloudUpload__ allows you to control the maximum number of uploads that can be running simultaneously. You can do that using the __MaximumSimultaneousUploadsCount__ property. 

>The default value of the __MaximumSimultaneousUploadsCount__ property is __3__.

__Example 1: Setting the MaximumSimultaneousUploadsCount property in XAML__
```XAML
	<telerik:RadCloudUpload MaximumSimultaneousUploadsCount="5" />
```	

__Example 2: Setting the MaximumSimultaneousUploadsCount property in code__
```C#
	this.cloudUpload.MaximumSimultaneousUploadsCount = 5;
```
```VB.NET
	Me.cloudUpload.MaximumSimultaneousUploadsCount = 5;
```

## See Also
* [Providers]({%slug radcloudupload-features-providers%})
* [CloudUploadFile]({%slug radcloudupload-cloud-upload-file%})
* [Validation]({%slug radcloudupload-features-validation%})
