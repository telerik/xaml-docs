Public Class Default_Vb


' #region radscheduleview-features-recurrences-recurrencepatternhelper_1
Dim pattern = New RecurrencePattern() With {
    .Frequency = RecurrenceFrequency.Daily,
    .DaysOfWeekMask = RecurrenceDays.WeekDays,
    .Interval = 3,
    .MaxOccurrences = 10
}
' #endregion

' #region radscheduleview-features-recurrences-recurrencepatternhelper_3
Dim serializedPattern = RecurrencePatternHelper.RecurrencePatternToString(pattern)
' #endregion

' #region radscheduleview-features-recurrences-recurrencepatternhelper_5
Dim serializedPattern As String = "FREQ=DAILY;COUNT=10;INTERVAL=3;BYDAY=MO,TU,WE,TH,FR"
Dim pattern As RecurrencePattern
RecurrencePatternHelper.TryParseRecurrencePattern(serializedPattern, pattern)
' #endregion
End Class
