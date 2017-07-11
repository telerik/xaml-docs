---
title: Shapes
page_title: Shapes
description: Shapes
slug: raddiagrams-features-shapes
tags: shapes
published: True
position: 0
---

# Shapes

This tutorial will walk you through the functionality and the main features of the __RadDiagramShape__.
	  
>Before proceeding with this topic, it is recommended to get familiar with the [Visual Structure]({%slug raddiagram-structure%}) of the Diagramming Framework.

## Overview

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.		  

The __RadDiagramShape__ is an object that describes the nodes of the diagram. You can configure its form using the __Geometry__ property as it allows you to define a custom geometry:		

#### __XAML__
{{region raddiagram-features-shapes-5}}
    <telerik:RadDiagramShape Width="80"
                             Height="80"
                             Geometry="M16.35,6.39 C16.28,7.36 12.26,20.45 12.26,20.45 L20.56,20.45 C20.56,20.45 16.64,7.54 16.53,6.39 z M12.30,0.50 L20.97,0.50 L32.50,33.50 L24.54,33.50 L22.23,26.16 L10.70,26.16 L8.42,33.50 L0.50,33.50 z"
                             Position="160,80" />		  
{{endregion}}

![Rad Diagram Features Shapes Custom Shape](images/RadDiagram_Features_Shapes_CustomShape.png)

or to use one of the predefined shape geometries:		

#### __XAML__
{{region raddiagram-features-shapes-6}}
    <telerik:RadDiagramShape x:Name="ConditionShape"
                    Width="80"
                    Height="80"
                    Content="condition"
                    FontWeight="Bold"
                    Geometry="{telerik:FlowChartShape ShapeType=PredefinedShape}"
                    Position="160,80" />
{{endregion}}

#### __C#__
{{region raddiagram-features-shapes-7}}
    RadDiagramShape shape = new RadDiagramShape();
    shape.Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.PredefinedShape);
{{endregion}}
	
#### __VB.NET__
{{region raddiagram-features-shapes-8}}
    Dim shape As New RadDiagramShape()
    shape.Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.PredefinedShape)
{{endregion}}
	
>The __ShapeFactory__ class allows you to get a shape geometry from the __enums__ with predefined shapes. This way you can create a __RadDiagramShape__ in code-behind still taking advantage of the predefined list of shapes. The predefined shapes can be accesses in code-behind through the following enumerations:
>	- __ArrowShapeType__ - describes all ArrowShapes
>	- __CommonShapeType__ - describes all CommonShapes
>	- __FlowChartShapeType__ - describes all FlowChartShapes 

![Rad Diagram Features Shapes Predefined Shape](images/RadDiagram_Features_Shapes_PredefinedShape.png)

## Diagramming Framework Predefined Shape Geometries

__Telerik Diagramming Framework__ provides three types of predefined shape geometries - __ArrowShapes__, __CommonShapes__ and __FlowChartShapes__. For each of these types the framework exposes xaml markup extensions that can be applied at the __RadDiagramShape.Geometry__ property as a shortcut way of creating a shape.		

