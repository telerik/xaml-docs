---
title: Protect ZipArchive
page_title: Protect ZipArchive
description: Protect ZipArchive
slug: radziplibrary-protect-ziparchive
tags: protect,ziparchive
publish: True
position: 2
---

# Protect ZipArchive



__RadZipLibrary__ lets you protect a ZIP archive with a password. This help article will teach you to use __RadZipLibrary__ to password protect files and how to open files that are protected with a password. To protect a ZIP archive and all __ZipArchiveEntry__ items in it you should specify encryption settings when creating the [ZipArchive]({%slug radziplibrary-gettingstarted%}) object.
      

__RadZipLibrary__ supports traditional PKWARE encryption only. The settings for this encryption type are represented by the __DefaultEncryptionSettings__ class.
      

* [Create a Password-protected ZipArchive](#create-a-password-protected-ziparchive)

* [Read a Password-protected ZipArchive](#read-a-password-protected-ziparchive)

## Create a Password-protected ZipArchive

In order to create a password-protected ZIP archive you need to pass a __DefaultEncryptionSettings__ object to the __ZipArchive__'s constructor along with the __ZipArchiveMode.Create__ parameter.
        

__DefaultEncryptionSettings__ has a __Password__ property of type string which represents the used password.
        

__Example 1__: Create a password-protected ZIP archive:
        

#### __C#__

{{region radziplibrary-protect-ziparchive_0}}
	using (Stream stream = File.Open("test.zip", FileMode.Create)) 
	{
	    DefaultEncryptionSettings encryptionSettings = new DefaultEncryptionSettings(); 
	    encryptionSettings.Password = "password"; 
	    using (ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Create, false, null, null, encryptionSettings)) 
	    { 
	        using (ZipArchiveEntry entry = archive.CreateEntry("text.txt"))
	        { 
	            StreamWriter writer = new StreamWriter(entry.Open()); 
	            writer.WriteLine("Hello world!"); writer.Flush();
	        }
	    }
	}
	{{endregion}}



>tipYou must always dispose of the ZIP archive object when all operations that use it are competed. Telerik Support recommends that you declare and instantiate the ZIP archive object in a using statement. If it is not possible for some reason, then do not forget to call the __Dispose()__ method when you complete all operations.
          

## Read a Password-protected ZipArchive

In order to open a password-protected __ZipArchive__ you need to pass a __DefaultEncryptionSettings__ object with the password that was used to create the archive in the first place.
        

__Example 2__: Open and read a password-protected ZIP archive.
        

#### __C#__

{{region radziplibrary-protect-ziparchive_1}}
	using (Stream stream = File.Open("test.zip", FileMode.Open)) 
	{ 
	    DefaultEncryptionSettings encryptionSettings = new DefaultEncryptionSettings(); 
	    encryptionSettings.Password = "password"; 
	    using (ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Read, false, null,null, encryptionSettings))
	    {
	        {
	            // Display the list of the files in the selected zip file using the ZipArchive.Entries property. 
	        }
	    }
	{{endregion}}



>tipYou must always dispose of the ZIP archive object when all operations that use it are competed. Telerik Support recommends that you declare and instantiate the ZIP archive object in a using statement. If it is not possible for some reason, then do not forget to call the __Dispose()__ method when you complete all operations.
          

# See Also

 * [Getting Started]({%slug radziplibrary-gettingstarted%})

 * [Update ZipArchive]({%slug radziplibrary-update-ziparchive%})
