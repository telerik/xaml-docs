Public Class Default_Vb


' #region radscheduleview-end-user-capabilities-edit-appointment_1
If Me.radScheduleView.BeginEdit(appointment) Then
 appointment.Subject = "New Subject"
 Me.radScheduleView.Commit()
End If
' #endregion
End Class
