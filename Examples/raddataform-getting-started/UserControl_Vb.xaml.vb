Public Class Default_Vb


' #region raddataform-getting-started_5
Public Class Employee
 Public Property FirstName() As String
  Get
   Return m_FirstName
  End Get
  Set
   m_FirstName = Value
  End Set
 End Property
 Private m_FirstName As String
 Public Property LastName() As String
  Get
   Return m_LastName
  End Get
  Set
   m_LastName = Value
  End Set
 End Property
 Private m_LastName As String
 Public Property Occupation() As String
  Get
   Return m_Occupation
  End Get
  Set
   m_Occupation = Value
  End Set
 End Property
        Private m_Occupation As String
 Public Property StartingDate() As DateTime
  Get
   Return m_StartingDate
  End Get
  Set
   m_StartingDate = Value
  End Set
 End Property
 Private m_StartingDate As DateTime
 Public Property IsMarried() As Boolean
  Get
   Return m_IsMarried
  End Get
  Set
   m_IsMarried = Value
  End Set
 End Property
 Private m_IsMarried As Boolean
 Public Property Salary() As Integer
  Get
   Return m_Salary
  End Get
  Set
   m_Salary = Value
  End Set
 End Property
 Private m_Salary As Integer
 Public Property Gender() As Gender
  Get
   Return m_Gender
  End Get
  Set
   m_Gender = Value
  End Set
 End Property
 Private m_Gender As Gender
End Class
' #endregion

' #region raddataform-getting-started_7
Public Enum Gender
 Female
 Male
End Enum
' #endregion

' #region raddataform-getting-started_9
    Dim employee As New Employee() With { _
     .FirstName = "Sarah", _
     .LastName = "Blake", _
     .Occupation = "Supplied Manager", _
     .StartingDate = New DateTime(2005, 4, 12), _
     .IsMarried = True, _
     .Salary = 3500, _
     .Gender = Gender.Female _
    }
 Me.DataForm1.CurrentItem = employee
End Sub
' #endregion

' #region raddataform-getting-started_11
Public Class Employee
 Public Sub New()
 End Sub
 Public Shared Function GetEmployees() As ObservableCollection(Of Employee)
  Dim employees As New ObservableCollection(Of Employee)()
            employees.Add(New Employee() With { _
              .FirstName = "Sarah", _
              .LastName = "Blake", _
              .Occupation = "Supplied Manager", _
              .StartingDate = New DateTime(2005, 4, 12), _
              .IsMarried = True, _
              .Salary = 3500, _
              .Gender = Gender.Female _
            })
            employees.Add(New Employee() With { _
              .FirstName = "Jane", _
              .LastName = "Simpson", _
              .Occupation = "Security", _
              .StartingDate = New DateTime(2008, 12, 3), _
              .IsMarried = True, _
              .Salary = 2000, _
              .Gender = Gender.Female _
            })
            employees.Add(New Employee() With { _
              .FirstName = "John", _
              .LastName = "Peterson", _
              .Occupation = "Consultant", _
              .StartingDate = New DateTime(2005, 4, 12), _
              .IsMarried = False, _
              .Salary = 2600, _
              .Gender = Gender.Male _
            })
            employees.Add(New Employee() With { _
              .FirstName = "Peter", _
              .LastName = "Bush", _
              .Occupation = "Cashier", _
              .StartingDate = New DateTime(2005, 4, 12), _
              .IsMarried = True, _
              .Salary = 2300, _
              .Gender = Gender.Male _
            })
  Return employees
 End Function
End Class
' #endregion

' #region raddataform-getting-started_13
Public Sub New()
 InitializeComponent()
 Me.DataForm1.ItemsSource = Employee.GetEmployees()
End Sub
' #endregion
End Class
