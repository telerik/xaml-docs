---
title: CloudUploadFile
page_title: CloudUploadFile
description: CloudUploadFile
slug: radcloudupload-cloud-upload-file
tags: clouduploadfile
published: True
position: 6
---

# CloudUploadFile





## 

The __CloudUploadFile__ is part of the __RadCloudUpload__ control. It is the entity that tracks all upload-related tasks. This class does not upload a file to the cloud. It encapsulates a provider, a file name and a file stream and handles all upload-related tasks, such as progress-tracking and cancellation. The __CloudUploadFile__ object is expected to be the __DataContext__ of the [RadCloudUploadListItem]({%slug radcloudupload-radclouduploadlistitem%}).
        

>The __CloudUploadFile__ does not open or dispose the stream. The disposal should be handled by the owner of this object.
          

Although the __CloudUploadFile__ exposes the __State__ property, you cannot directly set it. You can use it to track the current state on an item, only. It is handled internally.
        

# See Also

 * [RadCloudUploadListItem]({%slug radcloudupload-radclouduploadlistitem%})
