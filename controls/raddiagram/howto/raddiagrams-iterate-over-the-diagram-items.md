---
title: Iterate Over the Diagram Items
page_title: Iterate Over the Diagram Items
description: Check our &quot;Iterate Over the Diagram Items&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagrams-howto-iterate-over-the-diagram-items
tags: iterate,over,the,diagram,items
published: True
position: 7
---

# Iterate Over the Diagram Items

__RadDiagram__ provides 3 collections that store the DiagramItems - "__Items__", "__Shapes__" and "__Connections__"	  

## Diagram Items Collections

Below you can see a description of the 3 collections:

* __RadDiagram.Items__ - inherits from Telerik.Windows.Diagrams.Core.DiagramItemCollection. The DiagramItemCollection inherits from System.Collections.ObjectModel.ObservableCollection<object>. This mean that you are able to add everything in the Items collection. For example, if you add a Button in the Items, the ItemContainerGenerator of the RadDiagram will create a RadDiagramShape which wraps the Button and will add the generated shape in the Shapes collection.			

* __RadDiagram.Shapes__ - inherits from Telerik.Windows.Diagrams.Core.ShapeCollection. The ShapeCollection inherits from System.Collections.ObjectModel.ReadOnlyCollection <Telerik.Windows.Diagrams.Core.IShape>			

* __RadDiagram.Connections__ - inherits from Telerik.Windows.Diagrams.Core.ConnectionCollection. The ConnectionCollection inherits from System.Collections.ObjectModel.ReadOnlyCollection <Telerik.Windows.Diagrams.Core.IConnection>			

## Iterating Over Shapes or Connections

Here you can see a possible way to iterate the Shapes or Connection of the RadDiagram:

#### __C#__
```C#
	this.diagram.Shapes.ToList().ForEach(x =>
	{
	  //your custom logic goes here
	  (x as RadDiagramShape).Content = "Shape";
	});
```

#### __VB.NET__
```VB.NET
	Me.diagram.Shapes.ToList().ForEach(Function(x)
		'your custom logic goes here'
		TryCast(x, RadDiagramShape).Content = "Shape"
	End Function)
```

## Extension Methods

The __RadDiagram__ exposes two extension methods which you can use to iterate through the incoming and outgoing connections of a shape:		

* public static IEnumerable<IConnection> GetOutgoingConnectionsForShape(this IGraph graph, IShape shape)			  

* public static IEnumerable<IConnection> GetIncomingConnectionsForShape(this IGraph graph, IShape shape)</legacyBold>				

In order to take advatnage of these methods you need to add a using statement for the __Telerik.Windows.Diagrams.Core__ namespace in your code-behind file. Then you'll be able to access both methods through a __RadDiagram__ instance:		

#### __C#__
```C#
    using Telerik.Windows.Diagrams.Core;
    ...
    xDiagram.GetOutgoingConnectionsForShape(shape);
    xDiagram.GetIncomingConnectionsForShape(shape);
```

#### __VB.NET__	
```VB.NET
    Imports Telerik.Windows.Diagrams.Core
    ...
    xDiagram.GetOutgoingConnectionsForShape(shape)
    xDiagram.GetIncomingConnectionsForShape(shape)		  
```
	
## See Also
 * [Create Custom Shape]({%slug raddiagram-howto-create-custom-shape%})