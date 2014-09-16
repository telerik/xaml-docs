Public Class Default_Vb


' #region gridview-rowloaded-event_2
AddHandler Me.RadGridView1.RowLoaded, New EventHandler(Of RowLoadedEventArgs)(AddressOf RadGridView1_RowLoaded)
AddHandler Me.RadGridView1.RowUnloaded, New EventHandler(Of RowUnloadedEventArgs)(AddressOf RadGridView1_RowUnloaded)
' #endregion

' #region gridview-rowloaded-event_4
Sub RadGridView1_RowLoaded(sender As Object, e As RowLoadedEventArgs)
 If TypeOf e.Row Is GridViewRow AndAlso Not (TypeOf e.Row Is GridViewNewRow) Then
  Dim person As Person = TryCast(e.DataElement, Person)
  If person.Age < 30 Then
   (DirectCast(e.Row, GridViewRow)).IsEnabled = False
  End If
 End If
End Sub
' #endregion
End Class
