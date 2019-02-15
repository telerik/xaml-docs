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

The FileManager is an extension class which can be used to save/load your RadDiagram in in a file on your __Disk__ or in your application __IsolatedStorage__. 

## Properties

* __CurrentFile__: A property of type __string__ that gets or sets the current file path. 

## Methods

FileManager class expose two methods: LoadFromFile and SaveToFile. Depending on the paramerter of these methods the XML string can be save to two storage location: Disk or IsolatedStorage.

* __LoadFromFile(FileLocation location = FileLocation.Disk)__: This method accept enum type of __FileLocation__. By default the FileManager will load the XML string from the hard drive.

* __SaveToFile(FileLocation location = FileLocation.Disk)__: This method accept enum type of __FileLocation__. By default the FileManager will save the XML string to the hard drive.


To demonstrate this extension we are going to create a very simple application. First we can go ahead and declare the RadDiagram in XAML and add some shapes. Then we can add two buttons for save and load behavior.

#### __[XAML] Example 1: Specify your RadDiagram in XAML__
{{region xaml-raddiagram-extensions-filemanager_0}}
	<Grid>
		<Grid.RowDefinitions>
			<RowDefinition Height="*"/>
			<RowDefinition Height="Auto"/>
		</Grid.RowDefinitions>

		<telerik:RadDiagram x:Name="diagram">
			<telerik:RadDiagramShape x:Name="Shape1" Content="Shape1" Position="200,300"/>
			<telerik:RadDiagramShape x:Name="Shape2" Content="Shape2" Position="200,100"/>
			<telerik:RadDiagramConnection Source="{Binding ElementName=Shape1}" Target="{Binding ElementName=Shape2}" />
		</telerik:RadDiagram>

		<Grid Grid.Row="1">
			<telerik:RadButton Content="Load" Width="200"  HorizontalAlignment="Left" Click="Load_Click"/>
			<telerik:RadButton Content="Save"  Width="200" HorizontalAlignment="Right" Click="Save_Click"/>
		</Grid>
	</Grid>	
{{endregion}}

Then we can subscribe to the Click event of the Save Load buttons. The next step is to declare our FileManager and set its CurrentFile property. This property set the path where the XML file will be saved on the user Disk.

#### __[C#] Example 2: Specify FileManager and save/load the RadDiagram__
{{region csharp-raddiagram-extensions-filemanager_1}}
	public partial class MainWindow : Window
    {
        FileManager fileManager;
        public MainWindow()
        {
            InitializeComponent();
            fileManager = new FileManager(this.diagram);
            fileManager.CurrentFile = @"C:\Temp";
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            fileManager.LoadFromFile(FileLocation.Disk);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            fileManager.SaveToFile(FileLocation.Disk);
        }
    }
{{endregion}}


## See Also

* [RadDiagramThumbnail]({%slug raddiagram-extensions-thumbnail%})
* [RadDiagramRuler]({%slug raddiagram-extensions-ruler%})
* [RadDiagramToolbox]({%slug raddiagram-extensions-toolbox%})
* [RadDiagramRibbon]({%slug raddiagram-extensions-diagramribbon-overview%})