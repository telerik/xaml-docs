#region raddiagram-data-code-behind-0
private void GenerateRadDiagram()
{
    RadDiagram diagram = new RadDiagram();

    RadDiagramShape shapeCloud = new RadDiagramShape()
    {
        Width = 180,
        Height = 100,
        Position = new Point() { X = 100, Y = 100},
        Content = "Cloud"
    };
    shapeCloud.Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.CloudShape);

    RadDiagramShape dbShape = new RadDiagramShape()
    {
        Width = 80,
        Height = 100,
        Position = new Point() { X = 400, Y = 100 },
        Content = "DB"
    };
    dbShape.Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.Database2Shape);

    RadDiagramConnection connection = new RadDiagramConnection()
    {
        Source = shapeCloud,
        SourceConnectorPosition = ConnectorPosition.Right,
        Target = dbShape,
        TargetConnectorPosition = ConnectorPosition.Left,
        SourceCapType = CapType.Arrow4,
        TargetCapType = CapType.Arrow5Filled,
        Content = new TextBlock() { Text = " Connection ", Foreground = new SolidColorBrush() { Color = Colors.Blue} }
    };
    diagram.Items.Add(shapeCloud);
    diagram.Items.Add(dbShape);
    diagram.Items.Add(connection);
    diagram.SelectAll();

    this.LayoutRoot.Children.Add(diagram);
}
#endregion
