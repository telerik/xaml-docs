Public Class Default_Vb


' #region radchart-howto-binding-datapointmember-to-a-depenndency-property_2
Public Class MyObject
 Implements INotifyPropertyChanged
 Private _yValue As Double = 0
 Public Event PropertyChanged As PropertyChangedEventHandler
 Public Property yValue() As Double
  Get
   Return Me._yValue
  End Get
  Set
   If Me._yValue = value Then
    Return
   End If
   Me._yValue = value
   Me.OnPropertyChanged("yValue")
  End Set
 End Property
 Protected Overridable Sub OnPropertyChanged(propertyName As String)
  RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
 End Sub
End Class
' #endregion

' #region radchart-howto-binding-datapointmember-to-a-depenndency-property_4
Me.DataContext = New List(Of MyObject)() With { _
 New MyObject() _
}
' #endregion
End Class
