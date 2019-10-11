---
title: Styling Shapes When Using GraphSource 
page_title: Styling Shapes When Using GraphSource
description: Styling Shapes When Using GraphSource
slug: raddiagram-styling-shapes-with-graphsource
tags: customize,appearance,graphsource,mvvm,activetool,textshape,
published: True
position: 1
---

# Styling Shapes When Using GraphSource
 
This article describes which styles need to be applied when using different ActiveTool of the RadDiagram when the GraphSource property is set.

For the purpose of this example, we will create the following ViewModels:

__ContainerModel:__ A class deriving from the ContainerNodeViewModelBase ViewModel that represents a container node.

__Model:__ A class deriving from the NodeViewModelBase ViewModel that represents a node.__

__Link:__ A class deriving from the LinkViewModelBase ViewModel that represents a link.

__MyGraphSource:__ A class deriving from the ObservableGraphSourceBase ViewModel that represents the RadDiagram GraphSource.

#### __[C#] Example 1:  Creating ViewModels__
	{{region raddiagram-styling-shapes-with-graphsource_0}}
		public class ContainerModel : ContainerNodeViewModelBase<object> 
		{ 
		} 
		public class Model : NodeViewModelBase 
		{ 		 
		} 
		public class Link : LinkViewModelBase<NodeViewModelBase> 
		{ 		 
		} 
		public class MyGraphSource : ObservableGraphSourceBase<NodeViewModelBase, Link>
		{
			public MyGraphSource()
			{		
				ContainerModel containerModel = new ContainerModel() { Content = "Container Model", Position = new Point(250, 100) };
				Model model = new Model()
				{
					Content = "Custom Model",
					Position = new Point(250, 100),
				};
				containerModel.AddItem(model);
				this.AddNode(containerModel);			
			}   
		}		
	{{endregion}}
	
Next, we can go ahead and define a RadDiagram control in our View. We can add three buttons to change the ActiveTool property of the RadDiagram runtime.	

#### __[XAML] Example 2: Defining RadDiagram in XAML__
	{{region raddiagram-styling-shapes-with-graphsource_1}}
		<Grid>
			<Grid.RowDefinitions>
				<RowDefinition Height="auto"/>
				<RowDefinition Height="*"/>
			</Grid.RowDefinitions>
			<StackPanel Orientation="Horizontal" HorizontalAlignment="Center" Margin="10">
				<telerik:RadButton Content="Pointer Tool" Click="RadButton_Click" VerticalAlignment="Center" HorizontalAlignment="Center"/>
				<telerik:RadButton Content="Text Tool" Click="RadButton_Click" VerticalAlignment="Center" HorizontalAlignment="Center"/>
				<telerik:RadButton Content="Path Tool" Click="RadButton_Click" VerticalAlignment="Center" HorizontalAlignment="Center"/>
				<telerik:RadButton Content="Pencil Tool" Click="RadButton_Click" VerticalAlignment="Center" HorizontalAlignment="Center"/>
				<telerik:RadButton Content="Connector Tool" Click="RadButton_Click" VerticalAlignment="Center" HorizontalAlignment="Center"/>
			</StackPanel>
			<telerik:RadDiagram x:Name="diagram" Grid.Row="1"/> 
		</Grid>
	{{endregion}}

And finally, we need to set the RadDiagram GraphSource property and subscribe to the Click event of the RadButtons. In the event handler, we are changing the ActiveTool property depending on the button content:

#### __[C#] Example 3: Setting GraphSource property__
	{{region raddiagram-styling-shapes-with-graphsource_2}}
		public MainWindow() 
		{ 
			InitializeComponent();   
			this.diagram.GraphSource = new CarsGraphSource(); 
		} 
		private void RadButton_Click(object sender, RoutedEventArgs e)
		{
			var button = sender as RadButton;
			switch (button.Content)
			{
				case "Pointer Tool":
					this.diagram.ActiveTool = Telerik.Windows.Diagrams.Core.MouseTool.PointerTool;
					break;
				case "Path Tool":
					this.diagram.ActiveTool = Telerik.Windows.Diagrams.Core.MouseTool.PathTool;
					break;
				case "Pencil Tool":
					this.diagram.ActiveTool = Telerik.Windows.Diagrams.Core.MouseTool.PencilTool;
					break;
				case "Text Tool":
					this.diagram.ActiveTool = Telerik.Windows.Diagrams.Core.MouseTool.TextTool;
					break;
				case "Connector Tool":
                    diagram.ActiveTool = Telerik.Windows.Diagrams.Core.MouseTool.ConnectorTool;
                    break;
				default:
					break;
			}
		}
	{{endregion}}

If you run the application now, the RadDiagram should display the following structure:

![](images/raddiagram-styling-shapes-with-graphsource-nostyles.png)

You can observe that the container and the shape inside does not show our custom text. Clicking any of the buttons (without PointerTool) at the top you can see that every created shape afterward displays the NodeViewModelBase class string. Different active tool corresponded to different shape style. For example the tools which creates shapes are:

