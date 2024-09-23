---
title: Changes
page_title: Changes
description: Check our &quot;Changes&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagram-changes
tags: changes
published: True
position: 1
---

# Changes

This article describes the release history of the RadDiagram framework.

To see the fixes and features included in our latest official release please refer to our {% if site.site_name == 'Silverlight' %} [Release History](http://www.telerik.com/support/whats-new/silverlight/release-history) {% endif %} {% if site.site_name == 'WPF' %} [Release History](http://www.telerik.com/support/whats-new/wpf/release-history) {% endif %}.

## 2024 Q3 SP1

### What's New

* RadDiagram requires registering the custom types of shapes, connections, and connectors, in order to deserialize them successfully. Read more about this change [here]({%slug raddiagrams-features-serialization%}#allowing-tafe-types-and-assemblies).

## 2014 Q1

### What's Fixed

* Connectors' activation doesn't work correctly with collapsed items

* When zooming, the ManipulationAdorner should not be scaled.

### What's New

* Add additional/optional boolean parameter in Layout/LayoutAsync methods to support AutoFit.

	>Instead of adding a new boolean paramether, a new method was exposed - __AutoFitAsync()__. It is further described in the [Pan And Zoom]({%slug raddiagrams-features-pan-zoom%}) tutorial. 				

* Extend the serialization/deserialization of custom RadDiagramConnectors 

* Extensibility points for MouseTools 

	>You can examine the [Tools Customization]({%slug raddiagram-tools-customization%}) tutorial for more information.				  

## 2013 Q2

### What's Fixed

* Auto opening of VS 2012's design view  

* BackgroundGrid mismatches the ruler 

* Cannot create a connection to restored shape 

* Can't delete associated connections with a shape 

* Inconsistence in the ConnectionManipulationCompleted event logic 

* Offset property of connectors is not updated in data binding scenarios 

* RadDiagram doesn't handle the drop operation correctly

* Ruler's values are not updated when Pan is performed through the NavigationPane 

* Setting SnapX or SnapY to 1 hides ItemsToItems snapping lines 

* SettingsPane issues when setting Win8/Win8Touch application theme with StyleManager

* The items collection is not cleared on GraphSourceItems reset

* The SelectionRectangle is shown as a dot before first rectangle selection 

* Undo/Redo Not working properly when GraphSourse is used 

* You can't use the Path/PencilTool in MVVM scenarios {% if site.site_name == 'WPF' %}

* In WPF a connection manipulation cannot be completed outside the bounds of the RadDiagram {% endif %}

### What's New

* Add ItemsChanging event 

* Add public Export method 

* Change default zooming to be geometrical progression 

* Collapsible containers 

* Connections creation using tools should be delayed 

* Define a "drag restricted" area in RadDiagram

* Expose properties to control the Stroke and StrokeThickness of the Path element in the RadGeometryButtons 

* Extensibility points for SettingsPane 

* Implement an ability to display the SettingsPane only for certain diagram items 

* Improve print quality 

* Manipulation points for the corners and straight parts of a polyline connection

* Mouse Position Indicator in Ruler

* PreviewPositionChanged should be added 

* Provide an offset parameter to the ruler

* Provide possibility to use DragDropManager with the RadDiagram 

* Zoom step customization 

## 2013 Q1

### What's Fixed

* The SettingsPane throws an exception when in RadTab

* Moving ContainerShape containing a Shape is trying to snap to the shape's original position

* Container shapes are snapped to themselves

* When using touch theme the SettingsPane is hard to be opened

* IsMouseOver property is not set correctly in SL when using touch gestures

* Exception When using Cut Command in OOB application

* Incorrect behavior when pasting cut item

* Polyline connections are misplaced when created with mouse

* Focus is not received in the Diagram when clicking a selected Shape

* Brush properties cannot be deserialized

* Changing GraphSource when Thumbnail is Open is too slow

* Exception when creating a Polyline Connection from a Custom Connector

* Exception when setting the DataContext to an UIElement

* Pressing delete button when editing item with empty content delete the item

* Settings Pane is cut in horizontal connection

### What's New

* Ability to add Manipulation points to polyline connections in runtime

* Pages preview on canvas

* Resizable Grid

* Improve the Serialization

* By default diagram and shapes positions should not be fractions

* Provide move commands

* KeyBindings - Groups, Containers and others

* A shape should be aware of its parent ContainerShape

* Create an easy to use system to customize the services

* Extensibility Points for Snapping Functionality

* Text tool

* MVVM and containers integration

* Connections bridges

* Add event notifying that all shapes are prepared for layout

## 2012 Q3

### What's Fixed

* Fixed: Performance issues when GraphSource is set to null

* Fixed: AutoFit is performed on load, then panning does not work correctly

* Fixed: Connection's EditTemplate does not work correctly

* Fixed: ContainerShape's ContainerLayout = Fixed doesn't work as expected

* Fixed: Create IsEditable property on Diagram Item level

* Fixed: Dragging a floating connection throws an exception

* Fixed: Exception is raised if connectors with empty name are added

* Fixed: Min/Max(Width|Height) properties must be serialized and deserialized

* Fixed: Resizing respects MinWidth and MinHeight but not MaxWidth and MaxHeight

* Fixed: Scrollbars should be update on first loading of diagram

* Fixed: Shape is not removed from parent ContainerShape's Items collection when moved in a child ContainerShape

* Fixed: Snap to items doesn't work in some cases

* Fixed: Strange behavior of ContainerShape when its position is set

* Fixed: Strange bounce when moving a Shape out of ContainerShape

* Fixed: Telerik expandable controls doesn't work correct in rotated Shapes

* Fixed: The Minimap and the PrintPreview should not take into account the collapsed items

* Fixed: The slider in the PrintPreview doesn't work properly

* Fixed: The ticks in the ruler disappear if the diagram's zoom is greater than default maximum zoom

* Fixed: Turning virtualization off changes the collapsed shapes to visible

* Fixed: Zoom (Position) and Viewport properties are not synchronized when using animations 

### What's New{% if site.site_name == 'WPF' %}

* Feature: Ability to paste shapes from Visio{% endif %}

* Feature: Visual Containers

* Feature: Thumbnail container control

* Feature: DrawingTools: Introduce mechanism (property) to control the strokethickness and stroke of the drawing line/curve

* Feature: PathTool should show the new state of the figure-in-creation on every new anchor point creation (like in Blend)

* Feature: Allow free hand drawing

* Feature: Polygon drawing tool (pen)

* Feature: Print preview re-design

* Feature: Ruler Smart Scaling

* Feature: Optimize Ruler performance

* Feature: Implement Touch gestures

* Feature: Ruller Code Quality and Extensibility Improvement

* Feature: Diagram's design time - wizard

* Feature: Refactor and improve tools related services

* Feature: Create proper UI Automation peers

* Feature: Provide better API for enable/disable manipulation properties per shape

* Feature: Gliding connectors

* Feature: Create an example in the QSF that is based on visual objects - charts, grids...

## 2012 Q2

### What's Fixed

* Fixed: Exception when setting the DataContext to an UIElement

### What's New

* Feature: Horizontal and Vertical Rulers

* Feature: Implement scrolling functionality

* Feature: Ability to limit the number of connections to a shape

* Feature: Printing

* Feature: Different Tree Layouts 

* Feature: Org. Grid Router – algorithm for positioning of polyline connections. 

* Feature: Bi-directional MVVM data-binding support 

* Feature: Groups allowing to group shapes and connections 

* Feature: Custom Connectors  

* Feature: Bezier connections

* Feature: Allow bringing item(s) into view  

* Feature: New Diagram Extensions Assembly that contains new controls, features and extensions of the Diagramming framework like a Thumbnail a.k.a. Mini Map, Print Preview , Ruler, Built-in Toolbox and Built-in Settings Pane.