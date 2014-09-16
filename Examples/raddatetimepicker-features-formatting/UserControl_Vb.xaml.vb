Public Class Default_Vb

' #region raddatetimepicker-features-formatting_3
Me.radDateTimePicker.Culture = New System.Globalization.CultureInfo("de")
' #endregion

' #region raddatetimepicker-features-formatting_5
Me.radDateTimePicker.Culture = New System.Globalization.CultureInfo("en-US")
Me.radDateTimePicker.Culture.DateTimeFormat.ShortDatePattern = "dd-MMM"
Me.radDateTimePicker.Culture.DateTimeFormat.ShortTimePattern = "h tt"
' #endregion
End Class
