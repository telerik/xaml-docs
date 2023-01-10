---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadCloudUpload {{ site.framework_name }} control.
slug: radcloudupload-features-events
tags: events
published: True
position: 3
---

# {{ site.framework_name }} RadCloudUpload Events

The __RadCloudUpload__ control exposes the following events: 

* __ItemStateChanged__: It is raised when an item in the __Items__ collection changes its state. In the handler of this event you can implement logic that can be executed when upload starts or upload ends. The arguments of this event are of type __CloudUploadFileStateChangedEventArgs__ and expose the following members:

    * __Item__: This member is of type __CloudUploadFile__ and holds the item which status is changed.            

    * __PreviousState__ and __NewState__: The type of these members is __CloudUploadFileState__ and they hold the state in which the item was before the event was invoked and the state that the item will be after the event is invoked.

* **AddingFiles**: It is raised when the **Browse** and **AddFiles** commands are invoked, either programmatically or through the respective buttons. You can use this event to cancel the creation of the default **OpenFileDialog** and use your custom logic to load a collection of files to be uploaded. The arguments of this event are of type **AddingFilesEventArgs** and expose the following members:

    * **CancelDialogOpening**: A boolean property which determines whether the opening of the default OpenFileDialog will be cancelled.
    
    * **FileNames**: A collection of strings which represents the paths of the files to be uploaded.

    >A good example of how to use the AddingFiles event to replace the default OpenFileDialog with a [RadOpenFileDialog]({%slug radfiledialogs-radopenfiledialog%}) can be found in [this article]({%slug kb-cloudupload-howto-show-radfileopendialog%}). 

## See Also
* [Overview]({%slug radcloudupload-overview%})
* [Providers]({%slug radcloudupload-features-providers%})