---
title: Events
page_title: Events
description: This article describes the RadFilePathPicker events.
slug: radfilepathpicker-events
tags: events
position: 3
---

# {{ site.framework_name }} RadFilePathPicker Events

__RadFilePathPicker__ inherits the [Control](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.control?view=netframework-4.8) class. In addition to the events that it inherits, the control exposes the following ones:            

* __FilePathChanging__: Occurs when a new file path is about to be selected. The event handler receives two arguments:

	* The sender argument contains the __RadFilePathPicker__. This argument is of type object, but can be cast to the __RadFilePathPicker__ type.              

	* A __FilePathChangingEventArgs__ object. It exposes a __Cancel__ boolean property, which allows for canceling the change and a __FilePath__ property holding the new FilePath.          

* __FilePathChanged__: Occurs when a new valid file path is selected via file browser, via typing or via programmatic change of the property. The event handler receives two arguments:

	* The sender argument contains the __RadFilePathPicker__. This argument is of type object, but can be cast to the __RadFilePathPicker__ type.              

	* A __FilePathChangedEventArgs__ object. It exposes a __FilePath__ property holding the new FilePath.   

>important A programmatic change of the __FilePath__ property does not trigger the __FilePathChanging__ event, however it triggers the __FilePathChanged__ event. A programmatic change of the __Text__ property triggers both the __FilePathChanging__ and the __FilePathChanged__ events.

* __DialogOpening__: Occurs when the file dialog is about to be opened. The event handler receives two arguments:

	* The sender argument contains the __RadFilePathPicker__. This argument is of type object, but can be cast to the __RadFilePathPicker__ type.              

	* A __DialogOpeningEventArgs__ object. It exposes a __Cancel__ boolean property, which allows for canceling the opening and a __Dialog__ property, which allows you to get the dialog instance.
	
* __DialogClosed__: Occurs when the file dialog is closed. The event handler receives two arguments:

	* The sender argument contains the __RadFilePathPicker__. This argument is of type object, but can be cast to the __RadFilePathPicker__ type.              

	* A __WindowClosedEventArgs__ object.   	  

## See Also 

* [Getting Started]({%slug radfilepathpicker-getting-started%})
* [Dialog Types]({%slug radfilepathpicker-dialog-types%})
