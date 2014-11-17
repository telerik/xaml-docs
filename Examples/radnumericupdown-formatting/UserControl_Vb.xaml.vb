Public Class Default_Vb


    ' #region radnumericupdown-formatting_1-1
Private Function TestMethod() As RadNumericUpDown
   Dim numeric As RadNumericUpDown = New RadNumericUpDown
   numeric.Value = 15.50
   numeric.ValueFormat = ValueFormat.Numeric
   numeric.NumberFormatInfo = New NumberFormatInfo() With {
     .NumberDecimalDigits = 0
   }   
   //the display result is "16"
   
   return numeric
End Sub
    ' #endregion

    ' #region radnumericupdown-formatting_1-2
    Private Function TestMethod() As RadNumericUpDown
        Dim numeric As RadNumericUpDown = New RadNumericUpDown
        numeric.Value = 15.5
        numeric.ValueFormat = ValueFormat.Currency
        numeric.NumberFormatInfo = New NumberFormatInfo() With {
          .CurrencyDecimalDigits = 2
        }
        //the display result is "$15.50"
       
        Return numeric
    End Function
    ' #endregion

    ' #region radnumericupdown-formatting_1-3
    Private Function TestMethod() As RadNumericUpDown
        Dim numeric As RadNumericUpDown = New RadNumericUpDown
        numeric.Value = 15.5
        numeric.ValueFormat = ValueFormat.Percentage
        numeric.NumberFormatInfo = New NumberFormatInfo() With {
            .PercentDecimalDigits = 1
        }
    //the display result is "%1500.5"

        Return numeric
    End Function
    ' #endregion

' #region radnumericupdown-formatting_3
Private Function TestMethod() As RadNumericUpDown
  Dim numeric As RadNumericUpDown = New RadNumericUpDown
  numeric.Value = 10
  numeric.ValueFormat = ValueFormat.Numeric
  numeric.NumberFormatInfo = New NumberFormatInfo() With {
    .NumberDecimalDigits = 2
  }
  numeric.CustomUnit = "meters"
  //the display result is "10.00 meters"
  return numeric
End Sub
' #endregion
End Class
