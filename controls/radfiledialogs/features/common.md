---
title: Common
page_title: Common
description: Check our &quot;Common&quot; documentation article for the RadFileDialogs {{ site.framework_name }} control.
slug: radfiledialogs-features-common
tags: common,features
published: True
position: 0
---

# Common

This articles shows the features shared between all file dialogs controls - __RadOpenFileDialog, RadSaveFileDialog, RadOpenFolderDialog__ and __ExplorerControl__ .

## Setting Initial Directory

All the dialog controls expose a __InitialDirectory__ property that determines the directory that will be opened when the dialog shows.

#### __[C#] Example 1: Setting initial directory__ 
{{region radfiledialogs-features-common-0}}
	RadSaveFileDialog saveFileDialog = new RadSaveFileDialog();	
	saveFileDialog.Owner = this;
	
	saveFileDialog.InitialDirectory = @"C:\Temp\";
	
	saveFileDialog.ShowDialog();	
{{endregion}}

## Setting the Initial Layout of the Tiles

All the dialog controls expose a __InitialSelectedLayout__ property that determines the initial layout of the list with the files

#### __[C#] Example 2: Setting initial layout__ 
{{region radfiledialogs-features-common-1}}
	RadSaveFileDialog saveFileDialog = new RadSaveFileDialog();	
	saveFileDialog.Owner = this;
	
	saveFileDialog.InitialSelectedLayout = Telerik.Windows.Controls.FileDialogs.LayoutType.Tiles;
	
	saveFileDialog.ShowDialog();	
{{endregion}}

#### Figure 1: RadOpenFileDialog in Tile view mode in the Office2016 theme  
![RadOpenFileDialog in Tile view mode](images/FileDialogs_TileViewMode.png)

The layout is determined by the LayoutType enum that provides the following modes:

* __SmallIcons__

* __MediumIcons__

* __LargeIcons__

* __ExtraLargeIcons__

* __List__

* __Tiles__

* __Details__

## New Folder Button

Since __R1 2018__, you can add a new folder in all the dialog controls with the __New Folder__ button. The created folder enters edit mode in all [Layout View Modes](#setting-the-initial-layout-of-the-tiles). 

#### Figure 2: New folder button and new folder in edit mode in the Office2016 theme

![New Folder button](images/FileDialogs_NewFolder.png)

## Edit Mode

In order to edit the selected file/folder, you can press the __F2__ key. Alternatively, you can click on the TextBlock which holds the file/folder name in all layouts except the **Details** layout where you can click on the cell holding the file/folder name. If you try to add a reserved character in a file/folder name, you will receive the warning illustrated in **Figure 3**:

#### Figure 3: Reserved character warning in the Office2016 theme  
![Reserved character warning](images/FileDialogs_EditMode.png)

Trying to change the file extension prompts the message box shown in **Figure 4**:

#### Figure 4: Changing file extension message box in the Office2016 theme  
![Changing file extension message box](images/FileDialogs_ChangeFileExtensionMessageBox.png)

## Using the ContextMenu

As of __R1 2018 RadFileDialogs__ has a ContextMenu. The well-known ContextMenu used in Windows is used for this purpose. It is available for the __RadListBox, RadTreeView and RadGridView__ components used in the Main Pane.

#### Figure 5: Showing the ContextMenu

![Showing the ContextMenu](images/FileDialogs_ContextMenu.png)
## Disable the Automatic Expanding to Current Directory
By default the main pane with the files/folders and the navigation tree are synced and when you navigate through the folders the selection in the tree navigation pane will also be updated. To disable this you can set the __ExpandToCurrentDirectory__ property of the dialog to False.

#### __[C#] Example 3: Disabling the automatic expanding to current directory__ 
{{region radfiledialogs-features-common-2}}
	RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
	openFileDialog.Owner = theOwnerWindow;
	openFileDialog.ExpandToCurrentDirectory = false;
	openFileDialog.ShowDialog();
{{endregion}}

>tip When enabled the automatic expanding always synchronizes the files/folders list with the navigation tree. If you want to sync them only on load of the control, you can skip setting the property initially and then subscribe to the Loaded event of the dialog. In the event handler you can set the ExpandToCurrentDirectory property to False.

## Show Hidden Files

By default the file dialogs don't show hidden files and folders. To show them you can set the __ShowHiddenFiles__ property of the corresponding file dialog control to True.

#### __[C#] Example 4: Enable showing hidden files and folders__ 
{{region radfiledialogs-features-common-3}}
	RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
	openFileDialog.Owner = this;
	openFileDialog.ShowHiddenFiles = true;
	openFileDialog.ShowDialog();            
{{endregion}}

#### Figure 5: Showing hidden files  
![](images/radfiledialogs-features-common-0.png)

## Load Drives in Background

By default, when the file dialogs are shown, they will load all shared drives under the "This PC" node. There are scenarios when some drives are expected to load slower than normal. This could cause a delay in loading the file dialogs. In such scenarios, __LoadDrivesInBackground__ will get in handy. Setting this property to true will indicate the control to load the drives under the "This PC" node in a background thread. This way, we can reduce the loading time of the file dialogs and work with them while the engine is loading all drives.

#### __[C#] Example 5: Load Drives in Background Thread__ 
{{region radfiledialogs-features-common-4}}
	RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
	openFileDialog.Owner = this;
	openFileDialog.LoadDrivesInBackground = true;
	openFileDialog.ShowDialog();            
{{endregion}}

## Tooltips on Trimmed Text

As of **SP R3 2022** the dialogs display a tooltip when the name of a file or folder is trimmed due to insufficient space. The tooltips close upon click.

The tooltips show the full name of the file or folder which is hovered along with some additional information:

* **For files**&mdash;The type, size and last modified date.
* **For folders**&mdash;The size and creation date.

#### Figure 6: Folder name tooltip

![Folder name tooltip](images/radfiledialogs-features-common-tooltips.png)

## See Also 
* [Custom Places]({%slug radfiledialogs-features-customplaces%})
* [Filtering]({%slug radfiledialogs-features-filtering%})
