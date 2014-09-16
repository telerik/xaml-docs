Public Class Default_Vb


    ' #region radmap-visualization-layer-shapes-virtualization_2
Imports System.Windows
Imports System.Windows.Controls

Namespace ShapeVirtualization
        Partial Public Class MainPage
            Inherits UserControl
            Public Sub New()
                InitializeComponent()

                AddHandler Me.Loaded, AddressOf MainPage_Loaded
            End Sub

            Private Sub MainPage_Loaded(sender As Object, e As RoutedEventArgs)
                Me.mapShapeDataVirtualizationSource.BusyIndicator = Me.busyIndicator
                Me.mapShapeDataVirtualizationSource.ReadAsync()
            End Sub
        End Class
    End Namespace

    ' #endregion
    ' #region radmap-visualization-layer-shapes-virtualization_4
Imports System.Collections.Generic
Imports System.Linq
Imports Telerik.Windows.Controls.Map

Namespace ShapeVirtualization
        Public Class ShapeDataVirtualizer
            Implements IMapItemsVirtualizationSource
            Private sateData As List(Of ExtendedDataProvider)
            Private countyData As List(Of ExtendedDataProvider)
            Private firstRequest As Boolean = True
            Private m_layer As WeakReference = Nothing

            Public Sub New()
                Me.StartRead()
            End Sub

            ''' <summary>
            ''' Gets or sets the layer this virtualization source belongs to.
            ''' </summary>
            Private Property Layer() As VisualizationLayer
                Get
                    If Me.m_layer IsNot Nothing AndAlso Me.m_layer.IsAlive Then
                        Return TryCast(Me.m_layer.Target, VisualizationLayer)
                    Else
                        Return Nothing
                    End If
                End Get

                Set(value As VisualizationLayer)
                    Me.m_layer = If(value IsNot Nothing, New WeakReference(value), Nothing)
                End Set
            End Property

            Public Sub MapItemsRequest(sender As Object, e As MapItemsRequestEventArgs)
                If Me.firstRequest Then
                    Me.Layer = e.Layer
                    Me.firstRequest = False
                End If

                Me.QueryItems(e)
            End Sub

            Private Sub QueryItems(e As MapItemsRequestEventArgs)
                Dim shapes As List(Of ExtendedDataProvider) = Nothing
                If Me.sateData IsNot Nothing AndAlso Me.countyData IsNot Nothing Then
                    Dim query As IEnumerable(Of ExtendedDataProvider)

                    If e.MinZoom < 8 Then
                        ' Sate zoom level 
					query = From item In Me.sateData Where Me.ShouldBeAdded(e.Region, item)item
                    Else
                        ' County zoom level
					query = From item In Me.countyData Where Me.ShouldBeAdded(e.Region, item)item
                    End If

                    shapes = query.ToList()
                End If

                e.CompleteItemsRequest(shapes)
            End Sub

            Private Function ShouldBeAdded(rect As LocationRect, item As ExtendedDataProvider) As Boolean
                Dim shape As MapShapeData = TryCast(item, MapShapeData)
                If shape IsNot Nothing Then
                    Return rect.Intersect(shape.GeoBounds)
                End If

                Return rect.Contains(item.Location)
            End Function

            Private Sub StartRead()
			Dim stateReader As New AsyncShapeFileReader() With { _
				Key .Source = New Uri("/ShapeVirtualization;component/Resources/usa_states.shp", UriKind.Relative), _
				Key .ToolTipFormat = "STATE_NAME" _
			}

                AddHandler stateReader.PreviewReadShapeDataCompleted, AddressOf Me.State_PreviewReadShapeDataCompleted
                stateReader.ReadAsync()

			Dim cuntyReader As New AsyncShapeFileReader() With { _
				Key .Source = New Uri("/ShapeVirtualization;component/Resources/County.shp", UriKind.Relative), _
				Key .ToolTipFormat = "{COUNTY} ({STATE})" _
			}

                AddHandler cuntyReader.PreviewReadShapeDataCompleted, AddressOf Me.County_PreviewReadShapeDataCompleted
                cuntyReader.ReadAsync()
            End Sub

            Private Sub State_PreviewReadShapeDataCompleted(sender As Object, e As PreviewReadShapeDataCompletedEventArgs)
                Me.sateData = e.Items
                Me.RefreshVisualizationLayer()
            End Sub

            Private Sub County_PreviewReadShapeDataCompleted(sender As Object, e As PreviewReadShapeDataCompletedEventArgs)
                Me.countyData = e.Items
                Me.RefreshVisualizationLayer()
            End Sub

            Private Sub RefreshVisualizationLayer()
                If Me.Layer IsNot Nothing Then
                    Me.Layer.RefreshVirtualSource()
                End If
            End Sub
        End Class
    End Namespace
    ' #endregion
End Class
