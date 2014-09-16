---
title: Shapes
page_title: Shapes
description: Shapes
slug: raddiagrams-features-shapes
tags: shapes
publish: True
position: 0
---

# Shapes



This tutorial will walk you through the functionality and the main features of the __RadDiagramShape__.
	  

## Overview

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the
			{% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}
			article you can find more information on how to set an application-wide theme.
		  

The __RadDiagramShape__ is an object that describes the nodes of the diagram. You can configure its form using the __Geometry__ property as it allows you to define a custom geometry:
		

	
            <telerik:RadDiagramShape Width="80"
                                     Height="80"
                                     Geometry="M16.35,6.39 C16.28,7.36 12.26,20.45 12.26,20.45 L20.56,20.45 C20.56,20.45 16.64,7.54 16.53,6.39 z M12.30,0.50 L20.97,0.50 L32.50,33.50 L24.54,33.50 L22.23,26.16 L10.70,26.16 L8.42,33.50 L0.50,33.50 z"
                                     Position="160,80" />
		  

![Rad Diagram Features Shapes Custom Shape](images/RadDiagram_Features_Shapes_CustomShape.png)

or to use one of the predefined shape geometries:
		

	
<telerik:RadDiagramShape x:Name="ConditionShape"
                Width="80"
                Height="80"
                Content="condition"
                FontWeight="Bold"
                Geometry="{telerik:FlowChartShape ShapeType=PredefinedShape}"
                Position="160,80" />
		  



	
RadDiagramShape shape = new RadDiagramShape();
shape.Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.PredefinedShape);
		  



	
Dim shape As New RadDiagramShape()
shape.Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.PredefinedShape)
		  



>The __ShapeFactory__ class allows you to get a shape geometry from the __enums__ with predefined shapes. This way you can create a __RadDiagramShape__ in code-behind still taking advantage of the predefined list of shapes.
		  The predefined shapes can be accesses in code-behind through the following enumerations:

* __ArrowShapeType__ - describes all ArrowShapes
			  

* __CommonShapeType__ - describes all CommonShapes
			  

* __FlowChartShapeType__ - describes all FlowChartShapes
			  ![Rad Diagram Features Shapes Predefined Shape](images/RadDiagram_Features_Shapes_PredefinedShape.png)

## Diagramming Framework Predefined Shape Geometries

__Telerik Diagramming Framework__ provides three types of predefined shape geometries - __ArrowShapes__, __CommonShapes__ and __FlowChartShapes__. For each of these types the framework exposes xaml markup extensions that can be applied at the __RadDiagramShape.Geometry__ property as a shortcut way of creating a shape.
		

### ArrowShapes
<table>
				A list of all predefined ArrowShapes:
			  <tr><td>

Arrow1![Rad Diagram Features Shapes Arrow 1](images/RadDiagram_Features_Shapes_Arrow1.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:ArrowShape ShapeType=Arrow1}" />					  
					  

</td><td>

Arrow2![Rad Diagram Features Shapes Arrow 2](images/RadDiagram_Features_Shapes_Arrow2.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:ArrowShape ShapeType=Arrow2}" />				  
					  

</td><td>

Arrow3![Rad Diagram Features Shapes Arrow 3](images/RadDiagram_Features_Shapes_Arrow3.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:ArrowShape ShapeType=Arrow3}" />				  
					  

</td></tr><tr><td>

Arrow4![Rad Diagram Features Shapes Arrow 4](images/RadDiagram_Features_Shapes_Arrow4.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:ArrowShape ShapeType=Arrow4}" />				  
					  

</td><td>

Arrow5![Rad Diagram Features Shapes Arrow 5](images/RadDiagram_Features_Shapes_Arrow5.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:ArrowShape ShapeType=Arrow5}"/>				  
					  

</td><td>

Arrow6![Rad Diagram Features Shapes Arrow 6](images/RadDiagram_Features_Shapes_Arrow6.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:ArrowShape ShapeType=Arrow6}" />				  
					  

</td></tr><tr><td>

Arrow7![Rad Diagram Features Shapes Arrow 7](images/RadDiagram_Features_Shapes_Arrow7.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:ArrowShape ShapeType=Arrow7}"/>				  
					  

