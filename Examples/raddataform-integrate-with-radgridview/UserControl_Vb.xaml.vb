Public Class Default_Vb


' #region raddataform-integrate-with-radgridview_1
Public Class Employee
 Implements INotifyPropertyChanged
 Public Event PropertyChanged As PropertyChangedEventHandler
 Private m_firstName As String
 Private m_lastName As String
 Private m_ocupation As String
 Private m_startingDate As DateTime
 Private m_isMarried As Boolean
 Public Property FirstName() As String
  Get
   Return Me.m_firstName
  End Get
  Set
   If value <> Me.m_firstName Then
    Me.m_firstName = value
    Me.OnPropertyChanged("FirstName")
   End If
  End Set
 End Property
 Public Property LastName() As String
  Get
   Return Me.m_lastName
  End Get
  Set
   If value <> Me.m_lastName Then
    Me.m_lastName = value
    Me.OnPropertyChanged("LastName")
   End If
  End Set
 End Property
 Public Property Ocupation() As String
  Get
   Return Me.m_ocupation
  End Get
  Set
   If value <> Me.m_ocupation Then
    Me.m_ocupation = value
    Me.OnPropertyChanged("Ocupation")
   End If
  End Set
 End Property
 Public Property StartingDate() As DateTime
  Get
   Return Me.m_startingDate
  End Get
  Set
   If value <> Me.m_startingDate Then
    Me.m_startingDate = value
    Me.OnPropertyChanged("StartingDate")
   End If
  End Set
 End Property
 Public Property IsMarried() As Boolean
  Get
   Return Me.m_isMarried
  End Get
  Set
   If Me.m_isMarried <> value Then
    Me.m_isMarried = value
    Me.OnPropertyChanged("IsMarried")
   End If
  End Set
 End Property
 Private m_salary As Integer
 Public Property Salary() As Integer
  Get
   Return Me.m_salary
  End Get
  Set
   If Me.m_salary <> value Then
    Me.m_salary = value
    Me.OnPropertyChanged("Salary")
   End If
  End Set
 End Property
 Public Sub New()
 End Sub
 Protected Overridable Sub OnPropertyChanged(args As PropertyChangedEventArgs)
  Dim handler As PropertyChangedEventHandler = Me.PropertyChanged
  RaiseEvent handler(Me, args)
 End Sub
 Private Sub OnPropertyChanged(propertyName As String)
  Me.OnPropertyChanged(New PropertyChangedEventArgs(propertyName))
 End Sub
 Public Shared Function GetEmployees() As ObservableCollection(Of Employee)
  Dim employees As New ObservableCollection(Of Employee)()
  employees.Add(New Employee() With { _
   Key .FirstName = "Sarah", _
   Key .LastName = "Blake", _
   Key .Ocupation = "Supplied Manager", _
   Key .StartingDate = New DateTime(2005, 4, 12), _
   Key .IsMarried = True, _
   Key .Salary = 3500 _
  })
  employees.Add(New Employee() With { _
   Key .FirstName = "Jane", _
   Key .LastName = "Simpson", _
   Key .Ocupation = "Security", _
   Key .StartingDate = New DateTime(2008, 12, 3), _
   Key .IsMarried = True, _
   Key .Salary = 2000 _
  })
  employees.Add(New Employee() With { _
   Key .FirstName = "John", _
   Key .LastName = "Peterson", _
   Key .Ocupation = "Consultant", _
   Key .StartingDate = New DateTime(2005, 4, 12), _
   Key .IsMarried = False, _
   Key .Salary = 2600 _
  })
  employees.Add(New Employee() With { _
   Key .FirstName = "Peter", _
   Key .LastName = "Bush", _
   Key .Ocupation = "Casheer", _
   Key .StartingDate = New DateTime(2005, 4, 12), _
   Key .IsMarried = True, _
   Key .Salary = 2300 _
  })
  Return employees
 End Function
End Class
' #endregion

' #region raddataform-integrate-with-radgridview_4
Public Sub New()
 InitializeComponent()
 Me.RadGridView1.ItemsSource = Employee.GetEmployees()
End Sub
' #endregion
End Class
