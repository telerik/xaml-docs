#region raddiagram-howto-drag-custom-toolboxitem-0
public ToolboxDragDropExample()
{
    InitializeComponent();
    SerializationService.Default.ItemSerializing += Default_ItemSerializing;
}

void Default_ItemSerializing(object sender, SerializationEventArgs<IDiagramItem> e)
{
    if (e.Entity is RadDiagramShape)
    {
        e.SerializationInfo["MyGeometry"] = (e.Entity as RadDiagramShape).Geometry.ToString(CultureInfo.InvariantCulture);
    }
}
#endregion
#region raddiagram-howto-drag-custom-toolboxitem-1
private void RadDiagram_ShapeDeserialized(object sender, ShapeSerializationRoutedEventArgs e)
{
    if (e.Shape as RadDiagramShape != null)
    {
        (e.Shape as RadDiagramShape).Geometry = GeometryParser.GetGeometry(e.SerializationInfo["MyGeometry"].ToString());
    }
}
#endregion
#region raddiagram-howto-drag-custom-toolboxitem-2
void Default_ItemSerializing(object sender, SerializationEventArgs<IDiagramItem> e)
{
    if (e.Entity is RadDiagramShape)
    {
        e.SerializationInfo["MyGeometry"] = (e.Entity as RadDiagramShape).Geometry.ToString(CultureInfo.InvariantCulture);
        if((e.Entity as RadDiagramShape).DataContext is MyShape)
        e.SerializationInfo["DataContent"] = ((e.Entity as RadDiagramShape).DataContext as MyShape).Header;
    }
}

private void RadDiagram_ShapeDeserialized(object sender, ShapeSerializationRoutedEventArgs e)
{
    if (e.Shape as RadDiagramShape != null)
    {
        (e.Shape as RadDiagramShape).Geometry = GeometryParser.GetGeometry(e.SerializationInfo["MyGeometry"].ToString());
        (e.Shape as RadDiagramShape).Content = e.SerializationInfo["DataContent"].ToString();
    }
}
#endregion