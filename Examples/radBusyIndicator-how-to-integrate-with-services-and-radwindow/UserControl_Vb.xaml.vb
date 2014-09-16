Public Class Default_Vb


' #region radBusyIndicator-how-to-integrate-with-services-and-radwindow_3
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
 Public Property Married() As Boolean
  Get
   Return m_Married
  End Get
  Set
   m_Married = Value
  End Set
 End Property
 Private m_Married As Boolean
End Class
' #endregion

' #region radBusyIndicator-how-to-integrate-with-services-and-radwindow_4
Public Class EmployeeService
 Public Shared Function GetEmployees() As ObservableCollection(Of Employee)
  Dim employees As New ObservableCollection(Of Employee)()
  Dim employee As New Employee()
  employee.FirstName = "Maria"
  employee.LastName = "Anders"
  employee.Married = True
  employee.Age = 24
  employees.Add(employee)
  '...
  Thread.Sleep(employees.Count * 100)
  Return employees
 End Function
End Class
' #endregion

' #region radBusyIndicator-how-to-integrate-with-services-and-radwindow_6
Public Class RadWindow1
	Private worker As New BackgroundWorker()

	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		AddHandler worker.DoWork, AddressOf WorkerDoWork
		AddHandler worker.RunWorkerCompleted, AddressOf WorkerRunWorkerCompleted
	

	End Sub

	Private Sub WorkerDoWork(sender As Object, e As DoWorkEventArgs)
		e.Result = EmployeeService.GetEmployees()
	End Sub

	Private Sub UpdateGridDataSource(employees As ObservableCollection(Of Employee))
		Me.radGridView.ItemsSource = employees
		Me.radBusyIndicator.IsBusy = False
	End Sub

	Private Sub WorkerRunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
		Dispatcher.BeginInvoke(New Action(Of ObservableCollection(Of Employee))(AddressOf UpdateGridDataSource), e.Result)

	End Sub
	Private Sub LoadDataButton_Click(sender As Object, e As RoutedEventArgs)
		If Not worker.IsBusy Then
			Me.radBusyIndicator.IsBusy = True
			worker.RunWorkerAsync()
		End If
	End Sub
End Class
' #endregion


' #region radBusyIndicator-how-to-integrate-with-services-and-radwindow_8
Dim radWindow As RadWindow1 = New RadWindow1()
radWindow.Show()
' #endregion
End Class
