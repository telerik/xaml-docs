#region raddiagrams-features-pan-zoom-0
DiagramConstants.MinimumZoom = 0.2;
DiagramConstants.MaximumZoom = 10;
#endregion
#region raddiagrams-features-pan-zoom-1
//zoom in with a factor of 0.67
private void CustomZoomIn()
{
    this.xDiagram.ZoomIn(0.67);
}
//zoom out with a factor of 0.67
private void CustomZoomOut()
{
    this.xDiagram.ZoomOut(0.67);
}
#endregion
#region raddiagrams-features-pan-zoom-2
//zoom in around the point with coordinates of (125,200)
private void ZoomIn(object sender, RoutedEventArgs e)
{
    this.xDiagram.ZoomIn(null,new Point(125, 200));
}
//zoom out around the point with coordinates of (100,125)
private void ZoomOut(object sender, RoutedEventArgs e)
{
    this.xDiagram.ZoomOut(null,new Point(100,125));
}
#endregion
#region raddiagrams-features-pan-zoom-3
//zoom in around the point with coordinates of (125,200) with a zoom factor of 0.67
private void ZoomIn(object sender, RoutedEventArgs e)
{
    this.xDiagram.ZoomIn(0.67,new Point(125, 200));
}
//zoom out around the point with coordinates of (100,125) with a zoom factor of 0.67
private void ZoomOut(object sender, RoutedEventArgs e)
{
    this.xDiagram.ZoomOut(0.67,new Point(100,125));
}
#endregion
#region raddiagrams-features-pan-zoom-4
private void xDiagram_PreviewZoom(object sender, DiagramZoomEventArgs e)
{
    double delta = e.TargetZoom - e.Zoom;
    var newZoom = delta > 0 ? e.Zoom * 1.5 : e.Zoom / 1.5;

    if (DiagramConstants.MinimumZoom <= newZoom && newZoom <= DiagramConstants.MaximumZoom)
    {
        e.TargetZoom = newZoom;
    }
    else
    {
        e.Handled = true;
    }
}
#endregion
#region raddiagrams-features-pan-zoom-5
private List<double> availableZooms = new List<double>() { .1, .125, .16, .2, .25, .33, .5, .67, 1, 1.5, 2, 3, 4, 5, 6, 8, 10 };
private void xDiagram_PreviewZoom(object sender, DiagramZoomEventArgs e)
{
    double delta = e.TargetZoom - e.Zoom;
    int index = this.availableZooms.IndexOf(e.Zoom);
    var newIndex = delta > 0 ? index + 1 : index - 1;

    if (delta != 0 && 0 <= newIndex && newIndex < this.availableZooms.Count)
    {
        e.TargetZoom = this.availableZooms.ElementAt(newIndex);
    }
    else
    {
        e.Handled = true;
    }
}
#endregion