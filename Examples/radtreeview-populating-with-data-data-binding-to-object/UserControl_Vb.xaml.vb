Public Class Default_Vb


' #region radtreeview-populating-with-data-data-binding-to-object_1
Public Class Team
    Public Sub New(ByVal name As String)
        Me.Name = name
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
End Class
' #endregion

' #region radtreeview-populating-with-data-data-binding-to-object_3
Public Class Division
    Public Sub New(ByVal name As String)
        Me.Name = name
        Me.Teams = New ObservableCollection(Of Team)()
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
Private _Teams As ObservableCollection(Of Team)
    Public Property Teams() As ObservableCollection(Of Team)
        Get
            Return _Teams
        End Get
        Set(ByVal value As ObservableCollection(Of Team))
            _Teams = value
        End Set
    End Property
End Class
' #endregion

' #region radtreeview-populating-with-data-data-binding-to-object_5
Public Class League
    Public Sub New(ByVal name As String)
        Me.Name = name
        Me.Divisions = New ObservableCollection(Of Division)()
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
Private _Divisions As ObservableCollection(Of Division)
    Public Property Divisions() As ObservableCollection(Of Division)
        Get
            Return _Divisions
        End Get
        Set(ByVal value As ObservableCollection(Of Division))
            _Divisions = value
        End Set
    End Property
End Class
' #endregion

' #region radtreeview-populating-with-data-data-binding-to-object_7
Public Class RadTreeViewSampleData
    Public Sub New()
        Me.InitializeLeaguesDataSource()
    End Sub
Private _LeaguesDataSource As ObservableCollection(Of League)
    Public Property LeaguesDataSource() As ObservableCollection(Of League)
        Get
            Return _LeaguesDataSource
        End Get
        Set(ByVal value As ObservableCollection(Of League))
            _LeaguesDataSource = value
        End Set
    End Property
    Private Sub InitializeLeaguesDataSource()
        Me.LeaguesDataSource = New ObservableCollection(Of League)()
        Dim l As League
        Dim d As Division
        Me.LeaguesDataSource.Add(InlineAssignHelper(l, New League("League A")))
        l.Divisions.Add((InlineAssignHelper(d, New Division("Division A"))))
        d.Teams.Add(New Team("Team I"))
        d.Teams.Add(New Team("Team II"))
        d.Teams.Add(New Team("Team III"))
        d.Teams.Add(New Team("Team IV"))
        d.Teams.Add(New Team("Team V"))
        l.Divisions.Add((InlineAssignHelper(d, New Division("Division B"))))
        d.Teams.Add(New Team("Team Blue"))
        d.Teams.Add(New Team("Team Red"))
        d.Teams.Add(New Team("Team Yellow"))
        d.Teams.Add(New Team("Team Green"))
        d.Teams.Add(New Team("Team Orange"))
        l.Divisions.Add((InlineAssignHelper(d, New Division("Division C"))))
        d.Teams.Add(New Team("Team East"))
        d.Teams.Add(New Team("Team West"))
        d.Teams.Add(New Team("Team North"))
        d.Teams.Add(New Team("Team South"))
        Me.LeaguesDataSource.Add(InlineAssignHelper(l, New League("League B")))
        l.Divisions.Add((InlineAssignHelper(d, New Division("Division A"))))
        d.Teams.Add(New Team("Team 1"))
        d.Teams.Add(New Team("Team 2"))
        d.Teams.Add(New Team("Team 3"))
        d.Teams.Add(New Team("Team 4"))
        d.Teams.Add(New Team("Team 5"))
        l.Divisions.Add((InlineAssignHelper(d, New Division("Division B"))))
        d.Teams.Add(New Team("Team Diamond"))
        d.Teams.Add(New Team("Team Heart"))
        d.Teams.Add(New Team("Team Club"))
        d.Teams.Add(New Team("Team Spade"))
        l.Divisions.Add((InlineAssignHelper(d, New Division("Division C"))))
        d.Teams.Add(New Team("Team Alpha"))
        d.Teams.Add(New Team("Team Beta"))
        d.Teams.Add(New Team("Team Gamma"))
        d.Teams.Add(New Team("Team Delta"))
        d.Teams.Add(New Team("Team Epsilon"))
    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function
End Class
' #endregion
End Class
