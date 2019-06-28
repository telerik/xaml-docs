---
title: How to exclude shape from serialization
page_title: How to exclude shape from serialization
description: This article explains how you can exclude shapres from serialization.
slug: raddiagrams-howto-exclude-shape-from-serialization
tags: save,the,diagram,in,the,file,system, serialization,serialize,
published: True
position: 6
site_name: WPF
---

# How to exclude shapes from serialization

The following article will demonstrate how you can exclude shapes from serialization.
 
For the purpose of this example, we will create the following ViewModels.

* __Model__: A class deriving from the __NodeViewModelBase__ ViewModel that represents a node. In the Model class will have two additional properties: bool __IsStatic__ and Guid __ID__. The serialization of the shapes will depends on the first property. The __Guid__ property will be returned in the __GetNodeUniqueId()__ to cache the serialized shapes and connections.
* __Link__: A class deriving from the LinkViewModelBase ViewModel that represent a link.
* __MyGraphSource__: A class deriving from the __SerializableGraphSourceBase__ ViewModel that represent the RadDiagram GraphSource.

#### __[C#] Example 1: Creating ViewModels__
{{region cs-raddiagrams-howto-exclude-shape-from-serialization-0}}
	public class Model : NodeViewModelBase
	{
		public bool IsStatic { get; set; }
		public Guid Id { get; set; }
	}
	public class Link : LinkViewModelBase<NodeViewModelBase>
    {
    }
	public class MyGraphSource : SerializableGraphSourceBase<Model, Link>
	{       
		public MyGraphSource()
		{
			Model saveShape = new Model() { Content = "Shape 1", Position = new System.Windows.Point(122, 122) };
			Model notSaveShape = new Model() { Content = "Shape 2", Position = new System.Windows.Point(500, 100), IsStatic = true };
			this.AddNode(saveShape);
			this.AddNode(notSaveShape);
		}

		public override string GetNodeUniqueId(Model node)
		{
			return node.Id.ToString();
		}

		public override void SerializeNode(Model node, Telerik.Windows.Diagrams.Core.SerializationInfo info)
		{
			base.SerializeNode(node, info);
			info["Content"] = node.Content;
			info["IsStatic"] = node.IsStatic;
		}

		public override Model DeserializeNode(Telerik.Windows.Diagrams.Core.IShape shape, Telerik.Windows.Diagrams.Core.SerializationInfo info)
		{
			base.DeserializeNode(shape, info);
			if (info["Content"] != null)
			{
				return new Model()
				{
					Content = info["Content"].ToString(),
					IsStatic = info["IsStatic"].ToString() == "true" ? true : false
				};
			}
			return null;
		}
	}
{{endregion}}

Next to exclude a shape from serialization you can create custom class which derives from __SerializationService__ and override the __SerializeShapes__ method. Inside the method you can create custom logic to filter which shapes to be serialize and pass it to the __base.SerializeShapes()__ method.

#### __[C#] Example 2: Creating custom SerializationService__
{{region cs-raddiagrams-howto-exclude-shape-from-serialization-1}}
	public class CustomSerializationService : SerializationService
	{
		public CustomSerializationService(IGraphInternal graph) : base(graph) { }

		public override XElement SerializeShapes(IEnumerable<IShape> shapes)
		{
			var filteredShapes = shapes.Where(x =>
					x is RadDiagramShape &&
					(x as RadDiagramShape).DataContext is Model &&
					((x as RadDiagramShape).DataContext as Model).IsStatic == false);

			return base.SerializeShapes(filteredShapes);
		}
	}
{{endregion}}

Next, we can go ahead and define a RadDiagram control in our View. We'll keep it simple - two buttons for save and Load and a Diagram with two shapes.

#### __[XAML] Example 2: Defining RadDiagram in XAML__
{{region xaml-raddiagrams-howto-exclude-shape-from-serialization-1}}
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
            <telerik:RadDiagram x:Name="diagram"   >
                <telerik:RadDiagram.ShapeTemplate>
                    <DataTemplate>
                        <TextBlock Text="{Binding Content}"/>
                    </DataTemplate>
                </telerik:RadDiagram.ShapeTemplate>
                <telerik:RadDiagram.ShapeStyle>
                    <Style TargetType="telerik:RadDiagramShape">
                        <Setter Property="Position" Value="{Binding Position, Mode=TwoWay}" />
                        <Setter Property="Content" Value="{Binding Content}"/>
                    </Style>
                </telerik:RadDiagram.ShapeStyle>
            </telerik:RadDiagram>
        </Grid>
    </Grid>
{{endregion}}

And finally, we need to set the RadDiagram GraphSource property, register the custom __SerializationService__ and subscribe to the __Execute__ methods of the Open/Save DiagramCommands. Then using the [DiagramExtension FileManager]({%slug raddiagram-extensions-filemanager%}) class you can export the diagram into file and load it again from it.

#### __[C#] Example 2: Register the custom SerializationService__
{{region cs-raddiagrams-howto-serialize-viewport-save-load-2}}
	public partial class MainWindow : Window
	{
		private FileManager fileManager;
		public MainWindow()
		{
			InitializeComponent();
			this.diagram.GraphSource = new MyGraphSource();
			this.fileManager = new FileManager(this.diagram);
			this.diagram.ServiceLocator.Register<ISerializationService>(new CustomSerializationService(this.diagram));
		}

		static MainWindow()
		{
			var saveBinding = new CommandBinding(DiagramCommands.Save, ExecuteSave);
			var openBinding = new CommandBinding(DiagramCommands.Open, ExecuteOpen);

			CommandManager.RegisterClassCommandBinding(typeof(MainWindow), saveBinding);
			CommandManager.RegisterClassCommandBinding(typeof(MainWindow), openBinding);
		}
		private static void ExecuteOpen(object sender, ExecutedRoutedEventArgs e)
		{
			var owner = sender as MainWindow;
			if (owner != null)
			{
				owner.diagram.Clear();
				owner.fileManager.LoadFromFile();               
			}
		}
			
		private static void ExecuteSave(object sender, ExecutedRoutedEventArgs e)
		{
			var owner = sender as MainWindow;
			if (owner != null)
			{
				owner.fileManager.SaveToFile();
			}				
		}
	}
{{endregion}}

## See Also
 * [Serialization]({%slug raddiagrams-features-serialization%})
 * [Commands]({%slug raddiagrams-features-commands%})