### ArrowShapes
* A list of all predefined ArrowShapes:			

	__Arrow1__ 
	![Rad Diagram Features Shapes Arrow 1](images/RadDiagram_Features_Shapes_Arrow1.png)

	#### __XAML__
	{{region raddiagram-features-shapes-9}}
		<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow1}" />
	{{endregion}}
	
	__Arrow2__ 
	![Rad Diagram Features Shapes Arrow 2](images/RadDiagram_Features_Shapes_Arrow2.png)

	#### __XAML__
	{{region raddiagram-features-shapes-10}}
		<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow2}" />
	{{endregion}}
	
	__Arrow3__
	![Rad Diagram Features Shapes Arrow 3](images/RadDiagram_Features_Shapes_Arrow3.png)
	
	#### __XAML__
	{{region raddiagram-features-shapes-11}}
		<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow3}" />
	{{endregion}}
	
	__Arrow4__ 
	![Rad Diagram Features Shapes Arrow 4](images/RadDiagram_Features_Shapes_Arrow4.png)

	#### __XAML__
	{{region raddiagram-features-shapes-12}}
		<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow4}" />  
	{{endregion}}
	
	__Arrow5__ 
	![Rad Diagram Features Shapes Arrow 5](images/RadDiagram_Features_Shapes_Arrow5.png)

	#### __XAML__
	{{region raddiagram-features-shapes-13}}
		<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow5}"/>
	{{endregion}}
	
	__Arrow6__ 
	![Rad Diagram Features Shapes Arrow 6](images/RadDiagram_Features_Shapes_Arrow6.png)

	#### __XAML__
	{{region raddiagram-features-shapes-14}}
		<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow6}" />
	{{endregion}}
	
	__Arrow7__ 
	![Rad Diagram Features Shapes Arrow 7](images/RadDiagram_Features_Shapes_Arrow7.png)

	#### __XAML__
	{{region raddiagram-features-shapes-15}}
		<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow7}"/>
	{{endregion}}
	
	__Arrow8__ 
	![Rad Diagram Features Shapes Arrow 8](images/RadDiagram_Features_Shapes_Arrow8.png)

	#### __XAML__
	{{region raddiagram-features-shapes-16}}
		<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=Arrow8}"/>				  						  
	{{endregion}}
	
	__DoubleArrow1__ 	
	![Rad Diagram Features Shapes Double Arrow 1](images/RadDiagram_Features_Shapes_DoubleArrow1.png)

	#### __XAML__
	{{region raddiagram-features-shapes-18}}
		<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow1}" />				  						  
	{{endregion}}
	
	__DoubleArrow2__ 
	![Rad Diagram Features Shapes Double Arrow 2](images/RadDiagram_Features_Shapes_DoubleArrow2.png)

	#### __XAML__
	{{region raddiagram-features-shapes-19}}
		<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow2}" />				  						  
	{{endregion}}
	
	__DoubleArrow3__ 
	![Rad Diagram Features Shapes Double Arrow 3](images/RadDiagram_Features_Shapes_DoubleArrow3.png)

	#### __XAML__
	{{region raddiagram-features-shapes-20}}
		<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow3}" />
	{{endregion}}
	
	__DoubleArrow4__ 
	![Rad Diagram Features Shapes Double Arrow 4](images/RadDiagram_Features_Shapes_DoubleArrow4.png)

	#### __XAML__
	{{region raddiagram-features-shapes-21}}
		<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow4}" />
	{{endregion}}
	
	__DoubleArrow5__ 
	![Rad Diagram Features Shapes Double Arrow 5](images/RadDiagram_Features_Shapes_DoubleArrow5.png)

	#### __XAML__
	{{region raddiagram-features-shapes-22}}
		<telerik:RadDiagramShape Geometry="{telerik:ArrowShape ShapeType=DoubleArrow5}" />
	{{endregion}}
	
### CommonShapes

* A list of all predefined CommonShapes:
					
	__CloudShape__ 
	![Rad Diagram Features Shapes Cloud Shape](images/RadDiagram_Features_Shapes_CloudShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-23}}
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=CloudShape}" />				  
	{{endregion}}
	
	__Cross2Shape__ 
	![Rad Diagram Features Shapes Cross 2 Shape](images/RadDiagram_Features_Shapes_Cross2Shape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-24}}
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=Cross2Shape}"/>
	{{endregion}}
	
	__CrossShape__ 
	![Rad Diagram Features Shapes Cross Shape](images/RadDiagram_Features_Shapes_CrossShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-25}}
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=CrossShape}" />				  
	{{endregion}}
	
	__EllipseShape__ 
	![Rad Diagram Features Shapes Ellipse Shape](images/RadDiagram_Features_Shapes_EllipseShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-26}}
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=EllipseShape}" />				  
	{{endregion}}
	
	__HexagonShape__ 
	![Rad Diagram Features Shapes Hexagon Shape](images/RadDiagram_Features_Shapes_HexagonShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-27}}
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=HexagonShape}"/>				  						  
	{{endregion}}
	
	__OctagonShape__ 
	![Rad Diagram Features Shapes Octagon Shape](images/RadDiagram_Features_Shapes_OctagonShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-28}}
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=OctagonShape}" />
	{{endregion}}
	
	__PentagonShape__ 
	![Rad Diagram Features Shapes Pentagon Shape](images/RadDiagram_Features_Shapes_PentagonShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-29}}
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=PentagonShape}" />
	{{endregion}}
	
	__RectangleShape__ 
	![Rad Diagram Features Shapes Rectangle Shape](images/RadDiagram_Features_Shapes_RectangleShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-30}}
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=RectangleShape}"/>				  						  
	{{endregion}}
	
	__RightTriangleShape__ 
	![Rad Diagram Features Shapes Right Triangle Shape](images/RadDiagram_Features_Shapes_RightTriangleShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-31}}
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=RightTriangleShape}" />				  						  
	{{endregion}}
	
	__RoundedRectangleShape__ 
	![Rad Diagram Features Shapes Rounded Rectangle Shape](images/RadDiagram_Features_Shapes_RoundedRectangleShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-32}}
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=RoundedRectangleShape}" />				  						  
	{{endregion}}
	
	__Star5Shape__ 
	![Rad Diagram Features Shapes Star 5 Shape](images/RadDiagram_Features_Shapes_Star5Shape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-33}}
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=Star5Shape}"/>				  
	{{endregion}}
	
	__Star6Shape__ 
	![Rad Diagram Features Shapes Star 6 Shape](images/RadDiagram_Features_Shapes_Star6Shape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-34}}
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=Star6Shape}" />
	{{endregion}}
	
	__Star7Shape__ 
	![Rad Diagram Features Shapes Star 7 Shape](images/RadDiagram_Features_Shapes_Star7Shape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-35}}
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=Star7Shape}" />
	{{endregion}}
	
	__TriangleShape__ 
	![Rad Diagram Features Shapes Triangle Shape](images/RadDiagram_Features_Shapes_TriangleShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-36}}
		<telerik:RadDiagramShape Geometry="{telerik:CommonShape ShapeType=TriangleShape}"/>	
	{{endregion}}
	
