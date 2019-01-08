---
title: Serialization
page_title: Serialization
description: Serialization
slug: raddiagrams-features-serialization
tags: serialization
published: True
position: 7
---

# Serialization

__RadDiagram Framework__ allows you to serialize (save) your current diagram in an XML string and later deserialize it (load). You can achieve this with the __RadDiagram.Save()__ and __RadDiagram.Load(string serializationString)__ methods. You may also use the DiagramCommands __Save__ and __Open__.			

## Save And Load A RadDiagram

In the code below you can see how to save and load a __RadDiagram__ using Commands. Please note that before saving the current diagramming structure, it is best to check whether there are any items to save:				

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.

{% if site.site_name == 'Silverlight' %}

#### __XAML__
{{region raddiagrams_features_serialization_1}}
	<Grid>
		<Grid.RowDefinitions>
			<RowDefinition Height="Auto" />
			<RowDefinition Height="*" />
		</Grid.RowDefinitions>
	  
		<telerik:RadDiagram x:Name="diagram" Grid.Row="1">
			<telerik:RadDiagramShape />
			<telerik:CommandManager.CommandBindings>
				<telerik:CommandBindingCollection>
					<telerik:CommandBinding Command="telerik:DiagramCommands.Save"
							Executed="CommandBinding_Executed_Save"
							CanExecute="CommandBinding_CanExecute" />
					<telerik:CommandBinding Command="telerik:DiagramCommands.Open"
							Executed="CommandBinding_Executed_Open" />
				</telerik:CommandBindingCollection>
			</telerik:CommandManager.CommandBindings>
		</telerik:RadDiagram>
		<StackPanel Orientation="Horizontal">
			<telerik:RadButton Width="125" Command="telerik:DiagramCommands.Save"
					CommandTarget="{Binding ElementName=diagram}" Content="Save" />
			<telerik:RadButton Width="125" Command="telerik:DiagramCommands.Copy"
					CommandTarget="{Binding ElementName=diagram}" Content="Copy" />
			<telerik:RadButton Width="125" Command="telerik:DiagramCommands.Paste"
					CommandTarget="{Binding ElementName=diagram}" Content="Paste" />
			<telerik:RadButton Width="125" Command="telerik:DiagramCommands.Open"
					CommandTarget="{Binding ElementName=diagram}" Content="Load" />
		</StackPanel>
	</Grid>
{{endregion}}

{% endif %}
{% if site.site_name == 'WPF' %}

#### __XAML__
{{region raddiagrams_features_serialization_0}}
	<Grid>
		<Grid.RowDefinitions>
			<RowDefinition Height="Auto" />
			<RowDefinition Height="*" />
		</Grid.RowDefinitions>
		<StackPanel Orientation="Horizontal">
			<telerik:RadButton Width="125" 
							   Command="telerik:DiagramCommands.Save"
							   CommandTarget="{Binding ElementName=diagram}"
							   Content="Save" />
			<telerik:RadButton Width="125" 
							   Command="telerik:DiagramCommands.Clear"
							   CommandTarget="{Binding ElementName=diagram}"
							   Content="Clear" />
			<telerik:RadButton Width="125" 
							   Command="telerik:DiagramCommands.Open"
							   CommandTarget="{Binding ElementName=diagram}"
							   Content="Load" />
		</StackPanel>
		<telerik:RadDiagram x:Name="diagram" Grid.Row="1">
			<telerik:RadDiagramShape  />
			<telerik:RadDiagram.CommandBindings>
				<CommandBinding Command="telerik:DiagramCommands.Save" Executed="CommandBinding_Executed_Save" CanExecute="CommandBinding_CanExecute"/>
				<CommandBinding Command="telerik:DiagramCommands.Open" Executed="CommandBinding_Executed_Open" />
			</telerik:RadDiagram.CommandBindings>
		</telerik:RadDiagram>
	</StackPanel>
{{endregion}}

{% endif %}

#### __C#__
{{region raddiagrams_features_serialization_0}}
	private string diagramXMLString;       
	
	public MainWindow()
	{
		StyleManager.ApplicationTheme = new Windows8Theme();
		InitializeComponent();          
	}
	
	private void CommandBinding_Executed_Save(object sender, ExecutedRoutedEventArgs e)
	{
	   diagramXMLString =  this.diagram.Save();
	}
	
	private void CommandBinding_Executed_Open(object sender, ExecutedRoutedEventArgs e)
	{
		if (diagramXMLString != null)
		{
			this.diagram.Load(diagramXMLString);
		}
	}
	
	private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
	{
		e.CanExecute = this.diagram.Items.Count > 0;
	}
{{endregion}}

