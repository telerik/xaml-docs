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

#region raddatetimepicker-how-to-use-in-grid_0
public class Club
{
    public Club( string name, DateTime established, int stadiumCapacity )
    {
        this.Name = name;
        this.Established = established;
        this.StadiumCapacity = stadiumCapacity;
    }
    public string Name
    {
        get;
        set;
    }
    public DateTime? Established
    {
        get;
        set;
    }
    public int StadiumCapacity
    {
        get;
        set;
    }
    public static IEnumerable<Club> GetClubs()
    {
        ObservableCollection<Club> clubs = new ObservableCollection<Club>();
        clubs.Add( new Club( "Liverpool", new DateTime( 1892, 1, 1 ), 45362 ) );
        clubs.Add( new Club( "Manchester Utd.", new DateTime( 1878, 1, 1 ), 76212 ) );
        clubs.Add( new Club( "Chelsea", new DateTime( 1905, 1, 1 ), 42055 ) );
        clubs.Add( new Club( "Arsenal", new DateTime( 1886, 1, 1 ), 60355 ) );
        return clubs;
    }
}
#endregion

#region raddatetimepicker-how-to-use-in-grid_3
this.radGridView.ItemsSource = Club.GetClubs();
#endregion
}
