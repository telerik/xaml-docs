Public Class Default_Vb


' #region radexpressioneditor-getting-started_4
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
 Public Sub New()
 End Sub
 Public Shared Function GetEmployees() As ObservableCollection(Of Employee)
  Dim employees As New ObservableCollection(Of Employee)()
  employees.Add(New Employee() With { _
   Key .FirstName = "Sarah", _
   Key .LastName = "Blake", _
   Key .Occupation = "Supplied Manager", _
   Key .StartingDate = New DateTime(2005, 4, 12), _
   Key .IsMarried = True, _
   Key .Salary = 3500 _
  })
  employees.Add(New Employee() With { _
   Key .FirstName = "Jane", _
   Key .LastName = "Simpson", _
   Key .Occupation = "Security", _
   Key .StartingDate = New DateTime(2008, 12, 3), _
   Key .IsMarried = True, _
   Key .Salary = 2000 _
  })
  employees.Add(New Employee() With { _
   Key .FirstName = "John", _
   Key .LastName = "Peterson", _
   Key .Occupation = "Consultant", _
   Key .StartingDate = New DateTime(2005, 4, 12), _
   Key .IsMarried = False, _
   Key .Salary = 2600 _
  })
  employees.Add(New Employee() With { _
   Key .FirstName = "Peter", _
   Key .LastName = "Bush", _
   Key .Occupation = "Cashier", _
   Key .StartingDate = New DateTime(2005, 4, 12), _
   Key .IsMarried = True, _
   Key .Salary = 2300 _
  })
  Return employees
 End Function
End Class
' #endregion

' #region radexpressioneditor-getting-started_6
Public Class MyViewModel
 Private m_employees As ObservableCollection(Of Employee)
 Public ReadOnly Property Employees() As ObservableCollection(Of Employee)
  Get
   If Me.m_employees Is Nothing Then
    Me.m_employees = Employee.GetEmployees()
   End If
   Return Me.m_employees
  End Get
 End Property
End Class
' #endregion

    ' #region radexpressioneditor-getting-started_10
    Private genericFilterDescriptor As New FilterDescriptor(Of Employee)()
Private Sub ExpressionEditor_ExpressionChanged(sender As Object, e As Telerik.Windows.RadRoutedEventArgs)
 If Me.ExpressionEditor.Expression IsNot Nothing AndAlso Me.ExpressionEditor.Expression.[GetType]() = GetType(Expression(Of Func(Of Employee, Boolean))) Then
  Me.genericFilterDescriptor.FilteringExpression = DirectCast(Me.ExpressionEditor.Expression, Expression(Of Func(Of Employee, Boolean)))
  If Not Me.GridView.FilterDescriptors.Contains(Me.genericFilterDescriptor) Then
   Me.GridView.FilterDescriptors.Add(Me.genericFilterDescriptor)
  End If
 ElseIf Me.ExpressionEditor.Expression Is Nothing Then
  If Me.GridView.FilterDescriptors.Contains(Me.genericFilterDescriptor) Then
   Me.GridView.FilterDescriptors.Remove(Me.genericFilterDescriptor)
  End If
 End If
End Sub
' #endregion
End Class
