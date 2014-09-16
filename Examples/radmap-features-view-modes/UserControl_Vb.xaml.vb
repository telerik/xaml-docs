Public Class Default_Vb


' #region radmap-features-view-modes_1
Dim bingMap As New BingMapProvider(MapMode.Aerial, True, "key")
'or
bingMap.Mode = MapMode.Aerial
bingMap.IsLabelVisible = True
' #endregion
End Class
