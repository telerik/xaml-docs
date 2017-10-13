---
title: Filtering
page_title: Filtering
description: This article will described the filter functionality of the RadFileDialogs.
slug: radfiledialogs-features-filtering
tags: filtering,features,radopenfiledialog,radsavefiledialog
published: True
position: 3
---

# Filtering

With the R3 2017 SP 1 version of Telerik UI for WPF, you can now specify a filter to the __RadOpenFileDialog and RadSaveFileDialog__ dialogs in order indicate the user which types of files should be opening or saving. To enabled this functionality you can set the __Filter__ and __FilterIndex__ properties. 

The __Filter__ is a property of type string that determines what type of files should be used in the combo box. On the other hand the __FilterIndex__ property can be used to gets or sets the index of the filter currently selected in a file dialog.
> The index value of the first filter entry is 1. 

The string set to the __Filter__ property is parsed in strict way. So when parsing is not successful, an ArgumentException is thrown.
> __Provided filter string is not valid. Filter string should contain a description of the filter, followed by a vertical bar and the filter pattern. Must also separate multiple filter description and pattern pairs by a vertical bar. Must separate multiple extensions in a filter pattern with a semicolon. Example: "Image files (*.bmp, *.jpg)|*.bmp;*.jpg|All files (*.*)|*.*"__

## Filter in RadOpenFileDialog

To set filter to the __RadOpenFileDialog__ dialog you can set the __Filter__ property. When this property __is not set__ the combo box __will not__ appear.

#### __[C#] Example 1: Setting Filter property__ 
{{regiond radfiledialogs-features-filtering-0}}
	RadOpenFileDialog openFileDialog = new RadOpenFileDialog();
	openFileDialog.FileName = "Document";
	openFileDialog.Filter = "Word Documents(*.doc)|*.doc|Excel Worksheets (*.xls;*.xlsx)|*.xls;*.xlsx|"+
							"PowerPoint Presentations (*.ppt)|*.ppt" +
							"|Office Files (*.doc;*.xls;*.xlsx;*.ppt)|*.doc;*.xls;*.xlsx;*.ppt" +
							"|Image Files (*.jpg;*.png)|*.jpg;*.png" +
							"|Text Files (*.txt;)|*.txt;" +
							"|Archives Files (*.zip;*.rar)|*.zip;*.rar" +
							"|All Files (*.*)|*.*";
	openFileDialog.FilterIndex = 2;
	openFileDialog.ShowDialog();
{{endregiond}}

#### __Figure 1: Filter combo box visualization in RadOpenFileDialog__

![Filter combo box in RadOpenFileDialog](images/FileDialogs_Feature_Filtering_OpenFileDialog.PNG)

## Filter in RadSaveFileDialog

To set filter to the __RadSaveFileDialog__ dialog you can set the __Filter__ property. When this property __is not set__ the combo box will appear but will be empty. Is important to mentioned that the filter property not only filter the files in the main pane but also determines the type of the file in which the document will be saved.

#### __[C#] Example 2: Setting Filter property__ 
{{regiond radfiledialogs-features-filtering-1}}
	RadSaveFileDialog saveFileDialog = new RadSaveFileDialog();
	saveFileDialog.FileName = "Document";
	saveFileDialog.Filter = "Word Documents(*.doc)|*.doc|Excel Worksheets (*.xls;*.xlsx)|*.xls;*.xlsx|"+
							"PowerPoint Presentations (*.ppt)|*.ppt" +
							"|Office Files (*.doc;*.xls;*.xlsx;*.ppt)|*.doc;*.xls;*.xlsx;*.ppt" +
							"|Image Files (*.jpg;*.png)|*.jpg;*.png" +
							"|Text Files (*.txt;)|*.txt;" +
							"|Archives Files (*.zip;*.rar)|*.zip;*.rar" +
							"|All Files (*.*)|*.*";
	saveFileDialog.FilterIndex = 2;
	saveFileDialog.ShowDialog();
{{endregiond}}

#### __Figure 2: Filter combo box visualization in RadSaveFileDialog__

![Filter combo box in RadSaveFileDialog](images/FileDialogs_Feature_Filtering_SaveFileDialog.PNG)

## See Also
 * [Getting Started]({%slug radfiledialogs-getting-started%})
 * [RadOpenFileDialog]({%slug radfiledialogs-radopenfiledialog%})
 * [RadOpenFolderDialog]({%slug radfiledialogs-radopenfolderdialog%})
 * [RadSaveFileDialog]({%slug radfiledialogs-radsavefiledialog%})