* __TextTool__: Creates RadDiagramTextShape 
* __PathTool__: Creates RadDiagramShape
* __PencilTool__: Creates RadDiagramShape
* __ConnectorTool:__ Creates RadDiagramConnection
	
To overcome this you can create a StyleSelector and applied it to the ShapeStyleSelector of the RadDiagram. __Example 4__ demonstrate the custom __StyleSelector__.

#### __[C#] Example 4: Creating custom StyleSelector__
	{{region raddiagram-styling-shapes-with-graphsource_3}}
		public  class ShapeStyleSelector : StyleSelector
		{
			public Style ContainerStyle { get; set; }
			public Style ShapeStyle { get; set; }
			public Style TextToolShape { get; set; }
			public override Style SelectStyle(object item, DependencyObject container)
			{
				if (container is RadDiagramContainerShape)
				{
					return ContainerStyle;
				}

				if (container is RadDiagramShape)
				{
					return ShapeStyle;
				}
				
				if(container is RadDiagramTextShape)
				{
					return TextToolShape;
				}
				return base.SelectStyle(item, container);
			}
		}
	{{endregion}}

Now you need to specify different styles for the different types of shapes. For example, creating a shape with the TextTool, the TargetType property of the custom style needs to be set to __RadDiagramTextShape__. __Example 4__ shows the final XAML code.  

#### __[XAML] Example 5: Creating custom styles for every shape__
	{{region raddiagram-styling-shapes-with-graphsource_4}}
		<Window.Resources>
			<DataTemplate x:Key="contentTemplate">
				<TextBlock Text="{Binding Content}" />
			</DataTemplate>
			<DataTemplate x:Key="editTemplate">
				<TextBox Text="{Binding Content, Mode=TwoWay}" />
			</DataTemplate>
			<local:ShapeStyleSelector x:Key="shapeStyleSelector" >
				<local:ShapeStyleSelector.ContainerStyle>
					<Style TargetType="telerik:RadDiagramContainerShape">
						<Setter Property="Position" Value="{Binding Position, Mode=TwoWay}" />
						<Setter Property="ContentTemplate" Value="{StaticResource contentTemplate}" />
						<Setter Property="EditTemplate" Value="{StaticResource editTemplate}" />
					</Style>
				</local:ShapeStyleSelector.ContainerStyle>
				<local:ShapeStyleSelector.ShapeStyle>
					<Style TargetType="telerik:RadDiagramShape">
						<Setter Property="Position" Value="{Binding Position, Mode=TwoWay}" />
						<Setter Property="ContentTemplate" Value="{StaticResource contentTemplate}" />
						<Setter Property="EditTemplate" Value="{StaticResource editTemplate}" />
					</Style>
				</local:ShapeStyleSelector.ShapeStyle>
				<local:ShapeStyleSelector.TextToolShape>
					<Style TargetType="telerik:RadDiagramTextShape">
						<Setter Property="Position" Value="{Binding Position, Mode=TwoWay}" />
						<Setter Property="ContentTemplate" Value="{StaticResource contentTemplate}"/>
						<Setter Property="EditTemplate" Value="{StaticResource editTemplate}"/>
					</Style>
				</local:ShapeStyleSelector.TextToolShape>
			</local:ShapeStyleSelector>
		</Window.Resources>
		<Grid>
			<Grid.RowDefinitions>
				<RowDefinition Height="auto"/>
				<RowDefinition Height="*"/>
			</Grid.RowDefinitions>
			<StackPanel Orientation="Horizontal" HorizontalAlignment="Center" Margin="10">
				<telerik:RadButton Content="Pointer Tool" Click="RadButton_Click" VerticalAlignment="Center" HorizontalAlignment="Center"/>
				<telerik:RadButton Content="Text Tool" Click="RadButton_Click" VerticalAlignment="Center" HorizontalAlignment="Center"/>
				<telerik:RadButton Content="Path Tool" Click="RadButton_Click" VerticalAlignment="Center" HorizontalAlignment="Center"/>
				<telerik:RadButton Content="Pencil Tool" Click="RadButton_Click" VerticalAlignment="Center" HorizontalAlignment="Center"/>
				<telerik:RadButton Content="Connector Tool" Click="RadButton_Click" VerticalAlignment="Center" HorizontalAlignment="Center"/>
			</StackPanel>
			<telerik:RadDiagram x:Name="diagram" Grid.Row="1"
				ConnectionEditTemplate="{StaticResource editTemplate}"
				ConnectionTemplate="{StaticResource contentTemplate}"                   
				ShapeStyleSelector="{StaticResource shapeStyleSelector}">
			</telerik:RadDiagram>
		</Grid>
	{{endregion}}
	
## See Also
 * [Customize Appearance]({%slug raddiagram-styling-appearance%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Custom Connectors]({%slug raddiagram-features-custom-connectors%})
 * [Selection]({%slug raddiagrams-features-selection%})
 * [Grouping]({%slug raddiagram-features-grouping%})

	