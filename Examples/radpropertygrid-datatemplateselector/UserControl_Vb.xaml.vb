Public Class Default_Vb

    ' #region radpropertygrid-datatemplateselector_2
    Public Class Customer
        Public Property FirstName() As String
            Get
                Return m_FirstName
            End Get
            Set(value As String)
                m_FirstName = Value
            End Set
        End Property
        Private m_FirstName As String
        Public Property LastName() As String
            Get
                Return m_LastName
            End Get
            Set(value As String)
                m_LastName = Value
            End Set
        End Property
        Private m_LastName As String
        Public Property PhoneNumber() As String
            Get
                Return m_PhoneNumber
            End Get
            Set(value As String)
                m_PhoneNumber = Value
            End Set
        End Property
        Private m_PhoneNumber As String
        Public Property Department() As Department
            Get
                Return m_Department
            End Get
            Set(value As Department)
                m_Department = Value
            End Set
        End Property
        Private m_Department As Department
    End Class

    Public Class FieldTemplateSelector
        Inherits DataTemplateSelector
        Public Overrides Function SelectTemplate(item As Object, container As DependencyObject) As DataTemplate
            Dim propDef As PropertyDefinition = TryCast(item, PropertyDefinition)
            If propDef.DisplayName = "PhoneNumber" Then
                Return Me.PhoneNumberDataTemplate
            End If
            If propDef.SourceProperty.PropertyType = GetType(String) Then
                Return Me.StringDataTemplate
            End If
            Return Nothing
        End Function

        Public Property PhoneNumberDataTemplate() As DataTemplate
            Get
                Return m_PhoneNumberDataTemplate
            End Get
            Set(value As DataTemplate)
                m_PhoneNumberDataTemplate = Value
            End Set
        End Property
        Private m_PhoneNumberDataTemplate As DataTemplate
        Public Property StringDataTemplate() As DataTemplate
            Get
                Return m_StringDataTemplate
            End Get
            Set(value As DataTemplate)
                m_StringDataTemplate = Value
            End Set
        End Property
        Private m_StringDataTemplate As DataTemplate
    End Class

    ' #endregion

End Class
