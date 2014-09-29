---
title: Getting Started
page_title: Getting Started
description: Getting Started
slug: radziplibrary-gettingstarted
tags: getting,started
published: True
position: 1
---

# Getting Started



The __Zip Library__ allows you to load data from existing ZIP archives or create and edit ZIPs that can be used by other applications.
        You can also create ZIP archives in memory or use a stream to get data and add it to a ZIP archive.
      

The ZIP archive is represented by __ZipArchive__ class. It can be used in 3 modes:
      

* __Read__: Allows reading of the existing ZIP archive. In this mode it is not possible to add or update archive entries.
          

* __Create__: Allows creation of a new archive. In this mode you can add new entries in the archive but cannot read or update
            content of the entries which have been written already.
          

* __Update__: Allows update of the existing ZIP archive. In this mode you can add new entries, read and update existing entries.
          

>In order to use the __Zip Library__ in your application, you need to add a reference to the
          __Telerik.Windows.Zip__ assembly.
        

>ZipArchive class was introduced in Q1 2014. In case you are using an older version of Telerik UI for
          {% if site.site_name == 'Silverlight' %}Silverlight{% endif %}{% if site.site_name == 'WPF' %}WPF{% endif %}
          refer to [this article]({%slug radziplibrary-zippackage%}).
        

## Open Zip Archive

The following code snippet demonstrates how to open existing Zip archive using the __ZipArchive__ class.
        

#### __C#__

{{region radziplibrary-gettingstarted_16}}
	using (Stream stream = File.Open("test.zip", FileMode.Open))
	{
	    using (ZipArchive archive = new ZipArchive(stream))
	    {
	        // Display the list of the files in the selected zip file using the ZipArchive.Entries property.
	    }
	}
	{{endregion}}



The *archive* variable holds the files that are compressed in the selected zip. You can access the list of these files
          through the __ZipArchive.Entries__ property. It holds a collection of __ZipArchiveEntry__ elements - the
          elements that describe the files archived in the zip file. You can use these elements to get the name of the compressed file, its uncompressed and
          compressed size and other file attributes.
        

## Create Zip Archive

The example below shows how to create a new Zip archive using the __ZipArchive__ class and place a text file in it.
        

#### __C#__

{{region radziplibrary-gettingstarted_17}}
	using (Stream stream = File.Open("test.zip", FileMode.Create))
	{
	    using (ZipArchive archive = new ZipArchive(stream, ZipArchiveMode.Create, false, null))
	    {
	        using (ZipArchiveEntry entry = archive.CreateEntry("text.txt"))
	        {
	            StreamWriter writer = new StreamWriter(entry.Open());
	            writer.WriteLine("Hello world!");
	            writer.Flush();
	        }
	    }
	}
	{{endregion}}



>tipIf you use __StreamWriter__ to write content to the stream you should call the Flush() method in order to flush the data to
            the stream.
          

>Do not close the stream opened by the __ZipArchiveEntry.Open()__ method. Otherwise the result is unpredictable.
          

# See Also

 * [Update ZipArchive]({%slug radziplibrary-update-ziparchive%})
