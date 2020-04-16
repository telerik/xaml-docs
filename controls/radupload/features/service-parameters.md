---
title: Upload Service Parameters
page_title: Upload Service Parameters
description: Check our &quot;Upload Service Parameters&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-features-upload-service-parameters
tags: upload,service,parameters
published: True
position: 3
site_name: Silverlight
---

# Upload Service Parameters

Sometimes you may need to pass custom parameters to the upload service. 

To learn how to read the parameters on the server-side, read the last section of the topic.

## Upload-specific parameters

If you want to pass parameters, that will be sent with every request to the upload handler, for all the files that will be uploaded, you can use the __AdditionalPostFileds__ property of type __Dictionary<string, string>__.		

#### __[C#] Example 1: Adding parameters__  
{{region cs-radupload-features-upload-service-parameters_0}}
	this.radUpload.AdditionalPostFields.Add( "MyParameter", "MyValue" );
{{endregion}}

#### __[VB.NET] Example 1: Adding parameters__  
{{region vb-radupload-features-upload-service-parameters_1}}
	Me.radUpload.AdditionalPostFields.Add( "MyParameter", "MyValue" )
{{endregion}}

## File-specific parameters

If you want to pass parameters, that are specific to the file and will be sent with the request for this file only, you have to handle the __FileUploadStarting__ event and add the parameters to its event arguments.	

>tip The __FileUploadStarting__ event is fired for each file, when it starts being uploaded.

#### __[XAML] Example 2: Subscribing to the FileUploadStarting event__  
{{region xaml-radupload-features-upload-service-parameters_2}}
	<telerik:RadUpload x:Name="radUpload"
	                   FileUploadStarting="radUpload_FileUploadStarting" />
{{endregion}}

#### __[C#] Example 3: Implementing the FileUploadStarting event handler__  
{{region cs-radupload-features-upload-service-parameters_3}}
	private void radUpload_FileUploadStarting( object sender, FileUploadStartingEventArgs e )
	{
	    e.FileParameters.Add( "MyFileParameter", "MyFileValue" );
	}
{{endregion}}

#### __[VB.NET] Example 3: Implementing the FileUploadStarting event handler__  
{{region vb-radupload-features-upload-service-parameters_4}}
	Private Sub radUpload_FileUploadStarting(sender As Object, e As FileUploadStartingEventArgs)
		e.FileParameters.Add("MyFileParameter", "MyFileValue")
	End Sub
{{endregion}}

>The parameters passed through the __AdditionalPostFileds__ property will still be available for each of the uploaded files.		  

## Reading parameters on the server

The parameters passed to the service are stored in the __Request.Form__ property of the __RadUploadHandler__. They get initialized before the __SaveChunkData()__ is called, so if you want to access them this is the method that has to be overridden.		

>The __SaveChunkData()__ is a method that gets called every time a portion of the file is transferred. The default size of a chunk is 100 000 bytes and if you want to change the size of the portion, you have to set the __BufferSize__ property of __RadUpload__. Therefore, if your file is 500 kilobytes, __SaveChunkData()__ will get called 5 times. This is the method that should be used to read or pass parameters, to check the state of the upload via the __IsNewFileRequest(), IsFinalFileRequest(), IsFinalUploadRequest()__ methods.		  

#### __[C#] Example 4: Reading the additional parameters on the server__  
{{region cs-radupload-features-upload-service-parameters_5}}
	public override bool SaveChunkData( string filePath, long position, byte[] buffer, int contentLength, out int savedBytes )
	{
	    string myParam = this.GetQueryParameter( "MyParameter" );
	    return base.SaveChunkData( filePath, position, buffer, contentLength, out savedBytes );
	}
{{endregion}}

#### __[VB.NET] Example 4: Reading the additional parameters on the server__  
{{region vb-radupload-features-upload-service-parameters_6}}
	Public Overrides Function SaveChunkData(filePath As String, position As Long, buffer As Byte(), contentLength As Integer, savedBytes As Integer) As Boolean
	 Dim myParam As String = Me.GetQueryParameter("MyParameter")
	 Return MyBase.SaveChunkData(filePath, position, buffer, contentLength, savedBytes)
	End Function
{{endregion}}

>tip To learn more about the __RadUploadHandler__ and its members read [this topic]({%slug radupload-features-upload-handler%}).		  

## Return parameters to the client

You are allowed to return parameters from the service to the client. The desired return parameters should be added via the __AddReturnParam(string, object)__ method. This is done in the override for the __GetAssociatedData()__ method.		

#### __[C#] Example 5: Adding custom parameters that should be returned to the client__  
{{region cs-radupload-features-upload-service-parameters_7}}
	public override Dictionary<string, object> GetAssociatedData()
	{
	    Dictionary<string, object> associatedData = base.GetAssociatedData();
	    if ( this.IsFinalFileRequest() )
	    {
	        associatedData.Add( "MyReturnParam", "MyValue" );
	    }
	    return associatedData;
	}
{{endregion}}

#### __[VB.NET] Example 5: Adding custom parameters that should be returned to the client__  
{{region vb-radupload-features-upload-service-parameters_8}}
	Public Overloads Overrides Function GetAssociatedData() As Dictionary(Of String, Object)
	 Dim associatedData As Dictionary(Of String, Object) = MyBase.GetAssociatedData()
	 If Me.IsFinalFileRequest() Then
	  associatedData.Add("MyReturnParam", "MyValue")
	 End If
	 Return associatedData
	End Function
{{endregion}}

To access these custom parameters on the client you have to handle the __FileUploaded__ event. They are stored in the __HandlerData.CustomData__ property of the arguments.		

#### __[XAML] Example 6: Subscribing to the FileUploaded event__  
{{region xaml-radupload-features-upload-service-parameters_9}}
	<telerik:RadUpload x:Name="radUpload"
	                   FileUploaded="radUpload_FileUploaded" />
{{endregion}}

#### __[C#] Example 7: Getting custom parameteres returned from the file upload__  
{{region cs-radupload-features-upload-service-parameters_10}}
	private void radUpload_FileUploaded( object sender, FileUploadedEventArgs e )
	{
	    var value = e.HandlerData.CustomData[ "MyReturnParam" ];
	}
{{endregion}}

#### __[VB.NET] Example 7: Getting custom parameteres returned from the file upload__  
{{region vb-radupload-features-upload-service-parameters_11}}
	Private Sub radUpload_FileUploaded(sender As Object, e As FileUploadedEventArgs)
	 Dim value As var = e.HandlerData.CustomData("MyReturnParam")
	End Sub
{{endregion}}

## See Also  
 * [Upload Handler]({%slug radupload-features-upload-handler%})
 * [Buffering]({%slug radupload-features-buffering%})
 * [Create Custom Upload Handler]({%slug radupload-how-to-create-custom-upload-handler%})
 * [Limit the Upload Speed]({%slug radupload-how-to-limit-the-upload-speed%})
 * [Implement Simple Authentication]({%slug radupload-how-to-implement-simple-authentication%})
 * [Personalize the File Storage]({%slug radupload-how-to-personalize-the-file-storage%})
