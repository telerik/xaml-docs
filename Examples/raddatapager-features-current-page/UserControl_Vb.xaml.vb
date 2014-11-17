Public Class Default_Vb


' #region raddatapager-features-current-page_1
Public Class IndexToNumberConverter
 Implements IValueConverter
 Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object
  Return CInt(value) + 1
 End Function
 Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object
  Return CInt(value) - 1
 End Function
End Class
' #endregion
End Class
