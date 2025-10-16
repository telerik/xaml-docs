---
title: Save the Diagram in the File System
page_title: Save the Diagram in the File System
description: This article explains how you can save and load the RadDiagram control to and from an XML file on your system.
slug: raddiagrams-howto-save
tags: save,the,diagram,in,the,file,system
published: True
position: 6
site_name: WPF
---

# Save the Diagram in the File System

The following article will demonstrate how you can save the __RadDiagram__ in the file system and load it.	  

## Save the Diagram to the File System and Load

Let's first configure our XAML. We'll keep it simple - two buttons for save and Load and a Diagram with one shape.

__Example 1: RadDiagram with a single shape and two buttons for save and load__
```XAML
	<Grid x:Name="LayoutRoot" Background="White">
		<Grid.RowDefinitions>
			<RowDefinition Height="Auto" />
			<RowDefinition Height="*" />
		</Grid.RowDefinitions>
		<telerik:RadDiagram Grid.Row="1" x:Name="diagram">
			<telerik:RadDiagramShape Width="100" Height="100" Position="100 100" Content="Shape" />
		</telerik:RadDiagram>

		<StackPanel Orientation="Horizontal">
			<telerik:RadButton Content="Save To Storage" x:Name="SaveButton" Click="SaveButton_Click" />
			<telerik:RadButton Content="Load From Storage" x:Name="LoadButton" Click="LoadButton_Click" />
		</StackPanel>
	</Grid>
```

In the code behind we are using the Click event handlers of our save/load buttons. On save, we use a __SaveFileDialog__ to create a new file or overwrite an existing text file.		

Then we use the __RadDiagram.Save()__ method which returns a string with the serialized RadDiagram. Having this string, the final step is to use __StreamWriter__ to write the string into the chosen file.

On Load, we open the created file using an __OpenFileDialog__ and use the __StreamReader__ and the __RadDiagram.Load()__ method to load the serialized XML.

__Example 2: The Save and Load handlers__
```C#
	public partial class MainWindow : Window
	{
		private string fileName;
		public MainWindow()
		{
			InitializeComponent();
		}
		
		private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "XML Files|\*.xml|All Files|\*.\*";
            if (dialog.ShowDialog() == true)
            {
                using (Stream stream = dialog.OpenFile())
                {
                    this.fileName = dialog.FileName;
                    var serializationString = this.diagram.Save();
                    var writer = new StreamWriter(stream);
                    writer.Write(serializationString);
                    writer.Flush();
                }
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "XML Files|\*.xml|All Files|\*.\*";
            dialog.ShowDialog();
            using (Stream stream = dialog.OpenFile())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string serializedString = reader.ReadToEnd();
                    this.diagram.Load(serializedString);
                }
            }
        }
	}
```
```VB.NET
	Partial Public Class MainWindow
		 Inherits Window
		   Private fileName As String
		   Public Sub New()
			   InitializeComponent()
		   End Sub

		Private Sub SaveButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim dialog = New SaveFileDialog()
			dialog.Filter = "XML Files|\*.xml|All Files|\*.\*"
			If dialog.ShowDialog() = True Then
				Using stream As Stream = dialog.OpenFile()
					Me.fileName = dialog.FileName
					Dim serializationString = Me.diagram.Save()
					Dim writer = New StreamWriter(stream)
					writer.Write(serializationString)
					writer.Flush()
				End Using
			End If
		End Sub

		Private Sub LoadButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim dialog = New OpenFileDialog()
			dialog.Filter = "XML Files|\*.xml|All Files|\*.\*"
			dialog.ShowDialog()
			Using stream As Stream = dialog.OpenFile()
				Using reader As New StreamReader(stream)
					Dim serializedString As String = reader.ReadToEnd()
					Me.diagram.Load(serializedString)
				End Using
			End Using
		End Sub
    End Class
```

> You can also replace the OpenFileDialog and SaveFileDialog with Telerik's [RadOpenFileDialog]({%slug radfiledialogs-radopenfiledialog%}) and [RadSaveFileDialog]({%slug radfiledialogs-radsavefiledialog%}) for a more consistent look.

## See Also
 * [Serialization]({%slug raddiagrams-features-serialization%})
 * [Commands]({%slug raddiagrams-features-commands%})