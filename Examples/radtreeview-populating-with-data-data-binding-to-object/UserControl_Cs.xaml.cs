using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
	}

#region radtreeview-populating-with-data-data-binding-to-object_0
public class Team
{
    public Team( string name )
    {
        this.Name = name;
    }
    public string Name
    {
        get;
        set;
    }
}
#endregion

#region radtreeview-populating-with-data-data-binding-to-object_2
public class Division
{
    public Division( string name )
    {
        this.Name = name;
        this.Teams = new ObservableCollection<Team>();
    }
    public string Name
    {
        get;
        set;
    }
    public ObservableCollection<Team> Teams
    {
        get;
        set;
    }
}
#endregion

#region radtreeview-populating-with-data-data-binding-to-object_4
public class League
{
    public League( string name )
    {
        this.Name = name;
        this.Divisions = new ObservableCollection<Division>();
    }
    public string Name
    {
        get;
        set;
    }
    public ObservableCollection<Division> Divisions
    {
        get;
        set;
    }
}
#endregion

#region radtreeview-populating-with-data-data-binding-to-object_6
public class RadTreeViewSampleData
{
    public RadTreeViewSampleData()
    {
        this.InitializeLeaguesDataSource();
    }
    public ObservableCollection<League> LeaguesDataSource
    {
        get;
        set;
    }
    private void InitializeLeaguesDataSource()
    {
        this.LeaguesDataSource = new ObservableCollection<League>();
        League l;
        Division d;
        this.LeaguesDataSource.Add( l = new League( "League A" ) );
        l.Divisions.Add( ( d = new Division( "Division A" ) ) );
        d.Teams.Add( new Team( "Team I" ) );
        d.Teams.Add( new Team( "Team II" ) );
        d.Teams.Add( new Team( "Team III" ) );
        d.Teams.Add( new Team( "Team IV" ) );
        d.Teams.Add( new Team( "Team V" ) );
        l.Divisions.Add( ( d = new Division( "Division B" ) ) );
        d.Teams.Add( new Team( "Team Blue" ) );
        d.Teams.Add( new Team( "Team Red" ) );
        d.Teams.Add( new Team( "Team Yellow" ) );
        d.Teams.Add( new Team( "Team Green" ) );
        d.Teams.Add( new Team( "Team Orange" ) );
        l.Divisions.Add( ( d = new Division( "Division C" ) ) );
        d.Teams.Add( new Team( "Team East" ) );
        d.Teams.Add( new Team( "Team West" ) );
        d.Teams.Add( new Team( "Team North" ) );
        d.Teams.Add( new Team( "Team South" ) );
        this.LeaguesDataSource.Add( l = new League( "League B" ) );
        l.Divisions.Add( ( d = new Division( "Division A" ) ) );
        d.Teams.Add( new Team( "Team 1" ) );
        d.Teams.Add( new Team( "Team 2" ) );
        d.Teams.Add( new Team( "Team 3" ) );
        d.Teams.Add( new Team( "Team 4" ) );
        d.Teams.Add( new Team( "Team 5" ) );
        l.Divisions.Add( ( d = new Division( "Division B" ) ) );
        d.Teams.Add( new Team( "Team Diamond" ) );
        d.Teams.Add( new Team( "Team Heart" ) );
        d.Teams.Add( new Team( "Team Club" ) );
        d.Teams.Add( new Team( "Team Spade" ) );
        l.Divisions.Add( ( d = new Division( "Division C" ) ) );
        d.Teams.Add( new Team( "Team Alpha" ) );
        d.Teams.Add( new Team( "Team Beta" ) );
        d.Teams.Add( new Team( "Team Gamma" ) );
        d.Teams.Add( new Team( "Team Delta" ) );
        d.Teams.Add( new Team( "Team Epsilon" ) );
    }
}
#endregion
}
