---
title: Create Custom RadUpload Control
page_title: Create Custom RadUpload Control
description: Create Custom RadUpload Control
slug: how-to-create-custom-upload
tags: create,custom,radupload,control
published: True
position: 11
---

# Create Custom RadUpload Control



If you need to create your own Upload control, you can rely on the __RadUpload__ control to prepare your files for upload behind the scenes.
	  

## 

For example, if your application contains a custom control that creates a list of files for upload, you can create a __RadUpload__ in code-behind to manage the files and upload them on the server.
		

In order to do so, you will need to manually add the list of the files into the __CurrentSession.SelectedFiles__ collection:
		

#### __C#__

{{region how-to-create-custom-upload_0}}
	//create a RadUpload to handle the upload
	RadUpload upload = new RadUpload;
	// get a collection of files from the local system
	List<FileInfo> files = new List<FileInfo>();
	// add files 
	// . . . 
	// insert files in the RadUpload
	if (files.Count > 0)
	{
	 foreach (FileInfo file in files)
	 {
	  RadUploadSelectedFile f = new RadUploadSelectedFile(file);
	  upload.CurrentSession.SelectedFiles.Add(f);
	 }
	//prepare for upload
	...
	}
	{{endregion}}



#### __VB.NET__

{{region how-to-create-custom-upload_1}}
	Dim upload As New RadUpload()
	' get some files from the local system'
	Dim files As New List(Of FileInfo)()
	' add some files '
	' . . . '
	' insert files in the RadUpload'
	If files.Count > 0 Then
	 For Each file As FileInfo In files
	  Dim f As New RadUploadSelectedFile(file)
	  upload.CurrentSession.SelectedFiles.Add(f)
	 Next
	 ' prepare for upload'
	End If
	{{endregion}}



>tipThe __RadUploadSelectedFile__ class has a constructor that allows you to create a new instance from a __Stream__ object: RadUploadSelectedFile f = new RadUploadSelectedFile(fileStream,fileName). However, in order to create a valid object of tyle __RadUploadSelectedFile__, you need to make sure that the __fileStream Position__ is set to the beginning of the stream: fileStream.Position=0L. Only then you can use the __Stream__ object to create a __RadUploadSelectedFile__ instance.
		  

Then you have to prepare the RadUpload control for the upload process. The __PrepareSelectedFilesForUpload__ method facilitates the implementation of such scenarios by setting the __RadUpload__ in a state ready to upload the manually added __CurrentSession.SelectedFiles__ collection:
		

#### __C#__

{{region how-to-create-custom-upload_2}}
	// prepare for upload
	 this.upload.PrepareSelectedFilesForUpload();
	{{endregion}}



#### __VB.NET__

{{region how-to-create-custom-upload_3}}
	' prepare for upload'
	upload.PrepareSelectedFilesForUpload()
	{{endregion}}



Finally, you need to start the upload:

#### __C#__

{{region how-to-create-custom-upload_4}}
	this.upload.StartUpload();
	{{endregion}}



#### __VB.NET__

{{region how-to-create-custom-upload_5}}
	upload.StartUpload()
	{{endregion}}


