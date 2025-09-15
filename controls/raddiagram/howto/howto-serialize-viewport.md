---
title: How to serialize ViewPort after Save/Load operation
page_title: How to serialize ViewPort after Save/Load operation
description: This article explains how you can serialize RadDiagram ViewPort after save and load operation.
slug: raddiagrams-howto-serialize-viewport-save-load
tags: save,the,diagram,in,the,file,system, metadataserialized, MetadataDeserialized
published: True
position: 6
site_name: WPF
---

# How to serialize ViewPort after Save/Load operation

The following article will demonstrate how you can save the __RadDiagram__ current ViewPort position in the file system and load it again.	  

Let's first configure our XAML. We'll keep it simple - two buttons for save and Load and a Diagram with one shape.

__Example 1: RadDiagram with a single shape and two buttons for save and load__
```XAML
	<Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto" />
            <RowDefinition Height="*" />
        </Grid.RowDefinitions>
        <StackPanel HorizontalAlignment="Right">
            <Button Content="Save" Command="telerik:DiagramCommands.Save" />
            <Button Content="Load" Command="telerik:DiagramCommands.Open" />
        </StackPanel>
        <Grid Grid.Row="1">
            <telerik:RadDiagram x:Name="radDiagram" >
                <telerik:RadDiagramShape x:Name="ConditionShape" Width="80" Height="80"
                    Content="condition" FontWeight="Bold"
                    Geometry="{telerik:FlowChartShape ShapeType=DecisionShape}"
                    Position="160,80" />
            </telerik:RadDiagram>
        </Grid>
    </Grid>
```

In code behind we are subscribing to the Execute method of the Open/Save DiagramCommands. Then using the [DiagramExtension FileManager]({%slug raddiagram-extensions-filemanager%}) class you can export the diagram into file and load it again from it.

The next step is to subscribe to the __MetadataSerialized__ and __MetadataDeserialized__ events of the diagram control. In the MetadataSerialized event handler you can add a __Key__ to the __SerializationInfo__ object which will hold the __ViewPort.TopLeft__ property before the control is saved. Then in the __MetadataDeserialized__ event handler you can get the value of this property and call the __BringIntoView()__ method of the RadDiagram when the __DiagramCommands.Open__ command execute. __Example 2__ shows the whole logic for performing this approach.

__Example 2: Code-Behind logic__
```C#
	public partial class MainWindow : Window
	{
		private FileManager fileManager;
		private static double savedZoomFactor;
		private static Point savedDiagramPosition;

		static MainWindow()
		{
			var saveBinding = new CommandBinding(DiagramCommands.Save, ExecuteSave, CanExecutedSave);
			var openBinding = new CommandBinding(DiagramCommands.Open, ExecuteOpen);

			CommandManager.RegisterClassCommandBinding(typeof(MainWindow), saveBinding);
			CommandManager.RegisterClassCommandBinding(typeof(MainWindow), openBinding);
		}
					
		public MainWindow()
		{
			InitializeComponent();
			this.fileManager = new FileManager(this.radDiagram);
			this.radDiagram.MetadataSerialized += Diagram_MetadataSerialized;
			this.radDiagram.MetadataDeserialized += Diagram_MetadataDeserialized;
		}

		private void Diagram_MetadataDeserialized(object sender, DiagramSerializationRoutedEventArgs e)
		{
			var topLeft = e.SerializationInfo["viewPortTopLeft"];
			if (topLeft != null)
			{
				savedDiagramPosition = Utils.ToPoint((string)topLeft).Value;
				savedZoomFactor = double.Parse((string)e.SerializationInfo["Zoom"]);
			}
		}

		private void Diagram_MetadataSerialized(object sender, DiagramSerializationRoutedEventArgs e)
		{
			e.SerializationInfo["viewPortTopLeft"] = this.radDiagram.Viewport.TopLeft.ToInvariant();
		}

		private static void ExecuteOpen(object sender, ExecutedRoutedEventArgs e)
		{
			var owner = sender as MainWindow;
			if (owner != null)
			{
				owner.radDiagram.Clear();
				owner.fileManager.LoadFromFile();

				owner.radDiagram.BringIntoView(savedDiagramPosition, savedZoomFactor);
			}
		}

		private static void CanExecutedSave(object sender, CanExecuteRoutedEventArgs e)
		{
			var owner = sender as MainWindow;
			e.CanExecute = owner != null && owner.radDiagram != null && owner.radDiagram.Items.Count > 0;
		}

		private static void ExecuteSave(object sender, ExecutedRoutedEventArgs e)
		{
			var owner = sender as MainWindow;
			if (owner != null)
				owner.fileManager.SaveToFile();
		}
	}
```

## See Also
 * [Serialization]({%slug raddiagrams-features-serialization%})
 * [Commands]({%slug raddiagrams-features-commands%})