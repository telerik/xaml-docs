---
title: Common
page_title: Common
description: Common
slug: radfiledialogs-features-common
tags: common,features
published: True
position: 0
---

# Common

This articles shows the minor features shared between all file dialogs - __RadOpenFileDialog, RadSaveFileDialog and RadOpenFolderDialog__.

## Setting initial directory

All the dialog controls expose a __InitialDirectory__ property that determines the directory that will be opened when the dialog shows.

#### __[C#] Example 1: Setting initial directory__ 
{{regiond radfiledialogs-features-common-0}}
	RadSaveFileDialog saveFileDialog = new RadOpenFileDialog();	
	saveFileDialog.Owner = this;
	
	saveFileDialog.InitialDirectory = @"C:\Temp\";
	
	saveFileDialog.ShowDialog();	
{{endregiond}}

## Setting the initial layout of the files

All the dialog controls expose a __InitialSelectedLayout__ property that determines the initial layout of the list with the files

#### __[C#] Example 2: Setting initial layout__ 
{{regiond radfiledialogs-features-common-1}}
	RadSaveFileDialog saveFileDialog = new RadOpenFileDialog();	
	saveFileDialog.Owner = this;
	
	saveFileDialog.InitialSelectedLayout = Telerik.Windows.Controls.FileDialogs.LayoutType.Tiles;
	
	saveFileDialog.ShowDialog();	
{{endregiond}}

The layout is determined by the LayoutType enum that provides the following modes:

* __SmallIcons__

* __MediumIcons__

* __LargeIcons__

* __ExtraLargeIcons__

* __List__

* __Tiles__

* __Details__

## See Also
