#region raddiagram-features-customconnectors-0
var shape = new RadDiagramShape();
var connector = new RadDiagramConnector(){Offset = new Point(1, 0.67), Name = "CustomConnector1"};
shape.Connectors.Add(connector);
#endregion

#region raddiagram-features-customconnectors-1
this.diagram.Shapes.ToList().ForEach(x =>
{
	var connectorUpRight = new RadDiagramConnector() { Offset = new Point(1, 0.25), Name = x.Name + "Connector1" };
	var connectorDownRight = new RadDiagramConnector() { Offset = new Point(1, 0.75), Name = x.Name + "Connector2" };
	var connectorLeftUp = new RadDiagramConnector() { Offset = new Point(0, 0.25), Name = x.Name + "Connector3" };
	var connectorLeftDown = new RadDiagramConnector() { Offset = new Point(0, 0.75), Name = x.Name + "Connector4" };

	x.Connectors.Add(connectorUpRight);
	x.Connectors.Add(connectorDownRight);
	x.Connectors.Add(connectorLeftUp);
	x.Connectors.Add(connectorLeftDown);
});
#endregion
#region raddiagram-features-customconnectors-2
	var connection = this.diagram.AddConnection(this.diagram.Shapes[0], this.diagram.Shapes[1], "match1shapeConnector1", "match2shapeConnector3");
	(connection as RadDiagramConnection).Stroke = new SolidColorBrush() { Color = Color.FromArgb(255, 255, 116, 2) };

	var connection2 = this.diagram.AddConnection(this.diagram.Shapes[1], this.diagram.Shapes[2], "match2shapeConnector1", "match3shapeConnector4");
	(connection2 as RadDiagramConnection).Stroke = new SolidColorBrush() { Color = Color.FromArgb(255, 255, 116, 2) };


	var connection3 = this.diagram.AddConnection(this.diagram.Shapes[0], this.diagram.Shapes[4], "match1shapeConnector2", "match5shapeConnector3");
	(connection3 as RadDiagramConnection).Stroke = new SolidColorBrush() { Color = Color.FromArgb(255, 242, 8, 8) };

	var connection4 = this.diagram.AddConnection(this.diagram.Shapes[4], this.diagram.Shapes[5], "match5shapeConnector1", "match6shapeConnector3");
	(connection4 as RadDiagramConnection).Stroke = new SolidColorBrush() { Color = Color.FromArgb(255, 242, 8, 8) };

	var connection5 = new RadDiagramConnection(){Stroke = new SolidColorBrush(){Color = Color.FromArgb(255, 30, 30, 27)}};
	connection5.Attach(this.diagram.Shapes[3].Connectors[5], this.diagram.Shapes[1].Connectors[8]);
	this.diagram.Items.Add(connection5);

	var connection6 = new RadDiagramConnection() { Stroke = new SolidColorBrush() { Color = Color.FromArgb(255, 30, 30, 27) } };
	connection6.Attach(this.diagram.Shapes[1].Connectors[6], this.diagram.Shapes[5].Connectors[8]);
	this.diagram.Items.Add(connection6);

	var connection7 = new RadDiagramConnection() { Stroke = new SolidColorBrush() { Color = Color.FromArgb(255, 23, 156, 72) } };
	connection7.Attach(this.diagram.Shapes[3].Connectors[6], this.diagram.Shapes[4].Connectors[8]);
	this.diagram.Items.Add(connection7);

	var connection8 = new RadDiagramConnection() { Stroke = new SolidColorBrush() { Color = Color.FromArgb(255, 23, 156, 72) } };
	connection8.Attach(this.diagram.Shapes[4].Connectors[6], this.diagram.Shapes[2].Connectors[7]);
	this.diagram.Items.Add(connection8);
#endregion