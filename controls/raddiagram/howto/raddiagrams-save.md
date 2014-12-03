---
title: Save the Diagram in the File System
page_title: Save the Diagram in the File System
description: Save the Diagram in the File System
slug: raddiagrams-howto-save
tags: save,the,diagram,in,the,file,system
published: True
position: 6
site_name: WPF
---

# Save the Diagram in the File System

The following article will show how you can save the __RadDiagram__ in the File System and load it.	  

## Save the Diagram to the File System and Load

Let's first configure our XAML. We'll keep it simple - two buttons for Save and Load and a Diagram with one shape.

#### __XAML__
	<Grid x:Name="LayoutRoot" Background="White">
		<Grid.RowDefinitions>
			<RowDefinition Height="Auto" />
			<RowDefinition Height="*" />
		</Grid.RowDefinitions>
		<telerik:RadDiagram Grid.Row="1" x:Name="diagram">
			<telerik:RadDiagramShape Width="100" Height="100" Position="100 100" Content="Shape" />
		</telerik:RadDiagram>

		<StackPanel Orientation="Horizontal">
			<telerik:RadButton Content="Save To Storage" x:Name="saveButton" Click="saveButton_Click" />
			<telerik:RadButton Content="Load From Storage" x:Name="loadButton" Click="loadButton_Click" />
		</StackPanel>
	</Grid>

In code behind we are using the Click event handlers of our Save/Load Buttons. On Save, we use a __SaveFileDialog__ and we can create new or overwrite an existing text file.		

Then we use the __RadDiagram.Save()__ - this returns a string with the serialized Diagram. Having this string, the final step is to use __StreamWriter__ to write the string into the chosen file.	

On Load, we open the created file by __OpenFileDialog__ and use __StreamReader__ and __RadDiagram.Load()__ method.		

#### __C#__
	public partial class MainWindow : Window
	{
		private string fileName;
		public MainWindow()
		{
			InitializeComponent();
		}
		
		private void saveButton_Click(object sender, RoutedEventArgs e)
		{
			Stream fileStream = null;
			try
			{
				var dialog = new SaveFileDialog();
				if (dialog.ShowDialog() == true)
				{
					fileStream = dialog.OpenFile();
					this.fileName = dialog.FileName;
				}

				using (fileStream)
				{
					var serializationString = this.diagram.Save();
					var writer = new StreamWriter(fileStream);
					writer.Write(serializationString);
					writer.Flush();
				}
			}
			finally
			{
				if (fileStream != null)
					fileStream.Close();
			}
		}

		private void loadButton_Click(object sender, RoutedEventArgs e)
		{
			Stream fileStream = null;
			try
			{
				var dialog = new OpenFileDialog();
				dialog.ShowDialog();
				using (fileStream = dialog.OpenFile())
				{
					StreamReader reader = new StreamReader(fileStream);
					using(reader)
					{
						string serializedString = reader.ReadToEnd();
						this.diagram.Load(serializedString);
					}
				}
			}
			finally
			{
				if (fileStream != null)
					fileStream.Close();
			}
		}
	}

#### __VB.NET__
	Partial Public Class MainWindow
		 Inherits Window
		   Private fileName As String
		   Public Sub New()
			   InitializeComponent()
		   End Sub

		   Private Sub saveButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			   Dim fileStream As Stream = Nothing
			   Try
				   Dim dialog = New SaveFileDialog()
				   If dialog.ShowDialog() = True Then
					   fileStream = dialog.OpenFile()
					   Me.fileName = dialog.FileName
				   End If

				   Using fileStream
					   Dim serializationString = Me.diagram.Save()
					   Dim writer = New StreamWriter(fileStream)
					   writer.Write(serializationString)
					   writer.Flush()
				   End Using
			   Finally
				   If fileStream IsNot Nothing Then
					   fileStream.Close()
				   End If
			   End Try

		   End Sub

		   Private Sub loadButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			   Dim fileStream As Stream = Nothing
			   Try
				   Dim dialog = New OpenFileDialog()
				   dialog.ShowDialog()
				   fileStream = dialog.OpenFile()
				   Using fileStream
					   Dim reader As New StreamReader(fileStream)
					   Using reader
						   Dim serializedString As String = reader.ReadToEnd()
						   Me.diagram.Load(serializedString)
					   End Using
				   End Using
			   Finally
				   If fileStream IsNot Nothing Then
					   fileStream.Close()
				   End If
			   End Try
	End Sub

# See Also
 * [Serialization]({%slug raddiagrams-features-serialization%})
 * [Commands]({%slug raddiagrams-features-commands%})