### FlowChartShapes

* A list of all predefined FlowChartShapes:
	__BeginLoopShape__ 
	![Rad Diagram Features Shapes Begin Loop Shape](images/RadDiagram_Features_Shapes_BeginLoopShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-37}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=BeginLoopShape}" />
	{{endregion}}
	
	__CardShape__ 
	![Rad Diagram Features Shapes Card Shape](images/RadDiagram_Features_Shapes_CardShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-38}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=CardShape}"/>
	{{endregion}}
	
	__CollateShape__ 
	![Rad Diagram Features Shapes Collate Shape](images/RadDiagram_Features_Shapes_CollateShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-39}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=CollateShape}" />				  					  
	{{endregion}}
	
	__CreateRequestShape__ 
	![Rad Diagram Features Shapes Create Request Shape](images/RadDiagram_Features_Shapes_CreateRequestShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-40}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=CreateRequestShape}" />
	{{endregion}}
	
	__Database1Shape__ 
	![Rad Diagram Features Shapes Database 1 Shape](images/RadDiagram_Features_Shapes_Database1Shape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-41}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=Database1Shape}"/>				  
	{{endregion}}
	
	__Database2Shape__ 
	![Rad Diagram Features Shapes Database 2 Shape](images/RadDiagram_Features_Shapes_Database2Shape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-42}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=Database2Shape}" />				  
	{{endregion}}
	
	__Database3Shape__ 
	![Rad Diagram Features Shapes Database 3 Shape](images/RadDiagram_Features_Shapes_Database3Shape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-43}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=Database3Shape}"/>
	{{endregion}}
	
	__DataShape__ 
	![Rad Diagram Features Shapes Data Shape](images/RadDiagram_Features_Shapes_DataShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-44}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DataShape}" />
	{{endregion}}
	
	__DataStoreShape__ 
	![Rad Diagram Features Shapes Data Store Shape](images/RadDiagram_Features_Shapes_DataStoreShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-45}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DataStoreShape}" />
	{{endregion}}
	
	__DecisionShape__ 
	![Rad Diagram Features Shapes Decision Shape](images/RadDiagram_Features_Shapes_DecisionShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-46}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DecisionShape}"/>
	{{endregion}}
	
	__DelayShape__ 
	![Rad Diagram Features Shapes Delay Shape](images/RadDiagram_Features_Shapes_DelayShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-47}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DelayShape}" />				  						  
	{{endregion}}
	
	__DevidedProcessShape__ 
	![Rad Diagram Features Shapes Devided Process Shape](images/RadDiagram_Features_Shapes_DevidedProcessShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-48}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DevidedProcessShape}" />
	{{endregion}}
	
	__DirectDataShape__ 
	![Rad Diagram Features Shapes Direct Data Shape](images/RadDiagram_Features_Shapes_DirectDataShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-49}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DirectDataShape}"/>
	{{endregion}}
	
	__DisplayShape__ 
	![Rad Diagram Features Shapes Display Shape](images/RadDiagram_Features_Shapes_DisplayShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-50}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DisplayShape}" />				  
	{{endregion}}
	
	__DocumentShape__ 
	![Rad Diagram Features Shapes Document Shape](images/RadDiagram_Features_Shapes_DocumentShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-51}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DocumentShape}" />				  
	{{endregion}}
	
	__DuplicatingShape__ 
	![Rad Diagram Features Shapes Duplicating Shape](images/RadDiagram_Features_Shapes_DuplicatingShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-52}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=DuplicatingShape}"/>				  
	{{endregion}}
			
	__ExternalDataShape__ 
	![Rad Diagram Features Shapes External Data Shape](images/RadDiagram_Features_Shapes_ExternalDataShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-53}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=ExternalDataShape}" />
	{{endregion}}
	
	__FeedbackShape__ 
	![Rad Diagram Features Shapes Feedback Shape](images/RadDiagram_Features_Shapes_FeedbackShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-54}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=FeedbackShape}" />
	{{endregion}}
		
	__FramedRectangleShape__ 
	![Rad Diagram Features Shapes Framed Rectangle Shape](images/RadDiagram_Features_Shapes_FramedRectangleShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-55}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=FramedRectangleShape}"/>
	{{endregion}}
	
	__InternalStorageShape__ 
	![Rad Diagram Features Shapes Internal Storage Shape](images/RadDiagram_Features_Shapes_InternalStorageShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-56}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=InternalStorageShape}" />
	{{endregion}}
	
	__LinedDocumentShape__ 
	![Rad Diagram Features Shapes Lined Document Shape](images/RadDiagram_Features_Shapes_LinedDocumentShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-57}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=LinedDocumentShape}" />
	{{endregion}}
	
	__LoopLimitShape__ 
	![Rad Diagram Features Shapes Loop Limit Shape](images/RadDiagram_Features_Shapes_LoopLimitShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-58}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=LoopLimitShape}"/>				  
	{{endregion}}
	
	__ManualInputShape__ 
	![Rad Diagram Features Shapes Manual Input Shape](images/RadDiagram_Features_Shapes_ManualInputShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-59}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=ManualInputShape}" />
	{{endregion}}
	
	__ManualOperationShape__ 
	![Rad Diagram Features Shapes Manual Operation Shape](images/RadDiagram_Features_Shapes_ManualOperationShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-60}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=ManualOperationShape}" />
	{{endregion}}
	
	__MessageFromUserShape__ 
	![Rad Diagram Features Shapes Message From User Shape](images/RadDiagram_Features_Shapes_MessageFromUserShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-61}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MessageFromUserShape}"/>
	{{endregion}}
	
	__MessageToUserShape__ 
	![Rad Diagram Features Shapes Message To User Shape](images/RadDiagram_Features_Shapes_MessageToUserShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-62}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MessageToUserShape}" />
	{{endregion}}
	
	__MicroformProcessingShape__ 
	![Rad Diagram Features Shapes Microform Processing Shape](images/RadDiagram_Features_Shapes_MicroformProcessingShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-63}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MicroformProcessingShape}" />
	{{endregion}}
	
	__MicroformRecordingShape__ 
	![Rad Diagram Features Shapes Microform Recording Shape](images/RadDiagram_Features_Shapes_MicroformRecordingShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-64}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MicroformRecordingShape}"/>
	{{endregion}}
	
	__MultipleDocumentShape__ 
	![Rad Diagram Features Shapes Multiple Document Shape](images/RadDiagram_Features_Shapes_MultipleDocumentShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-65}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=MultipleDocumentShape}" />
	{{endregion}}
	
	__OffPageConnectionShape__ 
	![Rad Diagram Features Shapes Off Page Connection Shape](images/RadDiagram_Features_Shapes_OffPageConnectionShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-66}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=OffPageConnectionShape}" />
	{{endregion}}
	
	__OffPageLinkShape__ 
	![Rad Diagram Features Shapes Off Page Link Shape](images/RadDiagram_Features_Shapes_OffPageLinkShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-67}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=OffPageLinkShape}"/>
	{{endregion}}
	
	__OffPageReflectionShape__ 
	![Rad Diagram Features Shapes Off Page Reflection Shape](images/RadDiagram_Features_Shapes_OffPageReflectionShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-68}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=OffPageReflectionShape}" />
	{{endregion}}
	
	__OrShape__ 
	![Rad Diagram Features Shapes Or Shape](images/RadDiagram_Features_Shapes_OrShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-69}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=OrShape}" />
	{{endregion}}
	
	__PaperTapeShape__ 
	![Rad Diagram Features Shapes Paper Tape Shape](images/RadDiagram_Features_Shapes_PaperTapeShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-70}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PaperTapeShape}"/>
	{{endregion}}
	
	__PredefinedShape__ 
	![Rad Diagram Features Shapes Predefined Shape](images/RadDiagram_Features_Shapes_PredefinedShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-71}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PredefinedShape}"  />
	{{endregion}}
	
	__PreparationShape__ 
	![Rad Diagram Features Shapes Preparation Shape](images/RadDiagram_Features_Shapes_PreparationShape.png)

	#### __XAML__	
	{{region raddiagram-features-shapes-72}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PreparationShape}" />
	{{endregion}}
	
	__PrimitiveFromCallShape__ 
	![Rad Diagram Features Shapes Primitive From Call Shape](images/RadDiagram_Features_Shapes_PrimitiveFromCallShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-73}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PrimitiveFromCallShape}"/>
	{{endregion}}
	
	__PrimitiveToCallShape__ 
	![Rad Diagram Features Shapes Primitive To Call Shape](images/RadDiagram_Features_Shapes_PrimitiveToCallShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-74}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=PrimitiveToCallShape}"  />
	{{endregion}}
	
	__SequentialDataShape__ 
	![Rad Diagram Features Shapes Sequential Data Shape](images/RadDiagram_Features_Shapes_SequentialDataShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-75}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=SequentialDataShape}" />						  
	{{endregion}}
	
	__SortShape__ 
	![Rad Diagram Features Shapes Sort Shape](images/RadDiagram_Features_Shapes_SortShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-76}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=SortShape}"/>
	{{endregion}}
	
	__StartShape__ 
	![Rad Diagram Features Shapes Start Shape](images/RadDiagram_Features_Shapes_StartShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-77}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=StartShape}"  />
	{{endregion}}
	
	__StoredDataShape__
	![Rad Diagram Features Shapes Stored Data Shape](images/RadDiagram_Features_Shapes_StoredDataShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-78}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=StoredDataShape}" />
	{{endregion}}
	
	__SummingJunctionShape__ 
	![Rad Diagram Features Shapes Summing Junction Shape](images/RadDiagram_Features_Shapes_SummingJunctionShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-79}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=SummingJunctionShape}"/>
	{{endregion}}
	
	__TerminatorShape__ 
	![Rad Diagram Features Shapes Terminator Shape](images/RadDiagram_Features_Shapes_TerminatorShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-80}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=TerminatorShape}"  />
	{{endregion}}
	
	__TransmittalTapeShape__ 
	![Rad Diagram Features Shapes Transmittal Tape Shape](images/RadDiagram_Features_Shapes_TransmittalTapeShape.png)

	#### __XAML__
	{{region raddiagram-features-shapes-81}}
		<telerik:RadDiagramShape Geometry="{telerik:FlowChartShape ShapeType=TransmittalTapeShape}" />
	{{endregion}}
	
