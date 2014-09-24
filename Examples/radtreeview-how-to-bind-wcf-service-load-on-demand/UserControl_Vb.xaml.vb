Public Class Default_Vb


' #region radtreeview-how-to-bind-wcf-service-load-on-demand_3
Public Class TableItem
    Public Sub New()
        Me.Children = New List(Of TableItem)()
    End Sub
Private _Id As Integer
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property
Private _ParentId As Integer
    Public Property ParentId() As Integer
        Get
            Return _ParentId
        End Get
        Set(ByVal value As Integer)
            _ParentId = value
        End Set
    End Property
Private _Text As String
    Public Property Text() As String
        Get
            Return _Text
        End Get
        Set(ByVal value As String)
            _Text = value
        End Set
    End Property
Private _Children As List(Of TableItem)
    Public Property Children() As List(Of TableItem)
        Get
            Return _Children
        End Get
        Set(ByVal value As List(Of TableItem))
            _Children = value
        End Set
    End Property
End Class
' #endregion

' #region radtreeview-how-to-bind-wcf-service-load-on-demand_5
Public Class HierarchicalDataSource
    Inherits ObservableCollection(Of TableItem)
    Public Sub New()
    End Sub
End Class
' #endregion

' #region radtreeview-how-to-bind-wcf-service-load-on-demand_8
Public Class HierarchicalDataSource
    Inherits ObservableCollection(Of TableItem)
    ' This list holds all the items that come from the web service result
    Private unsortedList As New List(Of TableItem)()
    Public Sub New()
        Dim serviceClient As New SampleWcfServiceClient()
        AddHandler serviceClient.LoadHierarchicalDataCompleted, AddressOf serviceClient_LoadHierarchicalDataCompleted
        serviceClient.LoadHierarchicalDataAsync()
    End Sub
    Private Sub serviceClient_LoadHierarchicalDataCompleted(ByVal sender As Object, ByVal e As LoadHierarchicalDataCompletedEventArgs)
        ' transfer all the items from the result to the unsorted list
        For Each item As TableItem In e.Result
            Dim genericItem As New TableItem()
            Me.unsortedList.Add(genericItem)
        Next
        ' Get all the first level nodes.
        Dim rootNodes = Me.unsortedList.Where(Function(x) x.ParentId = 0)
        ' Foreach root node, get all its children and add the node to the HierarchicalDataSource.
        ' see below how the FindChildren method works
        For Each node As TableItem In rootNodes
            Me.FindChildren(node)
            Me.Add(node)
        Next
    End Sub
End Class
' #endregion

' #region radtreeview-how-to-bind-wcf-service-load-on-demand_9
Public Class HierarchicalDataSource
    Inherits ObservableCollection(Of TableItem)
    ' This list holds all the items that come from the web service result
    Private unsortedList As New List(Of TableItem)()
    Public Sub New()
        Dim serviceClient As New SampleWcfServiceClient()
        For Each item As TableItem In serviceClient.LoadHierarchicalData()
            ' transfer all the items from the result to the unsorted list
            Dim genericItem As New TableItem()
            Me.unsortedList.Add(genericItem)
        Next
        ' Get all the first level nodes.
        Dim rootNodes = Me.unsortedList.Where(Function(x) x.ParentId = 0)
        ' Foreach root node, get all its children and add the node to the HierarchicalDataSource.
        ' see below how the FindChildren method works
        For Each node As TableItem In rootNodes
            node.Children = New ObservableCollection(Of TableItem)()
            Me.FindChildren(node)
            Me.Add(node)
        Next
    End Sub
End Class
' #endregion

' #region radtreeview-how-to-bind-wcf-service-load-on-demand_11
Private Sub FindChildren(ByVal item As TableItem)
    ' find all the children of the item
    Dim children = unsortedList.Where(Function(x) x.ParentId = item.Id AndAlso x.Id <> item.Id)
    ' add the child to the item's children collection and call the FindChildren recursively, in case the child has children
    For Each child As TableItem In children
        ' By not calling iteratively FindChildren() here we prevent
        ' the automatic loading of all items in the data
        ' source and load only the next level in the hierarchy
        item.Children.Add(child)
    Next
End Sub
' #endregion

' #region radtreeview-how-to-bind-wcf-service-load-on-demand_13
Public Sub LoadItemChildren(ByVal item As TableItem)
    For Each i As TableItem In item.Children
        FindChildren(i)
    Next
End Sub
' #endregion

' #region radtreeview-how-to-bind-wcf-service-load-on-demand_16
Private Sub radTreeView_Expanded(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
    Dim tree As Telerik.Windows.Controls.RadTreeView = TryCast(sender, Telerik.Windows.Controls.RadTreeView)
    Dim item As RadTreeViewItem = TryCast(e.OriginalSource, RadTreeViewItem)
    If (tree IsNot Nothing) AndAlso (item IsNot Nothing) Then
        ' Load the next level from the data hierarchy
        Dim source As HierarchicalDataSource = TryCast(Me.Resources("Source"), HierarchicalDataSource)
        Dim ti As TableItem = TryCast(item.DataContext, TableItem)
        If (ti IsNot Nothing) AndAlso (source IsNot Nothing) Then
            source.LoadItemChildren(ti)
        End If
    End If
End Sub
' #endregion
End Class
