Public Class Default_Vb


' #region raddatetimepicker-how-to-implement-custom-parsing_2
Private Sub radDateTimePicker_ParseDateTimeValue(sender As Object, args As Telerik.Windows.Controls.ParseDateTimeEventArgs)
 Dim input As String = args.TextToParse.ToLower()
 Dim formatInfo As New System.Globalization.DateTimeFormatInfo()
 Dim monthIndex As Integer = 1
 For Each month As String In formatInfo.MonthNames
  If input.Contains(month.ToLower()) = True Then
   Exit For
  End If
  monthIndex += 1
 Next
 If monthIndex < 12 Then
  args.Result = New DateTime(2010, monthIndex, 1)
 Else
  args.IsParsingSuccessful = False
 End If
End Sub
' #endregion
End Class
