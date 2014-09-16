Public Class Default_Vb


' #region radscheduleview-styles-and-templates-appointment-style_2
Public Class AppointmentStyleSelector
 Inherits OrientedAppointmentItemStyleSelector
 Public Property Room402AHorizontalStyle() As Style
  Get
   Return m_Room402AHorizontalStyle
  End Get
  Set
   m_Room402AHorizontalStyle = Value
  End Set
 End Property
 Private m_Room402AHorizontalStyle As Style
 Public Property Room401BHorizontalStyle() As Style
  Get
   Return m_Room401BHorizontalStyle
  End Get
  Set
   m_Room401BHorizontalStyle = Value
  End Set
 End Property
 Private m_Room401BHorizontalStyle As Style
 Public Property Room605AHorizontalStyle() As Style
  Get
   Return m_Room605AHorizontalStyle
  End Get
  Set
   m_Room605AHorizontalStyle = Value
  End Set
 End Property
 Private m_Room605AHorizontalStyle As Style
 Public Property Room402AVerticalStyle() As Style
  Get
   Return m_Room402AVerticalStyle
  End Get
  Set
   m_Room402AVerticalStyle = Value
  End Set
 End Property
 Private m_Room402AVerticalStyle As Style
 Public Property Room401BVerticalStyle() As Style
  Get
   Return m_Room401BVerticalStyle
  End Get
  Set
   m_Room401BVerticalStyle = Value
  End Set
 End Property
 Private m_Room401BVerticalStyle As Style
 Public Property Room605AVerticalStyle() As Style
  Get
   Return m_Room605AVerticalStyle
  End Get
  Set
   m_Room605AVerticalStyle = Value
  End Set
 End Property
 Private m_Room605AVerticalStyle As Style
 Public Overrides Function SelectStyle(item As Object, container As DependencyObject, activeViewDefinition As ViewDefinitionBase) As Style
  Dim appointment As IAppointment = TryCast(item, IAppointment)
  If appointment Is Nothing Then
   Return MyBase.SelectStyle(item, container, activeViewDefinition)
  End If
  Dim r As IResource = appointment.Resources.GetResourceByType("Room")
  If r IsNot Nothing Then
   If activeViewDefinition.GetOrientation() = Orientation.Horizontal Then
    Select Case r.ResourceName
     Case "402A"
      Return Me.Room402AHorizontalStyle
     Case "401B"
      Return Me.Room401BHorizontalStyle
     Case "605A"
      Return Me.Room605AHorizontalStyle
     Case Else
      Exit Select
    End Select
   Else
    Select Case r.ResourceName
     Case "402A"
      Return Me.Room402AVerticalStyle
     Case "401B"
      Return Me.Room401BVerticalStyle
     Case "605A"
      Return Me.Room605AVerticalStyle
     Case Else
      Exit Select
    End Select
   End If
  End If
  Return MyBase.SelectStyle(item, container, activeViewDefinition)
 End Function
End Class
' #endregion
End Class
