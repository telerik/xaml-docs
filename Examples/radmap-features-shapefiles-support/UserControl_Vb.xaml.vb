Public Class Default_Vb


' #region radmap-features-shapefiles-support_2
Me.informationLayer.Reader = New MapShapeReader()
Me.informationLayer.Reader.Source = New Uri( "/Silverlight.Help.RadMapSamples;component/Data/world.shp", UriKind.RelativeOrAbsolute )
Me.informationLayer.Reader.DataSource = New Uri( "/Silverlight.Help.RadMapSamples;component/Data/world.dbf", UriKind.RelativeOrAbsolute )
' #endregion

' #region radmap-features-shapefiles-support_4
Dim shapeResourceInfo As StreamResourceInfo = Application.GetResourceStream(New Uri("/Silverlight.Help.RadMapSamples;component/Data/world.shp", UriKind.RelativeOrAbsolute))
Dim dbfResourceInfo As StreamResourceInfo = Application.GetResourceStream(New Uri("/Silverlight.Help.RadMapSamples;component/Data/world.dbf", UriKind.RelativeOrAbsolute))
Dim shapes As List(Of FrameworkElement) = ShapeFileReader.Read(shapeResourceInfo.Stream, dbfResourceInfo.Stream)
For Each shape In shapes
 Me.informationLayer.Items.Add(shape)
Next shape
' #endregion
End Class
