Public Class Default_Vb


    ' #region radmap-visualization-layer-items-selection_2
    Public Class MapItem
        Implements INotifyPropertyChanged
        Private Shared RegularBrush As New SolidColorBrush(Colors.Green)
        Private Shared SelectedBrush As New SolidColorBrush(Colors.Red)

        Private m_caption As String = String.Empty
        Private m_location As Location = Location.Empty
        Private m_isSelected As Boolean = False
        Private m_background As SolidColorBrush = RegularBrush

        Public Sub New(caption As String, _
                       location As Location)
            Me.Caption = caption
            Me.Location = location
        End Sub

        Public Event PropertyChanged As PropertyChangedEventHandler _
            Implements INotifyPropertyChanged.PropertyChanged

        Public Property Background() As SolidColorBrush
            Get
                Return Me.m_background
            End Get

            Set(value As SolidColorBrush)
                Me.m_background = value
                Me.OnPropertyChanged("Background")
            End Set
        End Property

        Public Property Caption() As String
            Get
                Return Me.m_caption
            End Get

            Set(value As String)
                Me.m_caption = value
                Me.OnPropertyChanged("Caption")
            End Set
        End Property

        Public Property IsSelected() As Boolean
            Get
                Return Me.m_isSelected
            End Get

            Set(value As Boolean)
                Me.m_isSelected = value
                Me.Background = If(Me.m_isSelected, SelectedBrush, RegularBrush)
                Me.OnPropertyChanged("IsSelected")
            End Set
        End Property

        Public Property Location() As Location
            Get
                Return Me.m_location
            End Get

            Set(value As Location)
                Me.m_location = value
                Me.OnPropertyChanged("Location")
            End Set
        End Property

        Private Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class

    ' #endregion
    ' #region radmap-visualization-layer-items-selection_5
    Partial Public Class SelectLocations
        Inherits UserControl
        Private rnd As New Random()

        Public Sub New()
            InitializeComponent()

            Dim usa As New LocationRect(New Location(50, -120), New Location(30, -70))
            Me.visualizationLayer.ItemsSource = Me.GeneratePoiCollection(50, usa)
        End Sub

        Private Sub GenerateMapItem(data As ObservableCollection(Of MapItem), location As Location, index As Integer)
            Dim poi As New MapItem(String.Format("Item {0}", index), location)

            data.Add(poi)
        End Sub

        Private Function GeneratePoiCollection(count As Integer, region As LocationRect) As ObservableCollection(Of MapItem)
            Dim data As New ObservableCollection(Of MapItem)()

            For i As Integer = 0 To count - 1
                Dim baseLocation As New Location(region.North - rnd.NextDouble() * region.GeoSize.Height, region.West + rnd.NextDouble() * region.GeoSize.Width)
                Me.GenerateMapItem(data, baseLocation, i)
            Next

            Return data
        End Function

        Private Sub LayerSelectionChanged(sender As Object, e As SelectionChangedEventArgs)
            If e.RemovedItems IsNot Nothing Then
                For Each item As MapItem In e.RemovedItems
                    item.IsSelected = False
                Next
            End If

            If e.AddedItems IsNot Nothing Then
                For Each item As MapItem In e.AddedItems
                    item.IsSelected = True
                Next
            End If
        End Sub
    End Class

    ' #endregion

    ' #region radmap-visualization-layer-items-selection_9
    Private Sub ShowSelectedItems(sender As Object, e As RoutedEventArgs)
        Dim condition As String = Me.filter.Text.Trim()
        Dim minSqkm As Double
        If Double.TryParse(condition, minSqkm) Then
            Dim itemsToSelect As IEnumerable(Of Object) = From item In Me.visualizationLayer.Items Where CDbl(item.ExtendedData.GetValue("SQKM")) > minSqkm * 1000.0 Select item
            Me.visualizationLayer.Select(itemsToSelect, True)
        End If
    End Sub

    Private Sub ReverseSelection(sender As Object, e As RoutedEventArgs)
        Me.visualizationLayer.ReverseSelection(Me.visualizationLayer.Items)
    End Sub
    ' #endregion

End Class
