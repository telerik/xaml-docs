#region raddiagram-features-customconnectors-0
Dim shape = New RadDiagramShape()
Dim connector = New RadDiagramConnector() With { 
	 .Offset = New Point(1, 0.67), 
	 .Name = "CustomConnector1" 
}
shape.Connectors.Add(connector)
#endregion

#region raddiagram-features-customconnectors-1
Me.diagram.Shapes.ToList().ForEach(Function(x) 
	Dim connectorUpRight = New RadDiagramConnector() With {
		 .Offset = New Point(1, 0.25),  .Name = x.Name.ToString() & "Connector1"
	}
	Dim connectorDownRight = New RadDiagramConnector() With {
		 .Offset = New Point(1, 0.75), 	 .Name = x.Name.ToString() & "Connector2" 
	}
	Dim connectorLeftUp = New RadDiagramConnector() With { 
		 .Offset = New Point(0, 0.25),  .Name = x.Name.ToString() & "Connector3" 
	}
	Dim connectorLeftDown = New RadDiagramConnector() With { 
		 .Offset = New Point(0, 0.75),  .Name = x.Name.ToString() & "Connector4" 
	}

	x.Connectors.Add(connectorUpRight)
	x.Connectors.Add(connectorDownRight)
	x.Connectors.Add(connectorLeftUp)
	x.Connectors.Add(connectorLeftDown)

End Function)
#endregion

#region raddiagram-features-customconnectors-2
Dim connection = Me.diagram.AddConnection(Me.diagram.Shapes(0), Me.diagram.Shapes(1), "match1shapeConnector1", "match2shapeConnector3")
TryCast(connection, RadDiagramConnection).Stroke = New SolidColorBrush() With { .Color = Color.FromArgb(255, 255, 116, 2) }

Dim connection2 = Me.diagram.AddConnection(Me.diagram.Shapes(1), Me.diagram.Shapes(2), "match2shapeConnector1", "match3shapeConnector4")
TryCast(connection2, RadDiagramConnection).Stroke = New SolidColorBrush() With { .Color = Color.FromArgb(255, 255, 116, 2) }


Dim connection3 = Me.diagram.AddConnection(Me.diagram.Shapes(0), Me.diagram.Shapes(4), "match1shapeConnector2", "match5shapeConnector3")
TryCast(connection3, RadDiagramConnection).Stroke = New SolidColorBrush() With { .Color = Color.FromArgb(255, 242, 8, 8) }

Dim connection4 = Me.diagram.AddConnection(Me.diagram.Shapes(4), Me.diagram.Shapes(5), "match5shapeConnector1", "match6shapeConnector3")
TryCast(connection4, RadDiagramConnection).Stroke = New SolidColorBrush() With { .Color = Color.FromArgb(255, 242, 8, 8) }

Dim connection5 = New RadDiagramConnection() With { .Stroke = New SolidColorBrush() With { .Color = Color.FromArgb(255, 30, 30, 27) } }
connection5.Attach(Me.diagram.Shapes(3).Connectors(5), Me.diagram.Shapes(1).Connectors(8))
Me.diagram.Items.Add(connection5)

Dim connection6 = New RadDiagramConnection() With { .Stroke = New SolidColorBrush() With { .Color = Color.FromArgb(255, 30, 30, 27) } }
connection6.Attach(Me.diagram.Shapes(1).Connectors(6), Me.diagram.Shapes(5).Connectors(8))
Me.diagram.Items.Add(connection6)

Dim connection7 = New RadDiagramConnection() With { .Stroke = New SolidColorBrush() With { .Color = Color.FromArgb(255, 23, 156, 72) } }
connection7.Attach(Me.diagram.Shapes(3).Connectors(6), Me.diagram.Shapes(4).Connectors(8))
Me.diagram.Items.Add(connection7)

Dim connection8 = New RadDiagramConnection() With { .Stroke = New SolidColorBrush() With { .Color = Color.FromArgb(255, 23, 156, 72) } }
connection8.Attach(Me.diagram.Shapes(4).Connectors(6), Me.diagram.Shapes(2).Connectors(7))
Me.diagram.Items.Add(connection8)
#endregion