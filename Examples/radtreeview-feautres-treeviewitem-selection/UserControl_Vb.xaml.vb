Public Class Default_Vb


' #region radtreeview-feautres-treeviewitem-selection_2
radTreeViewItem.IsSelected = True
' #endregion

' #region radtreeview-feautres-treeviewitem-selection_4
radTreeView.SelectedItems.Add(radTreeViewItem)
' #endregion

' #region radtreeview-feautres-treeviewitem-selection_6
radTreeView.SelectedItems.Add(myViewModel)
' #endregion

' #region radtreeview-feautres-treeviewitem-selection_10
Private Sub radTreeView_Selected(ByVal sender As Object, ByVal e As RadRoutedEventArgs)
    TryCast(e.Source, RadTreeViewItem).FontSize = 14
End Sub
' #endregion

' #region radtreeview-feautres-treeviewitem-selection_12
Private Sub radTreeView_SelectionChanged(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.SelectionChangedEventArgs)
    ' Get a reference to the treeview
    Dim treeView As Telerik.Windows.Controls.RadTreeView = TryCast(sender, Telerik.Windows.Controls.RadTreeView)
    ' Get the currently selected items
    Dim selectedItems As ObservableCollection(Of [Object]) = treeView.SelectedItems
    ' Get the newly added items to the collection
    Dim addedItems As IList = e.AddedItems
    ' Get the removed items from the collection
    Dim removedItems As IList = e.RemovedItems
End Sub
' #endregion

' #region radtreeview-feautres-treeviewitem-selection_14
Private Class MyViewModel
Private _Title As String
    Public Property Title() As String
        Get
            Return _Title
        End Get
        Set(ByVal value As String)
            _Title = value
        End Set
    End Property
Private _Price As String
    Public Property Price() As String
        Get
            Return _Price
        End Get
        Set(ByVal value As String)
            _Price = value
        End Set
    End Property
Private _Children As IList(Of MyViewModel)
    Public Property Children() As IList(Of MyViewModel)
        Get
            Return _Children
        End Get
        Set(ByVal value As IList(Of MyViewModel))
            _Children = value
        End Set
    End Property
End Class
' #endregion
End Class
