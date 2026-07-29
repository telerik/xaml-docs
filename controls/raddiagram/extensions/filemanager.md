---
title: FileManager
page_title: FileManager
description: This article describes the FileManager extension of the RadDiagram Framework.
slug: raddiagram-extensions-filemanager
tags: extensions
published: True
position: 5
---

# FileManager 

The FileManager is an extension class which can be used to save/load your RadDiagram in a file on your __Disk__ or in your application's __IsolatedStorage__. 

## Properties

* __CurrentFile__: A property of type __string__ that gets or sets the current file path. 

## Methods

FileManager class exposes two methods: LoadFromFile and SaveToFile. Depending on the parameter of these methods, the XML string can be saved to two storage locations: Disk or IsolatedStorage.

* __LoadFromFile(FileLocation location = FileLocation.Disk)__: This method accepts an enum of type __FileLocation__. By default the FileManager will load the XML string from the hard drive.

* __SaveToFile(FileLocation location = FileLocation.Disk)__: This method accepts an enum of type __FileLocation__. By default the FileManager will save the XML string to the hard drive.

To demonstrate this extension we are going to create a very simple application. First we can go ahead and declare the RadDiagram in XAML and add some shapes. Then we can add two buttons for save and load behavior.

__Example 1: Specify your RadDiagram in XAML__
<snippet id='raddiagram-extensions-filemanager-example_1_specify_your_raddiagram_in_xaml-xaml' />


Then we can subscribe to the Click event of the Save/Load buttons. The next step is to declare our FileManager and set its CurrentFile property. This property sets the path where the XML file will be saved on the user Disk.

__Example 2: Specify FileManager and save/load the RadDiagram__
<snippet id='raddiagram-extensions-filemanager-example_2_specify_filemanager_and_save_load_the_raddiagram-cs' />



## See Also

* [RadDiagramThumbnail]({%slug raddiagram-extensions-thumbnail%})
* [RadDiagramRuler]({%slug raddiagram-extensions-ruler%})
* [RadDiagramToolbox]({%slug raddiagram-extensions-toolbox%})
{% if site.framework_name == 'WPF' %}* [RadDiagramRibbon]({%slug raddiagram-extensions-diagramribbon-overview%}){% endif %}
