Public Class Default_Vb


' #region radscheduleview-howto-prevent-dialogs-from-opening_2
Private Sub RadScheduleView_ShowDialog(sender As System.Object, e As ShowDialogEventArgs)
    If TypeOf e.DialogViewModel Is AppointmentDialogViewModel Then
       e.Cancel = True
    End If
End Sub
' #endregion

' #region radscheduleview-howto-prevent-dialogs-from-opening_4
Private Sub RadScheduleView_ShowDialog(sender As System.Object, e As ShowDialogEventArgs)
    If TypeOf e.DialogViewModel Is ConfirmDialogViewModel Then
        e.DefaultDialogResult = True
        e.Cancel = True
    End If
End Sub
' #endregion

' #region radscheduleview-howto-prevent-dialogs-from-opening_6
Private Sub RadScheduleView_ShowDialog(sender As System.Object, e As ShowDialogEventArgs)
   Dim dialogViewModel = TryCast(e.DialogViewModel, RecurrenceChoiceDialogViewModel)
   If dialogViewModel IsNot Nothing Then
       dialogViewModel.IsSeriesModeSelected = True
   End If
End Sub
' #endregion
End Class
