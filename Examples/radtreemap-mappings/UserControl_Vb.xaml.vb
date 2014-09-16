Public Class Default_Vb


' #region radtreemap-mappings_1
Public Class FileCustomMapping
            Inherits CustomMapping
            Protected Overrides Sub Apply(ByVal treemapItem As RadTreeMapItem, ByVal dataItem As Object)
                  Dim file As File = TryCast(dataItem, File)
                  If TypeOf dataItem Is File Then
                        treemapItem.Background = New SolidColorBrush(Colors.Red)
                  Else
                        treemapItem.Background = New SolidColorBrush(Colors.Blue)
                  End If
            End Sub
            Protected Overrides Sub Clear(ByVal treemapItem As RadTreeMapItem, ByVal dataItem As Object)
                  treemapItem.ClearValue(RadTreeMapItem.BackgroundProperty)
            End Sub
      End Class
' #endregion
End Class
