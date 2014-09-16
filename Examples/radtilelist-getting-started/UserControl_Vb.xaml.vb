Public Class Default_Vb


    ' #region radtilelist-getting-started_5
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
 Private m_Ocupation As String
 Public Property Salary() As Integer
  Get
   Return m_Salary
  End Get
  Set
   m_Salary = Value
  End Set
 End Property
 Private m_Salary As Integer
End Class
' #endregion




    ' #region radtilelist-getting-started_7
Public Class Employee
 Public Sub New()
 End Sub
 Public Shared Function GetEmployees() As ObservableCollection(Of Employee)
  Dim employees As New ObservableCollection(Of Employee)()
  employees.Add(New Employee() With { _
   Key .FirstName = "Sarah", _
   Key .LastName = "Blake", _
   Key .Occupation = "Supplies Manager", _
   Key .Salary = 3500 _
  })
  employees.Add(New Employee() With { _
   Key .FirstName = "Jane", _
   Key .LastName = "Simpson", _
   Key .Occupation = "Security", _
   Key .Salary = 2000 _
  })
  employees.Add(New Employee() With { _
   Key .FirstName = "John", _
   Key .LastName = "Peterson", _
   Key .Occupation = "Consultant", _
   Key .Salary = 2600 _
  })
  employees.Add(New Employee() With { _
   Key .FirstName = "Peter", _
   Key .LastName = "Bush", _
   Key .Occupation = "Cashier", _
   Key .Salary = 2300 _
  })
  Return employees
 End Function
End Class
' #endregion

    ' #region radtilelist-getting-started_9
Public Sub New()
 InitializeComponent()
        Me.RadTileList.ItemsSource = Employee.GetEmployees()
End Sub
' #endregion
End Class
