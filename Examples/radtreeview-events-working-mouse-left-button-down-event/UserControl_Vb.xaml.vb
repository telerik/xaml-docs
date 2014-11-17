Public Class Default_Vb


' #region radtreeview-events-working-mouse-left-button-down-event_2
Imports Telerik.Windows
Me.radTreeView.[AddHandler](RadTreeViewItem.MouseLeftButtonDownEvent, New MouseButtonEventHandler(Me.radTreeView_MouseLeftButtonDown), True)
Private Sub radTreeView_MouseLeftButtonDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
    Dim treeView As Telerik.Windows.Controls.RadTreeView = TryCast(sender, Telerik.Windows.Controls.RadTreeView)
End Sub
' #endregion
End Class