## Setting the Position of a Shape

The __RadDiagramShape.Position__ property is of type __Point__ and it gets or sets the coordinates of the top left point of a shape. By default its value is a __Point__ with coordinates __(0,0)__.

## Content

You can add content in the __RadDiagramShape__ using its __Content__ property. It allows you to define the content as a string, a __UIElement__ or a business property.

* Define a sample string value for the __RadDiagramShape.Content__ property:			

	#### __XAML__
	{{region raddiagram_features_shapes_0 }}
		<Grid>
			<telerik:RadDiagram x:Name="MyDiagram">
				<telerik:RadDiagramShape Content="RadDiagramShape" />
			</telerik:RadDiagram>
		</Grid>
	{{endregion}}

	![Rad Diagram Features Shapes String Content](images/RadDiagram_Features_Shapes_StringContent.png)

* Define __UIElements__ in the __Content__ of the shape:

	#### __XAML__
	{{region raddiagram_features_shapes_1}}
		<Grid>
			<telerik:RadDiagram x:Name="MyDiagram">
				<telerik:RadDiagramShape x:Name="EndShape"
											Width="50"
											Height="50"
											FontWeight="Bold"
											Geometry="{telerik:CommonShape ShapeType=EllipseShape}"
											Position="185,450">
					<telerik:RadDiagramShape.ContentTemplate>
						<DataTemplate>
							<Ellipse Width="25"
									 Height="25"
									 Fill="#FF333333" />
						</DataTemplate>
					</telerik:RadDiagramShape.ContentTemplate>
				</telerik:RadDiagramShape>
			</telerik:RadDiagram>
		</Grid>
	{{endregion}}

	![Rad Diagram Features Shapes Custom Content](images/RadDiagram_Features_Shapes_CustomContent.png)

