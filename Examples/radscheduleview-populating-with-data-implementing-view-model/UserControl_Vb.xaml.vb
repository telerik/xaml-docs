Public Class Default_Vb


' #region radscheduleview-populating-with-data-implementing-view-model_2
Public Class MyViewModel
End Class
' #endregion

' #region radscheduleview-populating-with-data-implementing-view-model_4
Private m_Appointments As ObservableCollection(Of Appointment)
Private m_ResourceTypes As ObservableCollection(Of ResourceType)

Public Property Appointments() As ObservableCollection(Of Appointment)
	Get
		Return Me.m_Appointments
	End Get
	Private Set(value As ObservableCollection(Of Appointment))
		Me.m_Appointments = value
	End Set
End Property

Public Property ResourceTypes() As ObservableCollection(Of ResourceType)
	Get
		Return Me.m_ResourceTypes
	End Get
	Private Set(value As ObservableCollection(Of ResourceType))
		Me.m_ResourceTypes = value
	End Set
End Property
' #endregion

' #region radscheduleview-populating-with-data-implementing-view-model_6
Private Function GenerateResourceTypes() As ObservableCollection(Of ResourceType)
 Dim result As New ObservableCollection(Of ResourceType)()
 Dim roomType As New ResourceType("Room")
 Dim room102 As New Resource("Room 102")
 Dim room203 As New Resource("Room 203")
 Dim room406 As New Resource("Room 406")
 roomType.Resources.Add(room102)
 roomType.Resources.Add(room203)
 roomType.Resources.Add(room406)
 Dim speakerType As New ResourceType("Speaker")
 Dim tomSpeaker As New Resource("Tom")
 Dim peterSpeaker As New Resource("Peter")
 speakerType.Resources.Add(tomSpeaker)
 speakerType.Resources.Add(peterSpeaker)
 result.Add(roomType)
 result.Add(speakerType)
 Return result
End Function
' #endregion

' #region radscheduleview-populating-with-data-implementing-view-model_8
Public Sub New()
 Me.resourceTypes = Me.GenerateResourceTypes()
 Me.appointments = New ObservableCollection(Of Appointment)()
End Sub
' #endregion

' #region radscheduleview-populating-with-data-implementing-view-model_11
Me.DataContext = New MyViewModel()
' #endregion
End Class
