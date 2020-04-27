---
title: Overwrite Existing Files
page_title: Overwrite Existing Files
description: Check our &quot;Overwrite Existing Files&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-features-overwrite-existing-files
tags: overwrite,existing,files
published: True
position: 8
site_name: Silverlight
---

# Overwrite Existing Files

When there are files with the same name as the uploaded ones, the __RadUpload__ can overwrite the existing files. By default the overwriting of files is disabled, but you can enable it by setting the __OverwriteExistingFiles__ property to __True__.

#### __[XAML] Example 1: Allow overriding of existing files__  
{{region xaml-radupload-features-overwrite-existing-files_0}}
	<telerik:RadUpload x:Name="radUpload"
	                   OverwriteExistingFiles="True" />
{{endregion}}

When the overwriting is disabled and there are files with matching names, an error message is displayed.

![](images/RadUpload_Features_Overwriting_Existing_Files_01.png)

## See Also  
 * [Automatic Upload]({%slug radupload-features-automatic-upload%})
 * [Extension Filters]({%slug radupload-features-extension-filters%})
 * [Multiple Times File Selection]({%slug radupload-features-multiple-times-file-selection%})
 * [Multiple Files Selection]({%slug radupload-features-multiple-files-selection%})
 