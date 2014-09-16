Public Class Default_Vb


' #region gridview-building-hierarchical-grid-view_1
Public Class Team
Private _Id As Integer
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property
Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
Private _Place As Integer
    Public Property Place() As Integer
        Get
            Return _Place
        End Get
        Set(ByVal value As Integer)
            _Place = value
        End Set
    End Property
End Class
' #endregion

' #region gridview-building-hierarchical-grid-view_3
Public Class Division
Private _Id As Integer
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property
Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property
Private _Teams As List(Of Team)
    Public Property Teams() As List(Of Team)
        Get
            Return _Teams
        End Get
        Set(ByVal value As List(Of Team))
            _Teams = value
        End Set
    End Property
End Class
' #endregion

' #region gridview-building-hierarchical-grid-view_5
Public Class DivisionsService
    Public Shared Function GetDivisions() As ObservableCollection(Of Division)
        Dim divisions As New ObservableCollection(Of Division)()
        Dim dA As New Division()
        dA.Name = "Division A"
        dA.Id = 1
        dA.Teams = New List(Of Team)()
        Dim team1 As New Team()
        team1.Id = 1
        team1.Name = "Team I"
        team1.Place = 1
        dA.Teams.Add(team1)
        Dim team2 As New Team()
        team2.Id = 2
        team2.Name = "Team II"
        team2.Place = 2
        dA.Teams.Add(team2)
        Dim team3 As New Team()
        team3.Id = 3
        team3.Name = "Team III"
        team3.Place = 3
        dA.Teams.Add(team3)
        divisions.Add(dA)
        Dim dB As New Division()
        dB.Name = "Division B"
        dB.Id = 2
        dB.Teams = New List(Of Team)()
        Dim teamRed As New Team()
        teamRed.Id = 1
        teamRed.Name = "Team Red"
        teamRed.Place = 1
        dB.Teams.Add(teamRed)
        Dim teamGreen As New Team()
        teamGreen.Id = 2
        teamGreen.Name = "Team Green"
        teamGreen.Place = 2
        dB.Teams.Add(teamGreen)
        Dim teamBlue As New Team()
        teamBlue.Id = 3
        teamBlue.Name = "Team Blue"
        teamBlue.Place = 3
        dB.Teams.Add(teamBlue)
        divisions.Add(dB)
        Dim dC As New Division()
        dC.Name = "Division C"
        dC.Id = 3
        dC.Teams = New List(Of Team)()
        Dim teamAlpha As New Team()
        teamAlpha.Id = 1
        teamAlpha.Name = "Team Alpha"
        teamAlpha.Place = 1
        dC.Teams.Add(teamAlpha)
        Dim teamBeta As New Team()
        teamBeta.Id = 2
        teamBeta.Name = "Team Beta"
        teamBeta.Place = 2
        dC.Teams.Add(teamBeta)
        Dim teamGama As New Team()
        teamGama.Id = 3
        teamGama.Name = "Team Gama"
        teamGama.Place = 3
        dC.Teams.Add(teamGama)
        divisions.Add(dC)
        Return divisions
    End Function
End Class
' #endregion

' #region gridview-building-hierarchical-grid-view_8
Public Sub New()
    InitializeComponent()
    Me.HierarchicalGridView.ItemsSource = DivisionsService.GetDivisions()
End Sub
' #endregion
End Class