#### __VB.NET__
{{region raddiagrams_features_serialization_0}}
	Private diagramXMLString As String
	
	Public MainWindow()
		StyleManager.ApplicationTheme = New Windows8Theme()
		InitializeComponent()
	End Sub
	
	Private Sub CommandBinding_Executed_Save(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs)
		diagramXMLString = Me.diagram.Save()
	End Sub
	
	Private Sub CommandBinding_Executed_Open(ByVal sender As Object, ByVal e As ExecutedRoutedEventArgs)
		If diagramXMLString IsNot Nothing Then
			Me.diagram.Load(diagramXMLString)
		End If
	End Sub
	
	Private Sub CommandBinding_CanExecute(ByVal sender As Object, ByVal e As CanExecuteRoutedEventArgs)
		e.CanExecute = Me.diagram.Items.Count > 0
	End Sub
{{endregion}}

![raddiagrams features serialization](images/raddiagrams_features_serialization.png)

>Please note that the Content of the Shapes and the Connections is serialized as String. This means that if you have control like ListBox or TreeView as a Content , it will be not serialized successfully.					

## Extending RadDiagram Serialization

By default, not every property of the RadDiagramItem is serialized. Below is the list of the properties that are automatically serialized:				

>important These properties are serialized in scenarios where data bindings are __not__ involved. If you are using Binding in styles targeting any of the diagram items, you need to manually serialise and deserialize all the properties that are bound. This is demonstrated in the [Manual Serialization/Deserialization]({%slug raddiagrams-features-serialization%}#manual-serializationdeserialization) section of this article.

* __RadDiagram__
	* AllowCopy
	* AllowCut
	* AllowDelete
	* AllowPaste
	* ConnectionBridges
	* ConnectionRoundedCorners
	* IsBackgroundSurfaceVisible
	* IsConnectorsManipulationEnabled
	* IsDraggingEnabled
	* IsEditable
	* IsManipulationAdornerVisible
	* IsPanEnabled
	* IsResizingEnabled
	* IsRotationEnabled
	* IsSnapEnabled
	* IsZoomEnabled
	* Metadata
	* Position
	* RouteConnections
	* SelectionMode
	* SnapX
	* SnapY
	* Zoom

* __RadDiagramShape__
	* AllowCopy
	* AllowDelete
	* AllowPaste
	* Background
	* BorderBrush
	* BorderThickness
	* Content
	* FontFamily
	* FontSize
	* FontWeight
	* Foreground
	* Geometry
	* GlidingStyle
	* Id
	* IsConnectionManipulationEnabled
	* IsDraggingEnabled
	* IsEditable
	* IsResizingEnabled
	* IsRotationEnabled
	* MaxHeight
	* MaxWidth
	* MinHeight
	* MinWidth
	* ParentGroup
	* Position
	* RotationAngle
	* Size
	* Stroke
	* StrokeDashArray
	* StrokeThickness
	* UseDefaultConnectors
	* ZIndex

* __RadDiagramConnection__
	* AllowCopy
	* AllowDelete
	* AllowPaste
	* Background
	* BezierEndPoint    
	* BezierStartPoint    
	* BezierTention    
	* BorderBrush    
	* BorderThickness
	* ConnectionPoints    
	* ConnectionType    
	* Content    
	* EndPoint
	* FontFamily    
	* FontSize
	* FontWeight    
	* Foreground    
	* Id
	* IsConnectionManipulationEnabled
	* IsDraggingEnabled
	* IsEditable    
	* IsModified    
	* IsResizingEnabled
	* IsRotationEnabled
	* ParentGroup
	* Position
	* Source
	* SourceCapSize
	* SourceCapType
	* SourceConnectorPosition
	* StartPoint
	* Stroke
	* StrokeDashArray
	* StrokeThickness
	* Target    
	* TargetCapSize
	* TargetCapType
	* TargetConnectorPosition
	* ZIndex

For every other property that you need to be part of the Serialization/Deserialization process, you have to use the __RadDiagram.ShapeDeserialized__ and __RadDiagram.ShapeSerialized__ or __RadDiagram.ConnectionDeserialized__ and __RadDiagram.ConnectionSerialized__ events. Below is shown how you can serialized the Opacity of the Shapes:			

## Manual Serialization/Deserialization

>If you are using MVVM approach and need to serialize databound properties you can take a look at our [Serialize a Databound Diagram]({%slug raddiagrams-howto-serialize-databound-diagram%}) article.

#### __C#__
{{region raddiagrams-features-serialization-2}}
	void diagram_ShapeDeserialized(object sender, ShapeSerializationRoutedEventArgs e)
	{
		 // load the saved property
		 (e.Shape as RadDiagramShape).Opacity = Convert.ToDouble(e.SerializationInfo["Opacity"], CultureInfo.InvariantCulture);
	}

	void diagram_ShapeSerialized(object sender, ShapeSerializationRoutedEventArgs e)
	{
		 // save custom or other property
		 e.SerializationInfo["Opacity"] = (e.Shape as RadDiagramShape).Opacity.ToInvariant();
	}		  
{{endregion}}

#### __VB.NET__		
{{region raddiagrams-features-serialization-3}}  
	Private Sub diagram_ShapeDeserialized(ByVal sender As Object, ByVal e As ShapeSerializationRoutedEventArgs)
		 ' load the saved property'
		 TryCast(e.Shape, RadDiagramShape).Opacity = Convert.ToDouble(e.SerializationInfo("Opacity"), CultureInfo.InvariantCulture)
	End Sub

	Private Sub diagram_ShapeSerialized(ByVal sender As Object, ByVal e As ShapeSerializationRoutedEventArgs)
		 ' save custom or other property'
		 e.SerializationInfo("Opacity") = (TryCast(e.Shape, RadDiagramShape)).Opacity.ToInvariant()
	End Sub	
{{endregion}}

>Please note that the __Double.ToInvariant()__ extension method is defined in the __Telerik.Windows.Diagrams.Core__ namespace and in order to use it in your application, you'll have to add a using statement: using Telerik.Windows.Diagrams.Core;

## Preserve bindings to the automatically serialized properties

If you have a binding between a RadDiagramItem property that is [automatically serialized](#extending-raddiagram-serialization) and a property from the item’s view model the binding won’t work after the deserialization. This is because the serialization/deserialization logic of the diagram sets those properties locally which has bigger priority than a binding. You can read more about the value setting precedence in the [Dependency Property Value Precedence](https://msdn.microsoft.com/en-us/library/vstudio/ms743230(v=vs.100).aspx) MSDN article.

In order to preserve the binding you can remove the value of the property from the serialization info and use another key to serialize/deserialize it.

For example, if you have a binding to the Position property you can use the following approach for saving the binding:
* Override the __SerializeNode()__ method of the diagram’s __GraphSource__ and set the value of the bound property to *null* in the __SerializationInfo__. Then add the value with a new key in the serialization info. 
	#### __C#__
	{{region raddiagrams-features-serialization-4}}
		public override void SerializeNode(NodeViewModelBase node, SerializationInfo info)
		{
			   var position = info["Position"];
			   info["Position"] = null;
			   info["MyPosition"] = position;
			   base.SerializeNode(node, info);
		}	
	{{endregion}}
	
	#### __VB.NET__
	{{region raddiagrams-features-serialization-5}}
		public Overrides Sub SerializeNode(node As NodeViewModelBase, info As SerializationInfo)
			Dim position = info("Position")
			info("Position") = Nothing
			info("MyPosition") = position
			MyBase.SerializeNode(node, info)
		End Sub
	{{endregion}}
	
* Override the __DeserializeNode()__ method of the diagram’s __GraphSource__ and get the value of the bound property. Then assign it to the property of the view model.
	#### __C#__
	{{region raddiagrams-features-serialization-6}}
		public override NodeViewModelBase DeserializeNode(IShape shape, Telerik.Windows.Diagrams.Core.SerializationInfo info)
		{
			var node = base.DeserializeNode(shape, info);
			if (info["MyPosition"] != null)
			{
				 var position = Utils.ToPoint(info["MyPosition"].ToString());
			 node.Position = position.Value;
			}
			return node;
		}
	{{endregion}}
	
	#### __VB.NET__
	{{region raddiagrams-features-serialization-7}}
		Public Overrides Function DeserializeNode(shape As IShape, info As Telerik.Windows.Diagrams.Core.SerializationInfo) As NodeViewModelBase
			Dim node = MyBase.DeserializeNode(shape, info)
			If info("MyPosition") IsNot Nothing Then
				Dim position = Utils.ToPoint(info("MyPosition").ToString())
				node.Position = position.Value
			End If
			Return node
		End Function
	{{endregion}}
		
> The code snippets above demonstrate how to preserve the bindings in an __MVVM__ scenario with a custom __GraphSource__. If you have statically declared shapes you can use the __ShapeSerialized__ and __ShapeDeserialized__ events of the diagram.

## See Also
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Virtualization]({%slug raddiagrams-features-virtualization%})
 * [Commands]({%slug raddiagrams-features-commands%})
 * [Diagram Events]({%slug raddiagrams-events-diagram%})
 * [Items Events]({%slug raddiagrams-events-item%})