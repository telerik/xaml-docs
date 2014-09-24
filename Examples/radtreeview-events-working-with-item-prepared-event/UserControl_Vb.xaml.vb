Public Class Default_Vb


' #region radtreeview-events-working-with-item-prepared-event_1
Public Class DataItem
    Public Sub New()
        Me.Items = New List(Of DataItem)()
    End Sub
Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
Private _CheckState As System.Windows.Automation.ToggleState
    Public Property CheckState() As System.Windows.Automation.ToggleState
        Get
            Return _CheckState
        End Get
        Set(ByVal value As System.Windows.Automation.ToggleState)
            _CheckState = value
        End Set
    End Property
Private _Items As List(Of DataItem)
    Public Property Items() As List(Of DataItem)
        Get
            Return _Items
        End Get
        Set(ByVal value As List(Of DataItem))
            _Items = value
        End Set
    End Property
End Class
' #endregion

' #region radtreeview-events-working-with-item-prepared-event_3
Public Class RawDataSource
    Inherits List(Of DataItem)
    Public Sub New()
        Dim rand As New Random(CInt(DateTime.Now.Ticks))
        For i As Integer = 1 To 10
            Dim item As New DataItem()
            For j As Integer = 1 To 10
                Dim subItem As New DataItem()
                item.Items.Add(subItem)
            Next
            Me.Add(item)
        Next
    End Sub
    Private Function GetToggleState(ByVal code As Integer) As System.Windows.Automation.ToggleState
        Select Case code
            Case 0
                Return System.Windows.Automation.ToggleState.Off
            Case 1
                Return System.Windows.Automation.ToggleState.[On]
            Case 2
                Return System.Windows.Automation.ToggleState.Indeterminate
            Case Else
                Return System.Windows.Automation.ToggleState.Off
        End Select
    End Function
End Class
' #endregion

' #region radtreeview-events-working-with-item-prepared-event_9
Private Sub radTreeView_ItemPrepared(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.RadTreeViewItemPreparedEventArgs)
    e.PreparedItem.CheckState = TryCast(e.PreparedItem.Item, DataItem).CheckState
End Sub
' #endregion

' #region radtreeview-events-working-with-item-prepared-event_11
Private Sub radTreeView_ItemPrepared(ByVal sender As Object, ByVal e As Telerik.Windows.Controls.RadTreeViewItemPreparedEventArgs)
    e.PreparedItem.CheckState = TryCast(e.PreparedItem.Item, DataItem).CheckState
    AddHandler e.PreparedItem.Checked, AddressOf PreparedItem_Checked
    AddHandler e.PreparedItem.Unchecked, AddressOf PreparedItem_Unchecked
End Sub
Private Sub PreparedItem_Unchecked(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
    Dim item As RadTreeViewItem = TryCast(sender, RadTreeViewItem)
    If item IsNot Nothing Then
        TryCast(item.Item, DataItem).CheckState = System.Windows.Automation.ToggleState.Off
    End If
End Sub
Private Sub PreparedItem_Checked(ByVal sender As Object, ByVal e As Telerik.Windows.RadRoutedEventArgs)
    Dim item As RadTreeViewItem = TryCast(sender, RadTreeViewItem)
    If item IsNot Nothing Then
        TryCast(item.Item, DataItem).CheckState = System.Windows.Automation.ToggleState.[On]
    End If
End Sub
' #endregion
End Class
