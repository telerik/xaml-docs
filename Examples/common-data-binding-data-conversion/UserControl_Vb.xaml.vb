Public Class Default_Vb


' #region common-data-binding-data-conversion_1
Public Class BackgroundConverter
    Implements IValueConverter
    Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
        Dim slot As TimeSlot = TryCast(value, TimeSlot)
        If slot.Start = DateTime.Today Then
            Return New SolidColorBrush(Colors.Red)
        End If
        Return New SolidColorBrush(Colors.White)
    End Function
    Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object
        Return Nothing
    End Function
End Class
' #endregion
End Class
