#region raddiagram-features-layout-0
private void RadButton_Click(object sender, RoutedEventArgs e)
{
	SugiyamaSettings settings = new SugiyamaSettings()
	{
		HorizontalDistance = 50,
		VerticalDistance = 20,
		Orientation =  Telerik.Windows.Diagrams.Core.Orientation.Horizontal,
		TotalMargin = new Size(20,20),
		ShapeMargin = new Size(10,10),	
	};
	this.diagram.Layout(LayoutType.Sugiyama, settings);
}
#endregion
#region raddiagram-features-layout-1
private void RadButton_Click(object sender, RoutedEventArgs e)
{
	TreeLayoutSettings settings = new TreeLayoutSettings()
	{
		TreeLayoutType = TreeLayoutType.TreeDown,
		VerticalDistance = 20,				
	};
	settings.Roots.Add(this.diagram.Shapes[0]);
	this.diagram.Layout(LayoutType.Tree, settings);
}
#endregion