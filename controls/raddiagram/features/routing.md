---
title: Routing
page_title: Routing
description: This article describes the routing functionality of the RadDiagram framework.
slug: raddiagram-features-routing
tags: routing,astarrouter, treelayout,custom routertree, inflatedrectrouter, orgTreeRouter, tipovertreerouter, avoidshapes, avoidconnectionoverlap, overlap
published: True
position: 13
---
# Routing

A mechanism using algorithms to make sure that the connections don't cross each other while building links/paths between the shapes. 

## Default Routing
	
Routing in __RadDiagram__ is only available if the RadDiagram __RouteConnections__ property is set to __True__.  Please note that its default value is __False__ and you need to explicitly declare you want to enable the routing features.

> For optimal performance and better visual results, we recommend using the AStarRouter algorithm.    

__Example 1: Setting RouteConnections property in XAML__
<snippet id='raddiagram-features-routing-example_1_setting_routeconnections_property_in_xaml-xaml' />


#### __Figure 1: Default routing__
![raddiagram-features-routing 0](images/raddiagram-features-routing1_New.png)

If you want to __exclude/include__ a connection from the routing process, you can use the __Route__ property of the __RadDiagramConnection__. Using the code above we will exclude the second connection from the routing by setting its __Route__ property to __False__.

__Example 2: Setting Route property to False__
<snippet id='raddiagram-features-routing-example_2_setting_route_property_to_false-xaml' />


#### __Figure 2: Route property set to False__
![raddiagram-features-routing 1](images/raddiagram-features-routing2_New.png)	
	
