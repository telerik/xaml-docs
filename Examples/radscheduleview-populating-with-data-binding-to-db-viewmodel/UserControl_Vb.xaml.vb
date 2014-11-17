Public Class Default_Vb


' #region radscheduleview-end-user-capabilities-create-appointment_1
Dim appointment As IAppointment = Me.radScheduleView.CreateNew()
appointment.Start = DateTime.Now
appointment.End = DateTime.Now.AddHours(1)
appointment.Subject = "New appointment"
Me.radScheduleView.Commit()
' #endregion
End Class