* Bind the __Content__ to a business property: For the purpose of this tutorial, let's define a sample business class and set it as the __DataContext__ of the {% if site.site_name == 'Silverlight' %}UserControl{% endif %}{% if site.site_name == 'WPF' %}Window{% endif %}.

	#### __C#__
	{{region raddiagram-features-shapes-82}}
		public class EmployeeViewModel
		{
			public string ImagePath { get; set; }
			public string JobPosition { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }
		}
			....
		this.DataContext = new EmployeeViewModel()
		{
			ImagePath = "Images/NancyDavolio.jpg",
			FirstName = "Nancy",
			LastName = "Davolio",
			JobPosition = "President Marketing"
		};
	{{endregion}}
	
	#### __VB.NET__
	{{region raddiagram-features-shapes-83}}
		Public Class EmployeeViewModel
			Public Property ImagePath() As String
			Public Property JobPosition() As String
			Public Property FirstName() As String
			Public Property LastName() As String
		End Class
		...
		Me.DataContext = New EmployeeViewModel() With {
		  .ImagePath = "Images/NancyDavolio.jpg",
		  .FirstName = "Nancy",
		  .LastName = "Davolio",
		  .JobPosition = "President Marketing"
		  }
	{{endregion}}

	#### __XAML__

	{{region raddiagram_features_shapes_2}}
			<Grid>
				<telerik:RadDiagram x:Name="MyDiagram">
					<telerik:RadDiagramShape Content="{Binding LastName}"
											 Position="20,40" />
				</telerik:RadDiagram>
			</Grid>
	{{endregion}}

	![Rad Diagram Features Shapes Data Binding](images/RadDiagram_Features_Shapes_DataBinding.png)
	When you bind the __Content__ to a business class, the __RadDiagramShape__ will display the result of the business item __ToString()__ method. If you bind to a business property, then the value of the property will be displayed as the content of the shape.

