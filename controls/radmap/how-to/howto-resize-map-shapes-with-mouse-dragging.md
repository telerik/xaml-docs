---
title: Resize Map Shapes With Mouse Dragging
page_title: Resize Map Shapes With Mouse Dragging
description: Check our &quot;Resize Map Shapes With Mouse Dragging&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-howto-resize-map-shapes-with-mouse-dragging
tags: resize,map,shapes,with,mouse,dragging
published: True
position: 7
---

# Resize Map Shapes With Mouse Dragging

RadMap provides a rich set of [geocoordinate-enabled shapes]({%slug radmap-features-map-shapes%}) that can be defined and displayed onto the map surface .There are scenarios, however, where you would like to do more than just position a shape onto the map. This help topic will demonstrate how to manipulate each individual segment of line/polyline/polygon shape based on mouse input from the user. For example we will select (highlight) a point,
        and drag the selected object to another location on the map – modifying in this way the shape or the line segment.

First of all we’ll need two Information layers – one for the polyline and the other one for the points that we will use for the shape manipulation. We will disable the default pan / drag actions of the Map as we will attach our own mouse events on the pinpoints only:

```XAML
	<telerik:RadMap x:Name="radMap"
	                        InitializeCompleted="radMap_InitializeCompleted"
	                        Center="40,-100"
	                        MouseClickMode="None"
	                        MouseDragMode="None"
	                        MouseDoubleClickMode="None"
	                        ZoomLevel="4">
	            <telerik:RadMap.Provider>
	                <telerik:OpenStreetMapProvider />
	            </telerik:RadMap.Provider>
	
	            <telerik:InformationLayer x:Name="polylineLayer" />
	            <telerik:InformationLayer x:Name="pointLayer" />
	
	        </telerik:RadMap>
```

Now we will create a sample polyline and add it to the first information layer. Note that it is better to do this after the map provider has been initialized in order to prevent your items from appearing in the upper left corner before the map is initialized and loaded:

```C#
	private void radMap_InitializeCompleted(object sender, EventArgs e)
	{
		if (!initialized)
		{
			initialized = true;

			this.BuildPolyline();
		}
	}

	private void BuildPolyline()
	{
		LocationCollection points = new LocationCollection();
		points.Add(new Location(40, -100));
		points.Add(new Location(41, -101));
		points.Add(new Location(40, -102));
		points.Add(new Location(43, -103));
		points.Add(new Location(45, -97));

		MapPolyline polyline = new MapPolyline();
		polyline.Points = points;

		this.polylineLayer.Items.Add(polyline);
	}
```
```VB.NET
	Private Sub radMap_InitializeCompleted(ByVal sender As Object, ByVal e As EventArgs)
				If Not initialized Then
					initialized = True
	
					Me.BuildPolyline()
				End If
	End Sub
	
	Private Sub BuildPolyline()
		Dim points As New LocationCollection()
		points.Add(New Location(40, -100))
		points.Add(New Location(41, -101))
		points.Add(New Location(40, -102))
		points.Add(New Location(43, -103))
		points.Add(New Location(45, -97))

		Dim polyline As New MapPolyline()
		polyline.Points = points

		Me.polylineLayer.Items.Add(polyline)
	End Sub
```

And now to the essential part of our scenario – the pinpoints. Add a MapPinPoint instance for each vertex of the original polyline shape you are displaying. This is easy since the polyline itself was created from a set of predefined locations. To be able to modify the shape of our polyline on dragging the pinpoints we’ll attach the following three mouse events:

* __MouseLeftButtonDown__ - used to capture the mouse and to enable dragging

* __MouseLeftButtonUp__ - releases mouse capture and disables dragging.

* __MouseMove__ - gets the coordinates of the clicked pinpoint relative to the map control screen coordinates. Then redraw the polyline respecting the new location of its vertex.  Both actions are easily achieved via the static SetLocation() and GetLocation() methods of the MapLayer helper class:

	```C#
		private void pinPoint_MouseMove(object sender, MouseEventArgs e)
		{
			if (!this.isDragging)
				return;

			var pinPoint = sender as MapPinPoint;
			var oldLocation = MapLayer.GetLocation(pinPoint);
			var location = Location.GetCoordinates(radMap, e.GetPosition(radMap));
			MapLayer.SetLocation(sender as DependencyObject, location);

			var polyline = this.polylineLayer.Items[0] as MapPolyline;
			for (int i = 0; i < polyline.Points.Count; i++)
			{
				var locationPoint = polyline.Points[i];
				if (locationPoint == oldLocation)
				{
					polyline.Points[i] = location;
					break;
				}
			}
			e.Handled = true;

		}
	```
	```VB.NET
		Private Sub pinPoint_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
				If Not Me.isDragging Then
					Return
				End If

				Dim pinPoint = TryCast(sender, MapPinPoint)
				Dim oldLocation = MapLayer.GetLocation(pinPoint)
				Dim location = Location.GetCoordinates(radMap, e.GetPosition(radMap))
				MapLayer.SetLocation(TryCast(sender, DependencyObject), location)

				Dim polyline = TryCast(Me.polylineLayer.Items(0), MapPolyline)
				For i As Integer = 0 To polyline.Points.Count - 1
					Dim locationPoint = polyline.Points(i)
					If locationPoint Is oldLocation Then
						polyline.Points(i) = location
						Exit For
					End If
				Next i
			        e.Handled = True
		End Sub
	```

>tip The full source code can be downloaded from our blogpost [here](http://blogs.telerik.com/xamlteam/posts/12-01-09/radmap-for-silverlight-wpf-how-to-resize-map-shapes-with-mouse-dragging.aspx).
