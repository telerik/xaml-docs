---
title: Serialization
page_title: Serialization
description: This article describes the serialization mechanism of the RadDiagram framework.
slug: raddiagrams-features-serialization
tags: serialization
published: True
position: 7
---

# Serialization

`RadDiagram` allows you to serialize (save) your current diagram in an XML string and later deserialize it (load). You can achieve this with the `RadDiagram.Save()` and `RadDiagram.Load(string serializationString)` methods. You can also use the DiagramCommands `Save` and `Open`.			

>important With the `2024 Q3 SP1` release, the RadDiagram control requires registering the custom types of elements, in order to deserialize them successfully. Read more in the [Allowing Safe Types and Assemblies]({%slug raddiagrams-features-serialization%}#allowing-safe-types-and-assemblies) section of this article.

## Save And Load A RadDiagram

In the code below you can see how to save and load a RadDiagram using Commands. Please note that before saving the current diagramming structure, it is best to check whether there are any items to save:				

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the [Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind) article, you can find more information on how to set an application-wide theme.

__RadDiagram Xaml__
```XAML
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
```

__Save-Load logic__
```C#
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
```
```VB.NET
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
```

__RadDiagram Serialization__

![raddiagrams features serialization](images/raddiagrams_features_serialization.png)

>Please note that the Content of the Shapes and the Connections is serialized as String. This means that if you have control like ListBox or TreeView as a Content , it will be not serialized successfully.					

## Save/Load Diagram ViewPort

When zooming with a mouse or panning the RadDiagram, the ViewPort position will be changed. The viewPort is not saved/load during the serialization mechanism, thus you will have to manually restore it. The BringIntoView(position, zoom level) method can be used for this purpose. The following example demonstrates how you can preserve and restore the ViewPort position.

__Save-Load Diagram ViewPort__
```C#
	private double savedZoomFactor;
	Point savedDiagramPosition;
	private void CommandBinding_Executed_Save(object sender, ExecutedRoutedEventArgs e) 
	{ 
		savedZoomFactor = this.diagram.Zoom;
		savedDiagramPosition = this.diagram.Viewport.TopLeft;
		diagramXMLString =  this.diagram.Save(); 
	} 
	 
	private void CommandBinding_Executed_Open(object sender, ExecutedRoutedEventArgs e) 
	{ 
		if (diagramXMLString != null) 
		{ 
			this.diagram.Load(diagramXMLString);
			this.diagram.BringIntoView(savedDiagramPosition, savedZoomFactor);			
		} 
	}
```

## Extending RadDiagram Serialization

By default, not every property of the RadDiagramItem is serialized. Below is the list of the properties that are automatically serialized:		

>important These properties are serialized in scenarios where data bindings are __not__ involved. If you are using Binding in styles targeting any of the diagram items, you need to manually serialise and deserialize all the properties that are bound. This is demonstrated in the [Manual Serialization/Deserialization]({%slug raddiagrams-features-serialization%}#manual-serializationdeserialization) section of this article.

* `RadDiagram`
	* AllowCopy
	* AllowCut
	* AllowDelete
	* AllowPaste
	* Background
	* BackgroundGrid.CellSize
	* BackgroundGrid.LineStroke
	* BackgroundGrid.LineStrokeDashArray
	* BackgroundGrid.LineStrokeThickness
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

* `RadDiagramShape`
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
	* IsConnectorsManipulationEnabled
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

* `RadDiagramConnection`
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
	* IsConnectorsManipulationEnabled
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
	* UseFreeConnectors 

For every other property that you need to be part of the Serialization/Deserialization process, you have to use the `RadDiagram.ShapeDeserialized` and `RadDiagram.ShapeSerialized` or `RadDiagram.ConnectionDeserialized` and `RadDiagram.ConnectionSerialized` events. Below is shown how you can serialize the `Opacity` property of the shapes:			

## Manual Shape Serialization/Deserialization

>If you are using MVVM approach and need to serialize databound properties you can take a look at our [Serialize a Databound Diagram]({%slug raddiagrams-howto-serialize-databound-diagram%}) article.

__Handling the ShapeSerialized and ShapeDeserialized events__
```C#
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
```
```VB.NET  
	Private Sub diagram_ShapeDeserialized(ByVal sender As Object, ByVal e As ShapeSerializationRoutedEventArgs)
		 ' load the saved property'
		 TryCast(e.Shape, RadDiagramShape).Opacity = Convert.ToDouble(e.SerializationInfo("Opacity"), CultureInfo.InvariantCulture)
	End Sub

	Private Sub diagram_ShapeSerialized(ByVal sender As Object, ByVal e As ShapeSerializationRoutedEventArgs)
		 ' save custom or other property'
		 e.SerializationInfo("Opacity") = (TryCast(e.Shape, RadDiagramShape)).Opacity.ToInvariant()
	End Sub	
```

>Please note that the `Double.ToInvariant()` extension method is defined in the __Telerik.Windows.Diagrams.Core__ namespace and in order to use it in your application, you'll have to add a using statement: using Telerik.Windows.Diagrams.Core;

>tip If you decide to manually save one of the [properties](#extending-raddiagram-serialization) automatically saved by the diagram, make sure to give it a custom key (different from the default one used for saving). Also, implement both, the saving and loading logic in the ShapeSerialize and ShapeDeserialized event handlers. For example, if you want to manually save the FontWeight property of a RadDiagramShape, you can use a key different than "FontWeight" in the SerializationInfo (example: "MyFontWeight"). We recommend this as a precaution, because internally the diagram parses the value given in the SerializationInfo and if it doesn't match a specific format an exception will be thrown. 

## Serialize/Deserialize RadDiagram Properties

To include additional information in the generated XML when the RadDiagram control is being serialized, you can handle its `MetadataSerialized` event.

__Handling the MetadataSerialized event__
```C#
	private void OnMetadataSerialized(object sender, DiagramSerializationRoutedEventArgs e)
	{
	    RadDiagram diagram = (RadDiagram)sender; 
	    e.SerializationInfo["Opacity"] = diagram.Opacity.ToInvariant();
	}
```
```VB.NET
    Private Sub OnMetadataSerialized(ByVal sender As Object, ByVal e As DiagramSerializationRoutedEventArgs)
        Dim diagram As RadDiagram = CType(sender, RadDiagram)
        e.SerializationInfo("Opacity") = diagram.Opacity.ToInvariant()
    End Sub
```

To load the serialized property of the RadDiagram control, handle its `MetadataDeserialized` event. 

__Handling the MetadataDeserialized event__
```C#
	private void OnMetadataDeserialized(object sender, Telerik.Windows.Controls.Diagrams.DiagramSerializationRoutedEventArgs e)
    {
    	RadDiagram diagram = (RadDiagram)sender;
    	diagram.Opacity = Convert.ToDouble(e.SerializationInfo["Opacity"], CultureInfo.InvariantCulture);
    }
```
```VB.NET
    Private Sub OnMetadataDeserialized(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.Diagrams.DiagramSerializationRoutedEventArgs)
        Dim diagram As RadDiagram = CType(sender, RadDiagram)
        diagram.Opacity = Convert.ToDouble(e.SerializationInfo("Opacity"), CultureInfo.InvariantCulture)
    End Sub
```

## Preserve Bindings to the Automatically Serialized Properties of the RadDiagram's Items

If you have a binding between a RadDiagramItem property that is [automatically serialized](#extending-raddiagram-serialization) and a property from the item’s view model the binding won’t work after the deserialization. This is because the serialization/deserialization logic of the diagram sets those properties locally which has bigger priority than a binding. You can read more about the value setting precedence in the [Dependency Property Value Precedence](https://msdn.microsoft.com/en-us/library/vstudio/ms743230(v=vs.100).aspx) MSDN article.

In order to preserve the binding you can remove the value of the property from the serialization info and use another key to serialize/deserialize it.

For example, if you have a binding to the Position property you can use the following approach for saving the binding:

* Override the `SerializeNode()` method of the diagram’s `GraphSource` and set the value of the bound property to __null__ in the `SerializationInfo`. Then add the value with a new key in the serialization info. 
	__SerializeNode override__
	```C#
		public override void SerializeNode(NodeViewModelBase node, SerializationInfo info)
		{
			   var position = info["Position"];
			   info["Position"] = null;
			   info["MyPosition"] = position;
			   base.SerializeNode(node, info);
		}	
	```
```VB.NET
		public Overrides Sub SerializeNode(node As NodeViewModelBase, info As SerializationInfo)
			Dim position = info("Position")
			info("Position") = Nothing
			info("MyPosition") = position
			MyBase.SerializeNode(node, info)
		End Sub
	```
	
* Override the `DeserializeNode()` method of the diagram’s `GraphSource` and get the value of the bound property. Then assign it to the property of the view model.
	__DeserializeNode override__
	```C#
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
	```
```VB.NET
		Public Overrides Function DeserializeNode(shape As IShape, info As Telerik.Windows.Diagrams.Core.SerializationInfo) As NodeViewModelBase
			Dim node = MyBase.DeserializeNode(shape, info)
			If info("MyPosition") IsNot Nothing Then
				Dim position = Utils.ToPoint(info("MyPosition").ToString())
				node.Position = position.Value
			End If
			Return node
		End Function
	```
		
> The code snippets above demonstrate how to preserve the bindings in an __MVVM__ scenario with a custom GraphSource. If you have statically declared shapes you can use the `ShapeSerialized` and `ShapeDeserialized` events of the diagram.

>important If you are using the [RadDiagramToolbox]({%slug raddiagram-extensions-toolbox%}) in order to drag and drop shapes and you have bindings declared in a style, make sure that the style is added in the Application's Resources as in the above example. 

__Style containing Position binding in Application's Resources__
```XAML
	<Application.Resources>
        <Style TargetType="telerik:RadDiagramShape">
            <Setter Property="Position" Value="{Binding Position, Mode=TwoWay}" />
        </Style>
    </Application.Resources>
```

## Preserve Bindings of the Automatically Serialized Properties of the RadDiagram's Metadata

To preserve the bindings of the automatically serialized properties of RadDiagram's metadata, you can derive from it and override the `Deserialize` method. Through the __info__ parameter, you can retrieve the property that is used in a data-binding scenario and set its value to __null__. This will avoid the local setting of a value for it in the base implementation of the `Deserialize` method.

__Extending the RadDiagram control and overriding the Deserialize method__
```C#
    public class CustomDiagram : RadDiagram
    {
        public override void Deserialize(SerializationInfo info)
        {
            info[SerializationConstants.BackgroundGridLineStroke] = null;

            base.Deserialize(info);
        }
    }
```
```VB.NET
    Public Class CustomDiagram
        Inherits RadDiagram

        Public Overrides Sub Deserialize(ByVal info As SerializationInfo)
            info(SerializationConstants.BackgroundGridLineStroke) = Nothing
            MyBase.Deserialize(info)
        End Sub
    End Class
```

## Allowing Safe Types and Assemblies

The RadDiagram control requires registering the types of any custom shapes, connections, and connectors. This is required, so that the serialized string is deserialized successfully. To do so, the `DiagramConstants` class exposes the `AllowedSerializationTypes` collection that will allow you to add the `Type` of the custom elements. 

>important If a deserialization operation is undergoing and the custom types are not registered, an error will be displayed in the __Output__ window of Visual Studio. Furthermore, these custom elements will not be deserialized in the RadDiagram control. The displayed error will be as follows: __"The your-custom-shape/connection/connector type is not safe for deserialization. It must be registered in DiagramConstants.AllowedSerializationTypes or its defining assembly must be registered in DiagramConstants.SafeSerializationAssemblies."__

The default registered types are the following ones:

* `RadDiagramShape`
* `RadDiagramContainerShape`
* `RadDiagramTextShape`
* `RadDiagramConnection`
* `RadDiagramConnector`

The following example shows how to register your custom element's Type:

__Registering the Type of а custom RadDiagramShape__
```C#
	DiagramConstants.AllowedSerializationTypes.Add(typeof(MyCustomShape));
```
```VB.NET
	DiagramConstants.AllowedSerializationTypes.Add(GetType(MyCustomShape))
```

If the custom elements are defined in a separate assembly, the RadDiagram control provides the option to register it. This is done via the `SafeSerializationAssemblies` collection of the `DiagramContants` class. This collection is of the type of Dictionary&lt;string, string&gt; where the key is the name of the registered assembly and value is the `PublicKeyToken`. Setting a public key token is optional.

__Registring an assembly that contains the custom elements types without public key token__
```C#
	DiagramConstants.SafeSerializationAssemblies.Add("CustomDiagramElements", string.Empty);
```
```VB.NET
	DiagramConstants.SafeSerializationAssemblies.Add("CustomDiagramElements", String.Empty)
```

If your assembly has a set public key token, you can add as a parameter to the `Add` method as shown in the below example:

__Registring an assembly that contains the custom elements types with public key token__
```C#
	DiagramConstants.SafeSerializationAssemblies.Add("CustomDiagramElements", "customdiagramelements-public-key-token-here");
```
```VB.NET
	DiagramConstants.SafeSerializationAssemblies.Add("CustomDiagramElements", "customdiagramelements-public-key-token-here")
```

## See Also
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Virtualization]({%slug raddiagrams-features-virtualization%})
 * [Commands]({%slug raddiagrams-features-commands%})
 * [Diagram Events]({%slug raddiagrams-events-diagram%})
 * [Items Events]({%slug raddiagrams-events-item%})
