Public Class Default_Vb


' #region raddatapager-getting-started_2
Public Class Employee
 Public Sub New(name As String, companyName As String, title As String)
  Me.Name = name
  Me.CompanyName = companyName
  Me.Title = title
 End Sub
 Public Property Name() As String
  Get
   Return m_Name
  End Get
  Set
   m_Name = Value
  End Set
 End Property
 Private m_Name As String
 Public Property CompanyName() As String
  Get
   Return m_CompanyName
  End Get
  Set
   m_CompanyName = Value
  End Set
 End Property
 Private m_CompanyName As String
 Public Property Title() As String
  Get
   Return m_Title
  End Get
  Set
   m_Title = Value
  End Set
 End Property
 Private m_Title As String
End Class
' #endregion

' #region raddatapager-getting-started_5
Dim employees As New ObservableCollection(Of Employee)()
employees.Add(New Employee("Maria Anders", "Alfreds Futterkiste", "Sales Representative"))
employees.Add(New Employee("Ana Trujillo", "Ana Trujillo Emparedados y helados", "Owner"))
employees.Add(New Employee("Antonio Moreno", "Antonio Moreno Taqueria", "Owner"))
employees.Add(New Employee("Thomas Hardy", "Around the Horn", "Sales Representative"))
employees.Add(New Employee("Hanna Moos", "Blauer See Delikatessen", "Sales Representative"))
employees.Add(New Employee("Frederique Citeaux", "Blondesddsl pere et fils", "Marketing Manager"))
employees.Add(New Employee("Martin Sommer", "Bolido Comidas preparadas", "Owner"))
employees.Add(New Employee("Laurence Lebihan", "Bon app'", "Owner"))
employees.Add(New Employee("Elizabeth Lincoln", "Bottom-Dollar Markets", "Accounting manager"))
employees.Add(New Employee("Victoria Ashworth", "B's Beverages", "Sales representative"))
Me.radDataPager.Source = employees
' #endregion
End Class
