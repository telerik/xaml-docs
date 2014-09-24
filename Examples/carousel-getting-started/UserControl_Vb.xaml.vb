Public Class Default_Vb


' #region carousel-getting-started_3
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
 Public Property Age() As Integer
  Get
   Return m_Age
  End Get
  Set
   m_Age = Value
  End Set
 End Property
 Private m_Age As Integer
 Public Property Position() As String
  Get
   Return m_Position
  End Get
  Set
   m_Position = Value
  End Set
 End Property
 Private m_Position As String
End Class
' #endregion

' #region carousel-getting-started_5
Public Class EmployeeService
 Public Shared Function GetEmployees() As ObservableCollection(Of Employee)
  Dim employees As New ObservableCollection(Of Employee)()
  Dim employee As New Employee()
  employee.FirstName = "Margaret"
  employee.LastName = "Peacock"
  employee.Position = "Sales Representative"
  employee.Age = 24
  employees.Add(employee)
  employee = New Employee()
  employee.FirstName = "Steven"
  employee.LastName = "Buchanan"
  employee.Position = "Sales Manager"
  employee.Age = 44
  employees.Add(employee)
  employee = New Employee()
  employee.FirstName = "Michael"
  employee.LastName = "Suyama"
  employee.Position = "Sales Representative"
  employee.Age = 33
  employees.Add(employee)
  employee = New Employee()
  employee.FirstName = "Robert"
  employee.LastName = "King"
  employee.Position = "Sales Representative"
  employee.Age = 28
  employees.Add(employee)
  employee = New Employee()
  employee.FirstName = "Laura"
  employee.LastName = "Callahan"
  employee.Position = "Inside Sales Coordinator"
  employee.Age = 26
  employees.Add(employee)
  employee = New Employee()
  employee.FirstName = "Anne"
  employee.LastName = "Dodsworth"
  employee.Position = "Sales Representative"
  employee.Age = 30
  employees.Add(employee)
  Return employees
 End Function
End Class
' #endregion

' #region carousel-getting-started_7
Public Sub New()
 InitializeComponent()
 Me.MyCarousel.ItemsSource = EmployeeService.GetEmployees()
End Sub
' #endregion

' #region carousel-getting-started_9
Public Sub New()
 InitializeComponent()
 Dim myImages As New List(Of Image)()
 Dim myImage As New Image()
 myImage.Source = New BitmapImage(New Uri("/Images/nature1.jpg", UriKind.Relative))
 myImage.Height = 200
 myImage.Width = 200
 myImages.Add(myImage)
 Dim myImage1 As New Image()
 myImage1.Source = New BitmapImage(New Uri("/Images/nature2.jpg", UriKind.Relative))
 myImage1.Height = 200
 myImage1.Height = 200
 myImages.Add(myImage1)
 Dim myImage2 As New Image()
 myImage2.Source = New BitmapImage(New Uri("/Images/nature15.jpg", UriKind.Relative))
 myImage2.Width = 200
 myImage.Height = 200
 myImages.Add(myImage2)
 Dim myImage3 As New Image()
 myImage3.Source = New BitmapImage(New Uri("/Images/nature19.jpg", UriKind.Relative))
 myImage3.Height = 200
 myImage3.Width = 200
 myImages.Add(myImage3)
 Dim myImage4 As New Image()
 myImage4.Source = New BitmapImage(New Uri("/Images/nature26.jpg", UriKind.Relative))
 myImage4.Height = 200
 myImage4.Width = 200
 myImages.Add(myImage4)
 Me.MyCarousel.ItemsSource = myImages
End Sub
' #endregion
End Class
