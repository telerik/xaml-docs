---
title: CloudUploadFile
page_title: CloudUploadFile
description: CloudUploadFile
slug: radcloudupload-cloud-upload-file
tags: clouduploadfile
published: True
position: 2
---

# CloudUploadFile

__CloudUploadFile__ is part of the __RadCloudUpload__ control. It is the entity that tracks all upload-related tasks. This class does not upload a file to the cloud. It encapsulates a provider, a file name and a file stream and handles all upload-related tasks, such as progress-tracking and cancellation. The __CloudUploadFile__ object is expected to be the __DataContext__ of the [RadCloudUploadListItem]({%slug radcloudupload-radclouduploadlistitem%}).        

> The __CloudUploadFile__ class does not open or dispose the stream. The disposal should be handled by the owner of this object.          

## Properties

__CloudUploadFile__ exposes several key properties. Note that this section does not list all public properties of the class.

* __State__: A property of type __CloudUploadFileState__ which gets the current state of the upload operation. The property cannot be set, and it can be used only for tracking the state of the item. 

* __UploadResult__: A property of type __Object__ which gets the result of the upload operation. The value of the property depends on the result that will be returned by the upload request from the upload provider.   
	
	>You can subscribe for the __StateChanged__ event of the __CloudUploadFile__ in order to track the upload result and changes in the item's state. You can also use the __ItemStateChanged__ event of __RadCloudUpload__.
	
* __UploadedBytes__: A property of type __long__ which gets the count of uploaded bytes.

* __FileName__: A property of type __string__ which gets the name of the file.

* __FileSize__: A property of type __long__ which gets the size of the file.

* __ValidationErrors__: A property of type __List&lt;object&gt;__ which gets a collection with the upload validation errors, if there are any.

* __Provider__: A property of type __ICloudUploadProvider__ which gets and sets the upload provider.

## Events

__CloudUploadFile__ class exposes several events.

* __StateChanged__: The event occurs when the value of the __State__ property changes. The event arguments are of type __CloudUploadFileStateChangedEventArgs__ and expose the following properties.  
	* __Item__: An object of type __CloudUploadFile__ which gets the cloud upload file item. 
	* __NewState__: An object of type __CloudUploadFileState__ which gets the new state of the item.
	* __OldState__: An object of type __CloudUploadFileState__ which gets the old state of the item.
	
* __ProgressChanged__: The event occurs when the upload progress changes. The event arguments are of type __EventArgs__.

* __StartUploadRequested__: The event occurs when starting upload is requested. The event arguments are of type __StartUploadRequestedEventArgs__ and expose a single method, __ShouldQueueUpload__, which can be used to indicate whether the item should be queued for upload or started directly.

* __CloseRquested__: The event occurs when a close is requested. A close is requested when the __RequestClose__ method is called or the __RequestCloseCommand__ is executed. The event arguments are of type __EventArgs__.

* __PropertyChanged__: The event occurs when a property value changes. The event arguments are of type __PropertyChangedEventArgs__.

## See Also
* [RadCloudUploadListItem]({%slug radcloudupload-radclouduploadlistitem%})
* [Events]({%slug radcloudupload-features-events%})
* [CloudUploadFile API](http://docs.telerik.com/devtools/wpf/api/html/T_Telerik_Windows_Cloud_Controls_Upload_CloudUploadFile.htm)
