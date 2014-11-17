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

#region coverflow-databinding-overview_0
ObservableCollection<string> championsLeagueTeams = new ObservableCollection<string>();
championsLeagueTeams.Add("images/Barcelona.png");
championsLeagueTeams.Add("images/BayernMunchen.png");
championsLeagueTeams.Add("images/Chelsea.png");
championsLeagueTeams.Add("images/Juventus.png");
championsLeagueTeams.Add("images/Milan.png");
championsLeagueTeams.Add("images/OlympiqueLyon.png");
championsLeagueTeams.Add("images/RealMadrid.png");
#endregion
}
