---
title: Multiple Times File Selection
page_title: Multiple Times File Selection
description: Check our &quot;Multiple Times File Selection&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-features-multiple-times-file-selection
tags: multiple,times,file,selection
published: True
position: 5
site_name: Silverlight
---

# Multiple Times File Selection

By default the __RadUpload__ allows one time file selection. This means that after selecting the desired files from the browse dialog the user won't be able to add more files to the list. To enable the multiple times file selection you have to set the __IsAppendFilesEnabled__ property to __True__ (its default value is __True__).

>When the __IsMultiselect__ property is set to __False__, the multiple times file selection is __disabled__. The default value of the __IsMultiselect__ property is __True__. To learn more about selecting multiple files read [here]({%slug radupload-features-multiple-files-selection%}).

#### __[XAML] Example 1: Enabling the multiple times file selection__  
{{region xaml-radupload-features-multiple-times-file-selection_0}}
	<telerik:RadUpload IsAppendFilesEnabled="True" />
{{endregion}}

When the multiple times file selection is enabled, the Add more files button appears after the first selection.

![](images/RadUpload_Features_Multiple_Times_File_Selection.png)

## See Also  
 * [Automatic Upload]({%slug radupload-features-automatic-upload%})
 * [File Size and Count Limitation]({%slug radupload-features-file-size-and-count-limitation%})
 * [Overwrite Existing Files]({%slug radupload-features-overwrite-existing-files%})
 * [Multiple Files Selection]({%slug radupload-features-multiple-files-selection%})