</td><td>

Arrow8![Rad Diagram Features Shapes Arrow 8](images/RadDiagram_Features_Shapes_Arrow8.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:ArrowShape ShapeType=Arrow8}"/>				  
					  

</td><td>

DoubleArrow1![Rad Diagram Features Shapes Double Arrow 1](images/RadDiagram_Features_Shapes_DoubleArrow1.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:ArrowShape ShapeType=DoubleArrow1}" />				  
					  

</td></tr><tr><td>

DoubleArrow2![Rad Diagram Features Shapes Double Arrow 2](images/RadDiagram_Features_Shapes_DoubleArrow2.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:ArrowShape ShapeType=DoubleArrow2}" />				  
					  

</td><td>

DoubleArrow3![Rad Diagram Features Shapes Double Arrow 3](images/RadDiagram_Features_Shapes_DoubleArrow3.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:ArrowShape ShapeType=DoubleArrow3}" />				  
					  

</td><td>

DoubleArrow4![Rad Diagram Features Shapes Double Arrow 4](images/RadDiagram_Features_Shapes_DoubleArrow4.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:ArrowShape ShapeType=DoubleArrow4}" />				  
					  

</td></tr><tr><td>

DoubleArrow5![Rad Diagram Features Shapes Double Arrow 5](images/RadDiagram_Features_Shapes_DoubleArrow5.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:ArrowShape ShapeType=DoubleArrow5}" />				  
					  

</td><td></td><td></td></tr></table>

### CommonShapes
<table>
				A list of all predefined CommonShapes:
			  <tr><td>

CloudShape![Rad Diagram Features Shapes Cloud Shape](images/RadDiagram_Features_Shapes_CloudShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:CommonShape 
					 ShapeType=CloudShape}" />				  
					  

</td><td>

Cross2Shape![Rad Diagram Features Shapes Cross 2 Shape](images/RadDiagram_Features_Shapes_Cross2Shape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:CommonShape 
					 ShapeType=Cross2Shape}"/>				  
					  

</td><td>

CrossShape![Rad Diagram Features Shapes Cross Shape](images/RadDiagram_Features_Shapes_CrossShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:CommonShape 
					 ShapeType=CrossShape}" />				  
					  

</td></tr><tr><td>

EllipseShape![Rad Diagram Features Shapes Ellipse Shape](images/RadDiagram_Features_Shapes_EllipseShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:CommonShape 
					 ShapeType=EllipseShape}" />				  
					  

</td><td>

HexagonShape![Rad Diagram Features Shapes Hexagon Shape](images/RadDiagram_Features_Shapes_HexagonShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:CommonShape 
					 ShapeType=HexagonShape}"/>				  
					  

</td><td>

OctagonShape![Rad Diagram Features Shapes Octagon Shape](images/RadDiagram_Features_Shapes_OctagonShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:CommonShape 
					 ShapeType=OctagonShape}" />				  
					  

</td></tr><tr><td>

PentagonShape![Rad Diagram Features Shapes Pentagon Shape](images/RadDiagram_Features_Shapes_PentagonShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:CommonShape 
					 ShapeType=PentagonShape}" />				  
					  

</td><td>

RectangleShape![Rad Diagram Features Shapes Rectangle Shape](images/RadDiagram_Features_Shapes_RectangleShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:CommonShape 
					 ShapeType=RectangleShape}"/>				  
					  

</td><td>

RightTriangleShape![Rad Diagram Features Shapes Right Triangle Shape](images/RadDiagram_Features_Shapes_RightTriangleShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:CommonShape 
					 ShapeType=RightTriangleShape}" />				  
					  

</td></tr><tr><td>

RoundedRectangleShape![Rad Diagram Features Shapes Rounded Rectangle Shape](images/RadDiagram_Features_Shapes_RoundedRectangleShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:CommonShape 
					 ShapeType=RoundedRectangleShape}" />				  
					  

</td><td>

Star5Shape![Rad Diagram Features Shapes Star 5 Shape](images/RadDiagram_Features_Shapes_Star5Shape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:CommonShape 
					 ShapeType=Star5Shape}"/>				  
					  

