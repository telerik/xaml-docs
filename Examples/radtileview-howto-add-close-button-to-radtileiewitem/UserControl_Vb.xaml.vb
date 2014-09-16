Public Class Default_Vb
    ' #region radtileview-howto-add-close-button-to-radtileiewitem_0
    Public Class DataItem
        Public Property Header() As String
            Get
                Return m_Header
            End Get
            Set(value As String)
                m_Header = Value
            End Set
        End Property
        Private m_Header As String
        Public Property Content() As String
            Get
                Return m_Content
            End Get
            Set(value As String)
                m_Content = Value
            End Set
        End Property
        Private m_Content As String
    End Class
    ' #endregion

    ' #region radtileview-howto-add-close-button-to-radtileiewitem_1
    Public Class MainViewModel
        Public Property Items() As ObservableCollection(Of DataItem)
            Get
                Return m_Items
            End Get
            Set(value As ObservableCollection(Of DataItem))
                m_Items = Value
            End Set
        End Property
        Private m_Items As ObservableCollection(Of DataItem)

        Public Sub New()
            Me.Items = New ObservableCollection(Of DataItem)()

            For i As Integer = 0 To 4
                Dim dataItem = New DataItem() With { _
                    .Header = "Item " + i, _
                    .Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit." _
                }

                Me.Items.Add(dataItem)
            Next
        End Sub
    End Class
    ' #endregion

    ' #region radtileview-howto-add-close-button-to-radtileiewitem_2
    Public NotInheritable Class TileViewCommandsExtension
        Private Sub New()
        End Sub
        Shared Sub New()
            TileViewCommandsExtension.Delete = New RoutedUICommand("Deletes a tile view item", "Delete", GetType(TileViewCommandsExtension))
        End Sub

        Public Shared Property Delete() As RoutedUICommand
            Get
                Return m_Delete
            End Get
            Private Set(value As RoutedUICommand)
                m_Delete = Value
            End Set
        End Property
        Private Shared m_Delete As RoutedUICommand
    End Class
    ' #endregion

    ' #region radtileview-howto-add-close-button-to-radtileiewitem_3
    Partial Public Class Example
        Inherits UserControl
        Shared Sub New()
            Dim deleteBinding = New CommandBinding(TileViewCommandsExtension.Delete, AddressOf OnDeleteCommandExecute, AddressOf OnCanDeleteCommandExecute)
            CommandManager.RegisterClassCommandBinding(GetType(RadTileViewItem), deleteBinding)
        End Sub

        Private Shared Sub OnCanDeleteCommandExecute(sender As Object, e As CanExecuteRoutedEventArgs)
        End Sub

        Private Shared Sub OnDeleteCommandExecute(sender As Object, e As ExecutedRoutedEventArgs)
        End Sub

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
    ' #endregion

    ' #region radtileview-howto-add-close-button-to-radtileiewitem_4
    Partial Public Class Example
        Inherits UserControl
        Shared Sub New()
            Dim deleteBinding = New CommandBinding(TileViewCommandsExtension.Delete, AddressOf OnDeleteCommandExecute, AddressOf OnCanDeleteCommandExecute)
            CommandManager.RegisterClassCommandBinding(GetType(RadTileViewItem), deleteBinding)
        End Sub

        Private Shared Sub OnCanDeleteCommandExecute(sender As Object, e As CanExecuteRoutedEventArgs)
            e.CanExecute = True
        End Sub

        Private Shared Sub OnDeleteCommandExecute(sender As Object, e As ExecutedRoutedEventArgs)
            Dim tileViewItem = TryCast(sender, RadTileViewItem)
            Dim tileView = TryCast(tileViewItem.ParentTileView, RadTileView)
            If tileViewItem Is Nothing OrElse tileView Is Nothing Then
                Return
            End If

            If tileView.ItemsSource IsNot Nothing Then
                Dim dataItem = TryCast(tileView.ItemContainerGenerator.ItemFromContainer(tileViewItem), DataItem)

                ' Note: This will change the DataContext's Items collection.
                Dim source = TryCast(tileView.ItemsSource, IList)
                If dataItem IsNot Nothing AndAlso source IsNot Nothing Then
                    source.Remove(dataItem)
                End If
            Else
                tileView.Items.Remove(tileViewItem)
            End If
        End Sub

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
    ' #endregion
End Class
