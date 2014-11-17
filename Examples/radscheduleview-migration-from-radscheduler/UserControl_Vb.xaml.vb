Public Class Default_Vb


' #region radscheduleview-migration-from-radscheduler_5
If Me.radScheduleView.BeginEdit(appointment) Then
 appointment.Subject = "New Subject"
 Me.radScheduleView.Commit()
End If
' #endregion

' #region radscheduleview-migration-from-radscheduler_7
Me.radScheduleView.Remove(appointment)
' #endregion
End Class
