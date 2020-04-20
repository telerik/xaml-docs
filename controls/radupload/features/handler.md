---
title: Upload Handler
page_title: Upload Handler
description: Check our &quot;Upload Handler&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-features-upload-handler
tags: upload,handler
published: True
position: 1
site_name: Silverlight
---

# Upload Handler

The __RadUpload__ control must use an upload handler on the server in order to transfer its data. 

This handler is represented by a Generic (__ASHX__) Handler class that derives from the __RadUploadHandler__ class. This topic will make you familiar with the RadUploadHandler class and its most important members as follows.

## Uploading concepts

When a file is being uploaded, it gets separated in chunks. Each chunk gets transferred via the upload handler. The size of the chunks depends on the size of the buffer of the RadUpload control. See how to set this up in the [Buffering]({%slug radupload-features-buffering%}) article.

Each time a chunk gets transferred, a set of methods get executed on the server. If the chunk is the last from a file, the client is notified when the chunk is saved and the __FileUploaded__ event gets raised by the RadUpload control. When the chunk is the last for the upload, the __UploadFinished__ event gets raised, too.

The __RadUploadHandler__ class provides you with virtual methods, which can get overridden in order to customize the behavior of the handler. Read the rest of the topic to learn more about the methods and the properties of the class.

## Methods

* __AddReturnParam__ - appends a return parameter with its value.

* __CancelRequest__ - invoked on upload-cancelation. Removes the canceled file. The method can be __overridden__.

* __GetAssociatedData__ - prepares a dictionary for associated (custom) data returned to the client on each Final-file-request. The method can be __overridden__.

* __GetFileName__ - returns the name of the uploaded file. The method can be __overridden__.

* __GetFilePath__ - constructs the full name of the uploaded file. The method can be __overridden__.

* __GetQueryParameter__ - returns a Value linked to the specified key in the current Request Query. The method can be __overridden__.

* __GetTargetFolder__ - constructs the full path for the target folder. The method can be __overridden__.

* __Initialize__ - a place for first-time initialization of a custom-handler. The method can be __overridden__.

* __InitializeChunkStorage__- a place for first-time initialization of a custom-handler. The method can be __overridden__.

* __InvalidRequest__ - prepares return parameters when the upload-request is invalid. The method can be __overridden__.

* __IsFinalFileRequest__ - returns true if the current request contains the final chunk of the uploaded file. The method can be __overridden__.

* __IsFinalUploadRequest__ - returns true if the current request contains the final chunk of the last of the uploaded files. The method can be __overridden__.

* __IsNewFileRequest__ - returns true if the current request contains the first chunk of the uploaded file. The method can be __overridden__.

* __IsValidRequest__ - checks the validity of the current upload request. The method can be __overridden__.

* __OpenTargetFile__ - Opens the target file.

* __ProcessRequest__ - processes the HTTP Web request. The method can be __overridden__.

* __ProcessStream__ - the backbone of request-processing mechanism. The method can be __overridden__.

* __RemoveFile__ - removes the specified file. The method can be __overridden__.

* __SaveChunkData__ - saves the chunk's data in a file with the given name. The method can be __overridden__.

>tip Override this method in order to implement a custom logic inside the handler.

* __SendResponse__ - writes all the return parameters to the Response stream.

## Properties

* __Context__ - __HttpContext__ object that provides references to the intrinsic server objects (Request, Response, etc.) used to service HTTP requests.

* __FormChunkTag__ - gets the Chunk-tag value sent by the client.

* __IsReusable__ - gets a value indicating whether another request can use the __IHttpHandler__ instance. The property can be __overridden__.

* __OverwriteExistingFiles__ - gets or sets the value indicating whether __RadUpload__ should overwrite existing files having the same name in the __TargetFolder__. The property can be __overridden__.

* __Request__ - a __HttpRequest__ object for the current HTTP request.

* __Result__ - a container for all parameters returned to the client. The property can be __overridden__.

* __ResultChunkTag__ - gets or sets the Chunk-tag value returned to the client.

* __TargetFolder__ - gets or sets the virtual path of the folder, where __RadUpload__ will automatically save the valid files after the upload completes. The property can be __overridden__.

* __TargetPhysicalFolder__ - gets or sets the physical path of the folder, where __RadUpload__ will automatically save the valid files after the upload completes. The property can be __overridden__. 

	>important After version [LIB]({%slug installation-installing-lib%}) `2020.1.413` (inclusive) of Telerik UI for Silverlight, the __TargetPhysicalFolder__ property is not used by the default implementation of RadUploadHandler due to security reasons. To get the same effect (avoid providing physical folder to the upload handler) in previous versions you can implement a custom [upload handler]({%slug radupload-features-upload-handler%}). One way to do this is described in the [Secure Upload File Paths]({%slug radupload-how-to-sanitize-upload-file-paths%}) article. To enable the TargetPhysicalFolder property in version `2020.1.413` and later see the [Use TargetPhysicalFolder]({%slug radupload-how-to-use-targetphysicalfolder-property%}) article.

## See Also  
 * [Secure Upload File Paths]({%slug radupload-how-to-sanitize-upload-file-paths%})
 * [Upload Service Parameters]({%slug radupload-features-upload-service-parameters%})
 * [Programmatic Upload]({%slug radupload-features-programmatic-upload%})
 * [Create Custom Upload Handler]({%slug radupload-how-to-create-custom-upload-handler%})
 * [Limit the Upload Speed]({%slug radupload-how-to-limit-the-upload-speed%})
 * [Implement Simple Authentication]({%slug radupload-how-to-implement-simple-authentication%})
