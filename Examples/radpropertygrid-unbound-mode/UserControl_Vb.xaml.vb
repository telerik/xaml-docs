Public Class Default_Vb
   
    ' #region radpropertygrid-unbound-mode_3
    Public Class Employee
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = Value
            End Set
        End Property
        Private m_Name As String
        Public Property HireDate() As DateTime
            Get
                Return m_HireDate
            End Get
            Set(value As DateTime)
                m_HireDate = Value
            End Set
        End Property
        Private m_HireDate As DateTime
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

    Public Class Department
        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = Value
            End Set
        End Property
        Private m_Name As String
        Public Property ID() As Integer
            Get
                Return m_ID
            End Get
            Set(value As Integer)
                m_ID = Value
            End Set
        End Property
        Private m_ID As Integer
    End Class
    ' #endregion
    ' #region radpropertygrid-unbound-mode_5
   Public Sub New()
        InitializeComponent()
        Me.rpg.Item = New Employee()
        With {
               .Name = "Nancy Davolio",
               .HireDate = Date.Now,
               .Department = New Department() 
            With {
                 .ID = 1,
                 .Name = "US Department"
                 }

            End With
            }
    End Sub
    ' #endregion

End Class
