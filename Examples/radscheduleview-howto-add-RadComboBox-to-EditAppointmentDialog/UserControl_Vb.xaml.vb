Public Class Default_Vb


' #region radscheduleview-howto-add-RadComboBox-to-EditAppointmentDialog_3
Public Class MyViewModel
    Public Property Appointments() As ObservableCollection(Of Appointment)
        Get
            Return m_Appointments
        End Get
        Private Set(value As ObservableCollection(Of Appointment))
            m_Appointments = value
        End Set
    End Property
    Private m_Appointments As ObservableCollection(Of Appointment)
    Public Property ComboBoxItems() As ObservableCollection(Of String)
        Get
            Return m_ComboBoxItems
        End Get
        Private Set(value As ObservableCollection(Of String))
            m_ComboBoxItems = value
        End Set
    End Property
    Private m_ComboBoxItems As ObservableCollection(Of String)
    Public Sub New()
        Appointments = New ObservableCollection(Of Appointment)() From {
         New Appointment() With {
          .Subject = "test app",
          .Start = DateTime.Now,
         .[End] = DateTime.Now.AddHours(2)
        }
        }
        ComboBoxItems = New ObservableCollection(Of String)() From {
         "item1",
         "item2",
         "item3"
        }
    End Sub
End Class
' #endregion
End Class
