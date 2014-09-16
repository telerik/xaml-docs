Public Class Default_Vb
    ' #region radpropertygrid-data-annotations_2
    Public Class Employee
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
        Public Property PhoneNum() As String
            Get
                Return m_PhoneNum
            End Get
            Set(value As String)
                m_PhoneNum = Value
            End Set
        End Property
        Private m_PhoneNum As String
        Public Property Salary() As Integer
            Get
                Return m_Salary
            End Get
            Set(value As Integer)
                m_Salary = Value
            End Set
        End Property
        Private m_Salary As Integer
        Public Property Occupation() As String
            Get
                Return m_Occupation
            End Get
            Set(value As String)
                m_Occupation = Value
            End Set
        End Property
        Private m_Occupation As String
        Public Property StartingDate() As DateTime
            Get
                Return m_StartingDate
            End Get
            Set(value As DateTime)
                m_StartingDate = Value
            End Set
        End Property
        Private m_StartingDate As DateTime
    End Class

    ' #endregion
    ' #region radpropertygrid-data-annotations_4
    Me.PropertyGrid1.Item = New Employee() With { _
  .FirstName = "Sarah", _
  .LastName = "Blake", _
  .Occupation = "Supplied Manager", _
  .StartingDate = New DateTime(2005, 4, 12), _
  .Salary = 3500 _
}
    ' #endregion
    ' #region radpropertygrid-data-annotations_6
    <Display(Name:="Year")> _
    Public Property [StartingDate]() As DateTime
   
    ' #endregion
    ' #region radpropertygrid-data-annotations_8
    'Hide StartingDate from the UI
    <Browsable(False)> _
    Public Property [StartingDate]() As DateTime

    ' #endregion
    ' #region radpropertygrid-data-annotations_10
    '<ReadOnly(true)> _
    Public Property [StartingDate]() As DateTime
    ' #endregion
    ' #region radpropertygrid-data-annotations_12
    '<ReadOnly(true)> _
    Public Property [StartingDate]() As DateTime
    ' #endregion
End Class
