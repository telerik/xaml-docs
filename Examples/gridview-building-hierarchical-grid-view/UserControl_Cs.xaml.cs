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

#region gridview-building-hierarchical-grid-view_0
public class Team
{
    public int Id
    {
        get;
        set;
    }
    public string Name
    {
        get;
        set;
    }
    public int Place
    {
        get;
        set;
    }
}
#endregion

#region gridview-building-hierarchical-grid-view_2
public class Division
{
   public int Id
   {
       get;
       set;
   }
   public string Name
   {
       get;
       set;
   }
   public List<Team> Teams
   {
       get;
       set;
   }
}
#endregion

#region gridview-building-hierarchical-grid-view_4
public class DivisionsService
{
   public static ObservableCollection<Division> GetDivisions()
   {
       ObservableCollection<Division> divisions = new ObservableCollection<Division>();
       Division dA = new Division();
       dA.Name = "Division A";
       dA.Id = 1;
       dA.Teams = new List<Team>();
       Team team1 = new Team();
       team1.Id = 1;
       team1.Name = "Team I";
       team1.Place = 1;
       dA.Teams.Add( team1 );
       Team team2 = new Team();
       team2.Id = 2;
       team2.Name = "Team II";
       team2.Place = 2;
       dA.Teams.Add( team2 );
       Team team3 = new Team();
       team3.Id = 3;
       team3.Name = "Team III";
       team3.Place = 3;
       dA.Teams.Add( team3 );
       divisions.Add( dA );
       Division dB = new Division();
       dB.Name = "Division B";
       dB.Id = 2;
       dB.Teams = new List<Team>();
       Team teamRed = new Team();
       teamRed.Id = 1;
       teamRed.Name = "Team Red";
       teamRed.Place = 1;
       dB.Teams.Add( teamRed );
       Team teamGreen = new Team();
       teamGreen.Id = 2;
       teamGreen.Name = "Team Green";
       teamGreen.Place = 2;
       dB.Teams.Add( teamGreen );
       Team teamBlue = new Team();
       teamBlue.Id = 3;
       teamBlue.Name = "Team Blue";
       teamBlue.Place = 3;
       dB.Teams.Add( teamBlue );
       divisions.Add( dB );
       Division dC = new Division();
       dC.Name = "Division C";
       dC.Id = 3;
       dC.Teams = new List<Team>();
       Team teamAlpha = new Team();
       teamAlpha.Id = 1;
       teamAlpha.Name = "Team Alpha";
       teamAlpha.Place = 1;
       dC.Teams.Add( teamAlpha );
       Team teamBeta = new Team();
       teamBeta.Id = 2;
       teamBeta.Name = "Team Beta";
       teamBeta.Place = 2;
       dC.Teams.Add( teamBeta );
       Team teamGama = new Team();
       teamGama.Id = 3;
       teamGama.Name = "Team Gama";
       teamGama.Place = 3;
       dC.Teams.Add( teamGama );
       divisions.Add( dC );
       return divisions;
   }
}
#endregion

#region gridview-building-hierarchical-grid-view_7
public BuildingHierarchicalGrid()
{
    InitializeComponent();
    this.HierarchicalGridView.ItemsSource = DivisionsService.GetDivisions();
}
#endregion
}
