'#region raddiagram-data-code-behind-0
Private Sub GenerateRadDiagram()
    Dim diagram As New RadDiagram()

    Dim shapeCloud As New RadDiagramShape() With
    {
        .Width = 180,
        .Height = 100, .Position = New Point() With {.X = 100, .Y = 100},
        .Content = "Cloud"
    }
    shapeCloud.Geometry = ShapeFactory.GetShapeGeometry(CommonShapeType.CloudShape)

    Dim dbShape As New RadDiagramShape() With
    {
      .Width = 80,
      .Height = 100,
      .Position = New Point() With {.X = 400, .Y = 100},
      .Content = "DB"
    }
    dbShape.Geometry = ShapeFactory.GetShapeGeometry(FlowChartShapeType.Database2Shape)

    Dim connection As New RadDiagramConnection() With
    {
       .Source = shapeCloud,
       .SourceConnectorPosition = ConnectorPosition.Right,
       .Target = dbShape,
       .TargetConnectorPosition = ConnectorPosition.Left,
       .SourceCapType = CapType.Arrow4,
       .TargetCapType = CapType.Arrow5Filled,
       .Content = New TextBlock() With
           {
             .Text = " Connection ",
             .Foreground = New SolidColorBrush() With
                {
                    .Color = Colors.Blue
                }
            }
    }
    diagram.Items.Add(shapeCloud)
    diagram.Items.Add(dbShape)
    diagram.Items.Add(connection)
    diagram.SelectAll()

    Me.LayoutRoot.Children.Add(diagram)
End Sub
' #endregion

'#region raddiagram-data-code-behind-1
Public Shared Function CreateCircle(ByVal radiusX As Double, ByVal radiusY As Double, ByVal center As Point) As RadDiagramShape
Public Shared Function CreateRectangle(ByVal rect_Renamed As Rect) As RadDiagramShape
Public Shared Function GetShapeGeometry(ByVal shapeType As ArrowShapeType) As Geometry
Public Shared Function GetShapeGeometry(ByVal shapeType As CommonShapeType) As Geometry
Public Shared Function GetShapeGeometry(ByVal shapeType As FlowChartShapeType) As Geometry
    ' #endregion

