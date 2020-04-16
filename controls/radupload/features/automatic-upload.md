---
title: Automatic Upload
page_title: Automatic Upload
description: Check our &quot;Automatic Upload&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-features-automatic-upload
tags: automatic,upload
published: True
position: 2
site_name: Silverlight
---

# Automatic Upload

The __RadUpload__ allows the files to be uploaded automatically after the user selects them from the browse dialog window. Which means that the user won't have to click the Upload button to start the process. To enable the Automatic Upload feature you can set the __IsAutomaticUpload__ property of the __RadUpload__ to __True__ (its default value is __False__).

#### __[XAML] Example 1: Enabling the automatic upload feature in XAML__  
{{region xaml-radupload-features-automatic-upload_0}}
	<telerik:RadUpload IsAutomaticUpload="True" />
{{endregion}}

#### __[C#] Example 2: Enabling the automatic upload feature in code__  
{{region cs-radupload-features-automatic-upload_1}}
	RadUpload radUpload = new RadUpload();
	radUpload.IsAutomaticUpload = true;
{{endregion}}

#### __[VB.NET] Example 2: Enabling the automatic upload feature__  
{{region vb-radupload-features-automatic-upload_2}}
	Dim radUpload As New RadUpload()
	radUpload.IsAutomaticUpload = True
{{endregion}}

## See Also 
 * [File Size and Count Limitation]({%slug radupload-features-file-size-and-count-limitation%})
 * [Multiple Times File Selection]({%slug radupload-features-multiple-times-file-selection%})
 * [Multiple Files Selection]({%slug radupload-features-multiple-files-selection%})
 * [Overwrite Existing Files]({%slug radupload-features-overwrite-existing-files%})
 * [Buffering]({%slug radupload-features-buffering%})
