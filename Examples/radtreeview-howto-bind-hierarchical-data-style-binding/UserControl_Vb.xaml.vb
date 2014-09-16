Public Class Default_Vb


' #region radtreeview-howto-bind-hierarchical-data-style-binding_1
Public Class Person
    Public Sub New()
    End Sub
Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
Private _Selected As Boolean
    Public Property Selected() As Boolean
        Get
            Return _Selected
        End Get
        Set(ByVal value As Boolean)
            _Selected = value
        End Set
    End Property
End Class
' #endregion

' #region radtreeview-howto-bind-hierarchical-data-style-binding_3
Public Class Department
    Public Sub New()
        Me.Employees = New List(Of Person)()
    End Sub
Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
Private _Selected As Boolean
    Public Property Selected() As Boolean
        Get
            Return _Selected
        End Get
        Set(ByVal value As Boolean)
            _Selected = value
        End Set
    End Property
Private _Expanded As Boolean
    Public Property Expanded() As Boolean
        Get
            Return _Expanded
        End Get
        Set(ByVal value As Boolean)
            _Expanded = value
        End Set
    End Property
Private _Employees As List(Of Person)
    Public Property Employees() As List(Of Person)
        Get
            Return _Employees
        End Get
        Set(ByVal value As List(Of Person))
            _Employees = value
        End Set
    End Property
End Class
' #endregion

' #region radtreeview-howto-bind-hierarchical-data-style-binding_5
Public Class Organization
    Public Sub New()
        Me.Departments = New List(Of Department)()
    End Sub
Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
Private _Selected As Boolean
    Public Property Selected() As Boolean
        Get
            Return _Selected
        End Get
        Set(ByVal value As Boolean)
            _Selected = value
        End Set
    End Property
Private _Expanded As Boolean
    Public Property Expanded() As Boolean
        Get
            Return _Expanded
        End Get
        Set(ByVal value As Boolean)
            _Expanded = value
        End Set
    End Property
Private _Departments As List(Of Department)
    Public Property Departments() As List(Of Department)
        Get
            Return _Departments
        End Get
        Set(ByVal value As List(Of Department))
            _Departments = value
        End Set
    End Property
End Class
' #endregion

' #region radtreeview-howto-bind-hierarchical-data-style-binding_7
Public Class DataSource
    Inherits List(Of Organization)
    Public Sub New()
        Dim telerik As New Organization("Telerik")
        Dim silverlight As New Department("Silverlight")
        Dim wpf As New Department("WPF")
        telerik.Departments.Add(silverlight)
        telerik.Departments.Add(wpf)
        silverlight.Employees.Add(New Person("John"))
        silverlight.Employees.Add(New Person("Ben"))
        silverlight.Employees.Add(New Person("Ann"))
        wpf.Employees.Add(New Person("Karoline"))
        wpf.Employees.Add(New Person("Simone"))
        wpf.Employees.Add(New Person("Eduard"))
        Me.Add(telerik)
    End Sub
End Class
' #endregion

' #region radtreeview-howto-bind-hierarchical-data-style-binding_14
Public Class DataSource
    Inherits List(Of Organization)
    Public Sub New()
        Dim telerik As New Organization("Telerik", False, True)
        Dim silverlight As New Department("Silverlight", False, True)
        Dim wpf As New Department("WPF", False, False)
        telerik.Departments.Add(silverlight)
        telerik.Departments.Add(wpf)
        silverlight.Employees.Add(New Person("John", True))
        silverlight.Employees.Add(New Person("Ben", False))
        silverlight.Employees.Add(New Person("Ann", False))
        wpf.Employees.Add(New Person("Karoline", False))
        wpf.Employees.Add(New Person("Simone", False))
        wpf.Employees.Add(New Person("Eduard", False))
        Me.Add(telerik)
    End Sub
End Class
' #endregion
End Class