* If you want to customize the visual representation of the bound property, you can take advantage of the __RadDiagramShape ContentTemplate__ property:			

	#### __XAML__

	{{region raddiagram_features_shapes_3}}
		<Grid>
			<telerik:RadDiagram x:Name="MyDiagram">
				<telerik:RadDiagramShape Content="{Binding}"
										 Position="20,40"
						 Padding="0">
					<telerik:RadDiagramShape.ContentTemplate>
						<DataTemplate>
							<Grid Width="200"
								  Height="74"
								  Background="#FF9F9E9E">
								<Grid.ColumnDefinitions>
									<ColumnDefinition Width="Auto" />
									<ColumnDefinition Width="*" />
								</Grid.ColumnDefinitions>
								<Image Width="61"
									   Height="70"
									   Margin="2"
									   Source="{Binding ImagePath}"
									   Stretch="Fill" />
								<StackPanel Grid.Column="1"
											Margin="5 0 0 0"
											HorizontalAlignment="Left"
											VerticalAlignment="Top">
									<TextBlock Margin="0 5 0 0"
											   FontWeight="Bold"
											   Text="{Binding JobPosition}" />
									<TextBlock Width="80"
											   HorizontalAlignment="Left"
											   FontFamily="Segoe UI Light"
											   FontSize="19"
											   Foreground="#FFFFFFFF"
											   Text="{Binding FirstName}"
											   TextWrapping="Wrap" />
									<TextBlock Width="80"
											   HorizontalAlignment="Left"
											   FontFamily="Segoe UI Light"
											   FontSize="19"
											   Foreground="#FFFFFFFF"
											   Text="{Binding LastName}"
											   TextWrapping="Wrap" />
								</StackPanel>
							</Grid>
						</DataTemplate>
					</telerik:RadDiagramShape.ContentTemplate>
				</telerik:RadDiagramShape>
			</telerik:RadDiagram>
		</Grid>
	{{endregion}}

	![Rad Diagram Features Shapes Data Template](images/RadDiagram_Features_Shapes_DataTemplate.png)

