---
title: Predefined Shape Geometries
page_title: Predefined Shape Geometries
description: Telerik RadDiagram for WPF Predefined Shape Geometries
slug: raddiagrams-features-shapes-predefined-shapes
tags: shapes,predefined,geometry,shapefactory
published: True
position: 2
---

# Predefined Shape Geometries

The __Telerik Diagramming Framework__ provides three types of predefined shape geometries - __ArrowShapes__, __CommonShapes__ and __FlowChartShapes__. For each of these types the framework exposes xaml markup extensions that can be applied at the __RadDiagramShape.Geometry__ property as a shortcut way of creating a shape.

This article contains a list with the available geometries and shows how to set a geometry.

#### __[C#] Create a geometry in code behind__ 
{{region raddiagram-features-shapes-predefined-shapes-0}}
	Geometry arrowGeometry = ShapeFactory.GetShapeGeometry(ArrowShapeType.Arrow1);
	diagramShape.Geometry = arrowGeometry;
{{endregion}}

## ArrowShapes

__Arrow1__ 
![Rad Diagram Features Shapes Arrow 1](../images/RadDiagram_Features_Shapes_Arrow1.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-9}}
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow1}" />
{{endregion}}

__Arrow2__ 
![Rad Diagram Features Shapes Arrow 2](../images/RadDiagram_Features_Shapes_Arrow2.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-10}}
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow2}" />
{{endregion}}

__Arrow3__
![Rad Diagram Features Shapes Arrow 3](../images/RadDiagram_Features_Shapes_Arrow3.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-11}}
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow3}" />
{{endregion}}

__Arrow4__ 
![Rad Diagram Features Shapes Arrow 4](../images/RadDiagram_Features_Shapes_Arrow4.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-12}}
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow4}" />  
{{endregion}}

__Arrow5__ 
![Rad Diagram Features Shapes Arrow 5](../images/RadDiagram_Features_Shapes_Arrow5.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-13}}
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow5}"/>
{{endregion}}

__Arrow6__ 
![Rad Diagram Features Shapes Arrow 6](../images/RadDiagram_Features_Shapes_Arrow6.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-14}}
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow6}" />
{{endregion}}

__Arrow7__ 
![Rad Diagram Features Shapes Arrow 7](../images/RadDiagram_Features_Shapes_Arrow7.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-15}}
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow7}"/>
{{endregion}}

__Arrow8__ 
![Rad Diagram Features Shapes Arrow 8](../images/RadDiagram_Features_Shapes_Arrow8.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-16}}
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow8}"/>				  						  
{{endregion}}

__DoubleArrow1__ 	
![Rad Diagram Features Shapes Double Arrow 1](../images/RadDiagram_Features_Shapes_DoubleArrow1.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-18}}
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow1}" />				  						  
{{endregion}}

__DoubleArrow2__ 
![Rad Diagram Features Shapes Double Arrow 2](../images/RadDiagram_Features_Shapes_DoubleArrow2.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-19}}
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow2}" />				  						  
{{endregion}}

__DoubleArrow3__ 
![Rad Diagram Features Shapes Double Arrow 3](../images/RadDiagram_Features_Shapes_DoubleArrow3.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-20}}
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow3}" />
{{endregion}}

__DoubleArrow4__ 
![Rad Diagram Features Shapes Double Arrow 4](../images/RadDiagram_Features_Shapes_DoubleArrow4.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-21}}
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow4}" />
{{endregion}}

__DoubleArrow5__ 
![Rad Diagram Features Shapes Double Arrow 5](../images/RadDiagram_Features_Shapes_DoubleArrow5.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-22}}
	<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow5}" />
{{endregion}}
	
### CommonShapes
					
__CloudShape__ 
![Rad Diagram Features Shapes Cloud Shape](../images/RadDiagram_Features_Shapes_CloudShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-23}}
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=CloudShape}" />				  
{{endregion}}

__Cross2Shape__ 
![Rad Diagram Features Shapes Cross 2 Shape](../images/RadDiagram_Features_Shapes_Cross2Shape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-24}}
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=Cross2Shape}"/>
{{endregion}}

__CrossShape__ 
![Rad Diagram Features Shapes Cross Shape](../images/RadDiagram_Features_Shapes_CrossShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-25}}
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=CrossShape}" />				  
{{endregion}}

