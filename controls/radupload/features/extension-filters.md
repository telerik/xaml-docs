---
title: Extension Filters
page_title: Extension Filters
description: Check our &quot;Extension Filters&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-features-extension-filters
tags: extension,filters
published: True
position: 7
site_name: Silverlight
---

# Extension Filters

You are able to specify the types of files that are displayed in the Browse dialog window. This is done by specifying extension filters and setting them to the __Filter__ property of the __RadUpload.__ The string value should have the following format - __"Filter Name|extension1;extension2;...extensionN"__. Here is an example of a __RadUpload__ control with a filter for image files.

#### __[XAML] Example 1: Setting a filter for image files__  
{{region xaml-radupload-features-extension-filters_0}}
	<telerik:RadUpload Filter="Image Files (*.gif;*.jpg;*.jpeg;*.png)|*.gif;*.jpg;*.jpeg;*.png" />
{{endregion}}

With this filter defined, only the files with these extensions will be displayed in the Browse dialog window.

>tip Typically the filters make it easier for the user to find the file he wants to upload, but filters can also be used to limit the types of files, that can be uploaded. For example, if you have an Image Gallery, you will want only Image files to be uploaded.

If you need to define more than one filter, you concatenate the desired filters by separating them with "|".

#### __[XAML] Example 2: Setting multiple filters__  
{{region xaml-radupload-features-extension-filters_1}}
	<telerik:RadUpload Filter="Image Files (*.gif;*.jpg;*.jpeg;*.png)|*.gif;*.jpg;*.jpeg;*.png|All Files|*.*" />
{{endregion}}

>tip When having more than one filter, you can specify which to be the default by setting the __FilterIndex__ property to the index of the desired filter (the indexing starts from 1).

## See Also  
 * [Automatic Upload]({%slug radupload-features-automatic-upload%})
 * [File Size and Count Limitation]({%slug radupload-features-file-size-and-count-limitation%})
 * [Overwrite Existing Files]({%slug radupload-features-overwrite-existing-files%})
 * [Buffering]({%slug radupload-features-buffering%})
 