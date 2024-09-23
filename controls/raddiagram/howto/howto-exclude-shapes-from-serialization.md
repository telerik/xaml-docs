---
title: Exclude shape from serialization
page_title: Exclude shape from serialization
description: This article explains how you can exclude shapes from serialization.
slug: raddiagrams-howto-exclude-shape-from-serialization
tags: save,the,diagram,in,the,file,system, serialization,serialize,
published: True
position: 6
site_name: WPF
---

# How to Exclude Shapes from Serialization

The following article will demonstrate how to exclude shapes from serialization.

>With the __2024 Q3 SP1__ release, the RadDiagram control requires registering the custom types of shapes, connections, and connectors, in order to deserialize them successfully. Read more about this change [here]({%slug raddiagrams-features-serialization%}#allowing-tafe-types-and-assemblies).

For the purpose of this example, we will create the following view models.

* __Node__: A class deriving from the [NodeViewModelBase]({%slug raddiagram-data-nodeviewmodel%}) class that represents a node. The class will implement two additional properties: bool __IsStatic__ and Guid __ID__. The serialization of the shapes will depends on the first property. The __Guid__ property will be returned in the __GetNodeUniqueId()__ to cache the serialized shapes and connections.

* __Link__: A class deriving from the [LinkViewModelBase]({%slug raddiagram-data-linkviewmodel%}) that represent a connection.

* __MyGraphSource__: A class deriving from the [SerializableGraphSourceBase]({%slug raddiagram-data-serializablegraphsource%}) class that represent the RadDiagram GraphSource.

#### __[C#] Example 1: Creating view models__
{{region cs-raddiagrams-howto-exclude-shape-from-serialization-0}}
	public class Node : NodeViewModelBase
	{
		public bool IsStatic { get; set; }
		public Guid Id { get; set; }
	}
	public class Link : LinkViewModelBase<NodeViewModelBase>
    {
    }
	public class MyGraphSource : SerializableGraphSourceBase<Node, Link>
	{       
		public MyGraphSource()
		{
			Node saveShape = new Node() { Content = "Shape 1", Position = new System.Windows.Point(122, 122) };
			Node notSaveShape = new Node() { Content = "Shape 2", Position = new System.Windows.Point(500, 100), IsStatic = true };
			this.AddNode(saveShape);
			this.AddNode(notSaveShape);
		}

		public override string GetNodeUniqueId(Node node)
		{
			return node.Id.ToString();
		}

		public override void SerializeNode(Node node, Telerik.Windows.Diagrams.Core.SerializationInfo info)
		{
			base.SerializeNode(node, info);
			info["Content"] = node.Content;
			info["IsStatic"] = node.IsStatic;
		}

		public override Node DeserializeNode(Telerik.Windows.Diagrams.Core.IShape shape, Telerik.Windows.Diagrams.Core.SerializationInfo info)
		{
			base.DeserializeNode(shape, info);
			if (info["Content"] != null)
			{
				return new Node()
				{
					Content = info["Content"].ToString(),
					IsStatic = info["IsStatic"].ToString() == "true" ? true : false
				};
			}
			return null;
		}
	}
{{endregion}}

Next to exclude a shape from serialization, create a custom class which derives from __SerializationService__ and override the __SerializeShapes__ method. Inside the method you can create custom logic to filter which shapes to be serialize and pass it to the __base.SerializeShapes()__ method.

#### __[C#] Example 2: Creating custom SerializationService__
{{region cs-raddiagrams-howto-exclude-shape-from-serialization-1}}
	public class CustomSerializationService : SerializationService
	{
		public CustomSerializationService(IGraphInternal graph) : base(graph) { }

		public override XElement SerializeShapes(IEnumerable<IShape> shapes)
		{
			var filteredShapes = shapes.Where(x =>
					x is RadDiagramShape &&
					(x as RadDiagramShape).DataContext is Node &&
					((x as RadDiagramShape).DataContext as Node).IsStatic == false);

			return base.SerializeShapes(filteredShapes);
		}
	}
{{endregion}}

Next, define a RadDiagram control in the Xaml view. We'll keep it simple - two buttons for save and load and a diagram with two shapes.

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

Finally, set the RadDiagram __GraphSource__ property, register the custom __SerializationService__ class and override the __Open and Save commands__ from the DiagramCommands class. Then using the [DiagramExtension FileManager]({%slug raddiagram-extensions-filemanager%}) class you can export the diagram into a file and load it again from it.

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
