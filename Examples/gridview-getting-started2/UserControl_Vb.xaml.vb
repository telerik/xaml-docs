Public Class Default_Vb


' #region gridview-getting-started2_5
Public Class Employee
Private _FirstName As String
    Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal value As String)
            _FirstName = value
        End Set
    End Property
Private _LastName As String
    Public Property LastName() As String
        Get
            Return _LastName
        End Get
        Set(ByVal value As String)
            _LastName = value
        End Set
    End Property
Private _Age As Integer
    Public Property Age() As Integer
        Get
            Return _Age
        End Get
        Set(ByVal value As Integer)
            _Age = value
        End Set
    End Property
        Private _IsMarried As Boolean
        Public Property IsMarried() As Boolean
            Get
                Return _IsMarried
            End Get
            Set(ByVal value As Boolean)
                _IsMarried = value
            End Set
        End Property
    End Class
    ' #endregion

    ' #region gridview-getting-started2_7
    Public Class EmployeeService
        Public Shared Function GetEmployees() As ObservableCollection(Of Employee)
            Dim employees As New ObservableCollection(Of Employee)()
            Dim employee As New Employee()
            employee.FirstName = "Maria"
            employee.LastName = "Anders"
            employee.IsMarried = True
            employee.Age = 24
            employees.Add(employee)
            employee = New Employee()
            employee.FirstName = "Ana"
            employee.LastName = "Trujillo"
            employee.IsMarried = True
            employee.Age = 44
            employees.Add(employee)
            employee = New Employee()
            employee.FirstName = "Antonio"
            employee.LastName = "Moreno"
            employee.IsMarried = True
            employee.Age = 33
            employees.Add(employee)
            employee = New Employee()
            employee.FirstName = "Thomas"
            employee.LastName = "Hardy"
            employee.IsMarried = False
            employee.Age = 13
            employees.Add(employee)
            employee = New Employee()
            employee.FirstName = "Hanna"
            employee.LastName = "Moos"
            employee.IsMarried = False
            employee.Age = 28
            employees.Add(employee)
            employee = New Employee()
            employee.FirstName = "Frederique"
            employee.LastName = "Citeaux"
            employee.IsMarried = True
            employee.Age = 67
            employees.Add(employee)
            employee = New Employee()
            employee.FirstName = "Martin"
            employee.LastName = "Sommer"
            employee.IsMarried = False
            employee.Age = 22
            employees.Add(employee)
            employee = New Employee()
            employee.FirstName = "Laurence"
            employee.LastName = "Lebihan"
            employee.IsMarried = False
            employee.Age = 32
            employees.Add(employee)
            employee = New Employee()
            employee.FirstName = "Elizabeth"
            employee.LastName = "Lincoln"
            employee.IsMarried = False
            employee.Age = 9
            employees.Add(employee)
            employee = New Employee()
            employee.FirstName = "Victoria"
            employee.LastName = "Ashworth"
            employee.IsMarried = True
            employee.Age = 29
            employees.Add(employee)
            Return employees
        End Function
    End Class
' #endregion

' #region gridview-getting-started2_9
Me.radGridView.ItemsSource = EmployeeService.GetEmployees()
' #endregion
End Class