__EllipseShape__ 
![Rad Diagram Features Shapes Ellipse Shape](../images/RadDiagram_Features_Shapes_EllipseShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-26}}
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=EllipseShape}" />				  
{{endregion}}

__HexagonShape__ 
![Rad Diagram Features Shapes Hexagon Shape](../images/RadDiagram_Features_Shapes_HexagonShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-27}}
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=HexagonShape}"/>				  						  
{{endregion}}

__OctagonShape__ 
![Rad Diagram Features Shapes Octagon Shape](../images/RadDiagram_Features_Shapes_OctagonShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-28}}
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=OctagonShape}" />
{{endregion}}

__PentagonShape__ 
![Rad Diagram Features Shapes Pentagon Shape](../images/RadDiagram_Features_Shapes_PentagonShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-29}}
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=PentagonShape}" />
{{endregion}}

__RectangleShape__ 
![Rad Diagram Features Shapes Rectangle Shape](../images/RadDiagram_Features_Shapes_RectangleShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-30}}
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=RectangleShape}"/>				  						  
{{endregion}}

__RightTriangleShape__ 
![Rad Diagram Features Shapes Right Triangle Shape](../images/RadDiagram_Features_Shapes_RightTriangleShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-31}}
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=RightTriangleShape}" />				  						  
{{endregion}}

__RoundedRectangleShape__ 
![Rad Diagram Features Shapes Rounded Rectangle Shape](../images/RadDiagram_Features_Shapes_RoundedRectangleShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-32}}
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=RoundedRectangleShape}" />				  						  
{{endregion}}

__Star5Shape__ 
![Rad Diagram Features Shapes Star 5 Shape](../images/RadDiagram_Features_Shapes_Star5Shape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-33}}
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=Star5Shape}"/>				  
{{endregion}}

__Star6Shape__ 
![Rad Diagram Features Shapes Star 6 Shape](../images/RadDiagram_Features_Shapes_Star6Shape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-34}}
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=Star6Shape}" />
{{endregion}}

__Star7Shape__ 
![Rad Diagram Features Shapes Star 7 Shape](../images/RadDiagram_Features_Shapes_Star7Shape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-35}}
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=Star7Shape}" />
{{endregion}}

__TriangleShape__ 
![Rad Diagram Features Shapes Triangle Shape](../images/RadDiagram_Features_Shapes_TriangleShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-36}}
	<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=TriangleShape}"/>	
{{endregion}}
	
### FlowChartShapes

__BeginLoopShape__ 
![Rad Diagram Features Shapes Begin Loop Shape](../images/RadDiagram_Features_Shapes_BeginLoopShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-37}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=BeginLoopShape}" />
{{endregion}}

__CardShape__ 
![Rad Diagram Features Shapes Card Shape](../images/RadDiagram_Features_Shapes_CardShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-38}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=CardShape}"/>
{{endregion}}

__CollateShape__ 
![Rad Diagram Features Shapes Collate Shape](../images/RadDiagram_Features_Shapes_CollateShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-39}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=CollateShape}" />				  					  
{{endregion}}

__CreateRequestShape__ 
![Rad Diagram Features Shapes Create Request Shape](../images/RadDiagram_Features_Shapes_CreateRequestShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-40}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=CreateRequestShape}" />
{{endregion}}

__Database1Shape__ 
![Rad Diagram Features Shapes Database 1 Shape](../images/RadDiagram_Features_Shapes_Database1Shape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-41}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=Database1Shape}"/>				  
{{endregion}}

__Database2Shape__ 
![Rad Diagram Features Shapes Database 2 Shape](../images/RadDiagram_Features_Shapes_Database2Shape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-42}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=Database2Shape}" />				  
{{endregion}}

__Database3Shape__ 
![Rad Diagram Features Shapes Database 3 Shape](../images/RadDiagram_Features_Shapes_Database3Shape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-43}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=Database3Shape}"/>
{{endregion}}

__DataShape__ 
![Rad Diagram Features Shapes Data Shape](../images/RadDiagram_Features_Shapes_DataShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-44}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DataShape}" />
{{endregion}}

