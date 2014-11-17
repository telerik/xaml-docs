Public Class Default_Vb


' #region dragdropmanager-howto-set-cursor-to-arrow-while-dragging_1
DragDropManager.AddGiveFeedbackHandler(Me, New GiveFeedbackEventHandler(AddressOf OnGiveFeedBack))
Private Sub OnGiveFeedBack(sender As Object, e As Telerik.Windows.DragDrop.GiveFeedbackEventArgs) 
   args.SetCursor(Cursors.Arrow)
   args.Handled = True
End Sub
' #endregion
End Class
