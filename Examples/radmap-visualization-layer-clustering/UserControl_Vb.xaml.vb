Public Class Default_Vb


    ' #region radmap-visualization-layer-clustering_5
    Private Sub ExpandClusterToPolygon(sender As Object, e As MouseButtonEventArgs)
        Dim element As FrameworkElement = TryCast(sender, FrameworkElement)
        If element IsNot Nothing Then
            Dim data As ClusterData = TryCast(element.DataContext, ClusterData)
            If data IsNot Nothing Then
                If data.ClusterState <> ClusterState.ExpandedToPolygon Then
                    data.HideExpanded = False
                    data.ClusterState = ClusterState.ExpandedToPolygon
                Else
                    data.ClusterState = ClusterState.Collapsed
                End If
            End If
        End If

        e.Handled = True
    End Sub
    ' #endregion
    ' #region radmap-visualization-layer-clustering_7
    Private Sub ExpandCluster(sender As Object, e As MouseButtonEventArgs)
        Dim element As FrameworkElement = TryCast(sender, FrameworkElement)
        If element IsNot Nothing Then
            Dim data As ClusterData = TryCast(element.DataContext, ClusterData)
            If data IsNot Nothing Then
                If data.ClusterState <> ClusterState.Expanded Then
                    data.HideExpanded = False
                    data.ClusterState = ClusterState.Expanded
                Else
                    data.ClusterState = ClusterState.Collapsed
                End If
            End If
        End If

        e.Handled = True
    End Sub
    ' #endregion
End Class
