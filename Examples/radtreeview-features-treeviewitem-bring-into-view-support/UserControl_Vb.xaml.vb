Public Class Default_Vb


' #region radtreeview-features-treeviewitem-bring-into-view-support_2
Public Class MyViewModel
 Private Shared idCounter As Integer
 Private m_title As String
 Public Sub New()
  Me.Id = System.Math.Max(System.Threading.Interlocked.Increment(idCounter),idCounter - 1)
 End Sub
 Public Property Id() As Integer
  Get
   Return m_Id
  End Get
  Protected Set
   m_Id = Value
  End Set
 End Property
 Private m_Id As Integer
 Public Property Title() As [String]
  Get
   Return Me.m_title
  End Get
  Set
   If Me.m_title <> value Then
    Me.m_title = value
   End If
  End Set
 End Property
End Class
' #endregion

' #region radtreeview-features-treeviewitem-bring-into-view-support_4
Private Sub BringItemIntoView()
    Me.RadTreeViewItem.BringIndexIntoView(20)
End Sub
' #endregion
End Class
