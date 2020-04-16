---
title: Overview
page_title: Overview
description: Check our &quot;Overview&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-events-overview
tags: overview
published: True
position: 0
site_name: Silverlight
---

# Overview

This topic covers the specific events exposed by the __RadUpload__ control.

The __RadUpload__ control raises the following specific events: 

* __FileUploadStarting__ - occurs before a file starts uploading. The event handler receives two arguments:  
	* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.  
	* A [FileUploadStartingEventArgs](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_fileuploadstartingeventargs.html) object.								

* __FileUploadFailed__ - occurs when the upload of a file fails. The event handler receives two arguments:
	* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.  
	* A [FileUploadFailedEventArgs](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_fileuploadfailedeventargs.html) object.								

* __FileUploaded__ - occurs when the upload of a file finishes successfully. The event handler receives two arguments:  
	* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.  
	* A [FileUploadedEventArgs](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_fileuploadedeventargs.html) object.								

* __FileTooLarge__ - occurs when the selected file breaks the maximal file size limitation - the __MaxFileSize__ value. The event handler receives two arguments:
	* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.  
	* A [FileEventArgs](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_fileeventargs.html) object.  

* __FilesSelected__ - occurs when files have been selected from the browse dialog window. The event handler receives two arguments:  
	* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.  
	* A [FilesSelectedEventArgs](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_filesselectedeventargs.html) object.  								

* __FileCountExceeded__ - occurs only once, if the number of the selected files exceeds the __MaxFileCount__ value. The additional files are held in the __RadUpload CurrentSession.FilesOverCountCapacity__ collection. The event handler receives two arguments:  
	* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.  
	* A __RoutedEventArgs__ object.  								

* __ProgressChanged__ - occurs each time when the progress of the upload changes. The event handler receives two arguments:  
	* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.  
	* An __RoutedEventArgs__ object.  

* __UploadCanceled__ - occurs when the upload process gets canceled. The event handler receives two arguments:  
	* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.  
	* An __RoutedEventArgs__ object.								

* __UploadFinished__ - occurs when all files have been processed and the upload finishes. The event handler receives two arguments:
	* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.
	* An __RoutedEventArgs__ object.								

* __UploadPaused__ - occurs when the upload process gets paused. The event handler receives two arguments:
	* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.  
	* An __RoutedEventArgs__ object.  
	
* __UploadResumed__ - occurs when the upload process gets resumed. The event handler receives two arguments:
	* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.								
	* An __RoutedEventArgs__ object.								

* __UploadSizeExceeded__ - occurs only once, if the total size of the selected files exceeds the maximum allowed total size - the __MaxUploadSize__ value. The event handler receives two arguments:  
	* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.
	* A __RoutedEventArgs__ object.								

* __UploadStarted__ - occurs when the upload process has begun. The event handler receives two arguments:
	* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.
	* An [UploadStartedEventArgs](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_uploadstartedeventargs.html) object.

* __DuplicateFileName__ - occurs when a duplicate file name is selected. The event handler receives two arguments:  
	* The sender argument contains the __RadUpload__. This argument is of type object, but can be cast to the __RadUpload__ type.  
	* An [DuplicateFileNameEventArgs](http://www.telerik.com/help/silverlight/t_telerik_windows_controls_upload_eventarguments_duplicatefilenameeventargs.html) object.								

## See Also
 * [Visual Structure]({%slug radupload-visual-structure%})
 * [Event Cycles]({%slug radupload-events-event-cycles%})
 * [End-User Capabilities]({%slug radupload-end-user-capabilities%})
 * [Localization]({%slug radupload-localization%})