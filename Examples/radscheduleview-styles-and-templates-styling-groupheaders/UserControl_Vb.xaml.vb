Public Class Default_Vb


' #region radscheduleview-styles-and-templates-styling-groupheaders_6
Public Class CustomGroupHeaderStyleSelector
    Inherits OrientedGroupHeaderStyleSelector
    Public Property CalendarStyle() As Style
        Get
            Return m_CalendarStyle
        End Get
        Set(value As Style)
            m_CalendarStyle = value
        End Set
    End Property
    Private m_CalendarStyle As Style
    Public Property DateStyle() As Style
        Get
            Return m_DateStyle
        End Get
        Set(value As Style)
            m_DateStyle = value
        End Set
    End Property
    Private m_DateStyle As Style
    Public Overrides Function SelectStyle(item As Object, container As DependencyObject, activeViewDeifinition As ViewDefinitionBase) As Style
        Dim groupHeader = TryCast(container, GroupHeader)
        If groupHeader IsNot Nothing Then
            Dim groupKey = TryCast(groupHeader.GroupKey, Resource)
            If groupKey IsNot Nothing AndAlso groupKey.ResourceType = "Calendar" Then
                Return Me.CalendarStyle
            ElseIf TypeOf groupHeader.GroupKey Is DateTime Then
                Return Me.DateStyle
            End If
        End If
        Return MyBase.SelectStyle(item, container, activeViewDeifinition)
    End Function
End Class
' #endregion
End Class
