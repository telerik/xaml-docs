---
title: Events
page_title: Events
description: Events
slug: radfiledialogs-events
tags: events
published: True
position: 7
---

# Events

This article lists the events specific to the RadFileDialog controls. All file dialos

* __PreviewClosed__: This event occurs when the dialog is closing. The event arguments are of type __WindowPreviewClosedEventArgs__. You can use the arguments to cancel the event.
	
	#### __[C#] Example 1: Cancel dialog closing__
	{{region radfiledialogs-events-0}}
		private void FileDialog_PreviewClosed(object sender, WindowPreviewClosedEventArgs e)
        {
			e.Cancel = true;
        }
	{{endregion}}
	
* __Closed__: This event occurs when the dialog is closed. The event arguments are of type __WindowClosedEventArgs__. 

* __ExceptionRaised__: This event occurs when an exception is raised. This event could be raised in different occasions, for example - if the selected folder cannot be accessed or if the file path is too long, or when there is an error while searching, etc.

	#### __[C#] Example 2: Showing an alert when an error appears__
	{{region radfiledialogs-events-0}}
		private void openDialog_ExceptionRaised(object sender, FileBrowserExceptionRaisedEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }
	{{endregion}}

## See Also
* [Getting Started]({%slug radfiledialogs-getting-started%})
* [RadOpenFileDialog]({%slug radfiledialogs-radopenfiledialog%})
* [RadOpenFolderDialog]({%slug radfiledialogs-radopenfolderdialog%})
* [RadSaveFileDialog]({%slug radfiledialogs-radsavefiledialog%})
