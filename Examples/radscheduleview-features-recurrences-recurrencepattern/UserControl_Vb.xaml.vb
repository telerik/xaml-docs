Public Class Default_Vb


' #region radscheduleview-features-recurrences-recurrencepattern_1
Dim pattern = New RecurrencePattern() With {
    .Frequency = RecurrenceFrequency.Monthly,
    .MaxOccurrences = 10
}
Dim copyPattern = pattern.Copy()
' #endregion

' #region radscheduleview-features-recurrences-recurrencepattern_3
Dim pattern = New RecurrencePattern() With {
    .Frequency = RecurrenceFrequency.Monthly,
    .MaxOccurrences = 10
}
Dim newPattern As New RecurrencePattern()
newPattern.CopyFrom(pattern)
' #endregion

' #region radscheduleview-features-recurrences-recurrencepattern_5
Dim startDate = New DateTime(2011, 5, 11, 10, 0, 0)
Dim appointment = New Appointment() With {
    .Start = startDate,
    .End = startDate.AddHours(2),
    .Subject = "Example"
}
' #endregion

' #region radscheduleview-features-recurrences-recurrencepattern_7
Dim pattern = New RecurrencePattern() With {
    Frequency = RecurrenceFrequency.Daily
}
appointment.RecurrenceRule = New RecurrenceRule(pattern)
' #endregion

' #region radscheduleview-features-recurrences-recurrencepattern_9
Dim pattern = New RecurrencePattern() With {
     .Frequency = RecurrenceFrequency.Weekly,
     .DaysOfWeekMask = RecurrenceDays.WeekDays
}
appointment.RecurrenceRule = New RecurrenceRule(pattern)
' #endregion

' #region radscheduleview-features-recurrences-recurrencepattern_11
Dim pattern = New RecurrencePattern() With {
     .Frequency = RecurrenceFrequency.Daily,
     .DaysOfWeekMask = RecurrenceDays.EveryDay,
     .Interval = 3
}
appointment.RecurrenceRule = New RecurrenceRule(pattern)
' #endregion

' #region radscheduleview-features-recurrences-recurrencepattern_13
Dim pattern = New RecurrencePattern() With {
     .DayOfMonth = 5,
     .Frequency = RecurrenceFrequency.Monthly,  
     .Interval = 2
}
appointment.RecurrenceRule = New RecurrenceRule(pattern)
' #endregion

' #region radscheduleview-features-recurrences-recurrencepattern_15
Dim pattern = New RecurrencePattern() With {
     .DayOrdinal = 2,
     .DaysOfWeekMask = RecurrenceDays.Monday,
     .Frequency = RecurrenceFrequency.Monthly,  
     .Interval = 2
}
appointment.RecurrenceRule = New RecurrenceRule(pattern)
' #endregion

' #region radscheduleview-features-recurrences-recurrencepattern_17
Dim pattern = New RecurrencePattern() With {
    .Frequency = RecurrenceFrequency.Yearly,
    .MonthOfYear = 11,
    .DayOfMonth = 13
}
appointment.RecurrenceRule = New RecurrenceRule(pattern)
' #endregion

' #region radscheduleview-features-recurrences-recurrencepattern_19
Dim pattern = New RecurrencePattern() With {
    .Frequency = RecurrenceFrequency.Daily,
    .MaxOccurrences = 3
}
appointment.RecurrenceRule = New RecurrenceRule(pattern)
' #endregion

' #region radscheduleview-features-recurrences-recurrencepattern_21
Dim pattern = New RecurrencePattern() With {
     .Frequency = RecurrenceFrequency.Daily,
     .RecursUntil = New DateTime(2011, 5, 24, 10, 0, 0)
}
appointment.RecurrenceRule = New RecurrenceRule(pattern)
' #endregion
End Class
