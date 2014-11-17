' #region raddiagram-howto-drag-custom-toolboxitem-0
Public Sub New()
    InitializeComponent()
    AddHandler SerializationService.[Default].ItemSerializing, AddressOf Default_ItemSerializing
End Sub

Private Sub Default_ItemSerializing(sender As Object, e As SerializationEventArgs(Of IDiagramItem))
    If TypeOf e.Entity Is RadDiagramShape Then
        e.SerializationInfo("MyGeometry") = TryCast(e.Entity, RadDiagramShape).Geometry.ToString(CultureInfo.InvariantCulture)
    End If
End Sub
' #endregion
' #region raddiagram-howto-drag-custom-toolboxitem-1
Private Sub RadDiagram_ShapeDeserialized(sender As Object, e As ShapeSerializationRoutedEventArgs)
    If TryCast(e.Shape, RadDiagramShape) IsNot Nothing Then
        TryCast(e.Shape, RadDiagramShape).Geometry = GeometryParser.GetGeometry(e.SerializationInfo("MyGeometry").ToString())
    End If
End Sub
' #endregion
' #region raddiagram-howto-drag-custom-toolboxitem-2
Private Sub Default_ItemSerializing(sender As Object, e As SerializationEventArgs(Of IDiagramItem))
    If TypeOf e.Entity Is RadDiagramShape Then
        e.SerializationInfo("MyGeometry") = TryCast(e.Entity, RadDiagramShape).Geometry.ToString(CultureInfo.InvariantCulture)
        If TypeOf TryCast(e.Entity, RadDiagramShape).DataContext Is MyShape Then
            e.SerializationInfo("DataContent") = TryCast(TryCast(e.Entity, RadDiagramShape).DataContext, MyShape).Header
        End If
    End If
End Sub

Private Sub RadDiagram_ShapeDeserialized(sender As Object, e As ShapeSerializationRoutedEventArgs)
    If TryCast(e.Shape, RadDiagramShape) IsNot Nothing Then
        TryCast(e.Shape, RadDiagramShape).Geometry = GeometryParser.GetGeometry(e.SerializationInfo("MyGeometry").ToString())
        TryCast(e.Shape, RadDiagramShape).Content = e.SerializationInfo("DataContent").ToString()
    End If
End Sub
' #endregion
