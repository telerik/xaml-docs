---
title: Programmatic Upload
page_title: Programmatic Upload
description: Check our &quot;Programmatic Upload&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-features-programmatic-upload
tags: programmatic,upload
published: True
position: 10
site_name: Silverlight
---

# Programmatic Upload

You can achieve programmatic upload by using the different methods exposed by the __RadUpload__ control. Here is a list of them:

* __CancelUpload()__ - cancels the current upload. When the upload gets canceled the __UploadCanceled__ event is raised.

* __PauseUpload()__ - pauses the current upload. When the upload gets paused the __UploadPaused__ event is raised.

* __ResumeUpload()__ - resumes the paused upload. When the upload gets resumed the __UploadResumed__ event is raised.

* __ShowFileDialog()__ - opens the browse dialog window.

* __StartUpload()__ - starts the upload. When the upload gets started the __UploadStarted__ event is raised.

>tip To learn more about the events of the __RadUpload__ read [here]({%slug radupload-events-overview%}).

>tip You can use the __Items.Count__ property to see if any files have been selected for upload, before starting it.

## See Also  
 * [Upload Handler]({%slug radupload-features-upload-handler%})
 * [Upload Service Parameters]({%slug radupload-features-upload-service-parameters%})
 * [Rename a File]({%slug radupload-how-to-rename-a-file%})
 * [Hide the Buttons]({%slug radupload-how-to-hide-the-buttons%})
 * [Limit the Upload Speed]({%slug radupload-how-to-limit-the-upload-speed%})
 