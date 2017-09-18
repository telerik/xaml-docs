---		
title: Error Handling		
page_title: Error Handling		
description: Error Handling		
slug: radfiledialogs-features-error-handling		
tags: error,handle,handling,exception,raised		
published: True		
position: 2		
---
		
# Error Handling

The file dialogs come with their own error handling mechanism so that you can deal with most exceptional situations that may occur while navigating through the file system.
Here's a list of exceptions that get handled internally by the controls and can be analyzed and processed in the [ExceptionRaised](%slug radfiledialogs-events%) event.

* **ArgumentException**: Selected file is empty string, contains only white space, contains one or more invalid characters, or refers to a non-file device.
* **ArgumentNullException**: Selected file is null.
* **ArgumentOutOfRangeException**: The specified mode contains an invalid value.
* **DirectoryNotFoundException**: Selected file is invalid, such as being on an unmapped drive.
* **NotSupportedException**: Selected file refers to a non-file device.
* **FileNotFoundException**: Selected file cannot be found, such as when mode is FileMode.Truncate or FileMode.Open, and the file specified by path does not exist. The file must already exist in these modes.
* **IOException**: An I/O error occurred or the stream has been closed.
* **PathTooLongException**: The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters.
* **SecurityException**: The caller does not have the required permission.
* **UnauthorizedAccessException**: The access requested is not permitted by the operating system for the specified path, such as when access is Write or ReadWrite and the file or directory is set for read-only access.

> When calling the **OpenFile** method of the RadOpenFileDialog and RadSaveFileDialog you need to manually handle the exceptions raised when creating a stream for the specified file(s).

## See Also

* [Events](%slug radfiledialogs-events%)
* [RadOpenFileDialog]({%slug radfiledialogs-radopenfiledialog%})
* [RadOpenFolderDialog]({%slug radfiledialogs-radopenfolderdialog%})
* [RadSaveFileDialog]({%slug radfiledialogs-radsavefiledialog%})