Public Class Default_Vb


    ' #region radmap-features-routing_2
    Private wayPoints As New LocationCollection()
    Private routeProvider As BingRouteProvider
    Public Sub New()
        InitializeComponent()
        Me.routeProvider = New BingRouteProvider()
        Me.routeProvider.ApplicationId = "key"
        Me.routeProvider.MapControl = Me.radMap
        AddHandler Me.routeProvider.RoutingCompleted, AddressOf Me.routeProvider_RoutingCompleted

        Me.wayPointsLayer.ItemsSource = Me.wayPoints
    End Sub
    Private Sub routeProvider_RoutingCompleted(sender As Object, e As RoutingCompletedEventArgs)
    End Sub
    ' #endregion

    ' #region radmap-features-routing_4
    Private Sub MapMouseClick(sender As Object, eventArgs As MapMouseRoutedEventArgs)
        Me.wayPoints.Add(eventArgs.Location)
    End Sub

    Private Sub ClearRouteClicked(sender As Object, e As RoutedEventArgs)
        Me.findRouteButton.IsEnabled = True

        Me.wayPoints.Clear()
        Me.routeLayer.Items.Clear()
    End Sub

    Private Sub FindRouteClicked(sender As Object, e As RoutedEventArgs)
        Me.routeLayer.Items.Clear()

        Dim routeRequest As New RouteRequest()
        routeRequest.Culture = New System.Globalization.CultureInfo("en-US")
        routeRequest.Options.RoutePathType = RoutePathType.Points

        If Me.wayPoints.Count > 1 Then
            Me.findRouteButton.IsEnabled = False

            For Each location As Location In Me.wayPoints
                routeRequest.Waypoints.Add(location)
            Next
            Me.routeProvider.CalculateRouteAsync(routeRequest)
        End If
    End Sub
    ' #endregion

    ' #region radmap-features-routing_6
    Private Sub RouteProvider_RoutingCompleted(sender As Object, e As RoutingCompletedEventArgs)
        Me.findRouteButton.IsEnabled = True

        Dim routeResponse As RouteResponse = TryCast(e.Response, RouteResponse)
        If routeResponse IsNot Nothing AndAlso routeResponse.[Error] Is Nothing Then
            If routeResponse.Result IsNot Nothing AndAlso routeResponse.Result.RoutePath IsNot Nothing Then
                Dim routeLine As New PolylineData() With { _
                    .Points = routeResponse.Result.RoutePath.Points, _
                    .ShapeFill = New MapShapeFill() With { _
                        .Stroke = New SolidColorBrush(Colors.Red), _
                        .StrokeThickness = 2 _
                    } _
                }

                Me.routeLayer.Items.Add(routeLine)
            End If
        End If
    End Sub
    ' #endregion
End Class
