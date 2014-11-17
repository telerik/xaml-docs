Public Class Default_Vb


' #region gridview-events-delete_2
AddHandler Me.gridView.Deleting, AddressOf gridView_Deleting
' #endregion

' #region gridview-events-delete_4
Public Sub New()
 InitializeComponent()
 gridView.ItemsSource = Club.GetClubs()
 AddHandler Me.gridView.Deleting, AddressOf gridView_Deleting
End Sub
Protected itemsToBeDeleted As IEnumerable(Of [Object])
Private Sub gridView_Deleting(sender As Object, e As Telerik.Windows.Controls.GridViewDeletingEventArgs)
 'store the items to be deleted
 itemsToBeDeleted = e.Items
 'cancel the event so the item is not deleted
 'and wait for the user confirmation
 e.Cancel = True
 'open the Confirm dialog
 RadWindow.Confirm("Are you sure?", Me.OnRadWindowClosed)
End Sub
Private Sub OnRadWindowClosed(sender As Object, e As WindowClosedEventArgs)
 'check whether the user confirmed
 Dim shouldDelete As Boolean = If(e.DialogResult.HasValue, e.DialogResult.Value, False)
 If shouldDelete Then
  For Each club As var In itemsToBeDeleted
   gridView.Items.Remove(club)
  Next
 End If
End Sub
' #endregion

' #region gridview-events-delete_7
AddHandler Me.gridView.Deleted, AddressOf gridView_Deleted
' #endregion
End Class
