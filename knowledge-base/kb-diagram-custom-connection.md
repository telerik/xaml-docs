---
title: Create Custom RadDiagramConnection
page_title: Custom RadDiagramConnection 
description: Currently the RadDiagramConnection and Cap elements are represented by one Path object. To achieve further customization, extend the base implementation of the RadDiagramConnection element.
type: how-to
slug: kb-diagram-custom-connection-cap
position: 0
tags: diagram, connection, cap
ticketid: 1542456
res_type: kb
category: knowledge-base
---

## Environment
<table>
	<tbody>
		<tr>
			<td>Product Version</td>
			<td>2021.1.325</td>
		</tr>
		<tr>
			<td>Product</td>
			<td>Diagram for WPF</td>
		</tr>
	</tbody>
</table>

## Description

With the current implementation of the __RadDiagram__ control applying properties to a __RadDiagramConnection__ element will also apply them to the Connection Cap. This is because the __ConnectionLine__ and __ConnectionCap__ elements are visualized by a single native __Path__ control. To further customize the separate elements, the default implementation of the __RadDiagramConnection__ control, would need to be extended.

## Solution

To extend the base implementation of the __RadDiagramConnection__ element, extract its default control template, and add two additional __Path__ controls.

#### __[XAML]__

{{region kb-diagram-custom-connection-cap_0}}
	<Path x:Name="SourceConnectionCap" Fill="{TemplateBinding Background}" 
      Stroke="{TemplateBinding Stroke}" 
      StrokeThickness="{TemplateBinding StrokeThickness}"/>
	<Path x:Name="TargetConnectionCap" Fill="{TemplateBinding Background}" 
      Stroke="{TemplateBinding Stroke}" 
      StrokeThickness="{TemplateBinding StrokeThickness}"/>
{{endregion}}

Create a class that derives from the __RadDiagramConnection__ class and implement the following logic for handling the two additional path elements.

#### __[C#]__

{{region kb-diagram-custom-connection-cap_1}}
	public class CustomConnection : RadDiagramConnection
	{
	    private Path sourceConnectionCap;
	    private Path targetConnectionCap;

	    public override void OnApplyTemplate()
	    {
	        base.OnApplyTemplate();
	        this.sourceConnectionCap = (Path)this.GetTemplateChild("SourceConnectionCap");
	        this.targetConnectionCap = (Path)this.GetTemplateChild("TargetConnectionCap");
	        this.UpdateGeometryOverride();
	    }

	    protected override Geometry CreateGeometry(BridgeType bridgeType, bool roundedCorners)
	    {
	        this.AddConnectionCaps();
	        return base.CreateGeometry(bridgeType, roundedCorners);
	    }

	    private void AddConnectionCaps()
	    {
	        if (this.sourceConnectionCap != null && this.targetConnectionCap != null)
	        {
	            var sourcePoint = this.StartPoint.Substract(this.Position);
	            var targetPoint = this.EndPoint.Substract(this.Position);
	            var transformedPoints = this.TranslateConnectionPoints(false).ToList();

	            Point sourceCapSecondPoint;
	            Point targetCapSecondPoint;
	            if (this.ConnectionType == ConnectionType.Spline)
	            {
	                var points = new List<Point> { sourcePoint };
	                points.AddRange(transformedPoints);
	                points.Add(targetPoint);
	                GeometryExtensions.GetSplineFigureTangents(points, out 	sourceCapSecondPoint, out targetCapSecondPoint);
	            }
	            else
	            {
	                sourceCapSecondPoint = transformedPoints.Count == 0 ? targetPoint : 	transformedPoints[0];
	                targetCapSecondPoint = transformedPoints.Count == 0 ? sourcePoint : 	transformedPoints[transformedPoints.Count - 1];
	            }

	            if (this.SourceCapType != CapType.None)
	            {
	                this.sourceConnectionCap.Data = CreateSourceCapGeometryData(sourcePoint, 	sourceCapSecondPoint, ref sourcePoint);
	            }
	            if (this.TargetCapType != CapType.None)
	            {
	                this.targetConnectionCap.Data = CreateTargetCapGeometryData(targetPoint, 	targetCapSecondPoint, ref targetPoint);
	            }
	        }
	    }

	    private Geometry CreateSourceCapGeometryData(Point startPoint, Point endPoint, ref 	Point baseLineStart)
	    {
	        var geometry = new PathGeometry();
	        geometry.Figures.Add(this.CreateSourceCapGeometry(startPoint, endPoint, ref 	baseLineStart));
	        return geometry;
	    }

	    private Geometry CreateTargetCapGeometryData(Point startPoint, Point endPoint, ref 	Point baseLineStart)
	    {
	        var geometry = new PathGeometry();
	        geometry.Figures.Add(this.CreateTargetCapGeometry(startPoint, endPoint, ref 	baseLineStart));
	        return geometry;
	    }
	}
{{endregion}}

