---
title: Custom Connectors
page_title: Custom Connectors
description: Check our &quot;Custom Connectors&quot; documentation article for the RadDiagram {{ site.framework_name }} control.
slug: raddiagram-features-custom-connectors
tags: custom,connectors
published: True
position: 0
---

# Custom Connectors

Custom Connectors increase your experience when using __Diagrams__ by enabling you to define custom connector points around the shapes.	

## Defining Custom Connectors

By default a shape has five connectors:		

* Four (Left, Right, Top, Bottom) connectors located in the middle of the four sides of the shape's bounding rectangle.

* A central connector (aka auto-connector) which acts as an auto-switch. If you connect to this one the framework will choose automatically between the standard four connectors with logic based on shortest paths between shapes.			  

Besides these connectors you can define custom connectors or remove the existing connectors.

>The internal logic of the auto-connector depends on the four additional connectors, if you remove one or more of these connectors it will lead to issues if attaching to the auto-connector. Best practice is to either leave the five connectors (besides your own custom connectors) or remove all of them at the same time.			

Adding a custom connector can be done by simply adding a RadDiagramConnector to the Connectors collection of the shape:

__Example 1: Adding a custom Connector__
<snippet id='raddiagram-features-custom-connectors-example_1_adding_a_custom_connector-cs' />

<snippet id='raddiagram-features-custom-connectors-example_1_adding_a_custom_connector-vb' />


>Please note that __setting the name of the connector is almost mandatory__ if you are going to use it later in your application.

![radidiagram-features-customconnectors 1](images/radidiagram-features-customconnectors1.png)

The Offset property  defines the location of the custom connector with respect to the shape's bounds. For example, an Offset of:		

* (0,0) corresponds to the upper-left corner of the shape.

* (.5,.5) corresponds to the center of the shape.

* (1,1) corresponds to the bottom-right of the shape.

You can go outside the [0,1] range but the following should be considered:		

* The bounds of the shape do not take the connectors into account. If you put a connector at an Offset of (23,55) for instance the shape's width will not be scaled to 23 times the actual shape's width. This also means that when using a graph layout the layout will organize shapes with respect to the actual or visual bounds.			  

* The visual interpretation of a connector put at a large Offset might lead to confusion since it potentially can be interpreted as the connector of another shape. In addition, if a connection is bound to a connector far off its parent shape it might be interpreted as a floating connection.			  

So, in practice you can go outside the actual bounds of the  shape but some moderation is advised.	

## Using Custom Connectors

Now let's define some shapes and custom connectors and use them. First, we will create 6 shapes with the following template:		

__Example 2: Creating shapes__
<snippet id='raddiagram-features-custom-connectors-example_2_creating_shapes-xaml' />


We will define 4 custom connectors for each shape in the diagram. __Naming them is mandatory__:
		
__Example 3: Creating custom connectors__
<snippet id='raddiagram-features-custom-connectors-example_3_creating_custom_connectors-cs' />

<snippet id='raddiagram-features-custom-connectors-example_3_creating_custom_connectors-vb' />


Next step is to add some connections between the custom connectors. The first four connections below are created with the RadDiagram.AddConnection() method with the overload that takes 2 shapes and 2 custom connectors given by their names.

The next four connections are attached with the RadDiagramConnection.Attach() method which takes two connectors.
		
__Example 4: Attaching connections__
<snippet id='raddiagram-features-custom-connectors-example_4_attaching_connections-cs' />

<snippet id='raddiagram-features-custom-connectors-example_4_attaching_connections-vb' />


Below you can see a possible result of the code so far (some additional styling is applied):

![radidiagram-features-customconnectors 2](images/radidiagram-features-customconnectors2.png)

>tip Find a runnable project of the previous example in the [WPF Samples GitHub repository](https://github.com/telerik/xaml-sdk/tree/master/Diagram/CustomConnectors).

## Connectors Visibility 

Note that the Connectors are made visible on selection or when [ConnectorTool]({%slug raddiagrams-features-mouse-tools%}) is active. When you are defining a custom shape you can control the visibility of the Connectors by disabling the ConnectorsAdornerVisible VisualState.

> You can find the ConnectorsAdornerVisible VisualState in the ControlTemplate of the RadDigramShape.

__Example 5: Making a custom shape's connectors always visible__
<snippet id='raddiagram-features-custom-connectors-example_5_making_a_custom_shape_s_connectors_always_visible-cs' />

<snippet id='raddiagram-features-custom-connectors-example_5_making_a_custom_shape_s_connectors_always_visible-vb' />


## See Also
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Populating with Data]({%slug raddiagrams-features-connections%})