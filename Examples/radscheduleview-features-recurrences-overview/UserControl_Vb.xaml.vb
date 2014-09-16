Public Class Default_Vb


' #region radscheduleview-features-recurrences-overview_1
Dim startDate = New DateTime(2011, 5, 11, 10, 0, 0)
Dim appointment = New Appointment() With {
    .Start = startDate,
    .End = startDate.AddMinutes(30),
    .Subject = "Daily appointment"
}
' #endregion

' #region radscheduleview-features-recurrences-overview_3
Dim pattern = New RecurrencePattern() With {
    .Frequency = RecurrenceFrequency.Daily,
    .DaysOfWeekMask = RecurrenceDays.EveryDay,
    .MaxOccurrences = 4
}
' #endregion

' #region radscheduleview-features-recurrences-overview_5
appointment.RecurrenceRule = New RecurrenceRule(pattern)
' #endregion

' #region radscheduleview-features-recurrences-overview_7
appointment.RecurrenceRule.AddException(New DateTime(2011, 5, 14, 10, 0, 0))
' #endregion

' #region radscheduleview-features-recurrences-overview_9
Dim exceptionAppointment As Appointment = DirectCast(appointment.Copy(), Appointment)
exceptionAppointment.Start = New DateTime(2011, 5, 15, 11, 0, 0)
exceptionAppointment.End = exceptionAppointment.Start.AddMinutes(45)
appointment.RecurrenceRule.AddException(New DateTime(2011, 5, 15, 10, 0, 0), exceptionAppointment)
' #endregion
End Class