</td><td>

Star6Shape![Rad Diagram Features Shapes Star 6 Shape](images/RadDiagram_Features_Shapes_Star6Shape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:CommonShape 
					 ShapeType=Star6Shape}" />				  
					  

</td></tr><tr><td>

Star7Shape![Rad Diagram Features Shapes Star 7 Shape](images/RadDiagram_Features_Shapes_Star7Shape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:CommonShape 
					 ShapeType=Star7Shape}" />				  
					  

</td><td>

TriangleShape![Rad Diagram Features Shapes Triangle Shape](images/RadDiagram_Features_Shapes_TriangleShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:CommonShape 
					 ShapeType=TriangleShape}"/>				  
					  

</td><td></td></tr></table>

### FlowChartShapes
<table>
				A list of all predefined FlowChartShapes:
			  <tr><td>

BeginLoopShape![Rad Diagram Features Shapes Begin Loop Shape](images/RadDiagram_Features_Shapes_BeginLoopShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=BeginLoopShape}" />				  
					  

</td><td>

CardShape![Rad Diagram Features Shapes Card Shape](images/RadDiagram_Features_Shapes_CardShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=CardShape}"/>				  
					  

</td><td>

CollateShape![Rad Diagram Features Shapes Collate Shape](images/RadDiagram_Features_Shapes_CollateShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=CollateShape}" />				  
					  

</td></tr><tr><td>

CreateRequestShape![Rad Diagram Features Shapes Create Request Shape](images/RadDiagram_Features_Shapes_CreateRequestShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=CreateRequestShape}" />				  
					  

</td><td>

Database1Shape![Rad Diagram Features Shapes Database 1 Shape](images/RadDiagram_Features_Shapes_Database1Shape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=Database1Shape}"/>				  
					  

</td><td>

Database2Shape![Rad Diagram Features Shapes Database 2 Shape](images/RadDiagram_Features_Shapes_Database2Shape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=Database2Shape}" />				  
					  

</td></tr><tr><td>

Database3Shape![Rad Diagram Features Shapes Database 3 Shape](images/RadDiagram_Features_Shapes_Database3Shape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape
					 ShapeType=Database3Shape}"/>				  
					  

</td><td>

DataShape![Rad Diagram Features Shapes Data Shape](images/RadDiagram_Features_Shapes_DataShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=DataShape}" />				  
					  

</td><td>

DataStoreShape![Rad Diagram Features Shapes Data Store Shape](images/RadDiagram_Features_Shapes_DataStoreShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=DataStoreShape}" />				  
					  

</td></tr><tr><td>

DecisionShape![Rad Diagram Features Shapes Decision Shape](images/RadDiagram_Features_Shapes_DecisionShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=DecisionShape}"/>				  
					  

</td><td>

DelayShape![Rad Diagram Features Shapes Delay Shape](images/RadDiagram_Features_Shapes_DelayShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=DelayShape}" />				  
					  

</td><td>

DevidedProcessShape![Rad Diagram Features Shapes Devided Process Shape](images/RadDiagram_Features_Shapes_DevidedProcessShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=DevidedProcessShape}" />				  
					  

</td></tr><tr><td>

DirectDataShape![Rad Diagram Features Shapes Direct Data Shape](images/RadDiagram_Features_Shapes_DirectDataShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=DirectDataShape}"/>				  
					  

</td><td>

DisplayShape![Rad Diagram Features Shapes Display Shape](images/RadDiagram_Features_Shapes_DisplayShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=DisplayShape}" />				  
					  

</td><td>

DocumentShape![Rad Diagram Features Shapes Document Shape](images/RadDiagram_Features_Shapes_DocumentShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=DocumentShape}" />				  
					  

</td></tr><tr><td>

DuplicatingShape![Rad Diagram Features Shapes Duplicating Shape](images/RadDiagram_Features_Shapes_DuplicatingShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=DuplicatingShape}"/>				  
					  

</td><td>

