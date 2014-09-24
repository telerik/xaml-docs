#region raddiagram-features-routing-0
public MainPage()
{
	InitializeComponent();
	OrgTreeRouter router = new OrgTreeRouter()
	{
		 TreeLayoutType = TreeLayoutType.TreeDown,
		 ConnectionOuterSpacing = 20,
	};
	this.diagram.RoutingService.Router = router;
}
#endregion

#region raddiagram-features-routing-1
public class CustomRouter : IRouter
{
	public System.Collections.Generic.IList<Point> GetRoutePoints(IConnection connection, bool showLastLine)
	{
		List<Point> pointList = new List<Point>();
		Point start = connection.StartPoint;
		Point end = connection.EndPoint;

		pointList.Add(new Point(start.X + (end.X - start.X)*0.45, start.Y));
		pointList.Add(new Point((start.X + end.X)/2 , (start.Y + end.Y) / 2 - 50));
		pointList.Add(new Point((start.X + end.X)/2, (start.Y + end.Y) / 2 + 50));
		pointList.Add(new Point(start.X + (end.X - start.X) * 0.55, end.Y));	

		return pointList;
	}
}
#endregion

#region raddiagram-features-routing-2
this.diagram.RoutingService.Router = new CustomRouter();
#endregion
#region raddiagram-features-routing-3
	private void RadButton_Click(object sender, RoutedEventArgs e)
		{
			PrepareShapesForTipOverTreeRouting();
			TreeLayoutSettings settings = new TreeLayoutSettings()
			{
				TreeLayoutType = TreeLayoutType.TipOverTree,
				UnderneathVerticalSeparation = 50,
				VerticalDistance = 50,
				UnderneathHorizontalOffset = 50,
				UnderneathVerticalTopOffset = 50
			};
			settings.Roots.Add(this.diagram.Shapes[0]);
			OrgTreeRouter router = new OrgTreeRouter()
			{
				TreeLayoutType = TreeLayoutType.TipOverTree,
				ConnectionOuterSpacing = 10
			};
			this.diagram.RoutingService.Router = router;
			this.diagram.Layout(LayoutType.Tree, settings);
		}

		private void PrepareShapesForTipOverTreeRouting()
		{
			foreach (var item in this.diagram.Shapes)
			{
				var connector = new RadDiagramConnector(){Offset = new Point(0.2, 1)};
				connector.Name = CustomConnectorPosition.TreeLeftBottom;
				item.Connectors.Add(connector);
			}
		}
		#endregion
