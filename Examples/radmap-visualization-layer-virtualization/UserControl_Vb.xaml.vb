Public Class Default_Vb
    ' #region radmap-visualization-layer-virtualization_1
    Public Class MyVirtualizationSource
        Implements IMapItemsVirtualizationSource
        Private document As XmlDocument

        Public Sub New()
            Dim streamInfo As StreamResourceInfo =
                Application.GetResourceStream(
                    New Uri("/TestMapFeatures;component/Resources/GeoData/StoresLocation.xml",
                            UriKind.Relative))

            Me.document = New XmlDocument()
            Me.document.Load(streamInfo.Stream)
        End Sub

        Public Sub MapItemsRequest(sender As Object, eventArgs As MapItemsRequestEventArgs)
            Dim minZoom As Double = eventArgs.MinZoom
            Dim upperLeft As Location = eventArgs.UpperLeft
            Dim lowerRight As Location = eventArgs.LowerRight

            If Me.document Is Nothing Then
                Return
            End If

            If minZoom = 3 Then
                ' request areas
                Dim list As List(Of StoreLocation) =
                    Me.GetStores(upperLeft.Latitude,
                                 upperLeft.Longitude,
                                 lowerRight.Latitude,
                                 lowerRight.Longitude,
                                 StoreType.Area)

                eventArgs.CompleteItemsRequest(list)
            End If

            If minZoom = 9 Then
                ' request areas
                Dim list As List(Of StoreLocation) =
                    Me.GetStores(upperLeft.Latitude,
                                 upperLeft.Longitude,
                                 lowerRight.Latitude,
                                 lowerRight.Longitude,
                                 StoreType.Store)

                eventArgs.CompleteItemsRequest(list)
            End If
        End Sub

        Friend Function GetStores(upperLeftLat As Double,
                                  upperLeftLong As Double,
                                  lowerRightLat As Double,
                                  lowerRightLong As Double,
                                  storeType__1 As StoreType) As List(Of StoreLocation)
            Dim locations As New List(Of StoreLocation)()

            Dim latLonCondition As String =
                "[number(@Latitude) < "
                & upperLeftLat.ToString(CultureInfo.InvariantCulture) 
                & " and number(@Latitude) > " 
                & lowerRightLat.ToString(CultureInfo.InvariantCulture) 
                & " and number(@Longitude) > " 
                & upperLeftLong.ToString(CultureInfo.InvariantCulture) 
                & " and number(@Longitude) < " 
                & lowerRightLong.ToString(CultureInfo.InvariantCulture) 
                & "]"

            Select Case storeType__1
                Case StoreType.Area
                    If True Then
                        Dim nodeList As XmlNodeList = document.SelectNodes(
                            "/StoresLocation/Area" & latLonCondition)
                        For Each node As XmlNode In nodeList
                            Dim element As XmlElement = DirectCast(node, XmlElement)

                            locations.Add(New StoreLocation(
                                          Convert.ToDouble(
                                              element.GetAttribute("Latitude"),
                                              CultureInfo.InvariantCulture),
                                          Convert.ToDouble(
                                              element.GetAttribute("Longitude"),
                                              CultureInfo.InvariantCulture),
                                          element.GetAttribute("Name"),
                                          StoreType.Area))
                        Next
                    End If
                    Exit Select

                Case StoreType.Store
                    If True Then
                        Dim nodeList As XmlNodeList = document.SelectNodes(
                            "/StoresLocation/Area/*" & latLonCondition)
                        For Each node As XmlNode In nodeList
                            Dim element As XmlElement = DirectCast(node, XmlElement)

                            locations.Add(New StoreLocation(
                                          Convert.ToDouble(
                                              element.GetAttribute("Latitude"),
                                              CultureInfo.InvariantCulture),
                                          Convert.ToDouble(
                                              element.GetAttribute("Longitude"),
                                              CultureInfo.InvariantCulture),
                                          element.GetAttribute("Name"),
                                          If(element.LocalName = "Market", StoreType.Market, StoreType.Store)))
                        Next
                    End If
                    Exit Select
            End Select

            Return locations
        End Function
    End Class

    ' #endregion
End Class
