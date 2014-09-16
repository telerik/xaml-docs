Public Class Default_Vb


' #region radscheduleview-features-recurrences-recurrencerule_1
Dim startDate = New DateTime(2011, 5, 11, 10, 0, 0)
Dim fitnessAppointment = New Appointment() With {
    .Start = startDate,
    .[End] = startDate.AddHours(2),
    .Subject = "Fitness"
}
Dim recurrencePattern = New RecurrencePattern() With {
    .Frequency = RecurrenceFrequency.Weekly,
    .MaxOccurrences = 30,
    .DaysOfWeekMask = RecurrenceDays.Monday Or RecurrenceDays.Wednesday Or RecurrenceDays.Friday
}
fitnessAppointment.RecurrenceRule = New RecurrenceRule(recurrencePattern)
' #endregion

' #region radscheduleview-features-recurrences-recurrencerule_3
Dim startDate = New DateTime(2011, 5, 11, 10, 0, 0)
Dim fitnessAppointment = New Appointment() With {
    .Start = startDate,
    .[End] = startDate.AddHours(2),
    .Subject = "Fitness"
}
' #endregion

' #region radscheduleview-features-recurrences-recurrencerule_5
Dim recurrencePattern = New RecurrencePattern() With {
    .Frequency = RecurrenceFrequency.Daily,
    .DaysOfWeekMask = RecurrenceDays.Wednesday,
    .MaxOccurrences = 10
}
' #endregion

' #region radscheduleview-features-recurrences-recurrencerule_7
Dim rule = New RecurrenceRule(recurrencePattern)
' #endregion

' #region radscheduleview-features-recurrences-recurrencerule_9
Dim exceptionDate = fitnessAppointment.Copy()
exceptionDate.Start = fitnessAppointment.Start.AddDays(-1)
exceptionDate.[End] = fitnessAppointment.[End].AddDays(-1)
rule.AddException(startDate, exceptionDate)
' #endregion

' #region radscheduleview-features-recurrences-recurrencerule_11
fitnessAppointment.RecurrenceRule = rule
' #endregion
End Class
