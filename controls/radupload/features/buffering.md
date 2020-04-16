---
title: Buffering
page_title: Buffering
description: Check our &quot;Buffering&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-features-buffering
tags: buffering
published: True
position: 9
site_name: Silverlight
---

# Buffering

This article describes the buffering mechanism implemented in the RadUpload control.

The files uploaded through the __RadUpload__ are separated in chunks, which get send one by one to the server. The buffer determines the size of the chunks and is measured in bytes. A bigger buffer means faster upload and a bigger chance for timeout. Decreasing the buffer size will also decrease the upload speed. The default value is 100 000 bytes. In order to change the size of the buffer you have to set the desired value to the __BufferSize__ property of the __RadUpload__.	

#### __[XAML] Example 1: Setting the buffer size__  
{{region xaml-radupload-features-buffering_0}}
	<telerik:RadUpload x:Name="radUpload"
	                   BufferSize="1024" />
{{endregion}}

>There are no restrictions on the __RadUpload__ side, but the maximum buffer size can be restricted by the server.

 If this is the case, you would have to configure your server to be able to accept larger chunks of data. You can do this from the __web.config__ file by setting a larger __maxRequestLength__ with the following code :

#### __[XML] Example 2: Setting up the server__  
{{region radupload-features-buffering_1}}
	<configuration>
		<system.web>
			<httpRuntime  maxRequestLength="10000000" executionTimeout="3600" />
			<compilation debug="true" targetFramework="4.0" />
		</system.web>
	</configuration>
{{endregion}}

>tip To see how to limit the upload speed of the __RadUpload__ via the __BufferSize__ read [here]({%slug radupload-how-to-limit-the-upload-speed%}).		  

## See Also  
 * [Automatic Upload]({%slug radupload-features-automatic-upload%})
 * [File Size and Count Limitation]({%slug radupload-features-file-size-and-count-limitation%})
 * [Limit the Upload Speed]({%slug radupload-how-to-limit-the-upload-speed%})
