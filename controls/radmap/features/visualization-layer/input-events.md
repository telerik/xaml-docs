---
title: Attaching input events to the map shapes
page_title: Attaching input events to the map shapes
description: Check our &quot;Attaching input events to the map shapes&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-visualization-layer-input-events
tags: attaching,input,events,to,the,map,shapes
published: True
position: 4
---

# Attaching input events to the map shapes

The visualization engine based on the VisualizationLayer class separates geographical data and its visualization. The map shape data classes aren’t dependency objects. It means that you can’t attach input events to these classes directly. Instead you can attach events to the map shape visualization. It allows assigning of any input events supported by ContentPresenter to the map shape visual presentation.        

The VisualizationLayer class provides 2 events:        

1. __MapShapeVisualizationCreated__ – occurs when map shape visualization object is created. Can be used to attach event handlers.            

1. __MapShapeVisualizationRemoved__ – occurs when map shape visualization object is removed. Can be used to detach event handlers.            

Here it is an example which attaches MouseEnter and MouseLeave events to the map shape visualization object:        


```XAML
	<telerik:RadMap x:Name="radMap"
	                ZoomLevel="8"
	                Center="42.6957539183824, 23.3327663758679">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Provider>
		<telerik:VisualizationLayer x:Name="visualizationLayer"
	                                MapShapeVisualizationCreated="MapShapeVisualizationCreated"
	                                MapShapeVisualizationRemoved="MapShapeVisualizationRemoved">
			<telerik:RectangleData Location="42.9457539183824,23.0827663758679"
	                               Height="0.5"
	                               Width="0.5"
	                               RadiusX="0.05"
	                               RadiusY="0.05">
				<telerik:RectangleData.ShapeFill>
					<telerik:MapShapeFill Fill="#6FDFEFFF"
	                                      Stroke="Blue"
	                                      StrokeThickness="2" />
				</telerik:RectangleData.ShapeFill>
				<telerik:RectangleData.HighlightFill>
					<telerik:MapShapeFill Fill="#6F00EFFF"
	                                      Stroke="Red"
	                                      StrokeThickness="2" />
				</telerik:RectangleData.HighlightFill>
			</telerik:RectangleData>
		</telerik:VisualizationLayer>
	</telerik:RadMap>
```


```C#
	private void MapShapeVisualizationCreated(object sender, MapShapeOperationEventArgs e)
	{
		if (e.Visualization != null)
		{
			// Attach mouse events to the map shape visualization.
			e.Visualization.MouseEnter += this.Visualization_MouseEnter;
			e.Visualization.MouseLeave += this.Visualization_MouseLeave;
		}
	}
	
	private void MapShapeVisualizationRemoved(object sender, MapShapeOperationEventArgs e)
	{
		if (e.Visualization != null)
		{
			// Detach mouse events to the map shape visualization.
			e.Visualization.MouseEnter -= this.Visualization_MouseEnter;
			e.Visualization.MouseLeave -= this.Visualization_MouseLeave;
		}
	}
	
	private void Visualization_MouseEnter(object sender, MouseEventArgs e)
	{
		// Highlight shape when mouse enter.
		FrameworkElement elt = sender as FrameworkElement;
		if (elt != null)
		{
			MapShapeData data = elt.DataContext as MapShapeData;
			data.UseHighlightFill();
		}
	}
	
	private void Visualization_MouseLeave(object sender, MouseEventArgs e)
	{
		// Use regular fill when mouse leave the shape.
		FrameworkElement elt = sender as FrameworkElement;
		if (elt != null)
		{
			MapShapeData data = elt.DataContext as MapShapeData;
			data.UseRegularFill();
		}
	}
```
```VB.NET
	Private Sub MapShapeVisualizationCreated(sender As Object, e As MapShapeOperationEventArgs)
		If e.Visualization IsNot Nothing Then
			' Attach mouse events to the map shape visualization.'
			AddHandler e.Visualization.MouseEnter, AddressOf Me.Visualization_MouseEnter
			AddHandler e.Visualization.MouseLeave, AddressOf Me.Visualization_MouseLeave
			End If
		End Sub
	
	Private Sub MapShapeVisualizationRemoved(sender As Object, e As MapShapeOperationEventArgs)
		If e.Visualization IsNot Nothing Then
			' Detach mouse events to the map shape visualization.'
			RemoveHandler e.Visualization.MouseEnter, AddressOf Me.Visualization_MouseEnter
			RemoveHandler e.Visualization.MouseLeave, AddressOf Me.Visualization_MouseLeave
		End If
	End Sub
	
	Private Sub Visualization_MouseEnter(sender As Object, e As MouseEventArgs)
		' Highlight shape when mouse enter.'
		Dim elt As FrameworkElement = TryCast(sender, FrameworkElement)
		If elt IsNot Nothing Then
			Dim data As MapShapeData = TryCast(elt.DataContext, MapShapeData)
			data.UseHighlightFill()
		End If
	End Sub
	
	Private Sub Visualization_MouseLeave(sender As Object, e As MouseEventArgs)
		' Use regular fill when mouse leave the shape.'
		Dim elt As FrameworkElement = TryCast(sender, FrameworkElement)
		If elt IsNot Nothing Then
			Dim data As MapShapeData = TryCast(elt.DataContext, MapShapeData)
			data.UseRegularFill()
		End If
	End Sub
```