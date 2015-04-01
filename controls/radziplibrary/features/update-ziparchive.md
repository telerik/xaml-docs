---
title: Update ZipArchive
page_title: Update ZipArchive
description: Update ZipArchive
slug: radziplibrary-update-ziparchive
tags: update,ziparchive
published: True
position: 0
---

# Update ZipArchive



With __RadZipLibrary__ you can update existing ZIP archive in order to add new entries to it, delete or update existing entries.
      

The __ZipArchive__ class provides three modes: *Read*, *Create* and *Update*. More information on creating and reading an archive is available [here]({%slug radziplibrary-gettingstarted%}).
      

The following code snippet opens a ZIP archive in update mode using __ZipArchive__ class:
      

#### __[C#] Open for Update__

{{region radziplibrary-update-ziparchive_0}}
	            using (Stream stream = File.Open("test.zip", FileMode.Open))
	            {
	                using (ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Update, false, null))
	                {
	                    // Display the list of the files in the selected zip file using the ZipArchive.Entries property.
	                }
	            }
	{{endregion}}



#### __[VB.NET] Open for Update__

{{region radziplibrary-update-ziparchive_0}}
				Using stream As Stream = File.Open("test.zip", FileMode.Open)
					Using archive As New ZipArchive(stream, ZipArchiveMode.Update, False, Nothing)
						' Display the list of the files in the selected zip file using the ZipArchive.Entries property.
					End Using
				End Using
	{{endregion}}



## Add Entry

In order to add a new entry into the ZIP archive you should perform the following steps:
        

1. Use __CreateEntry()__ method of the __ZipArchive__ object to create a new entry.
            

1. Open the entry to obtain stream for writing.
            

1. Write necessary information into the entry.
            

1. Dispose entry when all necessary information is written. In the *Update* mode this step is optional. You can omit it if you are going to add/delete/update other entries in the archive.
            

#### __[C#] Add Entry__

{{region radziplibrary-update-ziparchive_1}}
	            using (ZipArchiveEntry entry = archive.CreateEntry("text.txt"))
	            {
	                StreamWriter writer = new StreamWriter(entry.Open());
	                writer.WriteLine("Hello world!");
	                writer.Flush();
	            }
	{{endregion}}



#### __[VB.NET] Add Entry__

{{region radziplibrary-update-ziparchive_1}}
				Using entry As ZipArchiveEntry = archive.CreateEntry("text.txt")
					Dim writer As New StreamWriter(entry.Open())
					writer.WriteLine("Hello world!")
					writer.Flush()
				End Using
		{{endregion}}



## Delete Entry

The __ZipArchive__ class provides a __GetEntry()__ method which allows you access to a particular entry in the archive.
        

The following code snippet obtains an entry and deletes it from the ZIP archive using the __Delete()__ method:
        

#### __[C#] Delete Entry__

{{region radziplibrary-update-ziparchive_2}}
	            ZipArchiveEntry entry = archive.GetEntry("text.txt");
	            if (entry != null)
	            {
	                entry.Delete();
	            }
	{{endregion}}



#### __[VB.NET] Delete Entry__

{{region radziplibrary-update-ziparchive_2}}
				Dim entry As ZipArchiveEntry = archive.GetEntry("text.txt")
				If entry IsNot Nothing Then
					entry.Delete()
				End If
	{{endregion}}


## Update Entry

In order to update an existing entry in the ZIP archive you should perform the following steps:
        

1. Use __GetEntry()__ method of the __ZipArchive__ object to obtain existing entry.
            

1. Open entry to get stream for reading/writing.
            

1. Read/Write necessary information from/to the entry.
            

1. Dispose entry when all necessary information is written. In the __Update__ mode this step is optional. You can omit it if you are going to add/delete/update other entries in the archive.
            

#### __[C#] Update Entry__

{{region radziplibrary-update-ziparchive_3}}
	            ZipArchiveEntry entry = archive.GetEntry("text.txt");
	            if (entry != null)
	            {
	                Stream entryStream = entry.Open();
	                StreamReader reader = new StreamReader(entryStream);
	                string content = reader.ReadToEnd();
	
	                entryStream.Seek(0, SeekOrigin.End);
	                StreamWriter writer = new StreamWriter(entryStream);
	                writer.WriteLine("Updated line.");
	                writer.Flush();
	            }
	{{endregion}}



#### __[VB.NET] Update Entry__

{{region radziplibrary-update-ziparchive_3}}
				Dim entry As ZipArchiveEntry = archive.GetEntry("text.txt")
				If entry IsNot Nothing Then
					Dim entryStream As Stream = entry.Open()
					Dim reader As New StreamReader(entryStream)
					Dim content As String = reader.ReadToEnd()
	
					entryStream.Seek(0, SeekOrigin.End)
					Dim writer As New StreamWriter(entryStream)
					writer.WriteLine("Updated line.")
					writer.Flush()
				End If
	{{endregion}}



# See Also

 * [Getting Started]({%slug radziplibrary-gettingstarted%})
