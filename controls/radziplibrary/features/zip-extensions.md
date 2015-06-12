---
title: Zip Extensions
page_title: Zip Extensions
description: Zip Extensions
slug: radziplibrary-zipextensions
tags: zip, extensions
published: True
position: 5
---

# Zip Extensions

In addition to the main __ZipLibrary__ control, you could take advantage of a set of helper methods, divided in two classes, which will help you to implement your scenarios faster. All these methods are in the __Telerik.Windows.Zip.Extensions.dll__. 


In this article you will find the classes and their members.



## The DotNetPlatformManager class

This class implements the [IPlatformManager](http://docs.telerik.com/devtools/silverlight/api/html/T_Telerik_Windows_Zip_IPlatformManager.htm) interface, which provides platform-specific operations.

### Properties

* __string AltDirectorySeparatorChar__: Gets a platform-specific alternate character used to separate directory levels in a path string that reflects a hierarchical file system organization.

* __Encoding DefaultEncoding__: Gets default encoding for this platform.

* __string DirectorySeparatorChar__: Gets a platform-specific character used to separate directory levels in a path string that reflects a hierarchical file system organization.

* __TemporaryStreamType TemporaryStreamType__: Gets or sets type of the temporary stream. The default value is TemporaryStreamType.Memory.


### Methods

* __stream CreateTemporaryStream()__: Creates temporary stream. Stream will be used for temporary operations.

* __void DeleteTemporaryStream(Stream stream)__: Deletes temporary stream.

* __ICryptoProvider GetCryptoProvider(EncryptionSettings settings)__: Gets crypto provider initialized using given encryption settings.

* __bool IsEncodingSupported(Encoding encoding)__: Indicates whether specified encoding is supported for this platform. <returns>true if encoding is allowed in the ZIP file.


## The ZipFile class

With the __ZipFile__ class you could take advantage of static methods, which will give you the ability to create, extract or open zip archives with only one line of code.

* __ZipArchiveEntry CreateEntryFromFile(this ZipArchive destination, string sourceFileName, string entryName)__ – Archives a file by compressing it and adding it to the zip archive. It has two more overloads, which allow you to specify the __CompressionLevel__ or __CompressionSettings__ of the __ZipEntry__.

* __void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName)__: Creates a zip archive that contains the files and directories from the specified directory. This method has few overloads to set different settings of the entry.
    
* __void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName)__: Extracts all the files in the specified zip archive to a directory on the file system.


* __void ExtractToFile(this ZipArchiveEntry source, string destinationFileName)__: Extracts an entry in the zip archive to a file. With the additional overload you could specify whether to overwrite an existing file that has the same name as the destination file or not.

* __ZipArchive Open(string archiveFileName, ZipArchiveMode mode)__: Opens a zip archive at the specified path and in the specified mode. Another overload allows specifying the encoding to use when reading or writing entry names in this archive. Specify a value for this parameter only when an encoding is required for interoperability with zip archive tools and libraries that do not support UTF-8 encoding for entry names.

* __ZipArchive OpenRead(string archiveFileName)__: Opens a zip archive for reading at the specified path. 

* __bool IsDirectoryEmpty(DirectoryInfo directoryInfo)__: Indicates whether specified directory is empty or not. 


# See Also

* [Compression Settings]({%slug radziplibrary-compression-settings%})
* [Compress Stream]({%slug radziplibrary-compress-stream%})
* [Update ZipArchive]({%slug radziplibrary-update-ziparchive%})