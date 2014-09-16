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

#region radmenu-binding-to-object-data_1
namespace HierarchicalDataSourceExample
{
 public class Team
 {
  private string name;
  public Team(string name)
  {
   this.name = name;
  }
  public string Name
  {
   get
   {
    return this.name;
   }
  }
 }
}
#endregion

#region radmenu-binding-to-object-data_2
using System.Collections.Generic;
namespace HierarchicalDataSourceExample
{
 public class Group
 {
  private string name;
  private List<Team> teams;
  public Group(string name)
  {
   this.name = name;
   this.teams = new List<Team>();
  }
  public string Name
  {
   get
   {
    return this.name;
   }
  }
  public List<Team> Teams
  {
   get
   {
    return this.teams;
   }
  }
 }
}
#endregion

#region radmenu-binding-to-object-data_3
using System.Collections.Generic;
namespace HierarchicalDataSourceExample
{
 public class Tournament
 {
  private string name;
  private List<Group> groups;
  public Tournament(string name)
  {
   this.name = name;
   this.groups = new List<Group>();
  }
  public string Name
  {
   get
   {
    return this.name;
   }
  }
  public List<Group> Groups
  {
   get
   {
    return this.groups;
   }
  }
 }
}
#endregion

#region radmenu-binding-to-object-data_4
public class HierarchicalDataSource : List<Tournament>
{
 public HierarchicalDataSource()
 {
  Tournament tournament = new Tournament("Champions League");
  Group group;
  this.Add(tournament);
  tournament.Groups.Add(group = new Group("Group A"));
  group.Teams.Add(new Team("Bordeaux"));
  group.Teams.Add(new Team("CFR Cluj-Napoca"));
  group.Teams.Add(new Team("Chelsea"));
  group.Teams.Add(new Team("Roma"));
.......
#endregion

#region radmenu-binding-to-object-data_5
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
namespace HierarchicalDataSourceExample
{
 public class HierarchicalDataSource : List<Tournament>
 {
  public HierarchicalDataSource()
  {
   Tournament tournament = new Tournament("Champions League");
   Group group;
   this.Add(tournament);
   tournament.Groups.Add(group = new Group("Group A"));
   group.Teams.Add(new Team("Bordeaux"));
   group.Teams.Add(new Team("CFR Cluj-Napoca"));
   group.Teams.Add(new Team("Chelsea"));
   group.Teams.Add(new Team("Roma"));
   tournament.Groups.Add(group = new Group("Group B"));
   group.Teams.Add(new Team("Anorthosis Famagusta"));
   group.Teams.Add(new Team("Inter Milan"));
   group.Teams.Add(new Team("Panathinaikos"));
   group.Teams.Add(new Team("Werder Bremen"));
   tournament.Groups.Add(group = new Group("Group C"));
   group.Teams.Add(new Team("Barcelona"));
   group.Teams.Add(new Team("Basle"));
   group.Teams.Add(new Team("Shakhtar Donetsk"));
   group.Teams.Add(new Team("Sporting Lisbon"));
   tournament.Groups.Add(group = new Group("Group D"));
   group.Teams.Add(new Team("Atletico Madrid"));
   group.Teams.Add(new Team("Liverpool"));
   group.Teams.Add(new Team("Marseille"));
   group.Teams.Add(new Team("PSV Eindhoven"));
   tournament.Groups.Add(group = new Group("Group E"));
   group.Teams.Add(new Team("AaB Aalborg"));
   group.Teams.Add(new Team("Celtic"));
   group.Teams.Add(new Team("Man Utd"));
   group.Teams.Add(new Team("Villarreal"));
   tournament.Groups.Add(group = new Group("Group F"));
   group.Teams.Add(new Team("Bayern Munich"));
   group.Teams.Add(new Team("Fiorentina"));
   group.Teams.Add(new Team("Lyon"));
   group.Teams.Add(new Team("Steaua Bucharest"));
   tournament.Groups.Add(group = new Group("Group G"));
   group.Teams.Add(new Team("Arsenal"));
   group.Teams.Add(new Team("Dynamo Kiev"));
   group.Teams.Add(new Team("FC Porto"));
   group.Teams.Add(new Team("Fenerbahce"));
   tournament.Groups.Add(group = new Group("Group H"));
   group.Teams.Add(new Team("BATE"));
   group.Teams.Add(new Team("Juventus"));
   group.Teams.Add(new Team("Real Madrid"));
   group.Teams.Add(new Team("Zenit St Petersburg"));
  }
 }
}
#endregion
}
