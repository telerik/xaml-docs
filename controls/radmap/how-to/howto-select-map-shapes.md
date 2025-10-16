---
title: Select Map Shapes
page_title: Select Map Shapes
description: Check our &quot;Select Map Shapes&quot; documentation article for the RadMap {{ site.framework_name }} control.
slug: radmap-howto-select-map-shapes
tags: select,map,shapes
published: True
position: 8
---

# Select Map Shapes

RadMap provides a rich set of [geocoordinate-enabled shapes]({%slug radmap-features-map-shapes%}) that can be defined and displayed onto the map surface. There are scenarios, however, where you would like to do more than just position a shape onto the map. This help topic will demonstrate how to manipulate each individual segment of line/polyline/polygon shape based on mouse input from the user. For example we will select (highlight) a Line segment of the Polyline and set a green color for it. The Polyline itself will be colored blue and on click it will become red. All these customizations will be made through styles:


```XAML
	<Style x:Key="defaultLineStyle" TargetType="telerik:MapShape">
		<Setter Property="StrokeThickness" Value="3" />
		<Setter Property="Stroke" Value="Transparent" />
	</Style>
	<Style x:Key="selectedLineStyle" TargetType="telerik:MapShape">
		<Setter Property="StrokeThickness" Value="3" />
		<Setter Property="Stroke" Value="Green" />
	</Style>
	<Style x:Key="defaultPolylineStyle" TargetType="telerik:MapShape">
		<Setter Property="StrokeThickness" Value="3" />
		<Setter Property="Stroke" Value="Blue" />
	</Style>
	<Style x:Key="selectedPolylineStyle" TargetType="telerik:MapShape">
		<Setter Property="StrokeThickness" Value="3" />
		<Setter Property="Stroke" Value="Red" />
	</Style>
```

First of all we’ll need two Information layers – one for the polyline and the other one for the points that we will use for the shape manipulation.


```XAML
	<telerik:RadMap x:Name="radMap"
						InitializeCompleted="radMap_InitializeCompleted"
						Center="40,-100"
						ZoomLevel="4">
		<telerik:RadMap.Provider>
			<telerik:OpenStreetMapProvider />
		</telerik:RadMap.Provider>

		<telerik:InformationLayer x:Name="polylineLayer" />
		<telerik:InformationLayer x:Name="lineLayer" />

	</telerik:RadMap>
```

Now we will create a sample polyline and add it to the first information layer. Note that it is better to do this after the map provider has been initialized in order to prevent your items from appearing in the upper left corner before the map is initialized and loaded:


```C#
    private bool initialized;

    // selected segment and polyline 
    private MapLine selectedLine;
    private MapPolyline selectedPolyline;

    public MainPage()
    {
        InitializeComponent();
    }

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
        this.SetDefaultStyle(polyline);

        this.polylineLayer.Items.Add(polyline);
        this.BuildLines(polyline);
    }
```
```VB.NET
Private initialized As Boolean

    ' selected segment and polyline '
    Private selectedLine As MapLine
    Private selectedPolyline As MapPolyline
	
    Public Sub New()
        InitializeComponent()
    End Sub

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
        Me.SetDefaultStyle(polyline)

        Me.polylineLayer.Items.Add(polyline)
        Me.BuildLines(polyline)
    End Sub
```

And now to the essential part of our scenario. Add a Line over each segment of the polyline. This is easy since the polyline itself was created from a set of predefined points(locations). To be able to change the appearance of the polyline or its segments on click we’ll attach a __MouseLeftButtonDown__ event on the line:


```C#
	private void BuildLines(MapPolyline polyline)
	{
		for (int i = 0; i < polyline.Points.Count - 1; i++)
		{
			Location point1 = polyline.Points[i];
			Location point2 = polyline.Points[i + 1];
			MapLine line = new MapLine()
			{
				Point1 = point1,
				Point2 = point2
			};

			this.SetDefaultStyle(line);

			line.MouseLeftButtonDown += new MouseButtonEventHandler(line_MouseLeftButtonDown);
			line.Tag = polyline;

			this.lineLayer.Items.Add(line);
		}
	}

	private void line_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
	{
		MapLine line = sender as MapLine;
		if (line != null)
		{
			if (this.selectedLine != null)
			{
				this.SetDefaultStyle(this.selectedLine);
			}

			if (this.selectedPolyline != null)
			{
				this.SetDefaultStyle(this.selectedPolyline);
			}

			this.selectedLine = line;
			this.selectedPolyline = line.Tag as MapPolyline;

			this.SetSelectedStyle(this.selectedLine);
			this.SetSelectedStyle(this.selectedPolyline);
		}
	}
```
```VB.NET
	Private Sub BuildLines(ByVal polyline As MapPolyline)
		For i As Integer = 0 To polyline.Points.Count - 2
			Dim point1 As Location = polyline.Points(i)
			Dim point2 As Location = polyline.Points(i + 1)
			Dim line As New MapLine() With {.Point1 = point1, .Point2 = point2}

			Me.SetDefaultStyle(line)

			AddHandler line.MouseLeftButtonDown, AddressOf line_MouseLeftButtonDown
			line.Tag = polyline

			Me.lineLayer.Items.Add(line)
		Next i
	End Sub

	Private Sub line_MouseLeftButtonDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
		Dim line As MapLine = TryCast(sender, MapLine)
		If line IsNot Nothing Then
			If Me.selectedLine IsNot Nothing Then
				Me.SetDefaultStyle(Me.selectedLine)
			End If

			If Me.selectedPolyline IsNot Nothing Then
				Me.SetDefaultStyle(Me.selectedPolyline)
			End If

			Me.selectedLine = line
			Me.selectedPolyline = TryCast(line.Tag, MapPolyline)

			Me.SetSelectedStyle(Me.selectedLine)
			Me.SetSelectedStyle(Me.selectedPolyline)
		End If
	End Sub
```

In event's body you check whether the selected shape is line or the whole polyline and apply the style for it.


```C#
    private void SetDefaultStyle(MapShape shape)
    {
        if (shape is MapLine)
        {
            shape.Style = this.Resources["defaultLineStyle"] as Style;
        }
        else
        {
            shape.Style = this.Resources["defaultPolylineStyle"] as Style;
        }
    }

    private void SetSelectedStyle(MapShape shape)
    {
        if (shape is MapLine)
        {
            shape.Style = this.Resources["selectedLineStyle"] as Style;
        }
        else
        {
            shape.Style = this.Resources["selectedPolylineStyle"] as Style;
        }
    } 
```
```VB.NET
	Private Sub SetDefaultStyle(ByVal shape As MapShape)
				If TypeOf shape Is MapLine Then
					shape.Style = TryCast(Me.Resources("defaultLineStyle"), Style)
				Else
					shape.Style = TryCast(Me.Resources("defaultPolylineStyle"), Style)
				End If
	End Sub
	
	Private Sub SetSelectedStyle(ByVal shape As MapShape)
		If TypeOf shape Is MapLine Then
			shape.Style = TryCast(Me.Resources("selectedLineStyle"), Style)
		Else
			shape.Style = TryCast(Me.Resources("selectedPolylineStyle"), Style)
		End If
	End Sub
```

## See Also
 * [Resize Map Shapes With Mouse Dragging]({%slug radmap-howto-resize-map-shapes-with-mouse-dragging%})
 * [Set the Best View for the InformationLayer]({%slug radmap-how-to-set-the-best-view-for-the-informationlayer%})
 * [Bring a Location into View]({%slug radmap-how-to-bring-a-location-into-view%})