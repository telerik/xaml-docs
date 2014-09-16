Public Class Default_Vb


' #region gridview-columns-defining-columns_1
Public Class Employee
		<DisplayAttribute(AutoGenerateField:=False)> _
		Public Property EmployeeId() As Integer
			Get
				Return m_EmployeeId
			End Get
			Set(value As Integer)
				m_EmployeeId = Value
			End Set
		End Property
		Private m_EmployeeId As Integer
		<DisplayAttribute(Name:="First Name")> _
		Public Property FirstName() As String
			Get
				Return m_FirstName
			End Get
			Set(value As String)
				m_FirstName = Value
			End Set
		End Property
		Private m_FirstName As String
		<DisplayAttribute(Name:="Last Name")> _
		Public Property LastName() As String
			Get
				Return m_LastName
			End Get
			Set(value As String)
				m_LastName = Value
			End Set
		End Property
		Private m_LastName As String
	End Class
' #endregion

' #region gridview-columns-defining-columns_4
Dim column As New GridViewDataColumn()
' #endregion

' #region gridview-columns-defining-columns_7
Dim column As New GridViewDataColumn()
column.DataMemberBinding = New Binding("FirstName")
column.Header = "My Column"
column.UniqueName = "MyColumn"
Me.radGridView.AutoGenerateColumns = False
Me.radGridView.Columns.Add(column)
' #endregion

' #region gridview-columns-defining-columns_9
Dim myColumn As GridViewDataColumn = Me.radGridView.Columns("MyColumn")
myColumn = Me.radGridView.Columns(0)
    ' #endregion

    ' #region gridview-columns-defining-columns_13
	Dim column As New GridViewDataColumn()
column.CellTemplate = DirectCast(Me.Resources("dataTemplate1"), DataTemplate)
Me.radGridView.Columns.Add(column)
    ' #endregion
End Class
