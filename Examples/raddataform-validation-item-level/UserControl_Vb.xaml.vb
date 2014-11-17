Public Class Default_Vb


    ' #region raddataform-validation-item-level_1
    Imports System.ComponentModel.DataAnnotations
    '...

    Public Class Employee
        <Required()> _
        Public Property FirstName() As String
            Get
                Return m_FirstName
            End Get
            Set(value As String)
                m_FirstName = Value
            End Set
        End Property
        Private m_FirstName As String

        <Required(ErrorMessage:="LastName is required")> _
        Public Property LastName() As String
            Get
                Return m_LastName
            End Get
            Set(value As String)
                m_LastName = Value
            End Set
        End Property
        Private m_LastName As String

        <Range(21, 70)> _
        Public Property Age() As Integer
            Get
                Return m_Age
            End Get
            Set(value As Integer)
                m_Age = Value
            End Set
        End Property
        Private m_Age As Integer

        <RegularExpression("[a-z]#[0-9]*")> _
        Public Property EmployeeID() As String
            Get
                Return m_EmployeeID
            End Get
            Set(value As String)
                m_EmployeeID = Value
            End Set
        End Property
        Private m_EmployeeID As String
    End Class
' #endregion
End Class
