---
title: Event Cycles
page_title: Event Cycles
description: Check our &quot;Event Cycles&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-events-event-cycles
tags: event,cycles
published: True
position: 1
site_name: Silverlight
---

# Event Cycles

This topic will explain the order in which the events described in the [Overview]({%slug radupload-events-overview%}) topic get fired.

* __FileTooLarge__, __FileCountExceeded__, __UploadSizeExceeded__ - these events can get triggered if some of the selected files exceed the predefined criteria.

* __FilesSelected__- raises when the user has selected files from the browse dialog window. This is the first of the __RadUpload__ specific events that can be triggered by the actions of the user.

* __UploadStarted__ - raises when the user clicks the __Upload__ button.

* __FileUploadStarting__ - raises during the upload of each file.

* __FileUploadFailed, ProgressChanged, FileUploadPaused, FileUploadResumed, FileUploadCanceled__ - these events can be triggered in different order, depending on the user actions.

* __FileUploaded__ - raises when the file has been fully uploaded.

* __UploadFinished__ - raises when all files in the list have been processed, no matter this has been successfully done or not.

## See Also  
 * [Events - Overview]({%slug radupload-events-overview%})
 * [Programmatic Upload]({%slug radupload-features-programmatic-upload%})