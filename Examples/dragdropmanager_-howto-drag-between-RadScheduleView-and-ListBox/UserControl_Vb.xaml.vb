Public Class Default_Vb


' #region dragdropmanager_-howto-drag-between-RadScheduleView-and-ListBox_2
SampleListBox.ItemsSource = New ObservableCollection(Of Appointment)()
' #endregion

' #region dragdropmanager_-howto-drag-between-RadScheduleView-and-ListBox_4
DragDropManager.AddDragInitializeHandler(Me, New DragInitializeEventHandler(AddressOf OnDragInitialized))           
DragDropManager.AddDragOverHandler(Me, New Telerik.Windows.DragDrop.DragEventHandler(AddressOf OnListDragOver))
DragDropManager.AddDragDropCompletedHandler(Me, New DragDropCompletedEventHandler(AddressOf(DragDropComplete))
Private Sub OnDrop(sender As Object, args As Telerik.Windows.DragDrop.DragEventArgs)
 Dim listBoxItems = DirectCast(SampleListBox.ItemsSource, IList)
 Dim draggedItems = DirectCast(args.Data, ScheduleViewDragDropPayload).DraggedAppointments
 For Each item As Object In draggedItems
  If Not listBoxItems.Contains(item) Then
   listBoxItems.Add(item)
  End If
 Next
End Sub
Private Sub OnDragInitialize(sender As Object, args As DragInitializeEventArgs)
 Dim listBoxItem = DirectCast(args.Source, System.Windows.Controls.ListBoxItem)
 Dim listbox = listBoxItem.ParentOfType(Of System.Windows.Controls.ListBox)()
 Dim appointments As IList(Of IOccurrence) = listbox.SelectedItems.OfType(Of IOccurrence)().ToList()
 If appointments.Count = 0 Then
  Return
 End If
 args.Data = New ScheduleViewDragDropPayload(listbox.ItemsSource, appointments)
 Dim dragVisual = New TextBlock()
 dragVisual.SetBinding(TextBlock.TextProperty, New System.Windows.Data.Binding("DraggedAppointment") With { _
  Key .Source = args.Data _
 })
 args.DragVisual = dragVisual
 args.AllowedEffects = DragDropEffects.All
End Sub
Private Sub OnDragDropComplete(sender As Object, args As DragDropCompletedEventArgs)
 Dim payload = DirectCast(args.Data, ScheduleViewDragDropPayload)
 Dim sourceItems = DirectCast(payload.SourceAppointmentsSource, IList)
 For Each item As Object In payload.DraggedAppointments
  sourceItems.Remove(item)
 Next
End Sub
Private Sub OnListDragOver(sender As Object, args As Telerik.Windows.DragDrop.DragEventArgs)
 If DirectCast(sender, System.Windows.Controls.ListBox).ItemsSource = DirectCast(args.Data, ScheduleViewDragDropPayload).SourceAppointmentsSource Then
  args.Effects = DragDropEffects.None
 End If
 args.Handled = True
End Sub
' #endregion

' #region dragdropmanager_-howto-drag-between-RadScheduleView-and-ListBox_7
ScheduleView.AppointmentsSource = New ObservableCollection(Of Appointment)(From c In Enumerable.Range(0, 10)New Appointment() With { _
 Key .Start = DateTime.Now.AddDays(c Mod 5), _
 Key .[End] = DateTime.Now.AddDays(c Mod 5).AddHours(2), _
 Key .Subject = "Event " & Convert.ToString(c) _
})
' #endregion
End Class
