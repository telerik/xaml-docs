Public Class Default_Vb


' #region scheduleview-features-loadondemand_2
Private Sub scheduleView_VisibleRangeChanged(sender As Object, e As System.EventArgs)
 Dim range = TryCast(sender, RadScheduleView).VisibleRange
 End Sub
' #endregion

' #region scheduleview-features-loadondemand_4
Private Sub scheduleView_VisibleRangeChanged(sender As Object, e As System.EventArgs)
 Dim range = TryCast(sender, RadScheduleView).VisibleRange
 Me.LoadAppointmentsByRange(range)
End Sub
' #endregion

' #region scheduleview-features-loadondemand_7
Private visibleRangeChanged As ICommand
Public Property VisibleRangeChanged() As ICommand
 Get
  Return Me.visibleRangeChanged
 End Get
 Set
  Me.visibleRangeChanged = value
 End Set
End Property
Public Sub New()
 Me.VisibleRangeChanged = New DelegateCommand(Me.VisibleRangeExecuted, Me.CanVisibleRangeCanExecuted)
End Sub
Private Sub VisibleRangeExecuted(param As Object)
 ' param is the value of the VisibleRange property. It is used to get the appointments only for the visual range.
 Me.LoadAppointmentsByRange(TryCast(param, DateSpan))
End Sub
Private Function CanVisibleRangeCanExecuted(param As Object) As Boolean
 Return param IsNot Nothing
End Function
' #endregion
End Class
