Public Class Default_Vb


' #region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_2
Public Class DataItem
        Inherits ViewModelBase
        Private m_title As String
        Private m_children As List(Of DataItem)

        Public Property Title() As [String]
            Get
                Return Me.m_title
            End Get
            Set(value As [String])
                If Me.m_title <> value Then
                    Me.m_title = value
                    Me.OnPropertyChanged("Title")
                End If
            End Set
        End Property

        Public ReadOnly Property Children() As List(Of DataItem)
            Get
                Return Me.m_children
            End Get
        End Property
    End Class
    ' #endregion

    ' #region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_6
    Public Class MyViewModel
        Implements INotifyPropertyChanged
        Private Shared idCounter As Integer
        Private title As String
        Public Sub New()
            Me.Children = New ObservableCollection(Of MyViewModel)()
            Me.Id = System.Math.Max(System.Threading.Interlocked.Increment(idCounter), idCounter - 1)
        End Sub
        Private _Id As Integer
        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Protected Set(ByVal value As Integer)
                _Id = value
            End Set
        End Property
....
    End Class
    ' #endregion

    ' #region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_9
    Private pendingSelectionPath As List(Of Integer)
    Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        pendingSelectionPath = New List(Of Integer)()
        pendingSelectionPath.Add(1)
        pendingSelectionPath.Add(12)
        pendingSelectionPath.Add(18)
        pendingSelectionPath.Add(22)

        Me.ExpandToPendingSelection()
    End Sub
Private Sub ExpandToPendingSelection()
End Sub
' #endregion

' #region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_11
Private Sub ExpandToPendingSelection()
    ' Grabs the treeview control.
    Dim itemsControl = TryCast(radTreeView, ItemsControl)
    Dim itemFound = True
    While itemsControl IsNot Nothing AndAlso itemFound
        itemFound = False
        ' Gets the next Id. If the current treeview item has the same id
        ' then this is the target item that should be expanded.
        Dim id = pendingSelectionPath.First()
        For i As Integer = 0 To itemsControl.Items.Count - 1
            Dim viewModel = TryCast(itemsControl.Items(i), MyViewModel)
            If viewModel.Id = id Then
                itemFound = True
                pendingSelectionPath.RemoveAt(0)
                BringIndexIntoView(itemsControl, i)
                itemsControl.UpdateLayout()
                Dim container = TryCast(itemsControl.ItemContainerGenerator.ContainerFromIndex(i), Telerik.Windows.Controls.RadTreeViewItem)
                container.IsExpanded = True
                container.UpdateLayout()
                itemsControl = TryCast(container, ItemsControl)
            End If
        Next
    End While
End Sub
' #endregion

' #region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_13
Private Sub BringIndexIntoView(ByVal itemsControl As ItemsControl, ByVal index As Integer)
    Dim treeView = TryCast(itemsControl, Telerik.Windows.Controls.RadTreeView)
    If treeView IsNot Nothing Then
        treeView.BringIndexIntoView(index)
    End If
    Dim treeViewItem = TryCast(itemsControl, Telerik.Windows.Controls.RadTreeViewItem)
    If treeViewItem IsNot Nothing Then
        treeViewItem.BringIndexIntoView(index)
    End If
End Sub
' #endregion

' #region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_15
AddHandler radTreeView.ItemPrepared, AddressOf radTreeView_ItemPrepared
....
Private Sub radTreeView_ItemPrepared(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.RadTreeViewItemPreparedEventArgs)
    If pendingSelectionPath Is Nothing OrElse Not pendingSelectionPath.Any() Then
        Exit Sub
    End If
    Dim myViewModel = TryCast(e.PreparedItem.Item, MyViewModel)
    If pendingSelectionPath.Contains(myViewModel.Id) Then
        e.PreparedItem.IsExpanded = True
        ' If we have retrieved the item we need, select it.
        If pendingSelectionPath.Count = 1 Then
            treeView.SelectedItem = myViewModel
        End If
        pendingSelectionPath.Remove(myViewModel.Id)
    End If
End Sub
    ' #endregion
    ' #region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_17
Public ReadOnly Property Children() As List(Of DataItem)
        Get
            If Me.children Is Nothing Then
                Me.children = New List(Of DataItem)()
                For i As Integer = 0 To 4
				Dim item As New DataItem() With { _
					Key .Title = String.Format("{0}.{1}", Me.Title, i) _
				}
                    Me.children.Add(item)
                Next
            End If
            Return Me.children
        End Get
    End Property
    ' #endregion
    ' #region radtreeview-howto-exapand-select-item-with-lod-enabled-treeview_19

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim headerAndIndexes As String() = Me.userInput.Text.Split(" "c)
        Dim indexes As String() = headerAndIndexes.LastOrDefault().Split("."c)
        Dim areIndexesValid As Boolean = False
        Dim i As Integer

        If headerAndIndexes IsNot Nothing AndAlso indexes IsNot Nothing Then
            For Each index As String In indexes
                areIndexesValid = Integer.TryParse(index, i)
            Next

            If headerAndIndexes.FirstOrDefault().Contains("Item") AndAlso areIndexesValid Then
                Dim item As RadTreeViewItem = Me.treeView.GetItemByPath(Me.GenetatePath(Me.userInput.Text))
                If item IsNot Nothing Then
                    item.IsSelected = True
                    item.IsExpanded = True
                End If
            End If
        End If
    End Sub

    Private Function GenetatePath(itemToExpand As String) As String
        Dim path As String = String.Empty
        Dim buffer As String
        Dim header As String() = itemToExpand.Split(" "c)
        Dim indexes As String() = header.LastOrDefault().Split("."c)

        header(0) = String.Format("{0} {1}", header(0), indexes(0))
        path = String.Format("{0}\", header(0))

        For i As Integer = 1 To indexes.Length - 1
            buffer = String.Format("{0}.{1}", header(0), indexes(i))
            header(0) = buffer
            path += String.Format("{0}\", buffer)
        Next
        Return path.TrimEnd("\"c)
    End Function
    ' #endregion
End Class
