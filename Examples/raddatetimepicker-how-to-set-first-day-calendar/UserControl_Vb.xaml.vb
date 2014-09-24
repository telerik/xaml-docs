Public Class Default_Vb


' #region raddatetimepicker-how-to-set-first-day-calendar_2
Public Sub New()
 InitializeComponent()
 Dim cultureInfo As New CultureInfo("en-US")
 Dim dateInfo As New DateTimeFormatInfo()
 dateInfo.FirstDayOfWeek = DayOfWeek.Friday
 cultureInfo.DateTimeFormat = dateInfo
 Me.radDateTimePicker.Culture = cultureInfo
End Sub
' #endregion
End Class
