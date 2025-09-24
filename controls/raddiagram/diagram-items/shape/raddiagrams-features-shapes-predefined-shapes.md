---
title: Predefined Shape Geometries
page_title: Predefined Shape Geometries
description: Telerik RadDiagram for {{ site.framework_name }} Predefined Shape Geometries.
slug: raddiagrams-features-shapes-predefined-shapes
tags: shapes,predefined,geometry,shapefactory
published: True
position: 2
---

# Predefined Shape Geometries

The __Telerik Diagramming Framework__ provides three types of predefined shape geometries - __ArrowShapes__, __CommonShapes__ and __FlowChartShapes__. For each of these types the framework exposes xaml markup extensions that can be applied at the __RadDiagramShape.Geometry__ property as a shortcut way of creating a shape.

This article contains a list with the available geometries and shows how to set a geometry.

__Create a geometry in code behind__ 
```C#
	Geometry arrowGeometry = ShapeFactory.GetShapeGeometry(ArrowShapeType.Arrow1);
	diagramShape.Geometry = arrowGeometry;
```

## ArrowShapes

__Arrow1__ 
![Rad Diagram Features Shapes Arrow 1](../images/RadDiagram_Features_Shapes_Arrow1.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow1}" />
```

__Arrow2__ 
![Rad Diagram Features Shapes Arrow 2](../images/RadDiagram_Features_Shapes_Arrow2.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow2}" />
```

__Arrow3__
![Rad Diagram Features Shapes Arrow 3](../images/RadDiagram_Features_Shapes_Arrow3.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow3}" />
```

__Arrow4__ 
![Rad Diagram Features Shapes Arrow 4](../images/RadDiagram_Features_Shapes_Arrow4.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow4}" />  
```

__Arrow5__ 
![Rad Diagram Features Shapes Arrow 5](../images/RadDiagram_Features_Shapes_Arrow5.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow5}"/>
```

__Arrow6__ 
![Rad Diagram Features Shapes Arrow 6](../images/RadDiagram_Features_Shapes_Arrow6.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow6}" />
```

__Arrow7__ 
![Rad Diagram Features Shapes Arrow 7](../images/RadDiagram_Features_Shapes_Arrow7.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow7}"/>
```

__Arrow8__ 
![Rad Diagram Features Shapes Arrow 8](../images/RadDiagram_Features_Shapes_Arrow8.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow8}"/>				  						  
```

__DoubleArrow1__ 	
![Rad Diagram Features Shapes Double Arrow 1](../images/RadDiagram_Features_Shapes_DoubleArrow1.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow1}" />				  						  
```

__DoubleArrow2__ 
![Rad Diagram Features Shapes Double Arrow 2](../images/RadDiagram_Features_Shapes_DoubleArrow2.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow2}" />				  						  
```

__DoubleArrow3__ 
![Rad Diagram Features Shapes Double Arrow 3](../images/RadDiagram_Features_Shapes_DoubleArrow3.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow3}" />
```

__DoubleArrow4__ 
![Rad Diagram Features Shapes Double Arrow 4](../images/RadDiagram_Features_Shapes_DoubleArrow4.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow4}" />
```

__DoubleArrow5__ 
![Rad Diagram Features Shapes Double Arrow 5](../images/RadDiagram_Features_Shapes_DoubleArrow5.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow5}" />
```
	
### CommonShapes
					
__CloudShape__ 
![Rad Diagram Features Shapes Cloud Shape](../images/RadDiagram_Features_Shapes_CloudShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=CloudShape}" />				  
```

__Cross2Shape__ 
![Rad Diagram Features Shapes Cross 2 Shape](../images/RadDiagram_Features_Shapes_Cross2Shape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=Cross2Shape}"/>
```

__CrossShape__ 
![Rad Diagram Features Shapes Cross Shape](../images/RadDiagram_Features_Shapes_CrossShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=CrossShape}" />				  
```

__EllipseShape__ 
![Rad Diagram Features Shapes Ellipse Shape](../images/RadDiagram_Features_Shapes_EllipseShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=EllipseShape}" />				  
```

__HexagonShape__ 
![Rad Diagram Features Shapes Hexagon Shape](../images/RadDiagram_Features_Shapes_HexagonShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=HexagonShape}"/>				  						  
```

__OctagonShape__ 
![Rad Diagram Features Shapes Octagon Shape](../images/RadDiagram_Features_Shapes_OctagonShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=OctagonShape}" />
```

__PentagonShape__ 
![Rad Diagram Features Shapes Pentagon Shape](../images/RadDiagram_Features_Shapes_PentagonShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=PentagonShape}" />
```

__RectangleShape__ 
![Rad Diagram Features Shapes Rectangle Shape](../images/RadDiagram_Features_Shapes_RectangleShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=RectangleShape}"/>				  						  
```

__RightTriangleShape__ 
![Rad Diagram Features Shapes Right Triangle Shape](../images/RadDiagram_Features_Shapes_RightTriangleShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=RightTriangleShape}" />				  						  
```

