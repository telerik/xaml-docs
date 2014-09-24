Public Class Default_Vb


' #region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_3
Public Class MenuItem
    Implements INotifyPropertyChanged

    Private _isEnabled As Boolean = True
    Private _text As String
    Private _subItems As ObservableCollection(Of MenuItem)

    Public Property IsEnabled() As Boolean
        Get
            Return Me._isEnabled
        End Get
        Set(value As Boolean)
            If Me._isEnabled <> value Then
                Me._isEnabled = value
                Me.OnNotifyPropertyChanged("IsEnabled")
            End If
        End Set
    End Property
    Public Property Text() As String
        Get
            Return Me._text
        End Get
        Set(value As String)
            If Me._text <> value Then
                Me._text = value
                Me.OnNotifyPropertyChanged("Text")
            End If
        End Set
    End Property
    Public Property SubItems() As ObservableCollection(Of MenuItem)
        Get
            If Me._subItems Is Nothing Then
                Me._subItems = New ObservableCollection(Of MenuItem)()
            End If
            Return Me._subItems
        End Get
        Set(value As ObservableCollection(Of MenuItem))
            If Me._subItems IsNot value Then
                Me._subItems = value
                Me.OnNotifyPropertyChanged("SubItems")
            End If
        End Set
    End Property

    Private Sub OnNotifyPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
End Class
' #endregion

' #region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_8
Private headerContextMenuItems As ObservableCollection(Of MenuItem)
Private rowContextMenuItems As ObservableCollection(Of MenuItem)
' #endregion

' #region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_10
Public Sub New()
    InitializeComponent()
    Me.radGridView.ItemsSource = EmployeeService.GetEmployees()
    Me.InitializeHeaderContextMenuItems()
    Me.InitializeRowContextMenuItems()
End Sub
Private Sub InitializeRowContextMenuItems()
    Dim items As New ObservableCollection(Of MenuItem)()
    Dim addItem As New MenuItem()
    addItem.Text = "Add"
    items.Add(addItem)
    Dim editItem As New MenuItem()
    editItem.Text = "Edit"
    items.Add(editItem)
    Dim deleteItem As New MenuItem()
    deleteItem.Text = "Delete"
    items.Add(deleteItem)
    Me.rowContextMenuItems = items
End Sub
Private Sub InitializeHeaderContextMenuItems()
    Dim headerItems As New ObservableCollection(Of MenuItem)()
    Dim sortItems As New ObservableCollection(Of MenuItem)()
    Dim sortAscItem As New MenuItem()
    sortAscItem.Text = "Ascending"
    sortItems.Add(sortAscItem)
    Dim sortDescItem As New MenuItem()
    sortDescItem.Text = "Descending"
    sortItems.Add(sortDescItem)
    Dim sortNoneItem As New MenuItem()
    sortNoneItem.Text = "None"
    sortItems.Add(sortNoneItem)
    Dim sortItem As New MenuItem()
    sortItem.Text = "Sort"
    sortItem.SubItems = sortItems
    headerItems.Add(sortItem)
    Dim moveLeftItem As New MenuItem()
    moveLeftItem.Text = "Move Left"
    headerItems.Add(moveLeftItem)
    Dim moveRightItem As New MenuItem()
    moveRightItem.Text = "Move Right"
    headerItems.Add(moveRightItem)
    Me.headerContextMenuItems = headerItems
End Sub
' #endregion

' #region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_12
Private ReadOnly Property ClickedHeader() As GridViewHeaderCell
    Get
        Return Me.GridContextMenu.GetClickedElement(Of GridViewHeaderCell)()
    End Get
End Property
Private ReadOnly Property ClickedRow() As GridViewRow
    Get
        Return Me.GridContextMenu.GetClickedElement(Of GridViewRow)()
    End Get
End Property
' #endregion

' #region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_15
Private Sub GridContextMenu_Opened(sender As Object, e As RoutedEventArgs)
    If Me.ClickedHeader IsNot Nothing Then
        Me.GridContextMenu.ItemsSource = Me.headerContextMenuItems
    ElseIf Me.ClickedRow IsNot Nothing Then
        Me.radGridView.SelectedItem = Me.ClickedRow.DataContext
        For Each item As Object In Me.rowContextMenuItems
            item.IsEnabled = True
        Next
        Me.GridContextMenu.ItemsSource = Me.rowContextMenuItems
    Else
        For Each item As Object In Me.rowContextMenuItems
            If Not item.Text.Equals("Add") Then
                item.IsEnabled = False
            End If
        Next
        Me.GridContextMenu.ItemsSource = Me.rowContextMenuItems
    End If
End Sub
' #endregion

' #region radcontextmenu-how-to-use-radcontextmenu-with-radgridview_18
Private Sub GridContextMenu_ItemClick(sender As Object, e As Telerik.Windows.RadRoutedEventArgs)
    Dim item As MenuItem = TryCast((TryCast(e.OriginalSource, RadMenuItem)).DataContext, MenuItem)
    Select Case item.Text
        Case "Add"
            Me.radGridView.BeginInsert()
            Exit Select
        Case "Edit"
            Me.radGridView.BeginEdit()
            Exit Select
        Case "Delete"
            Me.radGridView.Items.Remove(Me.radGridView.SelectedItem)
            Exit Select
        Case "Ascending"
            Me.radGridView.SortDescriptors.Clear()
            Me.radGridView.SortDescriptors.Add(New SortDescriptor With {
                                               .Member = Me.ClickedHeader.Column.UniqueName,
                                               .SortDirection = ListSortDirection.Ascending})
            Exit Select
        Case "Descending"
            Me.radGridView.SortDescriptors.Clear()
            Me.radGridView.SortDescriptors.Add(New SortDescriptor With {
                                               .Member = Me.ClickedHeader.Column.UniqueName,
                                               .SortDirection = ListSortDirection.Descending})
            Exit Select
        Case "None"
            Me.radGridView.SortDescriptors.Clear()
            Exit Select
        Case "Move Left"
            If Me.ClickedHeader.Column.DisplayIndex > 0 Then
                Me.ClickedHeader.Column.DisplayIndex -= 1
            End If
            Exit Select
        Case "Move Right"
            If Me.ClickedHeader.Column.DisplayIndex < Me.radGridView.Columns.Count - 1 Then
                Me.ClickedHeader.Column.DisplayIndex += 1
            End If
            Exit Select
    End Select
End Sub
' #endregion
End Class
