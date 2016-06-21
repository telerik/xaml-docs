---
title: Events
page_title: Events
description: Events
slug: radcloudupload-features-events
tags: events
published: True
position: 3
---

# Events

The __RadCloudUpload__ control exposes an __ItemStateChanged__ event. It is raised when an item in the __Items__ collection changes its state. In the handler of this event you can implement logic that can be executed when upload starts or upload ends. The arguments of this event are of type __CloudUploadFileStateChangedEventArgs__ and expose the following members:        

* __Item__ - this member is of type __CloudUploadFile__ and holds the item which status is changed.            

* __PreviousState__ and __NewState__ - the type of these members is __CloudUploadFileState__ and they hold the state in which the item was before the event was invoked and the state that the item will be after the event is invoked.            

## See Also
* [Overview]({%slug radcloudupload-overview%})
* [Providers]({%slug radcloudupload-features-providers%})
