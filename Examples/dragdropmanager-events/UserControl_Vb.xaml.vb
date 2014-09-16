Public Class Default_Vb


' #region dragdropmanager-events_1
DragDropManager.AddDragInitializeHandler(Me, New DragInitializeEventHandler(AddressOf OnDragInitialized))
DragDropManager.AddDragDropCompletedHandler(Me, New DragDropCompletedEventHandler(AddressOf OnDragDropCompleted))
DragDropManager.AddGiveFeedbackHandler(Me, New GiveFeedbackEventHandler(AddressOf OnGiveFeedback))
DragDropManager.AddQueryContinueDragHandler(Me, New QueryContinueDragEventHandler(AddressOf OnQueryContinue))
DragDropManager.AddDragOverHandler(FrameworkElement, New DragEventHandler(AddressOf OnElementDragOver))
DragDropManager.AddDragLeaveHandler(FrameworkElement, New DragEventHandler(AddressOf OnElementDragLeave))
DragDropManager.AddDropHandler(FrameworkElement, New DragEventHandler(AddressOf OnElementDrop)

Private Sub OnDragInitialized(sender As Object, e As DragInitializeEventArgs)    End Sub

Private Sub OnDragDropCompleted(sender As Object, e As DragDropCompletedEventArgs)    End Sub

Private Sub OnGiveFeedback(sender As Object, e As GiveFeedbackEventArgs)
    End Sub

Private Sub OnQueryContinue(sender As Object, e As QueryContinueDragEventArgs)
    End Sub

Private Sub OnElementDragOver(sender As Object, e As DragEventArgs)
    End Sub

Private Sub OnElementDrop(sender As Object, e As DragEventArgs)
    End Sub

Private Sub OnElementDragLeave(sender As Object, e As DragEventArgs)
    End Sub

' #endregion
End Class
