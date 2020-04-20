---
title: Rename a File
page_title: Rename a File
description: Check our &quot;Rename a File&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-how-to-rename-a-file
tags: rename,a,file
published: True
position: 3
site_name: Silverlight
---

# Rename a File

You can modify the name of the file on both the client and the server side of your application. The following topic will show you how to do this.

## Renaming a file on the client

If you want to change the name of the file to be uploaded on the client you should handle the __FileUploadStarting__ event. This is the last place where you can do it on the client, because after this event has been fired the upload of the file begins. Here is an example:

#### __[C#] Example 1: Renaming a file__
{{region cs-radupload-how-to-rename-a-file_0}}
	private int counter = 1;
	private void radUpload_FileUploadStarting( object sender, FileUploadStartingEventArgs e )
	{
	    string newFileName = "MyCustomFileName" + counter + e.SelectedFile.File.Extension;
	    e.UploadData.FileName = newFileName;
	    counter++;
	}
{{endregion}}

#### __[VB.NET] Example 1: Renaming a file__
{{region vb-radupload-how-to-rename-a-file_1}}
	Private counter As Integer = 1
	Private Sub radUpload_FileUploadStarting(sender As Object, e As FileUploadStartingEventArgs)
	 Dim newFileName As String = "MyCustomFileName" + counter + e.SelectedFile.File.Extension
	 e.UploadData.FileName = newFileName
	 counter += 1
	End Sub
{{endregion}}

## Renaming a file on the server

To rename a file on the server you have to override the __GetFilePath()__ method of the __RadUploadHandler__. More about the __RadUploadHandler__ can be found [here]({%slug radupload-features-upload-handler%}).

Here is an example:

#### __[C#] Example 2: Renaming a file on the server__  
{{region cs-radupload-how-to-rename-a-file_2}}
	private int counter = 1;
	public override string GetFilePath( string fileName )
	{
	    string newFileName = "MyCustomFileName" + counter + fileName.Substring( fileName.LastIndexOf( '.' ) );
	    return base.GetFilePath( newFileName );
	}
{{endregion}}

#### __[VB.NET] Example 2: Renaming a file on the server__  
{{region vb-radupload-how-to-rename-a-file_3}}
	Private counter As Integer = 1
	Public Overloads Overrides Function GetFilePath(fileName As String) As String
	 Dim newFileName As String = "MyCustomFileName" + counter + fileName.Substring(fileName.LastIndexOf("."c))
	 Return MyBase.GetFilePath(newFileName)
	End Function
{{endregion}}

## See Also
 * [Create Custom Upload Handler]({%slug radupload-how-to-create-custom-upload-handler%})
 * [Hide the Buttons]({%slug radupload-how-to-hide-the-buttons%})
 * [Personalize the File Storage]({%slug radupload-how-to-personalize-the-file-storage%})