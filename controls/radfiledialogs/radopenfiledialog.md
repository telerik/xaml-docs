---
title: RadOpenFileDialog
page_title: RadOpenFileDialog
description: RadOpenFileDialog
slug: radfiledialogs-radopenfiledialog
tags: open,file,dialog,show
published: True
position: 3
---

# RadOpenFileDialog

__RadOpenFileDialog__ is a modal dialog box that allows you to specify one or multiple filenames to open.

#### __Figure 1: RadOpenFileDialog in single selection mode__ 
![](images/radopenfiledialog-01.png)

## Showing the dialog

To show the dialog call its __ShowDialog__ method. If a valid file is opened when you press OK, the __DialogResult__ property will return True and the __FileName__, and __FileNames__ properties will be set. You can use FileName and FileNames to get the names of the selected items.

> Note that when the ShowDialog method is called the UI of the host application will freeze until the dialog closes.

#### __[C#] Example 1: Show a open file dialog__
{{region cs-radfiledialogs-radopenfiledialog-0}}
	RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
	openFileDialog.Owner = theHostWindowInstance;
	openFileDialog.ShowDialog();
	if (openFileDialog.DialogResult == true)
	{
		string fileName = openFileDialog.FileName;
	}
{{endregion}}

## Opening the selected file

You can open a read-only file stream for the selected file using the __OpenFile__ method. Or alternatively you can use the FileName and FileNames properties and open the file manually.

#### __[C#] Example 2: Open a file stream__
{{region cs-radfiledialogs-radopenfiledialog-1}}
	RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
	openFileDialog.Owner = theHostWindowInstance;
	openFileDialog.ShowDialog();
	if (openFileDialog.DialogResult == true)
	{
		Stream fileStream = openFileDialog.OpenFile();
	}
{{endregion}}

## Enabling multiple selection

The dialog supports single and multiple selection modes. By default you can select only one file at a time. To alter this you can set the __Multiselect__ property of RadOpenFileDialog.

#### __[C#] Example 3: Enable multiple selection__
{{region cs-radfiledialogs-radopenfiledialog-2}}
	RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
	openFileDialog.Owner = theHostWindowInstance;
	openFileDialog.Multiselect = true;
{{endregion}}

#### __Figure 2: Multiple selection__ 
![](images/radopenfiledialog-02.png)

## Working with the selected files

You can get the paths of the selected files via the __FileName__ and __FileNames__ properties. Note that the properties are empty until the DialogResult is valid. When you open file(s) the properties will return the corresponding paths.

You can get only the name of the selected files, without the full path, via the __SafeFileNames__ collection property.

#### __[C#] Example 3: Get the selected file names__
{{region cs-radfiledialogs-radopenfiledialog-3}}
	RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
	openFileDialog.Owner = theHostWindowInstance;
	openFileDialog.Multiselect = true;
	openFileDialog.ShowDialog();
	if (openFileDialog.DialogResult == true)
	{
		string filePath = openFileDialog.FileName;
		IEnumerable<string> filePaths = openFileDialog.FileNames;
		IEnumerable<string> fileNames = openFileDialog.SafeFileNames;
	}
{{endregion}}

The __FileName__ property can be set manually. This will change the value displayed in the selected file autocomplete box area. Note that setting this won't change the selected item in the list with the files.

## Saving the last used directory

You can save the last used directory by setting the __RestoreDirectory__ property of the RadOpenFileDialog. After setting this property to __True__ and opening a file the __InitialDirectory__ of this RadOpenFileDialog instance will be the parent folder of the opened file.

#### __[C#] Example 4: Set RestoreDirectory property__
{{region cs-radfiledialogs-radopenfolderdialog-4}}
	RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
	openFileDialog.RestoreDirectory = true;
{{endregion}}

## See Also
* [Visual Structure]({%slug radfiledialogs-visual-structure%})
* [RadOpenFolderDialog]({%slug radfiledialogs-radopenfolderdialog%})
* [RadSaveFileDialog]({%slug radfiledialogs-radsavefiledialog%})
* [Events]({%slug radfiledialogs-events%})
