Public Class Default_Vb


' #region raddatapager-styles-and-templates-styling-the-numeric-buttons_2
Public Class BooleanToVisibilityConverter
 Implements IValueConverter
 Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
  Return If(System.Convert.ToBoolean(value), Visibility.Visible, Visibility.Collapsed)
 End Function
 Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
  Return value
 End Function
End Class
' #endregion
End Class
