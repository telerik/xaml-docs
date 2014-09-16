#region raddiagram-features-routing-0
Public Sub New()
	InitializeComponent()
	Dim router As New OrgTreeRouter() With { 
		 .TreeLayoutType = TreeLayoutType.TreeDown, 
		 .ConnectionOuterSpacing = 20 _
	
	Me.diagram.RoutingService.Router = router
End Sub
#endregion

#region raddiagram-features-routing-1
Public Class CustomRouter
	Implements IRouter
	Public Function GetRoutePoints(connection As IConnection, showLastLine As Boolean) As System.Collections.Generic.IList(Of Point)
		Dim pointList As New List(Of Point)()
		Dim start As Point = connection.StartPoint
		Dim [end] As Point = connection.EndPoint

		pointList.Add(New Point(start.X + ([end].X - start.X) * 0.45, start.Y))
		pointList.Add(New Point((start.X + [end].X) / 2, (start.Y + [end].Y) / 2 - 50))
		pointList.Add(New Point((start.X + [end].X) / 2, (start.Y + [end].Y) / 2 + 50))
		pointList.Add(New Point(start.X + ([end].X - start.X) * 0.55, [end].Y))

		Return pointList
	End Function
End Class
#endregion

#region raddiagram-features-routing-2
this.diagram.RoutingService.Router = new CustomRouter();
#endregion
#region raddiagram-features-routing-3
Private Sub RadButton_Click(sender As Object, e As RoutedEventArgs)
	PrepareShapesForTipOverTreeRouting()
	Dim settings As New TreeLayoutSettings() With { 
		 .TreeLayoutType = TreeLayoutType.TipOverTree, 
		 .UnderneathVerticalSeparation = 50, 
		 .VerticalDistance = 50, 
		 .UnderneathHorizontalOffset = 50, 
		 .UnderneathVerticalTopOffset = 50 
	}
	settings.Roots.Add(Me.diagram.Shapes(0))
	Dim router As New OrgTreeRouter() With { 
		 .TreeLayoutType = TreeLayoutType.TipOverTree, 
		 .ConnectionOuterSpacing = 10 
	}
	Me.diagram.RoutingService.Router = router
	Me.diagram.Layout(LayoutType.Tree, settings)
End Sub

Private Sub PrepareShapesForTipOverTreeRouting()
	For Each item As var In Me.diagram.Shapes
		Dim connector = New RadDiagramConnector() With {
			.Offset = New Point(0.2, 1)
		}
		connector.Name = CustomConnectorPosition.TreeLeftBottom
		item.Connectors.Add(connector)
	Next
End Sub
#endregion
