Public Class Default_Vb


' #region radtabcontrol-populating-binding-to-collection_1
Public Class Person
    Public Sub New(ByVal name As String, ByVal age As Integer)
        Me.Name = name
        Me.Age = age
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
Private _Age As Integer
    Public Property Age() As Integer
        Get
            Return _Age
        End Get
        Set(ByVal value As Integer)
            _Age = value
        End Set
    End Property
End Class
' #endregion

' #region radtabcontrol-populating-binding-to-collection_3
Public Class ViewModel
    Public Sub New()
        Me.Persons = New ObservableCollection(Of Person)()
        Me.Persons.Add(New Person("Ivan", 23))
        Me.Persons.Add(New Person("Stefan", 34))
        Me.Persons.Add(New Person("Maria", 16))
        Me.Persons.Add(New Person("Michael", 78))
    End Sub
Private _Persons As ObservableCollection(Of Person)
    Public Property Persons() As ObservableCollection(Of Person)
        Get
            Return _Persons
        End Get
        Set(ByVal value As ObservableCollection(Of Person))
            _Persons = value
        End Set
    End Property
End Class
' #endregion
End Class
