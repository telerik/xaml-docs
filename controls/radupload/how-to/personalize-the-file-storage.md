---
title: Personalize the File Storage
page_title: Personalize the File Storage
description: Check our &quot;Personalize the File Storage&quot; documentation article for the RadUpload {{ site.framework_name }} control.
slug: radupload-how-to-personalize-the-file-storage
tags: personalize,the,file,storage
published: True
position: 6
site_name: Silverlight
---

# Personalize the File Storage


This tutorial will show you how to personalize the storage folder, so each user who uses your application can upload the files in his own folder.

>tip To see an example of how to implement simple authentication read [here]({%slug radupload-how-to-implement-simple-authentication%}).

In order to achieve the personalization of the storage you have to do the following things:

* [Prepare the Account Session](#Prepare_the_Account_Session)

* [Override the GetTargetFolder method](#Override_the_GetTargetFolder_method)

* [Prepare the Storage Folder](#Prepare_the_Storage_Folder)

* [Override the ProcessStream method](#Override_the_ProcessStream_method)

## Prepare the Account Session

In order to prepare the account session you have to create a method that gets the account name and determines whether the user is authorized.

>The account name and the authorization information should be passed as parameters to the Upload Handler. To learn how to pass parameters to it read [this topic]({%slug radupload-features-upload-service-parameters%}).

#### __[C#] Example 1: Preparing the account session__  
{{region cs-radupload-how-to-personalize-the-file-storage_0}}
	bool authorized = false;
	string accountName = string.Empty;
	private void PrepareAccountSession()
	{
	    string dataAuthorized = this.GetQueryParameter( "Authorized" );
	    this.authorized = !string.IsNullOrEmpty( dataAuthorized )
	        && dataAuthorized.ToLower() == "true";
	    this.accountName = this.GetQueryParameter("Account");
	    if ( !this.authorized || string.IsNullOrEmpty( this.accountName ) )
	        this.accountName = "Anonymous";
	}
{{endregion}}

#### __[VB.NET] Example 1: Preparing the account session__  
{{region vb-radupload-how-to-personalize-the-file-storage_1}}
	Private authorized As Boolean = False
	Private accountName As String = String.Empty
	Private Sub PrepareAccountSession()
	 Dim dataAuthorized As String = Me.GetQueryParameter("Authorized")
	 Me.authorized = Not String.IsNullOrEmpty(dataAuthorized) AndAlso dataAuthorized.ToLower() = "true"
	 Me.accountName = Me.GetQueryParameter("Account")
	 If Not Me.authorized OrElse String.IsNullOrEmpty(Me.accountName) Then
	  Me.accountName = "Anonymous"
	 End If
	End Sub
{{endregion}}

## Override the GetTargetFolder method

The storage folder should be inside the Target Folder and must be named after the user. To do that you have to override the __GetTargteFolder()__ method.

#### __[C#] Example 2: Setting up the target folder__  
{{region cs-radupload-how-to-personalize-the-file-storage_2}}
	public override string GetTargetFolder()
	{
	    string path = base.GetTargetFolder();
	    if ( !string.IsNullOrEmpty( this.accountName ) )
	    {
	        path += Path.DirectorySeparatorChar + this.accountName;
	    }
	    return path;
	}
{{endregion}}

#### __[VB.NET] Example 2: Setting up the target folder__  
{{region vb-radupload-how-to-personalize-the-file-storage_3}}
	Public Overloads Overrides Function GetTargetFolder() As String
	 Dim path As String = MyBase.GetTargetFolder()
	 If Not String.IsNullOrEmpty(Me.accountName) Then
	  path += Path.DirectorySeparatorChar + Me.accountName
	 End If
	 Return path
	End Function
{{endregion}}

## Prepare the Storage Folder

In order to prepare the storage folder you have to create a method that checks whether the folder returned by the __GetTargetFolder()__ method exists and creates the folder if needed.

#### __[C#] Example 3: Ensuring that the storage folder exists__  
{{region cs-radupload-how-to-personalize-the-file-storage_4}}
	private bool PrepareStorageFolder()
	{
	    string folderPath = this.GetTargetFolder();
	    if ( !Directory.Exists( folderPath ) )
	    {
	        Directory.CreateDirectory( folderPath );
	    }
	    return Directory.Exists( folderPath );
	}
{{endregion}}

#### __[VB.NET] Example 3: Ensuring that the storage folder exists__  
{{region vb-radupload-how-to-personalize-the-file-storage_5}}
	Private Function PrepareStorageFolder() As Boolean
	 Dim folderPath As String = Me.GetTargetFolder()
	 If Not Directory.Exists(folderPath) Then
	  Directory.CreateDirectory(folderPath)
	 End If
	 Return Directory.Exists(folderPath)
	End Function
{{endregion}}

## Override the SaveChunkData method

Overriding the __SaveChunkData()__ method allows you to put all this together.

#### __[C#] Example 4: Saving the data__  
{{region cs-radupload-how-to-personalize-the-file-storage_6}}
	public override bool SaveChunkData(string filePath, long position, byte[] buffer, int contentLength, out int savedBytes)
	{
	 bool result;
	 this.PrepareAccountSession();
	 if (!this.PrepareStorageFolder())
	 {
	  result = false;
	 }
	
	 string FilePath = this.GetFilePath();
	 result = base.SaveChunkData(FilePath, position, buffer, contentLength, out savedBytes);
	 return result;
	}
{{endregion}}

#### __[VB.NET] Example 4: Saving the data__  
{{region vb-radupload-how-to-personalize-the-file-storage_7}}
	Public Overrides Function SaveChunkData(filePath__1 As String, position As Long, buffer As Byte(), contentLength As Integer, ByRef savedBytes As Integer) As Boolean
		Dim result As Boolean
		Me.PrepareAccountSession()
	
		If Not Me.PrepareStorageFolder() Then
			result = False
		End If
	
		Dim FilePath__2 As String = Me.GetFilePath()
		result = MyBase.SaveChunkData(FilePath__2, position, buffer, contentLength, savedBytes)
	
		Return result
	End Function
{{endregion}}

## See Also  
 * [Upload Handler]({%slug radupload-features-upload-handler%})
 * [Upload Service Parameters]({%slug radupload-features-upload-service-parameters%})
 * [Implement Simple Authentication]({%slug radupload-how-to-implement-simple-authentication%})