Public Class Default_Vb


' #region radscheduleview-features-appointments-custom-appointment_1
Public Class Task
 Inherits Appointment
 Private m_isDone As Boolean
 Public Property IsDone() As Boolean
  Get
   Return Me.Storage(Of Task)().m_isDone
  End Get
  Set
   Dim storage = Me.Storage(Of Task)()
   If storage.m_isDone <> value Then
    storage.m_isDone = value
    Me.OnPropertyChanged("IsDone")
   End If
  End Set
 End Property
 Public Overrides Function Copy() As IAppointment
  Dim newAppointment = New Task()
  newAppointment.CopyFrom(Me)
  Return newAppointment
 End Function
 Public Overrides Sub CopyFrom(other As IAppointment)
  Dim task = TryCast(other, Task)
  If task IsNot Nothing Then
   Me.IsDone = task.IsDone
  End If
  MyBase.CopyFrom(other)
 End Sub
End Class
' #endregion

' #region radscheduleview-features-appointments-custom-appointment_3
Dim today = DateTime.Today
Dim data = New ObservableCollection(Of Task)(Enumerable.Range(9, 14).[Select](Function(i) New Task() With { _
 .Start = today.AddMinutes(i * 60 + 15), _
 .[End] = today.AddMinutes((i + 1) * 60), _
 .Subject = String.Format("Task num. {0}", i), _
 .IsDone = today.AddMinutes((i + 1) * 60) < DateTime.Now _
}))
Me.DataContext = data
' #endregion
End Class