>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %}[Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.		  

The routing algorithm can be parametrized using the __DiagramConstants.RoutingGridSize__ constant that has a default value of __40__ units.

This value indicates the size of the cells of the underlying grid used by the algorithm:

* A bigger value will decrease the time to compute the optimal path and will diminish the possible wiggling of the connection path due to obstacles (other shapes). On the other hand, a bigger value will not necessarily lead to an optimal solution in certain circumstances. That is, if your diagram involves a  lot of shapes and a high complexity a bigger __RoutingGridSize__ will not find a path through the maze of shapes.

* A smaller value will increase the time to compute the optimal path and increase the set of possible solutions for the path constraints. On the other hand, a small value leads usually to a lot of stairs/wiggling in the connection's path.

## OrgTreeRouter	  

The __OrgTreeRouter__ is __LayoutType__: Based router that performs a hierarchical routing between parent and child shape. When a shape is being dragged, it removes only the crossings between the connection and its source and target shapes. It should be used when following conditions are satisfied:		

* The __IsConnectorsManipulationEnabled__ is set to false.			

* The __LayoutType__ is among the following 5 - __TipOverTree__, __TreeDown__, __TreeUp__, __TreeLeft__, __TreeRight__.

In order to use the OrgTreeRouter , you have to instantiate an OrgTreeRouter object and set it as current Router of the RadDiagram via the RoutingService:

__Example 3: Setting OrgTreeRouter__

<snippet id='raddiagram-features-routing-example_3_setting_orgtreerouter-cs' />

<snippet id='raddiagram-features-routing-example_3_setting_orgtreerouter-vb' />


The TreeLayoutType points to the type of Layout you wish to use. The routing logic is based on this LayoutType.

The ConnectionOuterSpacing is the Minimum Margin between the Parent/Child Shape and the connection.

__Example 4: Specifing RadDiagram in XAML__
<snippet id='raddiagram-features-routing-example_4_specifing_raddiagram_in_xaml-xaml' />


__Figure 3__ demonstrate these shapes after TreeDown Layout operation performed on the Diagram.

#### __Figure 3: TreeDown Layout__
![raddiagram-features-routing 2](images/raddiagram-features-routing3.png)

The OrgTreeRouter is used in our __ClassDiagram__ and __OrgChart__ samples of RadDiagram.

## OrgTreeRouter : TipOverTreeRouter	  

When the TreeLayoutType is set to TipOverTree, the OrgTreeRouter uses a special kind of router - the TipOverTreeRouter. It produces best visual results when a custom connectors are added in the bottom-left part of the shapes. In the following lines we will create a quick sample demonstrating the TipOverTree routing and how to configure it properly. Lets first define some shapes:


<snippet id='raddiagram-features-routing-example_4_specifing_raddiagram_in_xaml-xaml' />


On a button's click event handler we will perform 3 base steps:

* Create custom connector points for every shape.
* Create TreeLayoutSettings and configure it.
* Create Router and assign it to be the default one.


<snippet id='raddiagram-features-routing-example_4_specifing_raddiagram_in_xaml-cs' />

<snippet id='raddiagram-features-routing-example_4_specifing_raddiagram_in_xaml-vb' />


Here is a possible result in Windows8 theme:

#### __Figure 4: TreeLayoutType set to TipOverTree__
![raddiagram-features-routing 3](images/raddiagram-features-routing4.png)

## AStarRouter

As the name suggest this is a connection router that uses a version of the [A* search algorithm](http://en.wikipedia.org/wiki/A*_search_algorithm) to find the best route between two points. There are several ways to parameterize the algorithm:

>tip The routing connection algorithm of the AStarRouter support two types of connection: Polyline and Spline.

#### Using Diagram Constants

* __DiagramConstants.RoutingGridSize__: A property of type double that gets or sets the routing grid size.

#### __Figure 5: Setting RoutingGridSize property__
![AStarRouter](images/radidiagram-features-AStarRouter.png)

* __DiagramConstants.RouterInflationValue__: A properly of type double that gets or sets the size of the restricted area around the shapes.

#### Using properties of the router

* __AvoidShapes__: Boolean property controlling the logic that makes the connections go around the shapes. This property is __True__ by default.

#### __Figure 6: Setting AvoidShapes property__
![AStarRouter](images/radidiagram-features-AStarRouter2.png)

* __WallOptimization__: Boolean property controlling router optimization logic. If you set this property to __True__ the router will try to optimize some of the steps so that there are the least corners. 

With the __R1 2019__ version of __Telerik UI for WPF__, several properties were created which can be used to further modify the algorithm for the routing connections. In order, the changes to be applied to the algorithm the __AvoidConnectionOverlap__ property of the __AStarRouter__ need to be set to __True__.

* __AvoidConnectionOverlap__: Boolean property that gets or sets a value which indicates whether the routing algorithm should try to minimize connection overlaps. The default value is False.

#### __Figure 7: Setting AvoidConnectionOverlap property__
![AvoidConnectionOverlap property](images/raddiagram-features-routing5.png)

* __SegmentOverlapPenalty__: A property of type double that indicates the penalty of a given path when it overlaps an existing diagram connection. Decreasing the value close to 0, the connections behavior will become very close to when __AvoidConnectionOverlap__ is set to __False__. The connections will start to cross each other. At another hand increasing this property, the connections might start to cross a given shape (avoiding connection will be with higher priority than avoiding a shape). There is no strict number when one is more important than the other. It dependents on the concrete 
scenario. The default value is __0.5__.

* __ShapeCrossPenalty__: A property of type double that indicates the penalty of a given path when it overlaps an existing diagram shape other than its start or end shape. This property has effect only when **AvoidShapes** is `true`. The default value is __1__.

* __StartOrEndShapeWallPenalty__: A property of type double that indicates the penalty value for a connection which crosses its start or end shape. When decreasing this value, paths crossing the start/end shape become more likely to be chosen from the AStar algorithm for finding the optimal path. The default value is __3__.

#### __Figure 8: Setting StartOrEndShapeWallPenalty property__
![StartOrEndShapeWallPenalty property](images/raddiagram-features-routing6.png)

* __SegmentOverlapDistance__: A property of type double that gets or sets the surrounding area of a segment in which an overlap is detected. This property require __AvoidConnectionOverlap__ to be set to __True__.

#### Using virtual methods

If the customization provided by these properties does not cover your requirements, you can create your custom router deriving from ours. This will allow you to customize the algorithm by overriding the following methods:

* __GetSiblingNodes__: This method receives the current state and the end target and should return the next possible nodes 

>The order in which the steps are returned is important - if you have two steps with the same price we'll choose the first one.

* __CalculateWallPenalty__: This method calculates the penalty for the node that we give it. By default if the node is inside a shape we return the penaltyBaseValue which is the heuristic distance to the endpoint.

* __CalculateBendAlteration__: This method calculates the bend alteration. By default the result value can be positive - a penalty for changing the direction or negative - a bonus for keeping the direction.

>If the source and target positions of your connections are Auto this router will adjust them so that the path is minimal.

## InflatedRectRouter

The InflatedRectRouter is a simple connection router whos goal is to create a route with least bends. This router doesn't try go around shapes except the start and end shape.

## ReflexiveRouter

The ReflexiveRouter is responsible for creating connections when the source and the target is the same shape.{% if site.site_name == 'WPF' %}In order to learn how to prevent such connections, read the [How to Prevent Shapes from Being Connected to Themselves]({%slug kb-diagrams-prevent-shape-from-being-contected-to-itself%}) KB article.{% endif %}

## Custom Router

In the following section we will create a custom Router. This way we will be able to set the routing points of our Polyline Connections.

Lets first create some items:


<snippet id='raddiagram-features-routing-example_4_specifing_raddiagram_in_xaml-xaml' />


Now we have to create class that implements the __IRouter__ interface and override the GetRoutePoints() method:
		

<snippet id='raddiagram-features-routing-example_4_specifing_raddiagram_in_xaml-cs' />

<snippet id='raddiagram-features-routing-example_4_specifing_raddiagram_in_xaml-vb' />


Please note that we only have to add in the list the route points, no need to add the start and the end point of the connection.

The final step is to make our Router the current one of the Diagram. This is done via Diagram's Routing Service;


<snippet id='raddiagram-features-routing-example_4_specifing_raddiagram_in_xaml-cs' />

<snippet id='raddiagram-features-routing-example_4_specifing_raddiagram_in_xaml-vb' />


Below you can see a possible output (Windows8 theme is applied). The custom points that router creates are marked with 1,2,3,4:
![raddiagram-features-customrouter](images/raddiagram-features-customrouter.png)

> If you have the gliding connectors of a shape enabled avoid using the StartPoint and EndPoint properties of the corresponding connection to calculate the route in the GetRoutePoints method. This could create a circular dependency between the ConnectionPoints and the Start/EndPoint property, thus leading to an unexpected behavior. Instead, when using gliding connectors and a custom router, use the Bounds property of the Target and Source shapes of the connection - example: `connection.Target.Bounds;`.

## See Also
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Layout]({%slug raddiagram-features-diagram-layout%})