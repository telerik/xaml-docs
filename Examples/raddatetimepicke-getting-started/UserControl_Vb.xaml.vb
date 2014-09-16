Public Class Default_Vb


' #region raddatetimepicke-getting-started_3
Dim radDateTimePicker As New RadDateTimePicker()
' #endregion

' #region raddatetimepicke-getting-started_5
Dim userSelectedValue As System.Nullable(Of DateTime) = Me.radDateTimePicker.SelectedValue
Dim userSelectedDate As System.Nullable(Of DateTime) = Me.radDateTimePicker.SelectedDate
Dim userSelectedTime As System.Nullable(Of TimeSpan) = Me.radDateTimePicker.SelectedTime
' #endregion
End Class