__DataStoreShape__ 
![Rad Diagram Features Shapes Data Store Shape](../images/RadDiagram_Features_Shapes_DataStoreShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-45}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DataStoreShape}" />
{{endregion}}

__DecisionShape__ 
![Rad Diagram Features Shapes Decision Shape](../images/RadDiagram_Features_Shapes_DecisionShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-46}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DecisionShape}"/>
{{endregion}}

__DelayShape__ 
![Rad Diagram Features Shapes Delay Shape](../images/RadDiagram_Features_Shapes_DelayShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-47}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DelayShape}" />				  						  
{{endregion}}

__DevidedProcessShape__ 
![Rad Diagram Features Shapes Devided Process Shape](../images/RadDiagram_Features_Shapes_DevidedProcessShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-48}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DevidedProcessShape}" />
{{endregion}}

__DirectDataShape__ 
![Rad Diagram Features Shapes Direct Data Shape](../images/RadDiagram_Features_Shapes_DirectDataShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-49}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DirectDataShape}"/>
{{endregion}}

__DisplayShape__ 
![Rad Diagram Features Shapes Display Shape](../images/RadDiagram_Features_Shapes_DisplayShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-50}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DisplayShape}" />				  
{{endregion}}

__DocumentShape__ 
![Rad Diagram Features Shapes Document Shape](../images/RadDiagram_Features_Shapes_DocumentShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-51}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DocumentShape}" />				  
{{endregion}}

__DuplicatingShape__ 
![Rad Diagram Features Shapes Duplicating Shape](../images/RadDiagram_Features_Shapes_DuplicatingShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-52}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DuplicatingShape}"/>				  
{{endregion}}
		
__ExternalDataShape__ 
![Rad Diagram Features Shapes External Data Shape](../images/RadDiagram_Features_Shapes_ExternalDataShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-53}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=ExternalDataShape}" />
{{endregion}}

__FeedbackShape__ 
![Rad Diagram Features Shapes Feedback Shape](../images/RadDiagram_Features_Shapes_FeedbackShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-54}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=FeedbackShape}" />
{{endregion}}
	
__FramedRectangleShape__ 
![Rad Diagram Features Shapes Framed Rectangle Shape](../images/RadDiagram_Features_Shapes_FramedRectangleShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-55}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=FramedRectangleShape}"/>
{{endregion}}

__InternalStorageShape__ 
![Rad Diagram Features Shapes Internal Storage Shape](../images/RadDiagram_Features_Shapes_InternalStorageShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-56}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=InternalStorageShape}" />
{{endregion}}

__LinedDocumentShape__ 
![Rad Diagram Features Shapes Lined Document Shape](../images/RadDiagram_Features_Shapes_LinedDocumentShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-57}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=LinedDocumentShape}" />
{{endregion}}

__LoopLimitShape__ 
![Rad Diagram Features Shapes Loop Limit Shape](../images/RadDiagram_Features_Shapes_LoopLimitShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-58}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=LoopLimitShape}"/>				  
{{endregion}}

__ManualInputShape__ 
![Rad Diagram Features Shapes Manual Input Shape](../images/RadDiagram_Features_Shapes_ManualInputShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-59}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=ManualInputShape}" />
{{endregion}}

__ManualOperationShape__ 
![Rad Diagram Features Shapes Manual Operation Shape](../images/RadDiagram_Features_Shapes_ManualOperationShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-60}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=ManualOperationShape}" />
{{endregion}}

__MessageFromUserShape__ 
![Rad Diagram Features Shapes Message From User Shape](../images/RadDiagram_Features_Shapes_MessageFromUserShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-61}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MessageFromUserShape}"/>
{{endregion}}

__MessageToUserShape__ 
![Rad Diagram Features Shapes Message To User Shape](../images/RadDiagram_Features_Shapes_MessageToUserShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-62}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MessageToUserShape}" />
{{endregion}}

__MicroformProcessingShape__ 
![Rad Diagram Features Shapes Microform Processing Shape](../images/RadDiagram_Features_Shapes_MicroformProcessingShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-63}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MicroformProcessingShape}" />
{{endregion}}

__MicroformRecordingShape__ 
![Rad Diagram Features Shapes Microform Recording Shape](../images/RadDiagram_Features_Shapes_MicroformRecordingShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-64}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MicroformRecordingShape}"/>
{{endregion}}

