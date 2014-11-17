---
title: UploadItem Events
page_title: UploadItem Events
description: UploadItem Events
slug: radupload-events-uploaditem-events
tags: uploaditem,events
published: True
position: 2
---

# UploadItem Events



## 

This topic covers the specific events exposed by a __RadUploadItem__.

Each __RadUploadItem__ raises the following specific events:

* __PreviewDelete__ - occurs before an __UploadItem__ is deleted. The event handler receives two arguments: 


* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.

* A __DeleteEventArgs__ object.

* __Delete__ - occurs when an __UploadItem__ is deleted. The event handler receives two arguments: 


* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.

* A __DeleteEventArgs__ object.

* __Validate__- occurs when the user clicks the __Upload__ button for each selected file before the start of the upload process. The event handler receives two arguments: 


* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.

* A __UploadValidateEventArgs__ object.
