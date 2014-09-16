Public Class Default_Vb


    ' #region radmap-features-providers_1
    Dim bingMap As New BingMapProvider(MapMode.Aerial, True, "key")
Me.radMap.Provider = bingMap
    ' #endregion

    ' #region radmap-features-providers_3
    Dim openStreetMap As New OpenStreetMapProvider()
Me.radMap.Provider = openStreetMap
    ' #endregion
End Class
