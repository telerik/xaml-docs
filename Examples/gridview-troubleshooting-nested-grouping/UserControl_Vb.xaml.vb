Public Class Default_Vb


' #region gridview-troubleshooting-nested-grouping_1
Private Sub RadGridView1_Grouping(sender As Object, e As GridViewGroupingEventArgs)
 Dispatcher.BeginInvoke(Function() Do
  Me.RadGridView1.CurrentItem = Nothing
 End Function)
End Sub
' #endregion
End Class
