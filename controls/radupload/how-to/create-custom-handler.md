---
title: Create Custom Upload Handler
page_title: Create Custom Upload Handler
description: Check our &quot;Create Custom Upload Handler&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-how-to-create-custom-upload-handler
tags: create,custom,upload,handler
published: True
position: 8
site_name: Silverlight
---

# Create Custom Upload Handler

In order to create a basic Upload Handler you should [create a ASHX handler class](#Defining_an_Upload_Service), which derives from the __RadUploadHandler__ class. If you want to implement some custom behavior you have to override some of the methods of the __RadUploadHandler__ class and place your custom logic in them.

To learn more about the methods and properties of the __RadUploadHandler__ class read [this topic]({%slug radupload-features-upload-handler%}).

Here is an example of a custom upload handler.

#### __[C#] Example 1: Custom upload handler__  
{{region cs-radupload-how-to-create-custom-upload-handler_0}}
	public class SampleUploadHandler : RadUploadHandler
	{
	    public override string GetTargetFolder()
	    {
	        string targetFolder = base.GetTargetFolder();
	        //Modify targetFolder
	        return targetFolder;
	    }
	    public override Dictionary<string, object> GetAssociatedData()
	    {
	        Dictionary<string, object> associatedData = base.GetAssociatedData();
	        if ( this.IsFinalFileRequest() )
	        {
	            associatedData.Add( "MyReturnParam", "MyValue" );
	        }
	        return associatedData;
	    }
	}
{{endregion}}

## See Also  
 * [Upload Handler]({%slug radupload-features-upload-handler%})
 * [Upload Service Parameters]({%slug radupload-features-upload-service-parameters%})
 * [Limit the Upload Speed]({%slug radupload-how-to-limit-the-upload-speed%})
 * [Implement Simple Authentication]({%slug radupload-how-to-implement-simple-authentication%})
 * [Personalize the File Storage]({%slug radupload-how-to-personalize-the-file-storage%})