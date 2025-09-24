---
title: Connections
page_title: Connections
description: This article describes the connection item of the RadDiagram Framework.
slug: raddiagrams-features-connections
tags: connections
published: True
position: 1
---

# Connections

This tutorial will walk you through the functionality and the main features of the __RadDiagramConnection__. It contains the following sections:

* [Overview](#overview)
* [Configure the Source and Target of a Connection](#configure-the-source-and-target-of-a-connection)
* [Connection Types](#connection-types)
* [CapTypes](#captypes)
* [Connection Content](#set-content)
* [Customize the Connection Appearance](#customize-the-connection-appearance)
* [Connection Edit Mode](#connection-edit-mode)
* [Connection Bridges](#connection-bridge)
* [Connection Selection State](#connection-selection-state)
* [Connection ZIndex](#connection-zindex)
* [Connection Bounds](#connection-bounds)
* [Use Free Connectors](#use-free-connectors)
* [Custom Connection](#custom-connection)

>Before proceeding with this topic, it is recommended to get familiar with the [Visual Structure]({%slug raddiagram-structure%}) of the Diagramming Framework.

## Overview

>Please note that the examples in this tutorial are showcasing Telerik Windows8 theme. In the {% if site.site_name == 'Silverlight' %}[Setting a Theme](http://www.telerik.com/help/silverlight/common-styling-apperance-setting-theme.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %}{% if site.site_name == 'WPF' %} [Setting a Theme](http://www.telerik.com/help/wpf/common-styling-apperance-setting-theme-wpf.html#Setting_Application-Wide_Built-In_Theme_in_the_Code-Behind){% endif %} article you can find more information on how to set an application-wide theme.		  

The __RadDiagramConnection__ is basically an object that connects zero, one or two shapes:
![Rad Diagram Features Connection](images/RadDiagram_Features_Connection.png)

You can use its extensive API to configure its source and target points or shapes. You can choose from a list of predefined cap types thus customizing the start and end point of the connection to better fit in your application scenario. You can also control the type of a connection using the ConnectionType property, add a custom content and customize the overall look and feel of the items.		

## Configure the Source and Target of a Connection

You can configure the source and the target of a connection as a point or as a shape. The __RadDiagramConnection__ class exposes the following properties that allow you to control the start and end points of a connection:		

* __StartPoint/EndPoint__: These properties are of type __Point__ and they set or get the start/end point of a connection.			

* __Source/Target__: These properties get or set the source/target __RadDiagramShape__ of a connection.			

* __SourceConnectorPosition/TargetConnectorPosition__: Both properties are of type __string__ and they get or set the source/target connector position.			

	>You can find more information about the __RadDiagramShape__ connectors in the [DiagramShapes]({%slug raddiagrams-features-shapes%}) topic. 

	There are five predefined strings that you can use to define where to position the connectors of the connection:			

	* __Auto__: Use it if you want to automatically determine the start/end point of a connection. This option will allow the connection to dynamically determine which shape connector to be used as a start/end point. Based on the end point position, the __SourceConnectorPosition__ will be set to the nearest shape connector. Alternatively, the __TargetConnectorPosition__ will be set to the nearest shape connector, based on the start point position of the connection.				

	* __Left__: Use it to define the left connector of a shape as the source/target point of the connection				

	* __Top__: Use it to define the top connector of a shape as the source/target point of the connection				

	* __Right__: Use it to define the right connector of a shape as the source/target point of the connection				

	* __Bottom__: Use it to define the bottom connector of a shape as the source/target point of the connection				

	>The __Diagramming Framework__ provides a __ConnectorPosition__ static class, which you can use to define the connector positions from code-behind:
	>`using Telerik.Windows.Diagrams.Core;`
	>`this.xDiagram.Connections[0].SourceConnectorPosition = ConnectorPosition.Bottom;`				

* __SourceCapSize/TargetCapSize__ - these properties are of type __Size__ and they get or set the size of the __SourceCap/TargetCap__.			

* __SourceCapType/TargetCapType__ - both properties are an enumeration of type __CapType__ that allow you to choose a cap from a set of predefined Cap types. For more detailed information, please, view the [CapTypes](#captypes) section below.			

You can also attach a connection to a source and target shape using the __RadDiagramConnection.Attach()__ method. It defines the following parameters:		

* __source of type IConnector__: Required parameter that sets the __Source__ of the connection.			

* __target of type IConnector__: Required parameter that sets the __Target__ of the connection.			

## Connection Types

You can control the connection type through the __ConnectionType__ property. As an enumeration of type  __Telerik.Windows.Diagrams.Core.ConnectionType__, it exposes the following members:		

* __Polyline__: This connection type allows you to define multiple points, a connection has to pass through. By default such a connection have two points it has to pass through - its source connector (or __StartPoint__) and its target connector (or __EndPoint__). This is why by default the __Polyline ConnectionType__ visualizes a straight connection.			

	__Example 1:Polyline Connection__
	```XAML
		<Grid>
			<telerik:RadDiagram>
				<telerik:RadDiagramShape x:Name="xShape1" Content="Shape1"  Geometry="{telerik:FlowChartShape ShapeType=Database1Shape}" Position="250,100" />
				<telerik:RadDiagramShape x:Name="xShape4" Content="Shape4" Geometry="{telerik:FlowChartShape ShapeType=Database2Shape}" Position="600,400" />
				
				<telerik:RadDiagramConnection Source="{Binding ElementName=xShape1}" Target="{Binding ElementName=xShape4}" ConnectionType="Polyline" />
			</telerik:RadDiagram>
		</Grid>		
	```
	
	Sample of a straight Polyline connection between two shapes:
	![Rad Diagram Features Connection Straight](images/RadDiagram_Features_Connection_Straight.png)

	If you want to change the route of the connection, you can add connection points in runtime while pressing the __Ctrl__ key and using the mouse to place points on the connection. You can move each point around the diagramming surface to create a curved connection. You can also explicitly define the connection points in code-behind through the __RadDiagramConnection.ConnectionPoints__ property. You can populate the __ConnectionPoints__ collection with objects of type __Point__:

	__Example 2: Add ConnectionPoints__
	```XAML
		<telerik:RadDiagram>
			<telerik:RadDiagramShape x:Name="xShape1"
										Content="Shape1"
										Geometry="{telerik:FlowChartShape ShapeType=Database1Shape}"
										Position="250,100" />
			<telerik:RadDiagramShape x:Name="xShape4"
										Content="Shape4"
										Geometry="{telerik:FlowChartShape ShapeType=Database2Shape}"
										Position="400,300" />

			<telerik:RadDiagramConnection x:Name="xConnection"
											ConnectionType="Polyline"
											Source="{Binding ElementName=xShape1}"
											Target="{Binding ElementName=xShape4}" />
		</telerik:RadDiagram>
	```
	
	__Example 3: Add ConnectionPoints__
	```C#
		xConnection.ConnectionPoints.Add(new Point(300, 140));
		xConnection.ConnectionPoints.Add(new Point(420, 200));
		xConnection.ConnectionPoints.Add(new Point(440, 300));	
	```
	```VB.NET
		xConnection.ConnectionPoints.Add(New Point(300, 140))
		xConnection.ConnectionPoints.Add(New Point(420, 200))
		xConnection.ConnectionPoints.Add(New Point(440, 300))	
	```
	
	Sample of a curved Polyline connection:
	![Rad Diagram Connections Curved Connection](images/RadDiagram_Connections_CurvedConnection.png)

	>tip You can use a default routing algorithm to automatically create connection points and route your connections. This basically ensures that the diagramming framework will use a routing algorithm to make sure that the path of the connection won't collide with any shapes. In order to use this feature, you can set the __RadDiagram RouteConnections__ property to __True__. Please refer to the [Routing]({%slug raddiagram-features-routing%}) tutorial for more information on the routing algorithm. If you want to use a rounded polyline connection, you can set the __RadDiagram ConnectionRoundedCorners__ to __True__.			

	__Example 4: Add rounded corners__
	```XAML
		<telerik:RadDiagram x:Name="xDiagram" ConnectionRoundedCorners="True">
			<telerik:RadDiagramShape x:Name="xShape1"
									 Content="Shape1"
									 Geometry="{telerik:FlowChartShape ShapeType=Database1Shape}"
									 Position="240,260" />
			<telerik:RadDiagramShape x:Name="xShape2"
									 Content="Shape2"
									 Geometry="{telerik:FlowChartShape ShapeType=DataStoreShape}"
									 GlidingStyle="Rectangle"
									 Position="600,80"
									 UseGlidingConnector="True" />
			<telerik:RadDiagramShape x:Name="xShape3"
									 Content="Shape3"
									 Geometry="{telerik:FlowChartShape ShapeType=DataStoreShape}"
									 Position="600,380" />
			<telerik:RadDiagramConnection ConnectionType="Polyline"
										  Source="{Binding ElementName=xShape1}"
										  SourceConnectorPosition="Top"
										  Target="{Binding ElementName=xShape2}"/>
			<telerik:RadDiagramConnection ConnectionType="Polyline"
										  Source="{Binding ElementName=xShape1}"
										  SourceConnectorPosition="Bottom"
										  Target="{Binding ElementName=xShape3}" />

		</telerik:RadDiagram>
	```
	![Rad Diagram Connections Rounded Polyline](images/RadDiagram_Connections_RoundedPolyline.png)

	>Please note that in the above example the __ConnectionPoints__ of the connections are added in runtime using the __Ctrl__ key and the mouse.			  

* __Bezier__: This connection type allows you to create a Bézier curve. The Bezier connection is a curve specified by four points: two end points (p1 and p2) - the source/start and target/end of the connection and two handle points (h1 and h2) and a tension parameter. The curve begins at p1 and ends at p2 and it doesn't pass through the handle points, but the handle points act as magnets, pulling the curve in certain directions and influencing the way the curve bends. The following illustration shows a Bézier __RadDiagramConnection__ along with its endpoints and handle points.			

	Illustration of a Bezier connection definition points:
	![Rad Diagram Connections Bezier Connection](images/RadDiagram_Connections_BezierConnection.png)

	The __RadDiagramConnection.BezierTension__ parameter defines the curve that will be produced for a given set of end and handle points. The following illustration shows four Bezier connections defined by the same set of end and handle points:			

	__Example 5: Bezier Connection Type__
	```XAML
		<telerik:RadDiagram x:Name="xDiagram" Margin="50">
			<telerik:RadDiagramShape x:Name="xShape1"
								Content="Shape1"
								Geometry="{telerik:FlowChartShape ShapeType=Database1Shape}"
								Position="50,50" />
			<telerik:RadDiagramShape x:Name="xShape2"
								Content="Shape2"
								Geometry="{telerik:FlowChartShape ShapeType=DataStoreShape}"
								Position="450,100" />
			<telerik:RadDiagramConnection ConnectionType="Bezier" BezierTension="3"
									Source="{Binding ElementName=xShape1}"
									Target="{Binding ElementName=xShape2}" Stroke="Red"/>
			<telerik:RadDiagramConnection ConnectionType="Bezier" BezierTension="9"
									Source="{Binding ElementName=xShape1}"
									Target="{Binding ElementName=xShape2}" Stroke="Blue"/>
			<telerik:RadDiagramConnection ConnectionType="Bezier" BezierTension="16"
									Source="{Binding ElementName=xShape1}"
									Target="{Binding ElementName=xShape2}" Stroke="Green"/>
		</telerik:RadDiagram> 
	```
	
	Illustration of a Bezier connection tension parameter:
	![Rad Diagram Connections Bezier Tension](images/RadDiagram_Connections_BezierTension.png)
	
	By default when you create a Bezier connection and attach its endpoints to __RadDiagramShapes__, the position of the handle points of the connection will be calculated based on the connector positions. Both handle points will be added to the __RadDiagramConnection.ConnectionPoints__ collection. The following snapshot illustrates the default direction of the Bezier connection handles based on the position of the connector to which the connection is attached.				

	Illustration of a Bezier connection default handle points directions:
	![Rad Diagram Connections Bezier Def Handles](images/RadDiagram_Connections_BezierDefHandles.png)
	
	The offset between a Bezier connection handle point and its corresponding endpoint is controlled thorough the __BezierAutoOffset DiagramConstants__. Its default value is 30px, but you can change it to better fit your needs:				

	__Example 6: Set Bezier Offset__
	```C#
		DiagramConstants.BezierAutoOffset = 40;			  
	```
	```VB.NET
		DiagramConstants.BezierAutoOffset = 40 
	```
	
	When attaching a Bezier connection to a __RadDiagramShape__ you need to consider if it is attached to a built-in connector or to a custom connector. If the connection is attached to a custom connector, then you will have to manually set the position of the Bezier handle points. You can change the position of the points after you access them from the __RadDiagramConnection.ConnectionPoints__ collection, but you will also have to set the __RadDiagramConnection.IsModified__ property to __True__ to apply the changes:

	__Example 7: Add ConnectionPoints to Bezier connection type__
	```C#
		this.xDiagram.Connections[0].ConnectionPoints[0] = new Point(100, 100);
		this.xDiagram.Connections[0].ConnectionPoints[1] = new Point(220, 200);
		this.xDiagram.Connections[0].IsModified = true;			  
	```
	```VB.NET
		Me.xDiagram.Connections(0).ConnectionPoints(0) = New Point(100, 100)
		Me.xDiagram.Connections(0).ConnectionPoints(1) = New Point(220, 200)
		Me.xDiagram.Connections(0).IsModified = True	
	```
	
	If you don't want to manually traverse the __ConnectionPoints__ collection and then set the __IsModified__ property, you can use the __RadDiagramConnection.SetBezierHandles(Point,Point)__ method. It facilitates the definition of custom coordinates for the two handle points of a Bezier connection:

	__Example 8: Using SetBezierHandles() method__
	```C#
		(this.xDiagram.Connections[0] as RadDiagramConnection).SetBezierHandles(new Point(100, 100), new Point(220, 200));	  
	```
	```VB.NET
		TryCast(Me.xDiagram.Connections(0), RadDiagramConnection).SetBezierHandles(New Point(100, 100), New Point(220, 200))
	```
	
	>Please note that if you create custom connectors which names include any of the following strings:
	>	- „right“
	>	- “left”
	>	- “bottom”
	>	- “up”
	>the __Bezier Connection__ handle points will point at the direction indicated by the respective string. 
	
	>On the other hand, if you attach a __Bezier Connection__ to a custom connector which name doesn't indicate a direction, the handle points of the connection will match the start and end point of the connection.			  

* __Spline__: This connection type represents a cardinal spline. The connection is specified by an array of points - the connection passes smoothly through each point in the array; there are no sharp corners and no abrupt changes in the tightness of the curve. The following illustration shows a set of points and a spline connection that passes through each point in the set.

	Sample of a Spline connection:
	![Rad Diagram Connections Spline Connection](images/RadDiagram_Connections_SplineConnection.png)
	In order to set the array of points, you will have to populate the __RadDiagram.ConnectionPoints__ collection. You can do that manually in code-behind:				

	__Example 9: Spline Connection Type__
	```XAML
		<telerik:RadDiagram x:Name="xDiagram" >
			<telerik:RadDiagramShape x:Name="xShape1"
									Content="Shape1"
									Geometry="{telerik:FlowChartShape ShapeType=Database1Shape}"
									Position="0,0" />
			<telerik:RadDiagramShape x:Name="xShape2"
									Content="Shape2"
									Geometry="{telerik:FlowChartShape ShapeType=DataStoreShape}"
									Position="450,100" />
			<telerik:RadDiagramConnection ConnectionType="Spline"
										  Source="{Binding ElementName=xShape1}"
										  Target="{Binding ElementName=xShape2}" />
		</telerik:RadDiagram>			  
	```
	
	__Example 10: Add ConnectionPoints to Spline Connection__		
	```C#
		this.xDiagram.Connections[0].ConnectionPoints.Add(new Point(140, 20));
		this.xDiagram.Connections[0].ConnectionPoints.Add(new Point(250, 150));
		this.xDiagram.Connections[0].ConnectionPoints.Add(new Point(350, 50));			  			  
	```
	```VB.NET
		Me.xDiagram.Connections(0).ConnectionPoints.Add(New Point(140, 20))
		Me.xDiagram.Connections(0).ConnectionPoints.Add(New Point(250, 150))
		Me.xDiagram.Connections(0).ConnectionPoints.Add(New Point(350, 50))							  
	```
	
	![Rad Diagram Connections Spline Conn Points](images/RadDiagram_Connections_SplineConnPoints.png)

## CapTypes

* CapTypes enumeration members:

	__None__:
	![Rad Diagram Features Cap Type None](images/RadDiagram_Features_CapType_None.png)

	__Example 11: None Cap Type__
	```XAML
		<telerik:RadDiagramConnection
			SourceCapType="None"
			TargetCapType="None"
			StartPoint="10,360"
			EndPoint="80,360" />
	```
	
	__Arrow1__: 
	![Rad Diagram Features Cap Type Arrow 1](images/RadDiagram_Features_CapType_Arrow1.png)

	__Example 12: Arrow1 Cap Type__
	```XAML
		<telerik:RadDiagramConnection
			SourceCapType="Arrow1"
			TargetCapType="Arrow1"
			StartPoint="10,30"
			EndPoint="80,30" />
	```
	
	__Arrow1Filled___
	 ![Rad Diagram Features Cap Type Arrow 1 Filled](images/RadDiagram_Features_CapType_Arrow1Filled.png)

	__Example 13: Arrow1Filled Cap Type__
	```XAML
		<telerik:RadDiagramConnection
			SourceCapType="Arrow1Filled"
			TargetCapType="Arrow1Filled"
			StartPoint="10,60"
			EndPoint="80,60" />					
	```
	
	__Arrow2__ 
	![Rad Diagram Features Cap Type Arrow 2](images/RadDiagram_Features_CapType_Arrow2.png)

	__Example 14: Arrow2 Cap Type__
	```XAML
		<telerik:RadDiagramConnection
			SourceCapType="Arrow2"
			TargetCapType="Arrow2"
			StartPoint="10,90"
			EndPoint="80,90" />					
	```
	
	__Arrow2Filled__ 
	![Rad Diagram Features Cap Type Arrow 2 Filled](images/RadDiagram_Features_CapType_Arrow2Filled.png)

	__Example 15: Arrow2Filled Cap Type__
	```XAML
		<telerik:RadDiagramConnection
			SourceCapType="Arrow2Filled"
			TargetCapType="Arrow2Filled"
			StartPoint="10,120"
			EndPoint="80,120" />				  
	```
	
	__Arrow3__ 
	![Rad Diagram Features Cap Type Arrow 3](images/RadDiagram_Features_CapType_Arrow3.png)

	__Example 16: Arrow3 Cap Type__
	```XAML
		<telerik:RadDiagramConnection
			SourceCapType="Arrow3"
			TargetCapType="Arrow3"
			StartPoint="10,150"
			EndPoint="80,150" />				  
	```
	
	__Arrow4__
	![Rad Diagram Features Cap Type Arrow 4](images/RadDiagram_Features_CapType_Arrow4.png)

	__Example 17: Arrow4 Cap Type__	
	```XAML
		<telerik:RadDiagramConnection
			SourceCapType="Arrow4"
			TargetCapType="Arrow4"
			StartPoint="10,180"
			EndPoint="80,180" />					
	```
	
	__Arrow4Filled__ 
	![Rad Diagram Features Cap Type Arrow 4 Filled](images/RadDiagram_Features_CapType_Arrow4Filled.png)

	__Example 18: Arrow4Filled Cap Type__	
	```XAML
		<telerik:RadDiagramConnection
			SourceCapType="Arrow4Filled"
			TargetCapType="Arrow4Filled"
			StartPoint="10,210"
			EndPoint="80,210" />				  
	```
	
	__Arrow5__ 
	![Rad Diagram Features Cap Type Arrow 5](images/RadDiagram_Features_CapType_Arrow5.png)

	__Example 19: Arrow5 Cap Type__
	```XAML
		<telerik:RadDiagramConnection
			SourceCapType="Arrow5"
			TargetCapType="Arrow5"
			StartPoint="10,240"
			EndPoint="80,240" />					
	```
	
	__Arrow5Filled__ 
	![Rad Diagram Features Cap Type Arrow 5 Filled](images/RadDiagram_Features_CapType_Arrow5Filled.png)

	__Example 20: Arrow5Filled Cap Type__
	```XAML
		<telerik:RadDiagramConnection
			SourceCapType="Arrow5Filled"
			TargetCapType="Arrow5Filled"
			StartPoint="10,270"
			EndPoint="80,270" />					
	```
	
	__Arrow6__ 
	![Rad Diagram Features Cap Type Arrow 6](images/RadDiagram_Features_CapType_Arrow6.png)

	__Example 21: Arrow6 Cap Type__
	```XAML
		<telerik:RadDiagramConnection
			SourceCapType="Arrow6"
			TargetCapType="Arrow6"
			StartPoint="10,300"
			EndPoint="80,300" />					
	```
	
	__Arrow6Filled__ 
	![Rad Diagram Features Cap Type Arrow 6 Filled](images/RadDiagram_Features_CapType_Arrow6Filled.png)

	__Example 22: Arrow6Filled Cap Type__
	```XAML
		<telerik:RadDiagramConnection
			SourceCapType="Arrow6Filled"
			TargetCapType="Arrow6Filled"
			StartPoint="10,330"
			EndPoint="80,330" />
	```
	
## Set Content

You can label a connection by setting its __Content__ property. The __Content__ property can define a string, a __UIElement__ or it can be bound to a business property.

* Label a connection with a sample string:

	__Example 23: Set Connection Content__
	```XAML
		<Grid>
			<telerik:RadDiagram>
				<telerik:RadDiagramShape
					x:Name="ConditionShape"
					Width="80"
					Height="80"
					Content="condition"
					FontWeight="Bold"
					Geometry="{telerik:FlowChartShape ShapeType=DecisionShape}"
					Position="160,80" />
				<telerik:RadDiagramShape
					x:Name="StatementShape1"
					Width="100"
					Content="statement(s)"
					FontWeight="Bold"
					Position="60,280" />
				<telerik:RadDiagramConnection
					Content="if condition is false"
					FontWeight="Bold"
					Source="{Binding ElementName=ConditionShape}"
					SourceConnectorPosition="Bottom"
					StrokeThickness="2"
					Target="{Binding ElementName=StatementShape1}"
					TargetCapType="Arrow1Filled" />
			</telerik:RadDiagram>
		</Grid>
	```

	![Rad Diagram Features Connection String Content](images/RadDiagram_Features_Connection_StringContent.png)

* Define __UIElements__ in the __Content__ of the connection:			

	__Example 24: Custom elements inside Connection Content__
	```XAML
		<Grid>
			<telerik:RadDiagram>
				<telerik:RadDiagramShape x:Name="ConditionShape"
										 Width="80"
										 Height="80"
										 Content="condition"
										 FontWeight="Bold"
										 Geometry="{telerik:FlowChartShape ShapeType=DecisionShape}"
										 Position="160,80" />
				<telerik:RadDiagramShape x:Name="StatementShape1"
										 Width="100"
										 Content="statement(s)"
										 FontWeight="Bold"
										 Position="60,280" />
				<telerik:RadDiagramConnection FontWeight="Bold"
											  Source="{Binding ElementName=ConditionShape}"
											  SourceConnectorPosition="Bottom"
											  StrokeThickness="2"
											  Target="{Binding ElementName=StatementShape1}"
											  TargetCapType="Arrow1Filled">
					<telerik:RadDiagramConnection.Content>
						<Grid>
							<Grid.RowDefinitions>
								<RowDefinition />
								<RowDefinition />
								<RowDefinition />
							</Grid.RowDefinitions>
							<StackPanel Margin="3" Orientation="Horizontal">
								<TextBlock Text="StrokeThickness: " />
								<TextBlock Text="{Binding RelativeSource={RelativeSource AncestorType=telerik:RadDiagramConnection}, Path=StrokeThickness}" />
							</StackPanel>
							<StackPanel Grid.Row="1"
										Margin="3"
										Orientation="Horizontal">
								<TextBlock Text="StartPoint: " />
								<TextBlock Margin="0,0,4,0" Text="{Binding RelativeSource={RelativeSource AncestorType=telerik:RadDiagramConnection}, Path=StartPoint}" />
							</StackPanel>
							<StackPanel Grid.Row="2"
										Margin="3"
										Orientation="Horizontal">
								<TextBlock Text="EndPoint: " />
								<TextBlock Text="{Binding RelativeSource={RelativeSource AncestorType=telerik:RadDiagramConnection}, Path=EndPoint}" />
							</StackPanel>
						</Grid>
					</telerik:RadDiagramConnection.Content>
				</telerik:RadDiagramConnection>
			</telerik:RadDiagram>
		</Grid>
	```

	![Rad Diagram Features Connection UIControls](images/RadDiagram_Features_Connection_UIControls.png)

* Bind the __Content__ to a business property: For the purpose of this tutorial, let's define a sample business class and set it as the __DataContext__ of the {% if site.site_name == 'Silverlight' %}UserControl{% endif %}{% if site.site_name == 'WPF' %}Window{% endif %}.

	__Example 25: Create business object__
	```C#
		 public class DataItem : ViewModelBase
			{
				private string ipAddress;
				public string IpAddress
				{
					get { return ipAddress; }
					set
					{
						ipAddress = value;
						this.OnPropertyChanged("IpAddress");
					}
				}
			}
			....
		this.DataContext = new DataItem() { IpAddress = "192.168.92.0" };
	```
	```VB.NET
		Public Class DataItem
			Inherits ViewModelBase
			Private m_ipAddress As String
			Public Property IpAddress() As String
				Get
					Return m_ipAddress
				End Get
				Set
					m_ipAddress = value
					Me.OnPropertyChanged("IpAddress")
				End Set
			End Property
		End Class
			...
		Me.DataContext = New DataItem() With { .IpAddress = "192.168.92.0" }
	```
	
	__Example 25: Bind Connection Content property__
	```XAML
		<Grid>
			<telerik:RadDiagram>
				<telerik:RadDiagramShape x:Name="ConditionShape"
										 Height="30"
										 Content="Router"
										 FontWeight="Bold"
										 Geometry="{telerik:FlowChartShape ShapeType=Database1Shape}"
										 Position="80,80" />
				<telerik:RadDiagramShape x:Name="StatementShape1"
										 Content="PC 1"
										 FontWeight="Bold"
										 Position="120,220" />
				<telerik:RadDiagramConnection VerticalContentAlignment="Top"
											  Content="{Binding IpAddress}"
											  FontWeight="Bold"
											  Source="{Binding ElementName=ConditionShape}"
											  Target="{Binding ElementName=StatementShape1}"
											  TargetCapType="Arrow1Filled" />
			</telerik:RadDiagram>
		</Grid>
	```

	![Rad Diagram Features Connection Binding](images/RadDiagram_Features_Connection_Binding.png)

* If you want to customize the visual representation of the bound property, you can take advantage of the __RadDiagramConnection ContentTemplate__ property:

	__Example 26: Set ContentTemplate__
	```XAML
		<Grid>
			<telerik:RadDiagram>
				<telerik:RadDiagramShape x:Name="ConditionShape"
										 Height="30"
										 Content="Router"
										 FontWeight="Bold"
										 Geometry="{telerik:FlowChartShape ShapeType=Database1Shape}"
										 Position="80,80" />
				<telerik:RadDiagramShape x:Name="StatementShape1"
										 Content="PC 1"
										 FontWeight="Bold"
										 Position="120,220" />
				<telerik:RadDiagramConnection VerticalContentAlignment="Top"
											  Content="{Binding IpAddress}"
											  FontWeight="Bold"
											  Source="{Binding ElementName=ConditionShape}"
											  Target="{Binding ElementName=StatementShape1}"
											  TargetCapType="Arrow1Filled">
					<telerik:RadDiagramConnection.ContentTemplate>
						<DataTemplate>
							<StackPanel Margin="-60,5,0,0" Orientation="Horizontal">
								<TextBlock Text="Interface: " />
								<TextBlock Text="{Binding}" />
							</StackPanel>
						</DataTemplate>
					</telerik:RadDiagramConnection.ContentTemplate>
				</telerik:RadDiagramConnection>
			</telerik:RadDiagram>
		</Grid>
	```

	![Rad Diagram Features Connection Content Template](images/RadDiagram_Features_Connection_ContentTemplate.png)

## Customize the Connection Appearance

You can easily customize the visual appearance of the __RadDiagramConnection__ by using the following properties:

* __Stroke__: Gets or sets the brush that specifies how the __RadDiagramConnection__ is painted.			

* __StrokeDashArray__: Gets or sets a collection of __Double__ values that indicate the pattern of dashes and gaps that is used to outline the __RadDiagramConnection__.			

* __StrokeThickness__: Gets or sets the width of the __RadDiagramConnection__ outline.			

* __Background__: Gets or sets the brush that specifies the __SourceCap__ and __TargetCap__ inner background.			

>tip You can use the __RadDiagram.ConnectionStyle__ property to explicitely apply a style on all __RadDiagramConnections__ in a __RadDiagram__ instance. [Read more]({%slug raddiagram-styling-selectors%}#customize-the-raddiagramconnection-style).

## Connection Edit Mode

You can set the __RadDiagramConnection__ in edit mode using the __IsInEditMode__ property. By default when an item enters edit mode, the __RadDiagramConnection.Content__ is displayed inside a __TextBox__ control so that you can change its value.
![Rad Diagram Features Connection Edit Mode](images/RadDiagram_Features_Connection_EditMode.png)

If the __RadDiagramConnection.Content__ property is bound to a business item, you can set the connection __EditTemplate__ to define how the business item will be edited. For example if we use the __DataItem__ class, defined above, as a __DataContext__ of the __RadDiagram__, we can set up the following connection:

__Example 27: Set EditTemplate__
```XAML
    <Grid>
        <telerik:RadDiagram>
            <telerik:RadDiagramShape x:Name="ConditionShape"
                                     Height="30"
                                     Content="Router"
                                     FontWeight="Bold"
                                     Geometry="{telerik:FlowChartShape ShapeType=Database1Shape}"
                                     Position="80,80" />
            <telerik:RadDiagramShape x:Name="StatementShape1"
                                     Width="100"
                                     Content="PC 1"
                                     FontWeight="Bold"
                                     Position="120,220" />
            <telerik:RadDiagramConnection VerticalContentAlignment="Top"
                                          Content="{Binding}"
                                          FontWeight="Bold"
                                          Source="{Binding ElementName=ConditionShape}"
                                          Target="{Binding ElementName=StatementShape1}"
                                          TargetCapType="Arrow1Filled">
                <telerik:RadDiagramConnection.ContentTemplate>
                    <DataTemplate>
                        <TextBlock Text="{Binding IpAddress}" />
                    </DataTemplate>
                </telerik:RadDiagramConnection.ContentTemplate>
                <telerik:RadDiagramConnection.EditTemplate>
                    <DataTemplate>
                        <TextBox Text="{Binding IpAddress}" />
                    </DataTemplate>
                </telerik:RadDiagramConnection.EditTemplate>
            </telerik:RadDiagramConnection>
        </telerik:RadDiagram>
    </Grid>
```

![Rad Diagram Features Connection Edit Template](images/RadDiagram_Features_Connection_EditTemplate.png)

>Apart from setting the __IsInEditMode__ property to __True__, you can also enter edit mode by pressing __F2__ or double-clicking on the shape. For more information please refer to the [Items Editing]({%slug raddiagrams-features-edit%}) tutorial.

## Connection Bridge

The Connection Bridge is essentially what you see when two connections collide. The __RadDiagram__ allows you to define what kind of bridge to display through the __ConnectionBridge__ property. It is an enumeration of type __BridgeType__ that exposes the following members:

* __None__: There is no bridge to visualize the intersection of the connections
![Rad Diagram Connections Bridge None](images/RadDiagram_Connections_BridgeNone.png)

* __Bow__: A half circle is displayed to indicate the intersection of the connections
![Rad Diagram Connections Bridge Bow](images/RadDiagram_Connections_BridgeBow.png)

* __Gap__: A gap is displayed to indicate the intersection of the connections
![Rad Diagram Connections Bridge Gap](images/RadDiagram_Connections_BridgeGap.png)

## Connection Selection State

The following properties allow you to track and control the selection state of a connection:

* __IsSelected__: Gets or sets whether the connection is selected.			

* __IsSelectedInGroup__: Gets a value indicating whether this connection is selected in a group.			

## Connection ZIndex

You can get or set the z-order rendering behavior of the __RadDiagramConnection__ through the __ZIndex__ property.		

## Connection Bounds

You can get the bounds of a __RadDiagramConnection__ through the __Bounds__ property. It is of type __Rect__ and it describes the width, height and location of the connection's bounds.		

## Use Free Connectors

With the __R1 2019__ version of our controls __RadDiagramConnection__ now expose a __UseFreeConnectors__ property. This __Boolean__ property gets or sets whether the connection will choose free connectors when attaching to a shape. In the definition of free connectors means that no connections are outgoing or incoming for this connector of the shape.

> The __UseFreeConnectors__ property require the __SourceConnectorPosition__ or __TargetConnectorPosition__ to be set to __Auto__ in order have effect.

## Custom Connection

The __RadDiagramConnection__ element exposes the __CreateGeometry()__ method, which can be overridden to create a custom connection. In this section we will demonstrate how to use __CreateGeometry()__ method to create our own connection. 

__Example 28: Create Custom Connection__
```C#
	public class CustomConnection : RadDiagramConnection
	{
		protected override System.Windows.Media.Geometry CreateGeometry(Telerik.Windows.Diagrams.Core.BridgeType bridgeType, bool roundedCorners)
		{
			var newGeometry = new GeometryGroup();

			var startX = this.StartPoint.X;
			var startY = this.StartPoint.Y;

			var boundsLeft = Math.Min(this.StartPoint.X, this.EndPoint.X);
			var boundsTop = Math.Min(this.StartPoint.Y, this.EndPoint.Y);

			var offsetX = Math.Abs(this.EndPoint.X - this.StartPoint.X);
			var offsetY = Math.Abs(this.EndPoint.Y - this.StartPoint.Y);
			var segmentsCount = (int)Math.Max(3, Math.Max(offsetX / Math.Pow(offsetX, 0.5) / 3, offsetY / Math.Pow(offsetY, 0.5) / 3));

			var xStep = (this.EndPoint.X - this.StartPoint.X) / Math.Pow(segmentsCount, 2) / 2;
			var yStep = (this.EndPoint.Y - this.StartPoint.Y) / Math.Pow(segmentsCount, 2) / 2;

			for (int i = 1; i <= segmentsCount; i++)
			{

				var center = new Point(startX + xStep * (2 * i * i - i) - boundsLeft, startY + yStep * (2 * i * i - i) - boundsTop);
				newGeometry.Children.Add(new EllipseGeometry(center, Math.Max(2, Math.Abs(xStep) * i), Math.Max(2, Math.Abs(yStep) * i)));
			}
			return newGeometry;
		}
	}
```

__Example 29: Declare Custom Connection__
```XAML
    <telerik:RadDiagram x:Name="diagram">
		<telerik:RadDiagramShape x:Name="shape1" Position="200 160" />
		<telerik:RadDiagramShape x:Name="shape2"
									Geometry="{telerik:CommonShape ShapeType=OctagonShape}"
									Position="540 150" />
		<local:CustomConnection Source="{Binding ElementName=shape1}" Target="{Binding ElementName=shape2}"
								StrokeThickness="2"
								Background="Blue"/>
	</telerik:RadDiagram> 
```

![Rad Diagram Custom Connection](images/RadDiagram_Connections_CustomConnection.PNG)

## See Also
 * [Structure]({%slug raddiagram-structure%})
 * [Getting Started]({%slug raddiagram-getting-started%})
 * [Populating with Data]({%slug raddiagram-data-overview%})
 * [Shapes]({%slug raddiagrams-features-shapes%})
 * [Items Editing]({%slug raddiagrams-features-edit%})
 * [Rotation]({%slug raddiagrams-features-rotation%})
 * [Selection]({%slug raddiagrams-features-selection%})
 * [Diagram Events]({%slug raddiagrams-events-diagram%})
 * [Items Events]({%slug raddiagrams-events-item%})
