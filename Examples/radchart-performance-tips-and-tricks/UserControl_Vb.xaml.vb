Public Class Default_Vb


' #region radchart-performance-tips-and-tricks_1
Public Class AddRangeObservableCollection(Of T)
 Inherits ObservableCollection(Of T)
 Private suppressOnCollectionChanged As Boolean
 Public Sub AddRange(items As IEnumerable(Of T))
  If items = Nothing Then
   Throw New ArgumentNullException("items")
  End If
  If items.Any() Then
   Try
    Me.suppressOnCollectionChanged = True
    For Each item As var In items
     Me.Add(item)
    Next
   Finally
    Me.suppressOnCollectionChanged = False
    Me.OnCollectionChanged(New NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset))
   End Try
  End If
 End Sub
 Protected Overloads Overrides Sub OnCollectionChanged(e As NotifyCollectionChangedEventArgs)
  If Not Me.suppressOnCollectionChanged Then
   MyBase.OnCollectionChanged(e)
  End If
 End Sub
End Class
' #endregion
End Class