## Connectors

Each __RadDiagramShape__ has 5 default connectors - Top, Right, Bottom, Left and Auto. Those are the predefined points where you can connect a __RadDiagramConnection__ to the shape.
![Rad Diagram Features Shapes Connectors](images/RadDiagram_Features_Shapes_Connectors.png)

* __Top__ - the connector point positioned in the middle of the top border of a shape			

* __Bottom__ - the connector point positioned in the middle of the bottom border of a shape			

* __Right__ - the connector point positioned in the middle of the right border of a shape			

* __Left__ - the connector point positioned in the middle of the left border of a shape			

* __Auto__ - the connector positioned at the center of a shape. If you attach a __RadDiagramConnection__ to this point, the connector point of the connection will dynamically change based on the shortest path to the shape.			

You can also define custom connectors as described in the [Custom Connectors]({%slug raddiagram-features-custom-connectors%}) tutorial. Or you can use the __gliding connectors__ feature exposed by the __RadDiagramShape__ class. This feature essentially says to a shape that it doesn't have any explicitly positioned connectors thus allowing a connection to glide through the edges of the shape. In order to use this feature you can set the __RadDiagramShape.UseGlidingConnector__ property to __True__. Moreover, this feature comes with a set of predefined shape forms determining the form of edges through which a gliding connection can slide. These shapes are described by the __GlidingStyle__ property, which is a __GlidingStyle__ enumeration exposing the following members:		

* __Rectangle__ - The connections attached to a gliding connector will glide along a rectangle with dimensions equal to the bounds of the shape.			

* __Ellipse__ - The connections attached to a gliding connector will glide along an ellipse with dimensions equal to the bounds of the shape.			

* __Diamond__ - The connections attached to a gliding connector will glide along a rhombus (diamond polygon) with dimensions equal to the bounds of the shape.			

* __RightTriangle__ - The connections attached to a gliding connector will glide along a right triangle with dimensions equal to the bounds of the shape.			

* __Triangle__ - The connections attached to a gliding connector will glide along a triangle with dimensions equal to the bounds of the shape.			

All connector points of a shape can be accessed through the __RadDiagramShape.Connectors__ property. It is a collection of __RadDiagramConnector__ items. Each item represents a __RadDiagramShape__ connector and can give you information about the coordinates of each connector point, its position and if the connector is active. A connector is active when the connection tool activates it in order to prepare it to start drawing a connection.		

If you want to change the default appearance of the connector points you can use the __RadDiagramShape.ConnectorStyle__ property to apply a custom style on them.		

## Common Properties

The __RadDiagramShape__ class exposes multiple properties that allow you to control the state and appearance of a shape.		

### Shape Bounds

You can get the bounds of a __RadDiagramShape__ through the __Bounds__ and __ActualBounds__ properties:			

* __Bounds__ - this property is of type __Rect__ and it gets the width, height and location of the shape's bounds.				

* __ActualBounds__ - this property is of type __Rect__ and it gets the width, height and location of a rotated shape's bounds.				

### Shape Connections

You can get all incoming and outgoing connections related to the shape through the following properties:			

* __IncomingLinks__ - this property is an enumeration that gets all incoming connections. It gives you information about the connections type, starting and ending points as well as the related connector positions.				

* __OutgoingLinks__ - this property is an enumeration that gets all outgoing connections. It gives you information about the connections type, starting and ending points as well as the related connector positions.				

### Rotation Angle

Telerik __RadDiagramShape__ supports rotation. You can get or set the rotation angle of a shape using the __RotationAngle__ property.			

### Edit Mode

You can set the __RadDiagramShape__ in edit mode using the __IsInEditMode__ property. By default when a shape enters edit mode, the __RadDiagramShape.Content__ is displayed inside a __TextBox__ control so that you can change its value. 
![Rad Diagram Features Shapes Edit String](images/RadDiagram_Features_Shapes_EditString.png)

If the __RadDiagramShape.Content__ property is bound to a business item, you can set the connection __EditTemplate__ to define how the business item will be edited. For example if we use the __BusinessItem__ class, defined above, as a __DataContext__ of the __RadDiagram__, we can set up the following connection:			

#### __XAML__