__RoundedRectangleShape__ 
![Rad Diagram Features Shapes Rounded Rectangle Shape](../images/RadDiagram_Features_Shapes_RoundedRectangleShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=RoundedRectangleShape}" />				  						  
```

__Star5Shape__ 
![Rad Diagram Features Shapes Star 5 Shape](../images/RadDiagram_Features_Shapes_Star5Shape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=Star5Shape}"/>				  
```

__Star6Shape__ 
![Rad Diagram Features Shapes Star 6 Shape](../images/RadDiagram_Features_Shapes_Star6Shape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=Star6Shape}" />
```

__Star7Shape__ 
![Rad Diagram Features Shapes Star 7 Shape](../images/RadDiagram_Features_Shapes_Star7Shape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=Star7Shape}" />
```

__TriangleShape__ 
![Rad Diagram Features Shapes Triangle Shape](../images/RadDiagram_Features_Shapes_TriangleShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=TriangleShape}"/>	
```
	
### FlowChartShapes

__BeginLoopShape__ 
![Rad Diagram Features Shapes Begin Loop Shape](../images/RadDiagram_Features_Shapes_BeginLoopShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=BeginLoopShape}" />
```

__CardShape__ 
![Rad Diagram Features Shapes Card Shape](../images/RadDiagram_Features_Shapes_CardShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=CardShape}"/>
```

__CollateShape__ 
![Rad Diagram Features Shapes Collate Shape](../images/RadDiagram_Features_Shapes_CollateShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=CollateShape}" />				  					  
```

__CreateRequestShape__ 
![Rad Diagram Features Shapes Create Request Shape](../images/RadDiagram_Features_Shapes_CreateRequestShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=CreateRequestShape}" />
```

__Database1Shape__ 
![Rad Diagram Features Shapes Database 1 Shape](../images/RadDiagram_Features_Shapes_Database1Shape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=Database1Shape}"/>				  
```

__Database2Shape__ 
![Rad Diagram Features Shapes Database 2 Shape](../images/RadDiagram_Features_Shapes_Database2Shape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=Database2Shape}" />				  
```

__Database3Shape__ 
![Rad Diagram Features Shapes Database 3 Shape](../images/RadDiagram_Features_Shapes_Database3Shape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=Database3Shape}"/>
```

__DataShape__ 
![Rad Diagram Features Shapes Data Shape](../images/RadDiagram_Features_Shapes_DataShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DataShape}" />
```

__DataStoreShape__ 
![Rad Diagram Features Shapes Data Store Shape](../images/RadDiagram_Features_Shapes_DataStoreShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DataStoreShape}" />
```

__DecisionShape__ 
![Rad Diagram Features Shapes Decision Shape](../images/RadDiagram_Features_Shapes_DecisionShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DecisionShape}"/>
```

__DelayShape__ 
![Rad Diagram Features Shapes Delay Shape](../images/RadDiagram_Features_Shapes_DelayShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DelayShape}" />				  						  
```

__DevidedProcessShape__ 
![Rad Diagram Features Shapes Devided Process Shape](../images/RadDiagram_Features_Shapes_DevidedProcessShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DevidedProcessShape}" />
```

__DirectDataShape__ 
![Rad Diagram Features Shapes Direct Data Shape](../images/RadDiagram_Features_Shapes_DirectDataShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DirectDataShape}"/>
```

__DisplayShape__ 
![Rad Diagram Features Shapes Display Shape](../images/RadDiagram_Features_Shapes_DisplayShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DisplayShape}" />				  
```

__DocumentShape__ 
![Rad Diagram Features Shapes Document Shape](../images/RadDiagram_Features_Shapes_DocumentShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DocumentShape}" />				  
```

__DuplicatingShape__ 
![Rad Diagram Features Shapes Duplicating Shape](../images/RadDiagram_Features_Shapes_DuplicatingShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DuplicatingShape}"/>				  
```
		
__ExternalDataShape__ 
![Rad Diagram Features Shapes External Data Shape](../images/RadDiagram_Features_Shapes_ExternalDataShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=ExternalDataShape}" />
```

__FeedbackShape__ 
![Rad Diagram Features Shapes Feedback Shape](../images/RadDiagram_Features_Shapes_FeedbackShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=FeedbackShape}" />
```
	
__FramedRectangleShape__ 
![Rad Diagram Features Shapes Framed Rectangle Shape](../images/RadDiagram_Features_Shapes_FramedRectangleShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=FramedRectangleShape}"/>
```

__InternalStorageShape__ 
![Rad Diagram Features Shapes Internal Storage Shape](../images/RadDiagram_Features_Shapes_InternalStorageShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=InternalStorageShape}" />
```

__LinedDocumentShape__ 
![Rad Diagram Features Shapes Lined Document Shape](../images/RadDiagram_Features_Shapes_LinedDocumentShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=LinedDocumentShape}" />
```

