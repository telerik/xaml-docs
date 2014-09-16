Public Class Default_Vb


' #region raddatetimepicker-features-clock-items_2
Public Sub New()
 InitializeComponent()
 Me.radDateTimePicker.ClockItemsSource = Me.LoadDataObjects()
End Sub
Public Function LoadDataObjects() As ObservableCollection(Of TimeSpan)
 Dim times As New ObservableCollection(Of TimeSpan)() With {
  New TimeSpan(9, 0, 0),
  New TimeSpan(10, 0, 0),
  New TimeSpan(10, 5, 0),
  New TimeSpan(10, 22, 0),
  New TimeSpan(13, 15, 0)
 }
 Return times
End Function
' #endregion
End Class