{{region raddiagram_features_shapes_4}}
    <Grid>
        <telerik:RadDiagram x:Name="MyDiagram">
            <telerik:RadDiagramShape Content="{Binding}"
                                     Position="20,40">
                <telerik:RadDiagramShape.ContentTemplate>
                    <DataTemplate>
                        <Grid Width="200"
                              Height="74"
                              Background="#FF9F9E9E">
                            <Grid.ColumnDefinitions>
                                <ColumnDefinition Width="Auto" />
                                <ColumnDefinition Width="*" />
                            </Grid.ColumnDefinitions>
                            <Image Width="61"
                                   Height="70"
                                   Margin="2"
                                   Source="{Binding ImagePath}"
                                   Stretch="Fill" />
                            <StackPanel Grid.Column="1"
                                        Margin="5 0 0 0"
                                        HorizontalAlignment="Left"
                                        VerticalAlignment="Top">
                                <TextBlock Margin="0 5 0 0"
                                           FontWeight="Bold"
                                           Text="{Binding JobPosition}" />
                                <TextBlock Width="80"
                                           HorizontalAlignment="Left"
                                           FontFamily="Segoe UI Light"
                                           FontSize="19"
                                           Foreground="#FFFFFFFF"
                                           Text="{Binding FirstName}"
                                           TextWrapping="Wrap" />
                                <TextBlock Width="80"
                                           HorizontalAlignment="Left"
                                           FontFamily="Segoe UI Light"
                                           FontSize="19"
                                           Foreground="#FFFFFFFF"
                                           Text="{Binding LastName}"
                                           TextWrapping="Wrap" />
                            </StackPanel>
                        </Grid>
                    </DataTemplate>
                </telerik:RadDiagramShape.ContentTemplate>
                <telerik:RadDiagramShape.EditTemplate>
                    <DataTemplate>
                        <StackPanel Orientation="Horizontal"
                                    VerticalAlignment="Center"
                                    HorizontalAlignment="Center">
                            <TextBox Text="{Binding FirstName}"
                                     Margin="5,0" />
                            <TextBox Text="{Binding LastName}"
                                     Margin="5,0" />
                        </StackPanel>
                    </DataTemplate>
                </telerik:RadDiagramShape.EditTemplate>
            </telerik:RadDiagramShape>
        </telerik:RadDiagram>
    </Grid>
{{endregion}}

![Rad Diagram Features Shapes Edit Template](images/RadDiagram_Features_Shapes_EditTemplate.png)

>Apart from setting the __IsInEditMode__ property to __True__, you can also enter edit mode by pressing __F2__ or double-clicking on the shape. For more information please refer to the [Items Editing]({%slug raddiagrams-features-edit%}) tutorial.			  

### Shape Selection State

The following properties allow you to track and control the selection state of a shape:

* __IsSelected__ - gets or sets whether the shape is selected.

### Shape ZIndex

You can get or set the z-order rendering behavior of the __RadDiagramShape__ through the __ZIndex__ property.			

## Customize the Shape Appearance

You can easily customize the visual appearance of the __RadDiagramShape__ by using the following properties:		

* __Background__ - gets or sets the brush that specifies the __RadDiagramShape__ background color.			

* __BorderBrush__ - gets or sets the brush that specifies the __RadDiagramShape__ border color.			

* __StrokeDashArray__ - gets or sets a collection of __Double__ values that indicate the pattern of dashes and gaps that is used to outline the __RadDiagramShape__.			

* __StrokeThickness__ - gets or sets the width of the __RadDiagramShape__ outline.			

>tip You can use the __RadDiagram.ShapeStyle__ property to explicitly apply a style on all __RadDiagramShapes__ in a __RadDiagram__ instance. [Read more]({%slug raddiagram-styling-selectors%}#customize-the-raddiagramshape-style).		  

## See Also
 * [Structure]({%slug raddiagram-structure%})
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [DataBinding Overview]({%slug raddiagram-data-overview%})
 * [Connections]({%slug raddiagrams-features-connections%})
 * [Items Editing]({%slug raddiagrams-features-edit%})
 * [Rotation]({%slug raddiagrams-features-rotation%})
 * [Resizing]({%slug raddiagrams-features-resizing%})
 * [ZOrder]({%slug raddiagrams-features-zorder%})
 * [Selection]({%slug raddiagrams-features-selection%})
 * [Removing Items]({%slug raddiagrams-features-delete%})
 * [Diagram Events]({%slug raddiagrams-events-diagram%})
 * [Items Events]({%slug raddiagrams-events-item%})