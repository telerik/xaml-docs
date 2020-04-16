---
title: Multiple Files Selection
page_title: Multiple Files Selection
description: Check our &quot;Multiple Files Selection&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-features-multiple-files-selection
tags: multiple,files,selection
published: True
position: 6
site_name: Silverlight
---

# Multiple Files Selection

By default the __RadUpload__ allows you to select and upload multiple files. If you want the user to select and upload only one file at a time you can set the __IsMultiselect__ property to __False__ (its default value is __True__).

>Disabling the multiple file selection will also disable [multiple times file selection]({%slug radupload-features-multiple-times-file-selection%}).

#### __[XAML] Example 1: Enabling the multiple files selection__  
{{region xaml-radupload-features-multiple-files-selection_0}}
	<telerik:RadUpload IsMultiselect="False" />
{{endregion}}

## See Also  
 * [Automatic Upload]({%slug radupload-features-automatic-upload%})
 * [Buffering]({%slug radupload-features-buffering%})
 * [Overwrite Existing Files]({%slug radupload-features-overwrite-existing-files%})
 * [Multiple Times File Selection]({%slug radupload-features-multiple-times-file-selection%})
 * [File Size and Count Limitation]({%slug radupload-features-file-size-and-count-limitation%})