ExternalDataShape![Rad Diagram Features Shapes External Data Shape](images/RadDiagram_Features_Shapes_ExternalDataShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=ExternalDataShape}" />				  
					  

</td><td>

FeedbackShape![Rad Diagram Features Shapes Feedback Shape](images/RadDiagram_Features_Shapes_FeedbackShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=FeedbackShape}" />				  
					  

</td></tr><tr><td>

FramedRectangleShape![Rad Diagram Features Shapes Framed Rectangle Shape](images/RadDiagram_Features_Shapes_FramedRectangleShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=FramedRectangleShape}"/>				  
					  

</td><td>

InternalStorageShape![Rad Diagram Features Shapes Internal Storage Shape](images/RadDiagram_Features_Shapes_InternalStorageShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=InternalStorageShape}" />				  
					  

</td><td>

LinedDocumentShape![Rad Diagram Features Shapes Lined Document Shape](images/RadDiagram_Features_Shapes_LinedDocumentShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=LinedDocumentShape}" />				  
					  

</td></tr><tr><td>

LoopLimitShape![Rad Diagram Features Shapes Loop Limit Shape](images/RadDiagram_Features_Shapes_LoopLimitShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=LoopLimitShape}"/>				  
					  

</td><td>

ManualInputShape![Rad Diagram Features Shapes Manual Input Shape](images/RadDiagram_Features_Shapes_ManualInputShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=ManualInputShape}" />				  
					  

</td><td>

ManualOperationShape![Rad Diagram Features Shapes Manual Operation Shape](images/RadDiagram_Features_Shapes_ManualOperationShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=ManualOperationShape}" />				  
					  

</td></tr><tr><td>

MessageFromUserShape![Rad Diagram Features Shapes Message From User Shape](images/RadDiagram_Features_Shapes_MessageFromUserShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=MessageFromUserShape}"/>				  
					  

</td><td>

MessageToUserShape![Rad Diagram Features Shapes Message To User Shape](images/RadDiagram_Features_Shapes_MessageToUserShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=MessageToUserShape}" />				  
					  

</td><td>

MicroformProcessingShape![Rad Diagram Features Shapes Microform Processing Shape](images/RadDiagram_Features_Shapes_MicroformProcessingShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=MicroformProcessingShape}" />				  
					  

</td></tr><tr><td>

MicroformRecordingShape![Rad Diagram Features Shapes Microform Recording Shape](images/RadDiagram_Features_Shapes_MicroformRecordingShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=MicroformRecordingShape}"/>				  
					  

</td><td>

MultipleDocumentShape![Rad Diagram Features Shapes Multiple Document Shape](images/RadDiagram_Features_Shapes_MultipleDocumentShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=MultipleDocumentShape}" />				  
					  

</td><td>

OffPageConnectionShape![Rad Diagram Features Shapes Off Page Connection Shape](images/RadDiagram_Features_Shapes_OffPageConnectionShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=OffPageConnectionShape}" />				  
					  

</td></tr><tr><td>

OffPageLinkShape![Rad Diagram Features Shapes Off Page Link Shape](images/RadDiagram_Features_Shapes_OffPageLinkShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=OffPageLinkShape}"/>				  
					  

</td><td>

OffPageReflectionShape![Rad Diagram Features Shapes Off Page Reflection Shape](images/RadDiagram_Features_Shapes_OffPageReflectionShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=OffPageReflectionShape}" />				  
					  

</td><td>

OrShape![Rad Diagram Features Shapes Or Shape](images/RadDiagram_Features_Shapes_OrShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=OrShape}" />				  
					  

</td></tr><tr><td>

PaperTapeShape![Rad Diagram Features Shapes Paper Tape Shape](images/RadDiagram_Features_Shapes_PaperTapeShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=PaperTapeShape}"/>				  
					  

</td><td>

PredefinedShape![Rad Diagram Features Shapes Predefined Shape](images/RadDiagram_Features_Shapes_PredefinedShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=PredefinedShape}"  />				  
					  

</td><td>

PreparationShape![Rad Diagram Features Shapes Preparation Shape](images/RadDiagram_Features_Shapes_PreparationShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=PreparationShape}" />				  
					  