__MultipleDocumentShape__ 
![Rad Diagram Features Shapes Multiple Document Shape](../images/RadDiagram_Features_Shapes_MultipleDocumentShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-65}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MultipleDocumentShape}" />
{{endregion}}

__OffPageConnectionShape__ 
![Rad Diagram Features Shapes Off Page Connection Shape](../images/RadDiagram_Features_Shapes_OffPageConnectionShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-66}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=OffPageConnectionShape}" />
{{endregion}}

__OffPageLinkShape__ 
![Rad Diagram Features Shapes Off Page Link Shape](../images/RadDiagram_Features_Shapes_OffPageLinkShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-67}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=OffPageLinkShape}"/>
{{endregion}}

__OffPageReflectionShape__ 
![Rad Diagram Features Shapes Off Page Reflection Shape](../images/RadDiagram_Features_Shapes_OffPageReflectionShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-68}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=OffPageReflectionShape}" />
{{endregion}}

__OrShape__ 
![Rad Diagram Features Shapes Or Shape](../images/RadDiagram_Features_Shapes_OrShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-69}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=OrShape}" />
{{endregion}}

__PaperTapeShape__ 
![Rad Diagram Features Shapes Paper Tape Shape](../images/RadDiagram_Features_Shapes_PaperTapeShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-70}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PaperTapeShape}"/>
{{endregion}}

__PredefinedShape__ 
![Rad Diagram Features Shapes Predefined Shape](../images/RadDiagram_Features_Shapes_PredefinedShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-71}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PredefinedShape}"  />
{{endregion}}

__PreparationShape__ 
![Rad Diagram Features Shapes Preparation Shape](../images/RadDiagram_Features_Shapes_PreparationShape.png)

#### __XAML__	
{{region raddiagram-features-shapes-predefined-shapes-72}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PreparationShape}" />
{{endregion}}

__PrimitiveFromCallShape__ 
![Rad Diagram Features Shapes Primitive From Call Shape](../images/RadDiagram_Features_Shapes_PrimitiveFromCallShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-73}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PrimitiveFromCallShape}"/>
{{endregion}}

__PrimitiveToCallShape__ 
![Rad Diagram Features Shapes Primitive To Call Shape](../images/RadDiagram_Features_Shapes_PrimitiveToCallShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-74}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PrimitiveToCallShape}"  />
{{endregion}}

__SequentialDataShape__ 
![Rad Diagram Features Shapes Sequential Data Shape](../images/RadDiagram_Features_Shapes_SequentialDataShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-75}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=SequentialDataShape}" />						  
{{endregion}}

__SortShape__ 
![Rad Diagram Features Shapes Sort Shape](../images/RadDiagram_Features_Shapes_SortShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-76}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=SortShape}"/>
{{endregion}}

__StartShape__ 
![Rad Diagram Features Shapes Start Shape](../images/RadDiagram_Features_Shapes_StartShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-77}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=StartShape}"  />
{{endregion}}

__StoredDataShape__
![Rad Diagram Features Shapes Stored Data Shape](../images/RadDiagram_Features_Shapes_StoredDataShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-78}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=StoredDataShape}" />
{{endregion}}

__SummingJunctionShape__ 
![Rad Diagram Features Shapes Summing Junction Shape](../images/RadDiagram_Features_Shapes_SummingJunctionShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-79}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=SummingJunctionShape}"/>
{{endregion}}

__TerminatorShape__ 
![Rad Diagram Features Shapes Terminator Shape](../images/RadDiagram_Features_Shapes_TerminatorShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-80}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=TerminatorShape}"  />
{{endregion}}

__TransmittalTapeShape__ 
![Rad Diagram Features Shapes Transmittal Tape Shape](../images/RadDiagram_Features_Shapes_TransmittalTapeShape.png)

#### __XAML__
{{region raddiagram-features-shapes-predefined-shapes-81}}
	<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=TransmittalTapeShape}" />
{{endregion}}

## See Also  
 * [Structure]({%slug raddiagram-structure%})
 * [Getting Started]({%slug raddiagram-getting-started%}) 
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Items Events]({%slug raddiagrams-events-item%})
 * [Diagram Shape]({%slug raddiagrams-features-shapes%})