#### __[VB.NET]__

{{region kb-diagram-custom-connection-cap_2}}
	Public Class CustomConnection
	    Inherits RadDiagramConnection

	    Private sourceConnectionCap As Path
	    Private targetConnectionCap As Path

	    Public Overrides Sub OnApplyTemplate()
	        MyBase.OnApplyTemplate()
	        Me.sourceConnectionCap = CType(Me.GetTemplateChild("SourceConnectionCap"), Path)
	        Me.targetConnectionCap = CType(Me.GetTemplateChild("TargetConnectionCap"), Path)
	        Me.UpdateGeometryOverride()
	    End Sub

	    Protected Overrides Function CreateGeometry(ByVal bridgeType As BridgeType, ByVal 	roundedCorners As Boolean) As Geometry
	        Me.AddConnectionCaps()
	        Return MyBase.CreateGeometry(bridgeType, roundedCorners)
	    End Function

	    Private Sub AddConnectionCaps()
	        If Me.sourceConnectionCap IsNot Nothing AndAlso Me.targetConnectionCap IsNot 	Nothing Then
	            Dim sourcePoint = Me.StartPoint.Substract(Me.Position)
	            Dim targetPoint = Me.EndPoint.Substract(Me.Position)
	            Dim transformedPoints = Me.TranslateConnectionPoints(False).ToList()
	            Dim sourceCapSecondPoint As Point
	            Dim targetCapSecondPoint As Point

	            If Me.ConnectionType = ConnectionType.Spline Then
	                Dim points = New List(Of Point) From {
	                    sourcePoint
	                }
	                points.AddRange(transformedPoints)
	                points.Add(targetPoint)
	                GeometryExtensions.GetSplineFigureTangents(points, sourceCapSecondPoint, 	targetCapSecondPoint)
	            Else
	                sourceCapSecondPoint = If(transformedPoints.Count = 0, targetPoint, 	transformedPoints(0))
	                targetCapSecondPoint = If(transformedPoints.Count = 0, sourcePoint, 	transformedPoints(transformedPoints.Count - 1))
	            End If

	            If Me.SourceCapType <> CapType.None Then
	                Me.sourceConnectionCap.Data = CreateSourceCapGeometryData(sourcePoint, 	sourceCapSecondPoint, sourcePoint)
	            End If

	            If Me.TargetCapType <> CapType.None Then
	                Me.targetConnectionCap.Data = CreateTargetCapGeometryData(targetPoint, 	targetCapSecondPoint, targetPoint)
	            End If
	        End If
	    End Sub

	    Private Function CreateSourceCapGeometryData(ByVal startPoint As Point, ByVal endPoint 	As Point, ByRef baseLineStart As Point) As Geometry
	        Dim geometry = New PathGeometry()
	        geometry.Figures.Add(Me.CreateSourceCapGeometry(startPoint, endPoint, 	baseLineStart))
	        Return geometry
	    End Function

	    Private Function CreateTargetCapGeometryData(ByVal startPoint As Point, ByVal endPoint 	As Point, ByRef baseLineStart As Point) As Geometry
	        Dim geometry = New PathGeometry()
	        geometry.Figures.Add(Me.CreateTargetCapGeometry(startPoint, endPoint, 	baseLineStart))
	        Return geometry
	    End Function
	End Class
{{endregion}}

The result is a custom connection element, which can be used both in Xaml and in code.

#### __[XAML]__

{{region kb-diagram-custom-connection-cap_3}}
	<telerik:RadDiagram>
		<!--values set for the new custom Path properties-->
	    <local:CustomConnection StartPoint="400, 100" 
	                            EndPoint="200, 100"
	                            SourceCapType="Arrow2" 
	                            TargetCapType="Arrow2"                                     
								SourceCapSize="6, 6" 
	                            TargetCapSize="6, 6"/>
	</telerik:RadDiagram>
{{endregion}}

#### __[C#]__

{{region kb-diagram-custom-connection-cap_4}}
	var connection = new CustomConnection() 
    {
        SourceCapType = Telerik.Windows.Diagrams.Core.CapType.Arrow1,
        TargetCapType = Telerik.Windows.Diagrams.Core.CapType.Arrow2,
        StartPoint = new Point(400, 100),
        EndPoint = new Point(200, 100)
    };

    this.diagram.Items.Add(connection);
{{endregion}}

#### __[VB.NET]__

{{region kb-diagram-custom-connection-cap_5}}
    Dim connection = New CustomConnection() With
    {
        .SourceCapType = Telerik.Windows.Diagrams.Core.CapType.Arrow1,
        .TargetCapType = Telerik.Windows.Diagrams.Core.CapType.Arrow2,
        .StartPoint = New Point(400, 100),
        .EndPoint = New Point(200, 100)
    }
	
    diagram.Items.Add(connection)
{{endregion}}