---
title: Providers
page_title: Providers
description: Check our &quot;Providers&quot; documentation article for the RadCloudUpload {{ site.framework_name }} control.
slug: radcloudupload-features-providers
tags: providers
published: True
position: 5
---

# {{ site.framework_name }} RadCloudUpload Providers

The __RadCloudUpload__ control does not upload files on its own. You need to specify custom implementation of an object serving as comunication layer between the control and a cloud provider. The actual uploading logic should be implemented in that layer. For this purpose you can use the __Provider__ property of the control. It is of type __ICloudUploadProvider__ and gets or sets the custom upload provider. It accepts any type of object implementing the __ICloudUploadProvider__ interface.        

For demonstration purposes we created sample implementations of providers that upload files to some cloud storages. You can find ready to run projects in our [GitHub XAML SDK repository](https://github.com/telerik/xaml-sdk/tree/master/CloudUpload).

## See Also
* [Visual Structure]({%slug radcloudupload-structure%})
