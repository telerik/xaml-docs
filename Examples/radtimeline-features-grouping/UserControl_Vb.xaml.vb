Public Class Default_Vb
' #region radtimeline-features-grouping-0
Public Class GroupKeyToIsExpandedConverter
	Implements IValueConverter
	Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object
		Dim groupKey As String = TryCast(value, String)

		If groupKey IsNot Nothing AndAlso groupKey = "Group1" Then
			Return True
		End If

		Return False
	End Function

	Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object
		Throw New NotImplementedException()
	End Function
End Class
' #endregion

End Class
