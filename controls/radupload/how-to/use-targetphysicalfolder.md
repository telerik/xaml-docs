---
title: Use TargetPhysicalFolder
page_title: Use TargetPhysicalFolder
description: Use TargetPhysicalFolder
slug: radupload-how-to-use-targetphysicalfolder-property
tags: cancel,raduploaditem,deletion
published: True
position: 0
---

# Use TargetPhysicalFolder

This article shows how to use the __TargetPhysicalFolder__ property of RadUpload.

The property is exposed on both the __RadUpload__ control and __RadUploadHandler__ and it allows setting a physical path on the server where the file should be uploaded. RadUpload sends its TargetPhysicalFolder value to the RadUploadHandler's property and this is used as a storage location.

In version `2020.1.413` and later of Telerik UI for Silverlight, the TargetPhysicalFolder is send to RadUploadHandler, but it no longer reads it from the web request. After this version the property is not used by the handler due to security reasons. 

To __enable reading the TargetPhysicalFolder from the web request__ in the handler, override its __Initialize__ method and set the __TargetPhysicalFolder__ property using the __GetQueryParameter__ method.

#### __[XAML] Example 1: Setting up the RadUpload control__  
{{region radupload-how-to-use-targetphysicalfolder-property-0}}
	<telerik:RadUpload UploadServiceUrl="/SampleUploadHandler.ashx" TargetPhysicalFolder="C:\UserData\Uploads"/>
{{endregion}}

#### __[C#] Example 2: Setting TargetPhysicalFolder in the handler__  
{{region radupload-how-to-use-targetphysicalfolder-property-1}}
	public class SampleUploadHandler : RadUploadHandler
    {
        public override void Initialize()
        {
            base.Initialize();
            this.TargetPhysicalFolder = this.GetQueryParameter(RadUploadConstants.ParamNameTargetPhysicalFolder);            
        }
	}
{{endregion}}

>tip If both TargetPhysicalFolder and TargetFolder are set, the TargetPhysicalFolder will take precedence.

## See Also  
 * [Upload Handler]({%slug radupload-features-upload-handler%})
 * [Secure Upload File Paths]({%slug radupload-how-to-sanitize-upload-file-paths%})
 * [Getting Started]({%slug radupload-getting-started%})
