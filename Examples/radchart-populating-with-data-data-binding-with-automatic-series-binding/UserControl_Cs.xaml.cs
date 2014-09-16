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

#region radchart-populating-with-data-data-binding-with-automatic-series-binding_0
int[] dataArray = new int[] { 12, 56, 23, 89, 12, 56, 34, 78, 32, 56 };
#endregion

#region radchart-populating-with-data-data-binding-with-automatic-series-binding_2
radChart.ItemsSource = dataArray;
#endregion

#region radchart-populating-with-data-data-binding-with-automatic-series-binding_4
List<Manufacturer> data = new List<Manufacturer>();
data.Add( new Manufacturer( "Toyota", 215, 462 ) );
data.Add( new Manufacturer( "General Motors", 192, 345 ) );
data.Add( new Manufacturer( "Volkswagen", 151, 310 ) );
data.Add( new Manufacturer( "Ford", 125, 340 ) );
data.Add( new Manufacturer( "Honda", 91, 201 ) );
data.Add( new Manufacturer( "Nissan", 79, 145 ) );
data.Add( new Manufacturer( "PSA", 79, 175 ) );
data.Add( new Manufacturer( "Hyundai", 64, 133 ) );
this.telerkChart.ItemsSource = data;
#endregion

#region radchart-populating-with-data-data-binding-with-automatic-series-binding_6
public class Manufacturer
{
    public Manufacturer( string name, int sales, int turnover )
    {
        this.Name = name;
        this.Sales = sales;
        this.Turnover = turnover;
    }
    public string Name
    {
        get;
        set;
    }
    public int Sales
    {
        get;
        set;
    }
    public int Turnover
    {
        get;
        set;
    }
}
#endregion
}
