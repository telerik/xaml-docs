Public Class Default_Vb


' #region radmaskedinput-features-common_2
Public Class NumericValueToTextConverter
	Implements IValueConverter
	Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
		If value IsNot Nothing Then
			Dim doubleValue As Double = 0.0
			Dim decimalValue As Decimal = 0D
			If Double.TryParse(value.ToString(), System.Globalization.NumberStyles.Number, culture, doubleValue) Then
				Return "Double Value: " & doubleValue.ToString("n4")
			ElseIf Decimal.TryParse(value.ToString(), System.Globalization.NumberStyles.Any, culture, decimalValue) Then
				Return "Decimal Value: " & decimalValue.ToString("c4")
			Else
				Return value.ToString()
			End If
		Else
			Return value
		End If
	End Function
	Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
		Throw New NotImplementedException()
	End Function
End Class
' #endregion
End Class
