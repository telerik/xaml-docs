#region raddiagram-features-grouping-0
private void RadButton_Click_1(object sender, RoutedEventArgs e)
{
		for (int i = 1; i < 21; i++)
		{
			RadDiagramShape shape = new RadDiagramShape() { Width = 30, Height = 30, Content = i };
			shape.Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.EllipseShape);
			shape.Position = new Point(random.Next(0, 900), random.Next(0, 200));
			this.diagram.Items.Add(shape);
		}
}
#endregion

#region raddiagram-features-grouping-1
private void RadButton_Click_3(object sender, RoutedEventArgs e)
{
	IShape[] evenShapes = this.diagram.Shapes.Where(x => int.Parse(x.Content.ToString()) % 2 == 0).ToArray<IShape>();
	IShape[] oddShapes = this.diagram.Shapes.Where(x => int.Parse(x.Content.ToString()) % 2 == 1).ToArray<IShape>();
	this.diagram.Group("Even", evenShapes);
	this.diagram.Group("Odd", oddShapes);
}
#endregion