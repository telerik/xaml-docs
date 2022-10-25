---
title: Events
page_title: Events
description: Check our &quot;Events&quot; documentation article for the RadFileDialogs {{ site.framework_name }} control.
slug: radfiledialogs-events
tags: events
published: True
position: 7
---

# Events

This article lists the events specific to all of the RadFileDialog controls.

* __PreviewClosed__: This event occurs when the dialog is closing. The event arguments are of type __WindowPreviewClosedEventArgs__. You can use the arguments to cancel the event.
	
	#### __[C#] Example 1: Cancel dialog closing__
	{{region cs-radfiledialogs-events-0}}
		private void FileDialog_PreviewClosed(object sender, WindowPreviewClosedEventArgs e)
        {
			e.Cancel = true;
        }
	{{endregion}}
	
* __Closed__: This event occurs when the dialog is closed. The event arguments are of type __WindowClosedEventArgs__. 

* __ExceptionRaised__: This event occurs when an exception is raised. This event could be raised in different occasions, for example - if the selected folder cannot be accessed or if the file path is too long, or when there is an error while searching, etc.

	#### __[C#] Example 2: Showing an alert when an error appears__
	{{region cs-radfiledialogs-events-1}}
		private void openDialog_ExceptionRaised(object sender, FileBrowserExceptionRaisedEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }
	{{endregion}}

* __DirectoryRequesting__: This event can be used to filter the navigation RadTreeView and RadBreadcrumb or any [Custom Places]({%slug radfiledialogs-features-customplaces%}) that are added. The following example demonstrates how you can filter out the "D:\\" and "K:\\" directories:

	#### __[C#] Example 3: Filtering the D and K directories__
	{{region cs-radfiledialogs-events-2}}
		private void OpenFileDialog_DirectoryRequesting(object sender, Telerik.Windows.Controls.FileDialogs.DirectoryRequestingEventArgs e)
        {
            if (e.Directory.FullName.StartsWith("D:\\\\") || e.Directory.FullName.StartsWith("K:\\\\"))
            {
                e.Cancel = true;
            }
        }
	{{endregion}}

	> If the __InitialDirectory__ of the RadFileDialog is filtered out as in __Example 3__, the current directory on load will be the default one. 

	#### Figure 1: Unfiltered Directories
	![](images/radfiledialogs-directories.png)
	
	#### Figure 2: Filtered Directories Based on Example 3
	![](images/radfiledialogs-filtereddirectories.png)
	
* __DirectoryNavigating__: This event occurs when the current folder is about to change. You can use it to execute an additional action or to cancel the navigation. 
	
	#### __[C#] Example 4: Disable navigation to the Program Files folder__
	{{region cs-radfiledialogs-events-3}}
		private void OpenFileDialog_DirectoryNavigating(object sender, Telerik.Windows.Controls.FileDialogs.DirectoryNavigatingEventArgs e)
		{
			if (e.DirectoryPath == "C:\\\\Program Files")
            {
                e.Cancel = true;
            }
		}
	{{endregion}}	
	
* __ShellContextMenuOpening__: This event occurs when the context menu is about to open. You can use it to cancel the menu opening or to add/remove options from the short menu (the one opened when the cursor is on an empty space in the explorer).
	
	#### __[C#] Example 5: Canceling context menu opening and adding only New Folder and Paste options in the short menu__
	{{region cs-radfiledialogs-events-4}}
		private void OpenFileDialog_ShellContextMenuOpening(object sender, Telerik.Windows.Controls.FileDialogs.ContextMenuOpeningEventArgs e)
		{
			if (e.SelectedFiles.Count > 0 && e.SelectedFiles[0].Path == "C:\\\\Program Files")
            {
                e.Cancel = true;
            }
            else
            {
                e.ShortContextMenuOptions = ShortContextMenuOptions.Paste | ShortContextMenuOptions.NewFolder;
            }
		}
	{{endregion}}	
	
	Additional feature of the ContextMenuOpeningEventArgs provided with the ShellContextMenuOpening event handler is the __IsOpeningOnEmptySpace__ property. You can use this to determine whether the mouse clicked on a file/folder or on empty space in the files list.
	
	#### __[C#] Example 6: Checking if the click was on an empty space__
	{{region cs-radfiledialogs-events-5}}
		private void OpenFileDialog_ShellContextMenuOpening(object sender, Telerik.Windows.Controls.FileDialogs.ContextMenuOpeningEventArgs e)
		{
			if (e.IsOpeningOnEmptySpace)
           		{
              			  // do something
            		}
		}
	{{endregion}}	

* __Renaming__: This event occurs when a file or a folder is about to be renamed. You can use it to prevent certain files or folders from having their name changed. 
	
	The event arguments will be of the type __RenamingEventArgs__ that exposes the following properties:

	* __Cancel__: Boolean property that will indicate if a renaming operation will be performed or not.
	* __FileInfo__: Property of the type __FileSystemInfoWrapper__. This property contains the __FileSystemInfoWrapper__ object for the file system information that will be renamed.

	>important This event will occur only when the __CanUserRename__ property is set to __True__.

	#### __[C#] Example 7: Cancel the renaming operation for certain a file/directory__
	{{region cs-radfiledialogs-events-6}}
		private void OpenFileDialog_Renaming(object sender, Telerik.Windows.Controls.FileDialogs.RenamingEventArgs e)
		{
		    if (e.FileInfo.Path.StartsWith("C:\\Windows")
		    {
		    	e.Cancel = true;
		    }
		}
	{{endregion}}

## See Also
* [Getting Started]({%slug radfiledialogs-getting-started%})
* [RadOpenFileDialog]({%slug radfiledialogs-radopenfiledialog%})
* [RadOpenFolderDialog]({%slug radfiledialogs-radopenfolderdialog%})
* [RadSaveFileDialog]({%slug radfiledialogs-radsavefiledialog%})