__LoopLimitShape__ 
![Rad Diagram Features Shapes Loop Limit Shape](../images/RadDiagram_Features_Shapes_LoopLimitShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=LoopLimitShape}"/>				  
```

__ManualInputShape__ 
![Rad Diagram Features Shapes Manual Input Shape](../images/RadDiagram_Features_Shapes_ManualInputShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=ManualInputShape}" />
```

__ManualOperationShape__ 
![Rad Diagram Features Shapes Manual Operation Shape](../images/RadDiagram_Features_Shapes_ManualOperationShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=ManualOperationShape}" />
```

__MessageFromUserShape__ 
![Rad Diagram Features Shapes Message From User Shape](../images/RadDiagram_Features_Shapes_MessageFromUserShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MessageFromUserShape}"/>
```

__MessageToUserShape__ 
![Rad Diagram Features Shapes Message To User Shape](../images/RadDiagram_Features_Shapes_MessageToUserShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MessageToUserShape}" />
```

__MicroformProcessingShape__ 
![Rad Diagram Features Shapes Microform Processing Shape](../images/RadDiagram_Features_Shapes_MicroformProcessingShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MicroformProcessingShape}" />
```

__MicroformRecordingShape__ 
![Rad Diagram Features Shapes Microform Recording Shape](../images/RadDiagram_Features_Shapes_MicroformRecordingShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MicroformRecordingShape}"/>
```

__MultipleDocumentShape__ 
![Rad Diagram Features Shapes Multiple Document Shape](../images/RadDiagram_Features_Shapes_MultipleDocumentShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MultipleDocumentShape}" />
```

__OffPageConnectionShape__ 
![Rad Diagram Features Shapes Off Page Connection Shape](../images/RadDiagram_Features_Shapes_OffPageConnectionShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=OffPageConnectionShape}" />
```

__OffPageLinkShape__ 
![Rad Diagram Features Shapes Off Page Link Shape](../images/RadDiagram_Features_Shapes_OffPageLinkShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=OffPageLinkShape}"/>
```

__OffPageReflectionShape__ 
![Rad Diagram Features Shapes Off Page Reflection Shape](../images/RadDiagram_Features_Shapes_OffPageReflectionShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=OffPageReflectionShape}" />
```

__OrShape__ 
![Rad Diagram Features Shapes Or Shape](../images/RadDiagram_Features_Shapes_OrShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=OrShape}" />
```

__PaperTapeShape__ 
![Rad Diagram Features Shapes Paper Tape Shape](../images/RadDiagram_Features_Shapes_PaperTapeShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PaperTapeShape}"/>
```

__PredefinedShape__ 
![Rad Diagram Features Shapes Predefined Shape](../images/RadDiagram_Features_Shapes_PredefinedShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PredefinedShape}"  />
```

__PreparationShape__ 
![Rad Diagram Features Shapes Preparation Shape](../images/RadDiagram_Features_Shapes_PreparationShape.png)

	
```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PreparationShape}" />
```

__PrimitiveFromCallShape__ 
![Rad Diagram Features Shapes Primitive From Call Shape](../images/RadDiagram_Features_Shapes_PrimitiveFromCallShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PrimitiveFromCallShape}"/>
```

__PrimitiveToCallShape__ 
![Rad Diagram Features Shapes Primitive To Call Shape](../images/RadDiagram_Features_Shapes_PrimitiveToCallShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PrimitiveToCallShape}"  />
```

__SequentialDataShape__ 
![Rad Diagram Features Shapes Sequential Data Shape](../images/RadDiagram_Features_Shapes_SequentialDataShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=SequentialDataShape}" />						  
```

__SortShape__ 
![Rad Diagram Features Shapes Sort Shape](../images/RadDiagram_Features_Shapes_SortShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=SortShape}"/>
```

__StartShape__ 
![Rad Diagram Features Shapes Start Shape](../images/RadDiagram_Features_Shapes_StartShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=StartShape}"  />
```

__StoredDataShape__
![Rad Diagram Features Shapes Stored Data Shape](../images/RadDiagram_Features_Shapes_StoredDataShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=StoredDataShape}" />
```

__SummingJunctionShape__ 
![Rad Diagram Features Shapes Summing Junction Shape](../images/RadDiagram_Features_Shapes_SummingJunctionShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=SummingJunctionShape}"/>
```

__TerminatorShape__ 
![Rad Diagram Features Shapes Terminator Shape](../images/RadDiagram_Features_Shapes_TerminatorShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=TerminatorShape}"  />
```

__TransmittalTapeShape__ 
![Rad Diagram Features Shapes Transmittal Tape Shape](../images/RadDiagram_Features_Shapes_TransmittalTapeShape.png)


```XAML
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=TransmittalTapeShape}" />
```

## See Also  
 * [Structure]({%slug raddiagram-structure%})
 * [Getting Started]({%slug raddiagram-getting-started%}) 
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Items Events]({%slug raddiagrams-events-item%})
 * [Diagram Shape]({%slug raddiagrams-features-shapes%})