</td></tr><tr><td>

PrimitiveFromCallShape![Rad Diagram Features Shapes Primitive From Call Shape](images/RadDiagram_Features_Shapes_PrimitiveFromCallShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=PrimitiveFromCallShape}"/>				  
					  

</td><td>

PrimitiveToCallShape![Rad Diagram Features Shapes Primitive To Call Shape](images/RadDiagram_Features_Shapes_PrimitiveToCallShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=PrimitiveToCallShape}"  />				  
					  

</td><td>

SequentialDataShape![Rad Diagram Features Shapes Sequential Data Shape](images/RadDiagram_Features_Shapes_SequentialDataShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=SequentialDataShape}" />				  
					  

</td></tr><tr><td>

SortShape![Rad Diagram Features Shapes Sort Shape](images/RadDiagram_Features_Shapes_SortShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=SortShape}"/>				  
					  

</td><td>

StartShape![Rad Diagram Features Shapes Start Shape](images/RadDiagram_Features_Shapes_StartShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=StartShape}"  />				  
					  

</td><td>

StoredDataShape![Rad Diagram Features Shapes Stored Data Shape](images/RadDiagram_Features_Shapes_StoredDataShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=StoredDataShape}" />				  
					  

</td></tr><tr><td>

SummingJunctionShape![Rad Diagram Features Shapes Summing Junction Shape](images/RadDiagram_Features_Shapes_SummingJunctionShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=SummingJunctionShape}"/>				  
					  

</td><td>

TerminatorShape![Rad Diagram Features Shapes Terminator Shape](images/RadDiagram_Features_Shapes_TerminatorShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=TerminatorShape}"  />				  
					  

</td><td>

TransmittalTapeShape![Rad Diagram Features Shapes Transmittal Tape Shape](images/RadDiagram_Features_Shapes_TransmittalTapeShape.png)

	
<telerik:RadDiagramShape 
  Geometry="{telerik:FlowChartShape 
					 ShapeType=TransmittalTapeShape}" />				  
					  

</td></tr></table>

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

* Bind the __Content__ to a business property:
			For the purpose of this tutorial, let's define a sample business class and set it as the __DataContext__ of the {% if site.site_name == 'Silverlight' %}UserControl{% endif %}{% if site.site_name == 'WPF' %}Window{% endif %}.
			

	
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
				



#### __XAML__

{{region raddiagram_features_shapes_2}}
	    <Grid>
	        <telerik:RadDiagram x:Name="MyDiagram">
	            <telerik:RadDiagramShape Content="{Binding LastName}"
	                                     Position="20,40" />
	        </telerik:RadDiagram>
	    </Grid>
	{{endregion}}

![Rad Diagram Features Shapes Data Binding](images/RadDiagram_Features_Shapes_DataBinding.png)When you bind the __Content__ to a business class, the __RadDiagramShape__ will display the result of the business item __ToString()__ method. If you bind to a business property, then the value of the property will be displayed as the content of the shape.
			

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
				

* __IsSelectedInGroup__ - gets a value indicating whether this shape is selected in a group.
				

### Shape ZIndex

You can get or set the z-order rendering behavior of the __RadDiagramShape__ through the __ZIndex__ property.
			

## Customize the Shape Appearance

You can easily customize the visual appearance of the __RadDiagramShape__ by using the following properties:
		

* __Background__ - gets or sets the brush that specifies the __RadDiagramShape__ background color.
			

* __BorderBrush__ - gets or sets the brush that specifies the __RadDiagramShape__ border color.
			

* __StrokeDashArray__ - gets or sets a collection of __Double__ values that indicate the pattern of dashes and gaps that is used to outline the __RadDiagramShape__.
			

* __StrokeThickness__ - gets or sets the width of the __RadDiagramShape__ outline.
			

>tipYou can use the __RadDiagram.ShapeStyle__ property to explicitely apply a style on all __RadDiagramShapes__ in a __RadDiagram__ instance. [Read more](2ab56752-2384-426a-926c-34fc2108c2e6#ShapeStyles).
		  

# See Also

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
