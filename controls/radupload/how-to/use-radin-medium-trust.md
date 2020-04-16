---
title: Use RadUpload in Medium Trust
page_title: Use RadUpload in Medium Trust
description: Check our &quot;Use RadUpload in Medium Trust&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-how-to-use-radupload-in-medium-trust
tags: use,radupload,in,medium,trust
published: True
position: 7
site_name: Silverlight
---

# Use RadUpload in Medium Trust

In order to run the __RadUpload__ in Medium Trust level you should do only one thing: register the upload handler in the __web.config__ file. In order to do this you have to do the following:

1. Open (for editing) the __web.config__ file related to the chosen application; 

2. In the "handlers" section append your upload handler.

	#### __[XML] Registering the upload handlers__
	{{region radupload-how-to-use-radupload-in-medium-trust_0}}
		<system.WebServer>
			<handlers>
				<add name="MyRadUploadHandler_ashx" 
					 path="MyRadUploadHandler.ashx" 
					 verb="*" 
					 type="Telerik.Windows.RadUploadHandler" />
				...
			</handlers>
			...
		</system.WebServer>
	{{endregion}}

3. Now you can configure your web site (or the whole web server) to run in Medium Trust level. Of course you can script by hand the command for Medium Trust level (see row 66 in the picture below);

	![](images/RadUpload_How_To_Medium_Trust_01.png)

## See Also  
 * [Limit the Upload Speed]({%slug radupload-how-to-limit-the-upload-speed%})
 * [Implement Simple Authentication]({%slug radupload-how-to-implement-simple-authentication%})
