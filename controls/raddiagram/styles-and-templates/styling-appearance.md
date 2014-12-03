---
title: Customize Appearance
page_title: Customize Appearance
description: Customize Appearance
slug: raddiagram-styling-appearance
tags: customize,appearance
published: True
position: 1
---

# Customize Appearance

This article describes how to customize the appearance of the __RadDiagram__,__RadDrigramShape__ and __RadDiagramConnection__ through a set of properties exposed by their API.	  

## Customizing the RadDiagram Appearance

### Controlling the Diagramming Surface Appearance

You can control the background settings of the diagramming surface through the following set of properties:

* __IsBackgroundSurfaceVisible__ - a __Boolean__ property that determines whether the background surface of the __RadDiagram__ should be displayed. When set to __true__ both the background grid and the [Preview Pages canvas](a0973f36-f74e-44df-ac8f-d124c3e948aa#PagesPreview) are displayed. Its default value is __true__.
![Rad Diagram Styling Background Surface](images/RadDiagram_Styling_BackgroundSurface.png)

* __Background__ - this property is of type __Brush__ and it controls the fill of the __RadDiagram__ background.
![Rad Diagram Styling Background](images/RadDiagram_Styling_Background.png)

The settings and appearance of the __RadDiagram__ background grid are controlled through the following set of attached properties:			  

>You can access the __BackgroundGrid__ attached properties through an alias pointing to the __Telerik.Windows.Controls.Diagrams.Primitives__ namespace:  `xmlns:primitives="clr-namespace:Telerik.Windows.Controls.Diagrams.Primitives;assembly=Telerik.Windows.Controls.Diagrams"` or by adding a using for the __Telerik.Windows.Controls.Diagrams.Primitives__ namespace in your code-behind file.

* __BackgroundGrid.IsGridVisible__ - this is a __Boolean__ property that controls the visibility of the background grid. Its default value is __True__.				
	
	#### __XAML__
		<telerik:RadDiagram primitives:BackgroundGrid.IsGridVisible="True" />					  
				
* __BackgroundGrid.IsDynamic__ - this is a __Boolean__ property that determines whether the background grid should be moved and resized accordingly to the __RadDiagram__ viewport changes (panning and zooming). Its default value is __True__ thus enabling the background grid to reflect the changes implemented by a pan and/or a zoom operation.
				
	#### __XAML__
		<telerik:RadDiagram primitives:BackgroundGrid.IsDynamic="True" />

* __BackgroundGrid.CellSize__ - this property is of type __Size__ and it controls the size of the cells in the __RadDiagram.GraphPaper__ surface. The default value of this property is a size of __20x20__ units.				

	#### __XAML__
		<telerik:RadDiagram primitives:BackgroundGrid.CellSize="40,40" />					  

* __BackgroundGrid.LineStroke__ - this property is of type __Brush__ and it specifies how the cells outline is painted.				

	#### __XAML__
		<telerik:RadDiagram primitives:BackgroundGrid.LineStroke="Red" />  					  					  

	![Rad Diagram Styling Line Stroke](images/RadDiagram_Styling_LineStroke.png)

* __BackgroundGrid.LineStrokeDashArray__ - this property gets or sets a collection of __Double__ values that indicate the pattern of dashes and gaps that is used to outline the cells in the __RadDiagram GraphPaper__.				

* __BackgroundGrid.LineStrokeThickness__ - this property is of type __double__ and it gets or sets the thickness of the __RadDiagram__ background grid lines.				

	#### __XAML__
		<telerik:RadDiagram primitives:BackgroundGrid.LineThickness="5" />					  					  

	![Rad Diagram Styling Line Thickness](images/RadDiagram_Styling_LineThickness.png)
	
>tip If you need to customize the appearance and the settings of the __RadDiagram__ PagesPreview canvas, you can examine the [Pages Preview](a0973f36-f74e-44df-ac8f-d124c3e948aa#PagesPreview) section in the __Printing__ article.

### DiagramAdorners

The __RadDiagram__ exposes a set of properties that allow you to control which Diagramming adorners to be displayed:			

* __IsInformationAdornerVisible__ - a __Boolean__ property that controls the visibility of the __InformationAdorner__ of the __RadDiagram__. The __InformationAdorner__ displays information about the diagram's elements settings like current position and rotation angle. The default value of the __IsInformationAdornerVisible__ property is __true__.
	![Rad Diagram Styling Info Adorner](images/RadDiagram_Styling_InfoAdorner.png)

* __IsManipulationAdornerVisible__ - a __Boolean__ property that controls the visibility of the __ManipulationAdorner__ of the __RadDiagram__. The __ManipulationAdorner__ visualizes the resizing and rotation thumbs of the __RadDiagram__ elements. It also visualizes selections. The default value of the __IsManipulationAdornerVisible__ property is __true__.
	![Rad Diagram Styling Manipulation Adorner](images/RadDiagram_Styling_ManipulationAdorner.png)

* __IsConnectorsManipulationEnabled__ - a __Boolean__ property that controls the visibility of the __RadDiagram__ elements connectors. The default value of the property is __true__.
	![Rad Diagram Styling Connectors Visibility](images/RadDiagram_Styling_ConnectorsVisibility.png)

The __RadDiagram__ also contains __AlignmentAdorner__. This adorner provides visual feedback about the alignment of the Diagramming elements.			

>The __AlignmentAdorner__ definition is placed in the __Telerik.Windows.Controls.Diagrams.Primitives__ namespace. This is why in order to control its settings, you need to add an alias to that namespace:			  >`xmlns:primitives="clr-namespace:Telerik.Windows.Controls.Diagrams.Primitives;assembly=Telerik.Windows.Controls.Diagrams"`
>`<telerik:RadDiagram primitives:AlignmentAdorner.VerticalLineStroke="Blue"/>`

The __RadDiagram__ allows you to control the following properties of the __AlignmentAdorner__:			

* __AlignmentAdorner.HorizontalLineStroke__ - this property is of type __Brush__ and it specifies how the horizontal alignment lines are painted.				

* __AlignmentAdorner.HorizontalLineStrokeDashArray__ - this property gets or sets a collection of __Double__ values that indicate the pattern of dashes and gaps that is used to outline the horizontal alignment lines.				

* __AlignmentAdorner.HorizontalLineStrokeThickness__ - this property is of type __double__ and it gets or sets the thickness of the horizontal alignment lines.				

* __AlignmentAdorner.VerticalLineStroke__ - this property is of type __Brush__ and it specifies how the vertical alignment lines are painted.				

* __AlignmentAdorner.VerticalLineStrokeDashArray__ - this property is of type __Brush__ and it specifies how the vertical alignment lines are painted.				

* __AlignmentAdorner.VerticalLineStrokeThickness__ - this property gets or sets a collection of __Double__ values that indicate the pattern of dashes and gaps that is used to outline the vertical alignment lines.				

## Customizing the RadDiagramShape Appearance

You can easily customize the visual appearance of the __RadDiagramShape__ by using the following properties:		

* __Background__ - gets or sets the brush that specifies the __RadDiagramShape__ background color.			

* __BorderBrush__ - gets or sets the brush that specifies the __RadDiagramShape__ border color.			

* __StrokeDashArray__ - gets or sets a collection of __Double__ values that indicate the pattern of dashes and gaps that is used to outline the __RadDiagramShape__.			

* __StrokeThickness__ - gets or sets the width of the __RadDiagramShape__ outline.			

You can also control what visual information should be displayed on a __RadDiagramShape__ through the following set of properties:		

* __IsConnectorsManipulationEnabled__ - a __Boolean__ property that controls the visibility of the __RadDiagramShape__ connectors. The default value of the property is __true__.			

* __IsManipulationAdornerVisible__ - a __Boolean__ property that controls the visibility of the __ManipulationAdorner__ of the __RadDiagramShape__. The __ManipulationAdorner__ visualizes the resizing and rotation thumbs of the shape, along with the selections it is part of. The default value of the __IsManipulationAdornerVisible__ property is __true__.			

* __IsResizingEnabled__ - a __Boolean__ property that controls the resizing functionality of the shape along with the visibility of the resizing thumb. Its default value is __True__.			

* __IsRotationEnabled__- a __Boolean__ property that controls the visibility of the rotation thumb as well as the rotation functionality of the shape. Its default value is __True__.			

* __IsDraggingEnabled__ - a __Boolean__ property that controls the dragging functionality of the shape, along with teh visibility of the dragging thumb. Its default value is __True__.			

## Customizing the RadDiagramConnection Appearance

You can easily customize the visual appearance of the __RadDiagramConnection__ by using the following properties:		

* __Stroke__ - gets or sets the brush that specifies how the __RadDiagramConnection__ is painted.			

* __StrokeDashArray__ - gets or sets a collection of __Double__ values that indicate the pattern of dashes and gaps that is used to outline the __RadDiagramConnection__.			

* __StrokeThickness__ - gets or sets the width of the __RadDiagramConnection__ outline.			

* __Background__ - gets or sets the brush that specifies the __SourceCap__ and __TargetCap__ inner background.