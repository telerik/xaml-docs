Public Class Default_Vb


    ' #region radscheduleview-howto-set-custom-appointment-height_0
    Public Class AppointmentStyleSelector
        Inherits OrientedAppointmentItemStyleSelector

        Public Property SmallAppointmentStyle() As Style
        Public Property RegularAppointmentStyle() As Style
        Public Property BigAppointmentStyle() As Style

        Public Overrides Function SelectStyle(ByVal item As Object, ByVal container As DependencyObject, ByVal activeViewDefinition As ViewDefinitionBase) As Style
            Dim appointment = TryCast(item, Appointment)

            If appointment IsNot Nothing Then
                If appointment.Duration() <= New TimeSpan(1, 0, 0) Then
                    Return Me.SmallAppointmentStyle
                ElseIf appointment.Duration() <= New TimeSpan(2, 0, 0) Then
                    Return Me.RegularAppointmentStyle
                ElseIf appointment.Duration() > New TimeSpan(2, 0, 0) Then
                    Return Me.BigAppointmentStyle
                End If
            End If

            Return MyBase.SelectStyle(item, container, activeViewDefinition)
        End Function
    End Class
' #endregion
End Class
