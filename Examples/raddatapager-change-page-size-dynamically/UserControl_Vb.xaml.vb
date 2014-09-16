Public Class Default_Vb


' #region raddatapager-change-page-size-dynamically_1
Public Class CountConverter
 Implements IValueConverter
 Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
  Dim items = TryCast(TryCast(value, DataPagerPresenter).DataContext, SampleDataSource)
  Dim i As Integer = 1
  Dim result As New List(Of Integer)()
  For Each item As var In items.Collection
   If i Mod 5 = 0 Then
    result.Add(i)
   End If
   i += 1
  Next
  Return result
 End Function
 Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object
  Return value
 End Function
End Class
' #endregion
End Class
