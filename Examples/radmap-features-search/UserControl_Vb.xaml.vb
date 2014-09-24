Public Class Default_Vb


' #region radmap-features-search_1
    Private searchProvider As BingSearchProvider
    Private itemCollection As New MapItemsCollection()
    Public Sub New()
        InitializeComponent()
        Me.searchProvider = New BingSearchProvider()
        searchProvider.ApplicationId = "key"
        searchProvider.MapControl = Me.radMap
        searchProvider.SearchCompleted += Me.searchProvider_SearchCompleted

        Me.itemsLayer.ItemsSource = Me.itemCollection
    End Sub
' #endregion

' #region radmap-features-search_3
    Private Sub SearchHandler(sender As Object, e As RoutedEventArgs)
        Dim query As String = Me.SearchCondition.Text

        If Not String.IsNullOrEmpty(query) Then
            Dim request As New SearchRequest()
            request.Culture = New System.Globalization.CultureInfo("en-US")
            request.Query = query

            Me.searchProvider.SearchAsync(request)
        End If
    End Sub
' #endregion

    ' #region radmap-features-search_5
    Private Sub Provider_SearchCompleted(sender As Object, args As SearchCompletedEventArgs)
        Me.itemCollection.Clear()
        Dim results As SearchResultCollection = args.Response.ResultSets.First().Results
        If results.Count > 0 Then
            For Each result As SearchResultBase In results
                Dim item As New MapItem() With { _
                    .Title = result.Name, _
                    .Location = result.LocationData.Locations(0) _
                }
                Me.itemCollection.Add(item)
            Next
            Me.radMap.SetView(args.Response.ResultSets(0).SearchRegion.GeocodeLocation.BestView)
        End If
    End Sub
' #endregion

' #region radmap-features-search_7
    Private Sub Provider_SearchCompleted(sender As Object, args As SearchCompletedEventArgs)

        Me.itemCollection.Clear()
        Dim results As SearchResultCollection = args.Response.ResultSets.First().Results
        Dim region As SearchRegion = args.Response.ResultSets.First().SearchRegion
        If results.Count > 0 Then
            Me.radMap.SetView(region.GeocodeLocation.BestView)
            For Each result As SearchResultBase In args.Response.ResultSets(0).Results
                Dim item As New MapItem() With { _
                    .Title = result.Name, _
                    .Location = result.LocationData.Locations(0) _
                }
                Me.itemCollection.Add(item)
            Next
        Else
            If region IsNot Nothing Then
                Me.radMap.SetView(region.GeocodeLocation.BestView)
                If region.GeocodeLocation.Address IsNot Nothing AndAlso region.GeocodeLocation.Locations.Count > 0 Then
                    For Each location As Location In region.GeocodeLocation.Locations
                        Dim item As New MapItem()

                        item.Location = location
                        Me.itemCollection.Add(item)
                    Next

                    ' Set the bounding area
                    If args.Response.ResultSets(0).SearchRegion.BoundingArea IsNot Nothing Then
                        Dim boundingArea As MapShapeData = args.Response.ResultSets(0).SearchRegion.BoundingAreaData
                        boundingArea.ShapeFill = New MapShapeFill() With { _
                            .Stroke = New SolidColorBrush(Colors.Red), _
                            .StrokeThickness = 1 _
                        }
                        Me.regionLayer.Items.Add(boundingArea)
                    End If
                End If
            End If
        End If
    End Sub
' #endregion

' #region radmap-features-search_9
Private Sub searchProvider_SearchCompleted(sender As Object, e As SearchCompletedEventArgs)
        Me.itemCollection.Clear()
        Dim results As SearchResultCollection = args.Response.ResultSets.First().Results
        Dim region As SearchRegion = args.Response.ResultSets.First().SearchRegion
        'code that runs when there are available results.
        If results.Count > 0 Then
        Else
            If region IsNot Nothing Then
                Me.radMap.SetView(region.GeocodeLocation.BestView)
                If region.GeocodeLocation.Address IsNot Nothing AndAlso region.GeocodeLocation.Locations.Count > 0 Then
                    For Each location As Location In region.GeocodeLocation.Locations
                        Dim item As New MapItem()
                        item.Location = location
                        Me.itemCollection.Add(item)
                    Next
                End If
            End If
        End If
    End Sub
' #endregion

' #region radmap-features-search_11
Private Sub searchProvider_SearchCompleted(sender As Object, e As SearchCompletedEventArgs)
 Dim alternateRegions As SearchRegionCollection = e.Response.ResultSets.First().AlternateSearchRegions
 If alternateRegions.Count > 0 Then
    ' implement AlternateSearchRegions logic here.
  For Each region As SearchRegion In alternateRegions
  Next
 End If
End Sub
' #endregion
End Class
